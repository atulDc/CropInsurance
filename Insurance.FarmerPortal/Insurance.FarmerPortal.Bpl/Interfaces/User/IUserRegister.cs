using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Insurance.FarmerPortal.Bpl.Entities;

namespace Insurance.FarmerPortal.Bpl.Interfaces.User
{
    public interface IUserRegister
    {
        Task<Status> UserRegisterAsync(Entities.User user);
    }
}
