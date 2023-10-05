using Blog.Entities.Entities;
using Blog.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Business.Manager
{
    public interface IUserManager : IManager<User>
    {
        User Login(UserDM user);
    }
}
