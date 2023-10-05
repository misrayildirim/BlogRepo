using Blog.DataAccess.Repository;
using Blog.DataAccess.Services.Abstract;
using Blog.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Business.Manager
{
    public class ArticleManager : Manager<Article>, IArticleManager
    {
        private IArticleDal articleDal;
        public ArticleManager(IArticleDal _articleDal) : base(_articleDal)
        {
            articleDal = _articleDal;
        }

        public override bool Add(Article model)
        {
            return base.Add(model);
        }
    }
}
