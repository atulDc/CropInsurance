using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model = Insurance.FarmerPortal.Bpl.Models;
using Entity = Insurance.FarmerPortal.Dal.Entities;
using Insurance.FarmerPortal.Bpl.Interfaces.User;
using AutoMapper;


namespace Insurance.FarmerPortal.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly ILogger<UsersController> logger;
        private readonly IMapper mapper;
        private readonly IUserRegister UserRegister;

        public UsersController(ILogger<UsersController> _logger, 
            IMapper _mapper,
            IUserRegister UserRegister)
        {
            this.logger = _logger;
            this.mapper = _mapper;
            this.UserRegister = UserRegister;
        }

        [HttpPost("Registration")]
        public async Task<IActionResult> UserRegisterAsync([FromBody]Model.User user)
        {
            if(user == null)
            {
                return NotFound(new { message = "Resource not found" });
            }
            var userEntity = this.mapper.Map<Entity.User>(user);
            var status = await this.UserRegister.UserRegisterAsync(userEntity);
            return Ok(status);
        }
    }
}
