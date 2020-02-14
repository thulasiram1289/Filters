using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace actionfiltersexample.actionexample
{
    public class ResultFilter: ActionFilterAttribute, IResultFilter
    {
        string path = @"E:\Logs\Logs";
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            using (StreamWriter ss = File.AppendText(path))
            {
                var ds = (ObjectResult)context.Result;
                ss.WriteLine(ds.Value);
            }

        }
        public override void OnResultExecuted(ResultExecutedContext context)
        {
            using (StreamWriter ss = File.AppendText(path))
            {
                var ds = (ObjectResult)context.Result;
                ss.WriteLine(ds.Value);
            }
        }
    }
}
