using System;

namespace BL.User
{
    public class UserBL : IUserBL
    {
        public string GetUserInfo(Guid user_id)
        {
            return "User Id - " + user_id;
        }
    }
}
