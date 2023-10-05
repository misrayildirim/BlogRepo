using Blog.DataAccess.Repository;
using Blog.DataAccess.Services.Abstract;
using Blog.Entities.Entities;
using Blog.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Business.Manager
{
    public class CategoryManager : Manager<Category> , ICategoryManager
    {
        private ICategoryDal categoryDal;
        public CategoryManager(ICategoryDal _categoryDal) : base(_categoryDal)
        {
            categoryDal = _categoryDal;
        }

        public bool Update(CategoryDM category)
        {
            var cat = categoryDal.GetOne(a => a.ID == category.ID);

            if (cat != null)
            {
                cat.Name = category.Name;

                categoryDal.Update(cat);

                return true;
            }

            return false;
        }
    }
}
