using Blog.DataAccess.Repository;
using Blog.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataAccess.Services.Abstract
{
    public interface IUserDal : IRepository<User>
    {
        
    }
}
