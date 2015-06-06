using CgsSite.Domain.Enities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CgsSite.Domain.IResPositories
{
    public interface IArticleRespository
    {
        IQueryable<Article> GetAllArticles(int pageIndex,int pageSize);
        Article GetArticleById(Guid id);
         void CreateArticle(Article article);
         void EditArticle(Article article);
         int GetArticleCounts();
    }
}
