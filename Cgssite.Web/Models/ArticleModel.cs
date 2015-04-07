using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Cgssite.Web.Models
{
    public class ArticleListModel
    {
        public string Id { get; set; }
        public string Subject { get; set; }
    }
    public class ArticleDetailModel
    {
        public string Id { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public DateTime CreatedDate { get; set; }
    }
    public class CreateArticleModel
    {
        [Required(ErrorMessage = "请输入文章标题。")]
        public string Subject { get; set; }
        [Required(ErrorMessage = "请输入文章内容。")]
        public string Body { get; set; }
    }
    public class EditArticleModel
    {
        [Required(ErrorMessage = "帖子ID不能为空。")]
        public string Id { get; set; }
        [Required(ErrorMessage = "请输入文章标题。")]
        public string Subject { get; set; }
        [Required(ErrorMessage = "请输入文章内容。")]
        public string Body { get; set; }
    }
}