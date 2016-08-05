using GoodsTracking.Domain.Constraints;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodsTracking.Domain
{
    public class Container : EntityBase
    {
        [TinyLength]
        [Required]
        public string Identifier { get; set; }

        [TextLength]
        public string Description { get; set; }

        [Required]
        public ContainerType Type { get; set; }
    }
}
