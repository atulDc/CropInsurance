using Insurance.FarmerPortal.Bpl.Entities;
using Insurance.FarmerPortal.Dal.Interfaces.User;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.FarmerPortal.Dal.ConcreteRepository.User
{
    public class UserRegisterRepository: IUserRegisterRepository
    {
        public async Task<Status> UserRegisterAsync(Bpl.Entities.User user)
        {

        }
    }
}
