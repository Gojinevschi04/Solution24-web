using WebApplication.Domain.Entities.User;

namespace WebApplication.BusinessLogic.Interfaces
{
    public interface ISession
    {
        ULoginResp UserLogin(ULoginData data);
    }
}