using System.Data.Entity;
using Cgssite.Domain.Enities;
using System.Data.Entity.Infrastructure;

namespace Cgssite.Infrastructure.Respositories
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
