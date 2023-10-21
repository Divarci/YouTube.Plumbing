using EntityLayer.Identity.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace YouTube.Plumbing.TagHelpers
{
    public class UserPictureTagHelper : TagHelper
    {
        public string FileName { get; set; } = null!;

        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;       

        public UserPictureTagHelper(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;           
        }

        public override async Task<Task> ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "img";

            var signedInUserId = _signInManager.Context.User.Claims.First(x => x.Type.Contains("identifier")).Value;
            var user = await _userManager.FindByIdAsync(signedInUserId);

            if(!string.IsNullOrEmpty(user!.FileName))
            {
                output.Attributes.SetAttribute("src",$"/images/{FileName}");
                return base.ProcessAsync(context, output);

            }

            output.Attributes.SetAttribute("src", "/images/user/default.png");
            return base.ProcessAsync(context, output);

                      
        }



    }
}
