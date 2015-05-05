using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cgssite.Application;
using EmitMapper;
using Cgssite.Application.DTO;
using Cgssite.Web.Models;
using Cgssite.Infrastructure;
using MvcSiteMapProvider.Web.Mvc.Filters;
using MvcSiteMapProvider;

namespace Cgssite.Web.Controllers
{
    public class ArticlesController : Controller
    {
        private readonly int pageSize = 1;
        private readonly IArticleService _articleservice;
        private readonly ObjectsMapper<Article, ListArticleModel> listmapper = ObjectMapperManager.DefaultInstance.GetMapper<Article, ListArticleModel>();
        public ArticlesController(IArticleService articleservice)
        {
            this._articleservice = articleservice;

        }
        public ActionResult Index(int page = 1)
        {
            int totalCount = _articleservice.GetArticleCounts();
            Paging paging = new Paging(totalCount, page, pageSize);
            var result = _articleservice.GetAllArticles(paging);
            var model = new List<ListArticleModel>();
            ViewBag.pageIndex = paging.PageIndex;
            ViewBag.nextPage = paging.NextPage;
            foreach (var article in result)
            {
                article.Body = article.Body.Abstract(250);
                model.Add(listmapper.Map(article));
            }
            return View(model);
        }
        //[SiteMapTitle("CreatedDate")]
        public ActionResult Detail(Guid id)
        {
            var result = _articleservice.GetArticleById(id);
            var node = SiteMaps.Current.CurrentNode;
            if (node != null)
            {
                node.Title = result.Subject;
            }
            return View(listmapper.Map(result));
        }
    }
}