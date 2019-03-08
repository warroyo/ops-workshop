using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace account_api.Controllers
{
    

    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private IConfiguration configuration;
        public AccountsController(AccountDb dbContext,IConfiguration iConfig)  
        {  
        DbContext = dbContext;
        configuration = iConfig;  
        }   

         public AccountDb DbContext { get; }
        // GET api/accounts
        [HttpGet]
        public IEnumerable<Account> Get()
        {
            string order_service = configuration.GetValue<string>("endpoints:order-service");  
            
            return DbContext.Accounts.ToList();
        }
  

        // GET api/accounts/5
        [HttpGet("{id}")]
        public Account Get(int id)
        {
            return DbContext.Accounts.First(t => t.Id == id);
        }

        // POST api/accounts
        [HttpPost]
        public void Post([FromBody]JObject value)
        {
            Account posted = value.ToObject<Account>();
           
            DbContext.Accounts.Add(posted);
            DbContext.SaveChanges();
        }

        // PUT api/accounts/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]JObject value)
        {
            Account posted = value.ToObject<Account>();
            posted.Id = id; // Ensure an id is attached
           
                DbContext.Accounts.Update(posted);
                DbContext.SaveChanges();
        }
        // DELETE api/accounts/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            if (DbContext.Accounts.Where(t => t.Id == id).Count() > 0) // Check if element exists
                DbContext.Accounts.Remove(DbContext.Accounts.First(t => t.Id == id));
            DbContext.SaveChanges();
        }
    }
}
