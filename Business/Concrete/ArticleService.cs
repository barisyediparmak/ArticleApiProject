using Business.Abstract;
using Common.Dtos.Article;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class ArticleService : IArticleService
    {
        private IArticleDal _articleDal;

        public ArticleService(IArticleDal articleDal)
        {
            _articleDal = articleDal;
        }

        public void Add(ArticleDto data)
        {
            var article = new Article
            {
                Title = data.Title,
                Content = data.Content
            };

            _articleDal.Add(article);
        }

        public List<ArticleDto> List()
        {
            var articles = _articleDal.GetAll().Select(x => new ArticleDto
            {
                Id = x.Id,
                Title = x.Title,
                Content = x.Content
            }).ToList();

            return articles;
        }
    }
}
