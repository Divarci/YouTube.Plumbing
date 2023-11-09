using AutoMapper;
using EntityLayer.Identity.Entities;
using EntityLayer.Identity.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NToastNotify;
using ServiceLayer.Messages.Identity;
using ServiceLayer.Services.Identity.Abstract;
using System.Security.Claims;

namespace YouTube.Plumbing.Areas.Admin.Controllers
{
    [Authorize(Policy = "AdminObserver")]
    [Area("Admin")]
    public class AdminController : Controller
    {
        private readonly IAuthenticationAdminService _admin;       
        private readonly IToastNotification _toasty;

        public AdminController(IToastNotification toasty, IAuthenticationAdminService admin)
        {           
            _toasty = toasty;
            _admin = admin;
        }

        public async Task<IActionResult> GetUserList()
        {
            var userListVM = await _admin.GetUserListAsync();
            return View(userListVM);
        }

        public async Task<IActionResult> ExtendClaim(string username)
        {
           
            var renewClaim = await _admin.ExtendClaimAsync(username);
            if (!renewClaim.Succeeded)
            {
                _toasty.AddErrorToastMessage(NotificationMessagesIdentity.ExtendClaimFailed, new ToastrOptions { Title = "I am sorry!!" });
                return RedirectToAction("GetUserList", "Admin", new { Area = "Admin" });
            }
            _toasty.AddSuccessToastMessage(NotificationMessagesIdentity.ExtendClaimSuccess, new ToastrOptions { Title = "Congratulations" });
            return RedirectToAction("GetUserList", "Admin", new { Area = "Admin" });
        }
    }
}
