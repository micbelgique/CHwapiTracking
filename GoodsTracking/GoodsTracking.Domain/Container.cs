using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodsTracking.Domain
{
    public class Container : EntityBase
    {
        public string Identifier { get; set; }

        public string Description { get; set; }

        public ContainerType Type { get; set; }
    }
}
