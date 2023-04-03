using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Insurance.FarmerPortal.Dal.Entities;

namespace Insurance.FarmerPortal.Bpl.Interfaces.User
{
    public interface IUserRegister
    {
        Task<Status> UserRegisterAsync(Dal.Entities.User user);
    }
}
