using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JackApi.Domain;
using JackApi.Service;

namespace JackApi.Controllers
{
    [Route("api/useracount")]
    public class UserAcountControllers : Controller
    {
        public UserAcountService UserAcountService { get; set; }
        public UserAcountControllers()
        {
            UserAcountService = new UserAcountService();
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<UserAcount> GetUserAcount()
        {
            return UserAcountService.GetUsers(0);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST api/values
        [HttpPost]
        public int Post([FromBody]UserAcount userAcount)
        {
            return UserAcountService.AddUser(userAcount);
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
