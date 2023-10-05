using Blog.DataAccess.Repository;
using Blog.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Business.Manager
{
    public class CommentManager : Manager<Comment>, ICommentManager
    {
        public CommentManager(IRepository<Comment> _repository) : base(_repository)
        {
        }
    }
}
