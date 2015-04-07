using Cgssite.Domain.Enities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cgssite.Domain.IResPositories;

namespace Cgssite.Domain
{
    public static class AggregateRootFactory
    {
        public static Article CreateArticle(string subject, string body,IArticleRespository articleresponsitory)
        {
            return new Article(subject, body, articleresponsitory);
        }
    }
}
