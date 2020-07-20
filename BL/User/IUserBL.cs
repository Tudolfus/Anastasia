using System;
using System.Collections.Generic;
using System.Text;

namespace BL.User
{
    public interface IUserBL
    {
        string GetUserInfo(Guid user_id);
    }
}
