using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CgsSite.Application.DTO;
using CgsSite.Domain.IResPositories;
using EmitObjectMapper;
using EmitMapper;
using CgsSite.Domain;
using CgsSite.Infrastructure;

namespace CgsSite.Application
{
    public class ArticleService : IArticleService
    {
        private readonly IArticleRespository _articleresposistory;
        private readonly ObjectsMapper<CgsSite.Domain.Enities.Article, Article> mapper;
        //private readonly ObjectsMapper<IEnumerable<CgsSite.Domain.Enities.Article>, IEnumerable<Article>> mapper2;
        public ArticleService(IArticleRespository articlerespository)
        {
            this._articleresposistory = articlerespository;
            this.mapper = ObjectMapperManager.DefaultInstance.GetMapper<CgsSite.Domain.Enities.Article, Article>();
            //this.mapper2 = ObjectMapperManager.DefaultInstance.GetMapper<IEnumerable<CgsSite.Domain.Enities.Article>,IEnumerable<Article>>();
        }
        public IEnumerable<Article> GetAllArticles(Paging paging)
        {
            //return _articleresposistory.GetAllArticles().Select(x => mapper.Map(x));
            var result = _articleresposistory.GetAllArticles(paging.PageIndex, paging.PageSize).AsEnumerable();
            var model = new List<Article>();
            foreach (var article in result)
            {
                model.Add(mapper.Map(article));
            }
            return model;
        }
        public Article GetArticleById(Guid id)
        {
            return mapper.Map(_articleresposistory.GetArticleById(id));
        }
        public bool CreatArticle(string subject, string body)
        {
            try
            {
                var article = AggregateRootFactory.CreateArticle(subject, body, this._articleresposistory);
                _articleresposistory.CreateArticle(article);
            }
            catch
            {
                return false;
            }
            return true;
        }
        public bool EditArticle(Guid id, string subject, string body)
        {
            try
            {
                var article = _articleresposistory.GetArticleById(id);
                article.Update(subject, body);
                _articleresposistory.EditArticle(article);
            }
            catch
            {
                return false;
            }
            return true;
        }
        public int GetArticleCounts()
        {
            return _articleresposistory.GetArticleCounts();
        }
    }
}
