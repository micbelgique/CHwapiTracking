using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodsTracking.Services.DTOs
{
    public class DashboardData
    {
        public Dictionary<DateTime, int> TotalMovementsDaily { get; set; }
        public int TotalCurrentMovements { get; set; }
        public Dictionary<string, int> MovementsByItemType { get; set; }
        public int TotalAlerts { get; set; }
    }
}
