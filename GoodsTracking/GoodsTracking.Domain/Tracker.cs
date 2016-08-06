using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodsTracking.Domain
{
    public class Tracker : EntityBase
    {
        [Required]
        public Area Area { get; set; }

        [Required]
        public TrackerType Type { get; set; }
    }
}
