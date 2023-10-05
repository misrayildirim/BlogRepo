using Blog.DataAccess.Repository;
using Blog.DataAccess.Services.Abstract;
using Blog.Entities.Entities;
using Blog.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Business.Manager
{
    public class UserManager : Manager<User>, IUserManager
    {
        private IUserDal userDal;
        public UserManager(IUserDal _userDal) : base(_userDal)
        {
            userDal = _userDal;
        }

        public override bool Add(User model)
        {


            return userDal.Add(model);
        }

        public User Login(UserDM user)
        {
            User _user = null;

            if (user != null)
                if (!string.IsNullOrEmpty(user.Email))
                    if (!string.IsNullOrEmpty(user.Password))
                        _user = userDal.GetOne(a => a.Email == user.Email && a.Password == user.Password);

            return _user;
        }
    }
}
