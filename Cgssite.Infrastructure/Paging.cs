using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cgssite.Infrastructure
{
    public class Paging
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        public int PageIndex { get; set; }
        /// <summary>
        /// 每页数量
        /// </summary>
        public int PageSize { get; set; }
        /// <summary>
        /// 总页数
        /// </summary>
        public int TotalPage { get; set; }
        /// <summary>
        /// 下一页页码
        /// </summary>
        public int NextPage { get; set; }
        ///// <summary>
        ///// 排序类型
        ///// </summary>
        //public Type SortType { get; set; }
        ///// <summary>
        ///// 排序方向:0为升序，1为降序
        ///// </summary>
        //public int SortDirection { get; set; }

        public Paging(int totalcounts, int pageindex = 1, int pagesize = 10)
        {
            this.PageIndex = pageindex;
            this.PageSize = pagesize;
            this.TotalPage =(int)Math.Ceiling((double)totalcounts / pagesize);
            this.NextPage = pageindex < this.TotalPage ? pageindex + 1 : -1;
        }

    }
}
