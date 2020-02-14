using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace actionfiltersexample.actionexample
{
    public class ActionFilter:ActionFilterAttribute,IActionFilter
    {
        string path = @"E:\Logs\Logs";
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            using (StreamWriter ss = File.AppendText(path))
            {
                ss.WriteLine($"{context.HttpContext.Request.Path.Value}Starting");
            }
        }
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            using (StreamWriter ss = File.AppendText(path))
            {
                ss.WriteLine($"{context.HttpContext.Request.Path.Value}Ended");
            }

        }
    }
}
