using System.Data.Entity;
using CgsSite.Domain.Enities;
using System.Data.Entity.Infrastructure;

namespace CgsSite.Infrastructure.Respositories
{
   public class CgsContext : DbContext
    {

        public  CgsContext()  : base("CgsContext")
       {
       }
     
       public DbSet<Article> Articles {get;set;}

       protected override void OnModelCreating(DbModelBuilder modelBuider)
       {
           //modelBuider.Conventions.Remove<IncludeMetadataConvention>();
           modelBuider.Configurations.Add(new ArticleConfiguration());
       }
    }
    
}
