using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodsTracking.Domain.Constraints
{
    [AttributeUsage(AttributeTargets.Property)]
    public class TinyLength : MaxLengthAttribute
    {
        public TinyLength() : base(24)
        { }
    }
}
