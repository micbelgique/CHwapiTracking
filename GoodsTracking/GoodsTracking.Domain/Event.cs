using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodsTracking.Domain
{
    public class Event : EntityBase
    {
        [Required]
        public EventType Type { get; set; }

        [Required]
        public Container Container { get; set; }

        [Required]
        public Movement Movement { get; set; }

        [Required]
        public Area Area { get; set; }

        public Tracker Tracker { get; set; }

        [Required]
        public DateTime Time { get; set; }
    }
}
