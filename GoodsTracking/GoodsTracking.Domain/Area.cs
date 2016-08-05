using System.Collections.Generic;

namespace GoodsTracking.Domain
{
    public class Area : EntityBase
    {
        public string Description { get; set; }

        public IEnumerable<Tracker> Trackers { get; set; }
    }
}