using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BL.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Anastasia.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserBL userBL;
        public UserController(IUserBL userBL)
        {
            this.userBL = userBL;
        }

        [Route("test")]
        public string GetUserInfoAsync(/*Guid user_id*/)
        {
            Guid guid = Guid.NewGuid();
            return userBL.GetUserInfo(guid);
        }
    }
}
