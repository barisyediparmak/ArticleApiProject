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
    public class CategoryService : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryService(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(CategoryDto data)
        {
            var category = new Category
            {
                Name = data.Name,
                Description = data.Description
            };

            _categoryDal.Add(category);
        }

        public List<CategoryDto> List()
        {
            var result = _categoryDal.GetAll().Select(x => new CategoryDto
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description
            }).ToList();

            return result;
        }

        public void Remove(int id)
        {
            var deletedCategory = _categoryDal.GetByDefault(x => x.Id == id);

            _categoryDal.Remove(deletedCategory);
        }

        public void Update(CategoryDto data)
        {
            var updatedCategory = _categoryDal.GetByDefault(x => x.Id == data.Id);

            if (updatedCategory != null)
            {
                updatedCategory.Name = data.Name;
                updatedCategory.Description = data.Description;

                _categoryDal.Update(updatedCategory);
            }
        }
    }
}
