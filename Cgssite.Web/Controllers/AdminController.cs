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
    //[Authorize]
    public class AdminController : Controller
    {
        private readonly IArticleService _articleservice;
        private readonly ObjectsMapper<Article, ListArticleModel> listmapper = ObjectMapperManager.DefaultInstance.GetMapper<Article, ListArticleModel>();
        private readonly ObjectsMapper<Article, CreateArticleModel> createmapper = ObjectMapperManager.DefaultInstance.GetMapper<Article, CreateArticleModel>();
        private readonly ObjectsMapper<Article, EditArticleModel> editmapper = ObjectMapperManager.DefaultInstance.GetMapper<Article, EditArticleModel>();
        public AdminController(IArticleService articleservice)
        {
            this._articleservice = articleservice;
        }
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CreateArticle()
        {
            var model = new CreateArticleModel();
            return View(model);
        }
        public ActionResult EditArticle(Guid id)
        {
            var model = editmapper.Map(_articleservice.GetArticleById(id));
            return View(model);
        }
        [HttpPost]
        public ActionResult CreateArticle(CreateArticleModel article)
        {
            if (ModelState.IsValid ? _articleservice.CreatArticle(article.Subject, article.Body) : false)
            {
                return View("Index");
            }
            else { return View(article); }
        }
        [HttpPost]
        public ActionResult EditArticle(EditArticleModel article)
        {
            if (ModelState.IsValid ? _articleservice.EditArticle(new Guid(article.Id),article.Subject,article.Body) : false)
            {
                return View("Index");
            }
            else { return View(article); }
        }
        public ActionResult Statistics()
        {
            return View();
        }
        public ActionResult Remove(Guid id)
        {
            return View("Index");
        }
    }
}