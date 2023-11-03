using CoreLayer.BaseEntities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using NToastNotify;
using RepositoryLayer.UnitOfWorks.Abstract;

namespace ServiceLayer.Filters.WebApplication
{
    public class GenericAddPreventationFilter<T> : IAsyncActionFilter where T : class,IBaseEntity,new()
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IToastNotification _toasty;

        public GenericAddPreventationFilter(IToastNotification toasty, IUnitOfWork unitOfWork)
        {
            _toasty = toasty;
            _unitOfWork = unitOfWork;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var entityList = await _unitOfWork.GetGenericRepository<T>().GetAlltEntityList().ToListAsync();
            var methodName = typeof(T).Name;
            if(entityList.Any())
            {
                _toasty.AddErrorToastMessage($"You already have an {methodName} Section. Please delete it first and try again later !!", new ToastrOptions { Title = "I am sorry!!" });
                context.Result = new RedirectToActionResult($"Get{methodName}List", methodName, new { Area = ("Admin") });
                return;

            }

            await next.Invoke();
            return;
        }
    }
}
