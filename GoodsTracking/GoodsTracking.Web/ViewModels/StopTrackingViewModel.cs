using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoodsTracking.Web.ViewModels
{
    [CustomValidation(typeof(StopTrackingViewModel), nameof(ValidateItemIdentifiers))]
    public class StopTrackingViewModel : ViewModelBase
    {
        public string ContainerIdentifier { get; set; }

        public string[] ItemIdentifiers { get; set; }

        public static ValidationResult ValidateItemIdentifiers(StopTrackingViewModel model)
        {
            if (model.ItemIdentifiers == null || string.IsNullOrWhiteSpace(string.Join(string.Empty, model.ItemIdentifiers)))
            {
                return new ValidationResult("At least one item identifier is required");
            }
            return ValidationResult.Success;
        }

    }
}