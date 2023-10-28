using AutoMapper;
using Azure.Core;
using CoreLayer.Enumerators;
using EntityLayer.Identity.Entities;
using EntityLayer.Identity.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using ServiceLayer.Helpers.Generic.Image;
using ServiceLayer.Services.Identity.Abstract;

namespace ServiceLayer.Services.Identity.Concrete
{
    public class AuthenticationUserService : IAuthenticationUserService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IMapper _mapper;
        private readonly IImageHelper _imageHelper;

        public AuthenticationUserService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IMapper mapper, IImageHelper imageHelper)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _mapper = mapper;
            _imageHelper = imageHelper;
        }



        public async Task<UserEditVM> FindUserAsync(HttpContext httpContext)
        {
            var user = await _userManager.FindByNameAsync(httpContext.User.Identity!.Name!);
            var userEditVm = _mapper.Map<UserEditVM>(user);
            return userEditVm;
        }

        public async Task<IdentityResult> UserEditAsync(UserEditVM request, AppUser user)
        {

            var passwordCheck = await _userManager.CheckPasswordAsync(user!, request.Password);
            if (!passwordCheck)
            {
                var errors = new IdentityError() { Code = "PasswordError", Description = "Wrong Password!" };
                var passwordFail = IdentityResult.Failed(errors);

                return passwordFail;            }


            if (request.NewPassword != null)
            {
                var passwordChange = await _userManager.ChangePasswordAsync(user!, request.Password, request.NewPassword);
                if (!passwordChange.Succeeded)
                {
                    return passwordChange;
                }
            }

            var oldFilename = user!.FileName;
            var oldFiletype = user!.FileType;

            if (request.Photo != null)
            {
                var image = await _imageHelper.ImageUpload(request.Photo, ImageType.identity, null);

                if (image.Error != null)
                {
                    if (request.NewPassword != null)
                    {
                        await _userManager.ChangePasswordAsync(user!, request.NewPassword, request.Password);
                        await _userManager.UpdateSecurityStampAsync(user);
                        await _signInManager.SignOutAsync();
                        await _signInManager.SignInAsync(user, false);
                    }

                    var errors = new IdentityError() { Code = "ImageError", Description = image.Error };
                    var imageResult = IdentityResult.Failed(errors);

                    return imageResult;
                }

                request.FileName = image.Filename;
                request.FileType = request.Photo.ContentType;
            }
            else
            {
                request.FileName = oldFilename;
                request.FileType = oldFiletype;
            }

            //var mappedUser = _mapper.Map<AppUser>(request);
            var mappedUser = _mapper.Map(request,user);
            var userUpdate = await _userManager.UpdateAsync(mappedUser);

            if (userUpdate.Succeeded)
            {
                if (request.Photo != null)
                {
                    if (oldFilename != null)
                    {
                        _imageHelper.DeleteImage(oldFilename);
                    }
                }

                await _userManager.UpdateSecurityStampAsync(user);
                await _signInManager.SignOutAsync();
                await _signInManager.SignInAsync(user, false);
                return userUpdate;

            }

            if (request.FileName != null)
            {
                _imageHelper.DeleteImage(request.FileName);
            }

            if (request.NewPassword != null)
            {
                await _userManager.ChangePasswordAsync(user!, request.NewPassword, request.Password);
                await _userManager.UpdateSecurityStampAsync(user);
                await _signInManager.SignOutAsync();
                await _signInManager.SignInAsync(user, false);
            }
            return userUpdate;
        }
    }
}
