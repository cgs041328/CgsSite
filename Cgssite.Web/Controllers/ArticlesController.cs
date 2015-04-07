using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cgssite.Application;
using EmitMapper;
using Cgssite.Application.DTO;
using Cgssite.Web.Models;

namespace Cgssite.Web.Controllers
{
    public class ArticlesController : Controller
    {
        private readonly IArticleService _articleservice;
        public ArticlesController(IArticleService articleservice)
        {
            this._articleservice = articleservice;

        }
        public ActionResult Index(int? page)
        {
            var result = _articleservice.GetAllArticles();
            var mapper = ObjectMapperManager.DefaultInstance.GetMapper<Article, ArticleListModel>();
            return View(mapper.Map(result));
        }
        public ActionResult Detail(Guid  id)
        {
            var result = _articleservice.GetAllArticles();
            var mapper = ObjectMapperManager.DefaultInstance.GetMapper<Article, ArticleDetailModel>();
            return View(mapper.Map(result));
        }

    }
}