using GoodsTracking.Services.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodsTracking.Web.ViewModels
{
    public class SearchViewModel
    {
        [Required(ErrorMessage = "Veuillez entrer un identifiant de contenu")]
        public string ContainerIdentifier { get; set; }

        public IEnumerable<ItemEventSearchResult> SearchResults { get; set; }
    }
}