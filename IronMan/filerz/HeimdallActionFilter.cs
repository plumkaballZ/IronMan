using System;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Collections.Generic;

namespace IronMan.filerz
{
    public class HeimdallActionFilter : IActionFilter
    {
        //Heimdall heim;
        public void OnActionExecuting(ActionExecutingContext context)
        {
            //heim = new Heimdall("IronMan");

            //heim.LogInfo("OnActionExecuting",
            //  new Dictionary<string, object> {
            //        { "RequestUri", context.Request.RequestUri },
            //        { "Headers", context.Request.Headers }
            //  });
        }

        public void OnActionExecuted(ActionExecutedContext context)
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
