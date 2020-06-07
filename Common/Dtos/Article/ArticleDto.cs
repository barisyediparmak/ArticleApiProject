using Common.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Dtos.Article
{
    public class ArticleDto : BaseDto
    {
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
