using GoodsTracking.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodsTracking.Services
{
    public class DashboardService
    {
        public DashboardData GetDashboardData()
        {
            return new DashboardData
            {
                MovementsByItemType = new Dictionary<string, int>
                {
                    ["Tube sanguin"] = new Random().Next(1000),
                    ["Document confidentiel"] = new Random().Next(1000),
                    ["Vaccin"] = new Random().Next(1000)
                }
            };
        }
    }
}
