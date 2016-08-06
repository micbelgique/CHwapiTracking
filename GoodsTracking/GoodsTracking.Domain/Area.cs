using GoodsTracking.Domain.Constraints;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GoodsTracking.Domain
{
    public class Area : EntityBase
    {
        [Required]
        [SmallLength]
        public string Name { get; set; }

        [TextLength]
        public string Description { get; set; }

        public virtual IEnumerable<Tracker> Trackers { get; set; }
    }
}