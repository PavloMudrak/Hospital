using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomIdentityApp.Models
{
    public interface IExceptionFilter
    {
        void OnException(ExceptionContext filterContext);
    } 

    public class IndexException : IExceptionFilter
    {

        public void OnException(ExceptionContext exceptionContext)
        {
            if (!exceptionContext.ExceptionHandled && exceptionContext.Exception is IndexOutOfRangeException)
            {
                exceptionContext.Result = new RedirectResult("Index");
                exceptionContext.ExceptionHandled = true;
            }
        }
    }
}
