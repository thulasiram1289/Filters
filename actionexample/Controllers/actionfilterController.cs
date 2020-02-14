using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using actionfiltersexample.actionexample;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace actionfiltersexample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ActionFilter]
    [ResultFilter]
    public class actionfilterController : ControllerBase
    {
        [Route("MyFirstController")]
        [HttpGet]
        public dynamic GetName()
        {
            return new {name="thulasi",age=22,post="jr Software Developer" };
        }

        [Route("Exception")]
        [HttpGet]
        [ExceptionFilter]
        public string GetExc()
        {
            throw new Exception("Exception Arrived");
        }
        [Route("Getdata")]
        [HttpGet]
        [OutputCache(Duration=5)]
        public string PredeFilter()
        {
            return DateTime.Now.ToString();
        }


    }
}