using System;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Collections.Generic;

namespace IronMan.filerz
{
    public class LoginLogFilter : ActionFilterAttribute
    {
        //Heimdall heim;
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            //var controller = context.ActionDescriptor.ActionConstraints;
            //var action = context.ActionDescriptor.FilterDescriptors;

            var keys = context.ActionArguments.Keys;
            var values = context.ActionArguments.Values;


            foreach (var value in values)
            {

            }
       


            //var host = context.HttpContext.Request.Host.Value;

            //var dateTime = context.HttpContext.User;
            //heim = new Heimdall("IronMan");

            //heim.LogInfo("OnActionExecuting",
            //  new Dictionary<string, object> {
            //        { "RequestUri", context.Request.RequestUri },
            //        { "Headers", context.Request.Headers }
            //  });
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {

            //heim.LogInfo("OnActionExecuted",
            //  new Dictionary<string, object> {
            //        { "RequestUri", context.Request.RequestUri },
            //        { "Headers", context.Request.Headers }
            //  });

            //if (context.Exception != null)
            //    heim.LogException(context.Exception);
        }
    }
}
