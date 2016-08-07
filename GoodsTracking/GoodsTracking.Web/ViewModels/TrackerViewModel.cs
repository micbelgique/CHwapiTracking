using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodsTracking.Web.ViewModels
{
    public class TrackerViewModel
    {
        [Required]
        public int? Id { get; set; }

        public SelectList TrackerTypes
        {
            get
            {
                List<SelectListItem> items = new List<SelectListItem>
                {
                    new SelectListItem { Text = "Entrée", Value = "0" },
                    new SelectListItem { Text = "Sortie", Value = "1" },
                    new SelectListItem { Text = "Entrée / Sortie", Value = "2" }
                };

                return new SelectList(items, nameof(SelectListItem.Value), nameof(SelectListItem.Text));
            }
        }

        public int TrackerType { get; set; }

        public SelectList Areas { get; set; }

        public int AreaId { get; set; }
    }
}