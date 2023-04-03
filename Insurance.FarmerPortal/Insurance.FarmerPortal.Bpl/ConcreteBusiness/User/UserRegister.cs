using Insurance.FarmerPortal.Bpl.Interfaces.User;
using Insurance.FarmerPortal.Dal.Interfaces.User;
using Insurance.FarmerPortal.Dal.Entities;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Insurance.FarmerPortal.Bpl.ConcreteBusiness.User
{
    public class UserRegister : IUserRegister
    {
        private readonly ILogger<UserRegister> logger;
        private readonly IUserRegisterRepository userRegisterRepo;
        public UserRegister(ILogger<UserRegister> _logger, IUserRegisterRepository userRegisterRepo)
        {
            this.logger = _logger;
            this.userRegisterRepo = userRegisterRepo;
        }
        public async Task<Status> UserRegisterAsync(Dal.Entities.User user)
        {
           return await this.userRegisterRepo.UserRegisterAsync(user);
        }
    }
}
