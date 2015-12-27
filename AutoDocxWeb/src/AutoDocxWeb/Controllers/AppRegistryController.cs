using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using AutoDocxWeb.Helpers;
using Microsoft.AspNet.Authorization;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AutoDocxWeb.Controllers
{
    [Route("api/[controller]")]
    public class AppRegistryController : Controller
    {
        private readonly IAuthorizationService _authz;

        public AppRegistryController(IAuthorizationService authz)
        {
            _authz = authz;
        }

        [HttpPost]
        [Route("Register")]
        public async Task Register(string pandlock)
        {
            HMACAuthentication h = new HMACAuthentication();
            //h.AuthenticateAsync(this.ActionContext.HttpContext.);
                //throw new NotImplementedException();

        }








        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
