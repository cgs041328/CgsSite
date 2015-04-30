﻿using Cgssite.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cgssite.Application
{
   public interface IArticleService
    {
       /// <summary>
       /// 获取所有文章
       /// </summary>
       /// <returns></returns>
        IEnumerable<Article> GetAllArticles();
       /// <summary>
       /// 根据ID获取文章
       /// </summary>
       /// <param name="id"></param>
       /// <returns></returns>
        Article GetArticleById(Guid id);
       /// <summary>
       /// 增加一篇文章
       /// </summary>
       /// <param name="subject"></param>
       /// <param name="body"></param>
       /// <returns></returns>
        bool CreatArticle(string subject, string body);
       /// <summary>
       /// 修改文章
       /// </summary>
       /// <param name="id"></param>
       /// <param name="subject"></param>
       /// <param name="body"></param>
       /// <returns></returns>
       bool EditArticle(Guid id, string subject, string body);
    }
}