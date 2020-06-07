using Common.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Dtos.Article
{
    public class CategoryDto : BaseDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
