using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodsTracking.Web.ViewModels
{
    public class ContainerViewModel
    {
        [Required]
        public string Identifier { get; set; }

        [Required]
        public string Description { get; set; }

    }
}