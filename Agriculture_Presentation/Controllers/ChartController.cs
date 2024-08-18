using Agriculture_Presentation.Models;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture_Presentation.Controllers
{
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProductChart()
        {
            List<ProductClass> products = new List<ProductClass>();
            products.Add(new ProductClass
            {
                productvalue = 850,
                productname = "Buğday"
            });

            products.Add(new ProductClass
            {
                productvalue = 480,
                productname = "Mercimek"
            });

            products.Add(new ProductClass
            {
                productvalue = 550,
                productname = "Arpa"
            });

            products.Add(new ProductClass
            {
                productvalue = 750,
                productname = "Pirinç"
            });

            products.Add(new ProductClass
            {
                productvalue = 960,
                productname = "Domates"
            });
            return Json(new { jsonlist = products });
        }
    }
}
