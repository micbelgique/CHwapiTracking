using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodsTracking.Web.ViewModels
{
    [CustomValidation(typeof(HomeViewModel), nameof(ValidateItemIdentifiers))]
    public class HomeViewModel
    {
        [Required]
        public string ContainerIdentifier { get; set; }

        public string[] ItemIdentifiers { get; set; }

        public string ContainerComments { get; set; }

        public static ValidationResult ValidateItemIdentifiers(HomeViewModel model)
        {
            if (model.ItemIdentifiers == null || string.IsNullOrWhiteSpace(string.Join(string.Empty, model.ItemIdentifiers)))
            {
                return new ValidationResult("At least one item identifier is required");
            }
            return ValidationResult.Success;
        }
    }
}