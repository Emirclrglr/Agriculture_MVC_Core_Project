using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Team
    {
        [Key]
        public int PersonId { get; set; }
        public string? PersonName { get; set; }
        public string? PersonTitle { get; set; }
        public string? ImageUrl { get; set; }
        public string? FacebookUrl { get; set; }
        public string? TwitterUrl { get; set; }
        public string? InstagramUrl { get; set; }
        public string? WebsiteUrl { get; set; }

    }
}
