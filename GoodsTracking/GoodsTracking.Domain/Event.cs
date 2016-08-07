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
        public virtual Container Container { get; set; }

        [Required]
        public virtual Tracker Tracker { get; set; }

        [Required]
        public virtual DateTime Time { get; set; }
    }
}
