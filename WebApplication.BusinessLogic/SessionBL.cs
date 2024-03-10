using WebApplication.BusinessLogic.Core;
using WebApplication.BusinessLogic.Interfaces;
using WebApplication.Domain.Entities.User;

namespace WebApplication.BusinessLogic
{
    public class SessionBL : UserApi, ISession
    {
        public ULoginResp UserLogin(ULoginData data)
        {
            return UserLoginAction(data);
        }
    }
}