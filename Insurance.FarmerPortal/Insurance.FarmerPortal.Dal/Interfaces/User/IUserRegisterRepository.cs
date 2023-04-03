using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Insurance.FarmerPortal.Bpl.Entities;


namespace Insurance.FarmerPortal.Dal.Interfaces.User
{
    public interface IUserRegisterRepository
    {
        Task<Status> UserRegisterAsync(Bpl.Entities.User user);
    }
}
