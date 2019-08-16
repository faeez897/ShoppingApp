using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController:ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetUsers()
        {
            return new string[] { "User-1", "User-2" };
        }
    }
}
