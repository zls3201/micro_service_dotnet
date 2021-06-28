using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiServiceA.Controllers
{
    [Route("apiservice/[controller]")]
    public class ValuesController : ControllerBase
    {
        public IConfiguration Configuration { get; }

        public ValuesController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // GET api/values
        [HttpGet]
        public string Get()
        {
            return HttpContext.Request.Host.Port + " " + Configuration["AppName"] + " " + DateTime.Now.ToString();
        }
    }
}
