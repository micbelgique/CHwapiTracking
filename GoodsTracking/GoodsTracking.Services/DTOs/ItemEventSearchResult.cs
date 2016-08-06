using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodsTracking.Services.DTOs
{
    public class ItemEventSearchResult
    {
        public string ItemIdentifier { get; set; }

        public string Location { get; set; }

        public DateTime Time { get; set; }
    }
}
