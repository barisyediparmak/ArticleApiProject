using Common.Dtos.Article;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        void Add(CategoryDto data);

        void Update(CategoryDto data);

        void Remove(int id);

        List<CategoryDto> List();
    }
}
