using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace CustomIdentityApp.Controllers
{
    public interface IExceptionFilter
    {
        void OnException(ExceptionContext filterContext);
    }
    internal class IndexExceptionAttribute : Attribute
    {

        public void OnException(ExceptionContext exceptionContext)
        {
            if (!exceptionContext.ExceptionHandled && exceptionContext.Exception is TypeInitializationException)
            {
                exceptionContext.Result = new RedirectResult("~/Home/index");
                exceptionContext.ExceptionHandled = true;
            }
        }

    }
}