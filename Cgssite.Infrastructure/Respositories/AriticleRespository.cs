using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cgssite.Domain.IResPositories;
using Cgssite.Domain.Enities;

namespace Cgssite.Infrastructure.Respositories
{
    public class AriticleRespository : RespositoryBase<Article>, IArticleRespository
    {
        public IQueryable<Article> GetAllArticles(int pageIndex, int pageSize)
        {
            return db.Set<Article>().OrderByDescending(m => m.CreatedDate).Skip((pageIndex - 1) * pageSize).Take(pageSize);
        }

        public Article GetArticleById(Guid id)
        {
            return Get(id);
        }

        public void CreateArticle(Article article)
        {
            Create(article);
        }

        public void EditArticle(Article article)
        {
            Update(article);
        }
        public int GetArticleCounts()
        {
           return db.Set<Article>().Count();
        }
    }
}
