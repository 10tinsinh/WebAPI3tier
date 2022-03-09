using BLL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private BLL.UserBLL _User;
        public UserController()
        {
            _User = new BLL.UserBLL();
        }


        [HttpGet]

        public IActionResult GetAllUser()
        {
            
            return Ok(_User.GetAll());
        }
    }
}
