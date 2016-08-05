using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodsTracking.Domain
{
    public class Package : EntityBase
    {
        public Container Container { get; set; }

        public Item Item { get; set; }

        public string Comment { get; set; }

        public DateTime In { get; set; }

        public DateTime Out { get; set; }
    }
}
