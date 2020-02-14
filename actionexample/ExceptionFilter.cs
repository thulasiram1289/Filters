using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace actionfiltersexample.actionexample
{
    public class ExceptionFilter: Attribute,IExceptionFilter

    {
        string path = @"E:\Logs\Logs";
        public void OnException(ExceptionContext context)
        {
            using (StreamWriter ss = File.AppendText(path))
            {
                ss.WriteLine(context.Exception.Message);
                ss.WriteLine(context.Exception.StackTrace);
            }
        }
    }
}
