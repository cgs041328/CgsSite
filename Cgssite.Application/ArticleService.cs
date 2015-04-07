using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cgssite.Application.DTO;
using Cgssite.Domain.IResPositories;
using EmitObjectMapper;
using EmitMapper;
using Cgssite.Domain;

namespace Cgssite.Application
{
   public class ArticleService:IArticleService
    {
       private readonly IArticleRespository _articleresposistory;
       private readonly ObjectsMapper<Cgssite.Domain.Enities.Article, Article> mapper;
       public ArticleService(IArticleRespository articlerespository)
       {
           this._articleresposistory = articlerespository;
           this.mapper = ObjectMapperManager.DefaultInstance.GetMapper<Cgssite.Domain.Enities.Article, Article>();
       }
       public IEnumerable<Article> GetAllArticles()
       {
          return  _articleresposistory.GetAllArticles().Select(x=>mapper.Map(x));
       }
       public Article GetArticleById(Guid id)
       {
           return mapper.Map(_articleresposistory.GetArticleById(id));
       }
       public bool CreatArticle(string subject, string body)
       {
          var article = AggregateRootFactory.CreateArticle(subject, body, _articleresposistory);
          _articleresposistory.CreateArticle(article);
          return true;
       }
       public bool EditArticle(Guid id, string subject, string body)
       {
           var article = _articleresposistory.GetArticleById(id);
           article.Update(subject, body);
           _articleresposistory.EditArticle(article);
           return true;
       }
    }
}
