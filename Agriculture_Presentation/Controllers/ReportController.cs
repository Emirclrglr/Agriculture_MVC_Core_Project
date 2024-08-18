using Agriculture_Presentation.Models;
using ClosedXML.Excel;
using DataAccessLayer.Concrete;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;

namespace Agriculture_Presentation.Controllers
{
    public class ReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StaticReport()
        {
            ExcelPackage excelPackage = new ExcelPackage();
            var workBook = excelPackage.Workbook.Worksheets.Add("Dosya1");

            workBook.Cells[1, 1].Value = "Ürün Adı";
            workBook.Cells[1, 2].Value = "Ürün Kategorisi";
            workBook.Cells[1, 3].Value = "Ürün Stok";

            workBook.Cells[2, 1].Value = "Mercimek";
            workBook.Cells[2, 2].Value = "Bakliyat";
            workBook.Cells[2, 3].Value = "785 Kg";

            workBook.Cells[3, 1].Value = "Buğday";
            workBook.Cells[3, 2].Value = "Bakliyat";
            workBook.Cells[3, 3].Value = "1.986 Kg";

            workBook.Cells[4, 1].Value = "Havuç";
            workBook.Cells[4, 2].Value = "Sebze";
            workBook.Cells[4, 3].Value = "167 Kg";

            var bytes = excelPackage.GetAsByteArray();

            return File(bytes, "application/vnd.openxmlformat-officedocument.spreadsheetml.sheet", "urun_raporlari.xlsx");
        }

        public List<ContactModel> ContactList()
        {
            List<ContactModel> contactModels = new List<ContactModel>();
            using var c = new Context();
            contactModels = c.Contacts.Select(x => new ContactModel
            {
                ContactId = x.ContactId,
                Name = x.Name,
                Mail = x.Mail,
                Message = x.Message,
                Date = x.Date
            }).ToList();

            return contactModels;
        }

        public IActionResult MessageReport()
        {
            using var workBook = new XLWorkbook();

            var workSheet = workBook.Worksheets.Add("Mesaj Listesi");
            workSheet.Cell(1, 1).Value = "Mesaj ID";
            workSheet.Cell(1, 2).Value = "Mesaj Gönderen";
            workSheet.Cell(1, 3).Value = "Mail Adresi";
            workSheet.Cell(1, 4).Value = "Mesaj İçeriği";
            workSheet.Cell(1, 5).Value = "Mesaj Tarihi";

            int contactRowCount = 2;
            foreach (var item in ContactList())
            {
                workSheet.Cell(contactRowCount,1).Value = item.ContactId;
                workSheet.Cell(contactRowCount,2).Value = item.Name;
                workSheet.Cell(contactRowCount,3).Value = item.Mail;
                workSheet.Cell(contactRowCount,4).Value = item.Message;
                workSheet.Cell(contactRowCount,5).Value = item.Date;
                contactRowCount++;
            }

            using var stream = new MemoryStream();
            workBook.SaveAs(stream);
            var content = stream.ToArray();
            

            return File(content, "application/vnd.openxmlformat-officedocument.spreadsheetml.sheet", "Mesaj_raporlari.xlsx");
        }

        public List<AnnouncementModel> AnnouncementList()
        {
            using var c = new Context();
            List<AnnouncementModel> announcementModels = new List<AnnouncementModel>();
            announcementModels = c.Announcements.Select(x => new AnnouncementModel
            {
                Id = x.AnnouncementId,
                Title = x.Title,
                Description = x.Description,
                Date = x.Date,
                Status = x.Status
            }).ToList();

            return announcementModels;
        }

        public IActionResult AnnouncementReport()
        {
            using var workBook = new XLWorkbook();

            var workSheets = workBook.Worksheets.Add("Duyuru Listesi");
            workSheets.Cell(1, 1).Value = "Anons ID";
            workSheets.Cell(1, 2).Value = "Anons Başlığı";
            workSheets.Cell(1, 3).Value = "Anons İçeriği";
            workSheets.Cell(1, 4).Value = "Anons Tarihi";
            workSheets.Cell(1, 5).Value = "Anons Durumu";

            int announceRowCount = 2;

            foreach(var item in AnnouncementList())
            {
                workSheets.Cell(announceRowCount, 1).Value = item.Id;
                workSheets.Cell(announceRowCount, 2).Value = item.Title;
                workSheets.Cell(announceRowCount, 3).Value = item.Description;
                workSheets.Cell(announceRowCount, 4).Value = item.Date;
                workSheets.Cell(announceRowCount, 5).Value = item.Status;
                announceRowCount++;
            }
            
            using var stream = new MemoryStream();
            workBook.SaveAs(stream);
            var content = stream.ToArray();

            return File(content, "application/vnd.openxmlformat-officedocument.spreadsheetml.sheet","Duyuru_Raporlari.xlsx");
        }
    }
}
