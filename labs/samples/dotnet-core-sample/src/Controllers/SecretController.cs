using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Steeltoe.Extensions.Configuration.CloudFoundry;
using Newtonsoft.Json;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Linq;


namespace account_api.Controllers
{
    

    [Route("api/[controller]")]
    [ApiController]
    public class SecretController : ControllerBase
    {
        private CloudFoundryServicesOptions CloudFoundryServices { get; set; }
        private CloudFoundryApplicationOptions CloudFoundryApplication { get; set; }
        

        public SecretController(
            IOptions<CloudFoundryApplicationOptions> appOptions, 
            IOptions<CloudFoundryServicesOptions> servOptions)
        {
            CloudFoundryServices = servOptions.Value;
            CloudFoundryApplication = appOptions.Value;
        }


        // GET api/vcap
        [HttpGet]
        public ActionResult<String> GetServices()
        {
            CloudFoundryServicesOptions services = CloudFoundryServices == null ? new CloudFoundryServicesOptions() : CloudFoundryServices;
           return "the value of workshop_secret is: " + services.Services["credhub"][0].Credentials["workshop_secret"].Value;
        }
  
    }
}
