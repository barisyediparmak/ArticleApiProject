using Common.Dtos.Article;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IArticleService
    {
        void Add(ArticleDto data);
        List<ArticleDto> List();
    }
}
