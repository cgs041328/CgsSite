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
            Paging paging = new Paging(totalCount,page,pageSize);
            var result = _articleservice.GetAllArticles(paging);
            var model = new List<ListArticleModel>();
            ViewBag.pageIndex = paging.PageIndex;
            ViewBag.nextPage = paging.NextPage;
            foreach (var article in result)
            {
                model.Add(listmapper.Map(article));
            }
            return View(model);
        }
        public ActionResult Detail(Guid id)
        {
            var result = _articleservice.GetArticleById(id);
            return View(listmapper.Map(result));
        }
        //[Authorize]
        //public ActionResult Create()
        //{
        //    return View();
        //}
        //[HttpPost]
        //[Authorize]
        //public ActionResult Create(string subject, string body)
        //{
        //  if(ModelState.IsValid ? _articleservice.CreatArticle(subject, body):false) 
        //  {
        //      return View("Index");
        //  }
        //    else {return View();}
        //}
        //[Authorize]
        //public ActionResult Edit(Guid id)
        //{
        //    return View("Index");
        //}
        //[Authorize]
        //public ActionResult Remove(Guid id)
        //{
        //    return View("Index");
        //}
    }
}