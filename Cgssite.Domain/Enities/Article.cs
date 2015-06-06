using CgsSite.Domain.IResPositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CgsSite.Domain.Enities
{
    public class Article : AggregateRoot
    {
        private IArticleRespository articlerespository;
        public string Subject { get; set; }
        public string Body { get; set; }
        public DateTime CreatedDate { get; private set; }
        [Obsolete]
        public Article()
        { }
        public Article(string subject, string body, IArticleRespository articlerespository)
            : base()
        {
            this.articlerespository = articlerespository;
            this.Subject = subject;
            this.Body = body;
            this.CreatedDate = DateTime.Now;
        }
        public void Update(string subject, string body)
        {
            this.Subject = subject;
            this.Body = body;
        }
    }

}
