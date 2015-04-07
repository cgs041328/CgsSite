using Cgssite.Domain.Enities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cgssite.Domain.IResPositories
{
    public interface IArticleRespository
    {
        IEnumerable<Article> GetAllArticles();
        Article GetArticleById(Guid id);
         void CreateArticle(Article article);
         void EditArticle(Article article);
    }
}
