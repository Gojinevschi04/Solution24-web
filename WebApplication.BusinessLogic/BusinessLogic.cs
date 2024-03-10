using WebApplication.BusinessLogic.Interfaces;

namespace WebApplication.BusinessLogic
{
    public class BusinessLogic
    {
        public ISession GetSessionBL()
        {
            return new SessionBL();
        }
    }
}