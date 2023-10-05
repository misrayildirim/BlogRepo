using Blog.DataAccess.Repository;
using Blog.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Business.Manager
{
    public class Manager<T> : IManager<T> where T : class, IEntity
    {
        private IRepository<T> repository;
        public Manager(IRepository<T> _repository)
        {
            repository = _repository;
        }
    
        public virtual bool Add(T model)
        {
             return repository.Add(model);
        }

        public virtual bool Delete(T model)
        {
            return repository.Delete(model);    
        }

        public virtual List<T> GetMany(Expression<Func<T, bool>> exp)
        {
            return repository.GetMany(exp).ToList();
        }
        public virtual List<T> GetAll()
        {
            return repository.GetAll().ToList();
        }
        public virtual T GetOne(Expression<Func<T, bool>> exp)
        {
            return repository.GetOne(exp);
        }

        public virtual bool Update(T model)
        {
            return repository.Update(model);
        }
    }
}
