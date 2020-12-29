using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Serilog;
using Serilog.Events;
using Serilog.Exceptions;
using System;
using System.Net;
using System.Security.Claims;
using YoYo_Logger;

namespace YoYo_Web_App_API.Exceptions
{
    public class YoyoExceptionFilter : IExceptionFilter
    {
         private readonly ILoggerManager _loggerManager;

        /// <summary>AbbRelCareExceptionFilter</summary>
        /// <param name="loggerManager"></param>
        public YoyoExceptionFilter(ILoggerManager loggerManager)
        {
            _loggerManager = loggerManager;
        }

        /// <summary>OnException this is used for the global exceptions handle</summary>
        /// <param name="context"></param>
        public void OnException(ExceptionContext context)
        {
            _loggerManager.LogError(context.Exception.ToString());
        }
    }
}
