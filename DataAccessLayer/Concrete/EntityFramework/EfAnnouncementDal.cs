using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfAnnouncementDal : GenericRepository<Announcement>, IAnnouncementDal
    {
        public void AnnouncementStatusToFalse(int id)
        {
            using var c = new Context();
            Announcement p = c.Announcements.Find(id);
            p.Status = false;
            c.SaveChanges();
        }

        public void AnnouncementStatusToTrue(int id)
        {
            using var c = new Context();
            Announcement p = c.Announcements.Find(id);
            p.Status = true;
            c.SaveChanges();
        }

		public List<Announcement> GetListOnlyTrue()
		{
			using var c = new Context();
			return c.Announcements.Where(x => x.Status == true).ToList();
		}
	}
}
