using System.Data.Entity;
using WebApplication.Domain.Entities.User;

namespace WebApplication.BusinessLogic.DBModel
{
    public class UserContext: DbContext
    {
        public UserContext() : 
            base("name=eUseControl") // connectionstring name define in your web.config
        {
        }

        public virtual DbSet<UDbTable> Users { get; set; }
    }
}