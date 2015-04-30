using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web;
using System.Web.Mvc;

namespace Cgssite.Web.Models
{
    public class ListArticleModel
    {
        public string Id { get; set; }
        public string Subject { get; set; }
        [AllowHtml]
        public string Body { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime CreatedDate { get; set; }
    }
    //public class ArticleDetailModel
    //{
    //    public string Id { get; set; }
    //    public string Subject { get; set; }
    //    [AllowHtml]
    //    public string Body { get; set; }
    //    [DataType(DataType.Date)]
    //    public DateTime CreatedDate { get; set; }
    //}
    public class CreateArticleModel
    {
        [Display(Name="标题")]
        [Required(ErrorMessage = "请输入文章标题。")]
        public string Subject { get; set; }
        [UIHint("MultilineText")]
        [Display(Name="内容")]
        [Required(ErrorMessage = "请输入文章内容。")]
        [AllowHtml]
        public string Body { get; set; }
    }
    public class EditArticleModel
    {
        [HiddenInput]
        public string Id { get; set; }
         [Display(Name = "标题")]
        [Required(ErrorMessage = "请输入文章标题。")]
        public string Subject { get; set; }
        [UIHint("MultilineText")]
        [Display(Name = "内容")]
        [Required(ErrorMessage = "请输入文章内容。")]
        [AllowHtml]
        public string Body { get; set; }
    }
}