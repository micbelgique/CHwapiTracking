using GoodsTracking.Domain.Constraints;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodsTracking.Domain
{
    public class Movement : EntityBase
    {
        [Required]
        public virtual Container Container { get; set; }

        [Required]
        public virtual Area Destination { get; set; }

        [TextLength]
        public string Comment { get; set; }

        [Required]
        public DateTime Begin { get; set; }

        public DateTime? End { get; set; }
    }
}
