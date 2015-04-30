using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Cgssite.Domain.Enities;

namespace Cgssite.Infrastructure.Respositories
{
  public class ArticleConfiguration : EntityTypeConfiguration<Article>
    {
      public ArticleConfiguration()
      {
          Property(t => t.Id).IsRequired();
          Property(t => t.Subject).IsRequired();
          Property(t => t.Body).IsRequired();
          Property(t => t.CreatedDate).IsRequired();
      }
    }
}
