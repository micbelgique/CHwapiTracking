using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodsTracking.Domain
{
    public class Package : EntityBase
    {
        [Required]
        public virtual Container Container { get; set; }

        [Required]
        public virtual Item Item { get; set; }
        
        public string Comment { get; set; }
        
        [Required]
        public DateTime In { get; set; }

        public DateTime? Out { get; set; }
    }
}
