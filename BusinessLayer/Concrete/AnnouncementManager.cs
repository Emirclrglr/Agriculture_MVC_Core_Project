using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AnnouncementManager : IAnnouncementService
    {
        IAnnouncementDal _announcementDal;

        public AnnouncementManager(IAnnouncementDal announcementDal)
        {
            _announcementDal = announcementDal;
        }

		public List<Announcement> GetListOnlyTrue()
		{
            return _announcementDal.GetListOnlyTrue();
		}

		public void TAdd(Announcement t)
        {
            _announcementDal.Add(t);
        }

        public void TAnnouncementStatusToFalse(int id)
        {
            _announcementDal.AnnouncementStatusToFalse(id);
        }

        public void TAnnouncementStatusToTrue(int id)
        {
            _announcementDal.AnnouncementStatusToTrue(id);
        }

        public void TDelete(Announcement t)
        {
            _announcementDal.Delete(t);
        }

        public Announcement TGetById(int id)
        {
            return _announcementDal.GetById(id);
        }

        public List<Announcement> TGetListAll()
        {
            return _announcementDal.GetListAll();
        }

        public void TUpdate(Announcement t)
        {
            _announcementDal.Update(t);
        }
    }
}
