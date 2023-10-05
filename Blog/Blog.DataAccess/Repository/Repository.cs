using Blog.DataAccess.DataAccess.DataContext;
using Blog.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class, IEntity
    {
        private BlogContext blogContext;
        public Repository(BlogContext _blogContext)
        {
            blogContext = _blogContext;
        }

         public bool Add(T model)
        {
            model.ID = Guid.NewGuid().ToString();

            blogContext.Set<T>().Add(model);

            return blogContext.SaveChanges() == 1 ? true : false ;
        }

        public bool Delete(T model)
        {
            blogContext.Set<T>().Remove(model);

            return blogContext.SaveChanges() == 1 ? true : false;
        }

        public ICollection<T> GetMany(Expression<Func<T, bool>> exp = null)
        {
            return blogContext.Set<T>().Where(exp).ToList();
        }

        public ICollection<T> GetAll()
        {
            return blogContext.Set<T>().ToList();
        }

        public T GetOne(Expression<Func<T, bool>> exp)
        {
            return blogContext.Set<T>().Where(exp).FirstOrDefault();
        }

        public bool Update(T model)
        {
            blogContext.Set<T>().Update(model);

            return blogContext.SaveChanges() == 1 ? true : false;
        }
    }
}
