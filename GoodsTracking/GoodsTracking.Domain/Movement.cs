using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodsTracking.Domain
{
    public class Movement : EntityBase
    {
        public Container Container { get; set; }

        public Area Destination { get; set; }

        public string Comment { get; set; }

        public DateTime Begin { get; set; }

        public DateTime? End { get; set; }
    }
}
