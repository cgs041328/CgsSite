using System.Data.Entity;
using Cgssite.Domain.Enities;

namespace Cgssite.Infrastructure.Respositories
{
    class CgsContext : DbContext
    {

       public  CgsContext :base("CgsConext")
       {

       }
     
       public DbSet<Article> Articles {get;set;}

       protected override void OnModelCreating(DbModelBuilder modelBuider)
       {

       }
    }
    
}
