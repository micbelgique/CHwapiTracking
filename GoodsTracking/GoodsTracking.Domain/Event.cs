using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodsTracking.Domain
{
    public class Event : EntityBase
    {
        public EventType Type { get; set; }

        public Container Container { get; set; }

        public Movement Movement { get; set; }

        public Area Area { get; set; }

        public Tracker Tracker { get; set; }

        public DateTime Time { get; set; }
    }
}
