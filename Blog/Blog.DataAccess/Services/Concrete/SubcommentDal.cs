using Blog.DataAccess.DataAccess.DataContext;
using Blog.DataAccess.Repository;
using Blog.DataAccess.Services.Abstract;
using Blog.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataAccess.Services.Concrete
{
    public class SubcategoryDal : Repository<Subcategory>, ISubcategoryDal
    {
        public SubcategoryDal(BlogContext _blogContext) : base(_blogContext)
        {
        }
    }
}
