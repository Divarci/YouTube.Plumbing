using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ServiceLayer.Helpers.Identity.ModelStateHelper
{
    public static class ModelErrorHelper
    {
        public static void AddModelErrorList(this ModelStateDictionary modelState, List<string> errors)
        {
            foreach (var error in errors)
            {
                modelState.AddModelError(string.Empty, error);
            }
        }

        public static void AddModelErrorList(this ModelStateDictionary modelState, IEnumerable<IdentityError> errors)
        {
            foreach (var error in errors)
            {
                modelState.AddModelError(string.Empty, error.Description);
            }
        }
    }
}
