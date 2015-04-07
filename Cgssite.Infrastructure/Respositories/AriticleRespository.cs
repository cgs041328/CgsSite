using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cgssite.Domain.IResPositories;
using Cgssite.Domain.Enities;

namespace Cgssite.Infrastructure.Respositories
{
    public class AriticleRespository :RespositoryBase<Article>,IArticleRespository
    {
        IEnumerable<Article> GetAllArticles()
        {
            return Get();
        }

        Article GetArticleById(Guid id)
        {
            return Get(id);
        }

        void CreateArticle(Article article)
        {
            Create();
        }

        void EditArticle(Article article)
        {
            Update();
        }
    }
}
