using System;
using System.Collections.Generic;
using System.Text;
using Insurance.FarmerPortal.Bpl.Interfaces.User;
using Insurance.FarmerPortal.Bpl.Entities;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Insurance.FarmerPortal.Bpl.ConcreteBusiness.User
{
    public class UserRegister : IUserRegister
    {
        private readonly ILogger<UserRegister> logger;
        public UserRegister(ILogger<UserRegister> _logger)
        {
            this.logger = _logger;
        }
        public async Task<Status> UserRegisterAsync(Entities.User user)
        {
            
        }
    }
}
