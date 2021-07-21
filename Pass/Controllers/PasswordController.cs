using Pass.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace Pass.Controllers
{
    public class PasswordController : ApiController
    {
        List<Password> passwords = new List<Password>();
        public IEnumerable<Password> GetAllPasswords()
        {
            return passwords;
        }
        public IHttpActionResult PostPassword(String idClient)
        {
           passwords.Add(new Password(idClient, DateTime.Now));
            if (passwords == null)
            {
                return NotFound();
            }
            return Ok(passwords);

        }
    }
}
