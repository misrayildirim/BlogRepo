using Blog.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Business.Manager
{
    public interface IManager<T> where T : class, IEntity
    {
        bool Add(T model);
        bool Update(T model);
        bool Delete(T model);
        T GetOne(Expression<Func<T, bool>> exp);
        List<T> GetMany(Expression<Func<T, bool>> exp);
        List<T> GetAll();
    }
}
