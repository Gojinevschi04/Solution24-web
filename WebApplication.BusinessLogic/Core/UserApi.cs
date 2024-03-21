using System.Linq;
using WebApplication.BusinessLogic.DBModel;
using WebApplication.Domain.Entities.User;

namespace WebApplication.BusinessLogic.Core
{
    public class UserApi
    {
        internal ULoginResp UserLoginAction(ULoginData data)
        {
            UDbTable user;

            using (var db = new UserContext())
            {
                user = db.Users.FirstOrDefault(u => u.Username == data.Credential);
            }
            
            if (user != null)
            {

            }

            return new ULoginResp();
        }
    }
}