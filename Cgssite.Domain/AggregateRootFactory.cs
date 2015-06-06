using CgsSite.Domain.Enities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CgsSite.Domain.IResPositories;

namespace CgsSite.Domain
{
    public static class AggregateRootFactory
    {
        public static Article CreateArticle(string subject, string body, IArticleRespository articlerespository)
        {
            return new Article(subject, body,articlerespository);
        }
    }
}
