using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Service
    {
        public int ServiceId { get; set; }
        public string ServiceTitle { get; set; }
        public string ServiceDescription { get; set; }
        public string ClientImage { get; set; }
        public string MainClass { get; set; }
        public string SecondaryClass { get; set; }

    }
}
