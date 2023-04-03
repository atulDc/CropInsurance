using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Insurance.FarmerPortal.Dal.Entities;


namespace Insurance.FarmerPortal.Dal.Interfaces.User
{
    public interface IUserRegisterRepository
    {
        Task<Status> UserRegisterAsync(Dal.Entities.User user);
    }
}
