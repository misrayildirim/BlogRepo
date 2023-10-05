using Blog.Business.Manager;
using Blog.Entities.Entities;
using Blog.Entities.Models;
using Blog.UI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blog.UI.Controllers
{
    public class ArticleController : Controller
    {
        private IArticleManager articleManager;
        private ICategoryManager categoryManager;

        public ArticleController (IArticleManager _articleManager, ICategoryManager _categoryManager)
        {
            this.articleManager = _articleManager;
            this.categoryManager = _categoryManager;    
        }
        public IActionResult Article()
        {
            return View();
        }
        public IActionResult Add(ArticleModel article)
        {
            var _article = new Article
            {
                Title = article.Title,
                Content = article.Content ,
               
            };

            articleManager.Add(_article);

            return View();
        }
        [HttpGet]
        [Route("~/makale-form")]
        [Route("~/{id}/makale-form")]

        public IActionResult Form(string id = "")
        {
            if (!string.IsNullOrEmpty(id) && id != "undefined")
            {
                var article = articleManager.GetOne(a => a.ID == id);

                return PartialView(new ArticleDM { ID = article.ID, Title = article.Title, Content = article.Content });
            }

            return PartialView();
        }

        [Route("~/makale-ekle")]
        public IActionResult Add()
        {
            var catList = categoryManager.GetAll();

            ViewData["CategoryList"] = catList;

            return View();
        }

        [HttpPost]
        [Route("~/makale-ekle")]
        public IActionResult Add(ArticleDM article)
        {
            var category = categoryManager.GetOne(a => a.ID == article.CategoryID);

            var _article = new Article
            {
                Title = article.Title, 
                Content = article.Content,
                cateogry = category,
                CreateTime = DateTime.Now
            };
            if(article.Content=!null)

            articleManager.Add(_article);

            return RedirectToAction("/makale-listesi");
        }

        [HttpPost]
        [Route("~/makale-düzenle")]
        public IActionResult Edit(ArticleDM article)
        {
            //articleManager.Update(article);

            return RedirectToAction("~/makale-listesi");
        }
    }

}
