using Blog.Business.Manager;
using Blog.Entities.Entities;
using Blog.Entities.Models;
using Blog.UI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blog.UI.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryManager categoryManager;

        public CategoryController (ICategoryManager _categoryManager)
        {
            this.categoryManager = _categoryManager;
        }

        [Route("~/kategori-listesi")]
        public IActionResult List()
        {
            var model = categoryManager.GetAll();

            return View(model);
        }

        [HttpGet]
        [Route("~/kategori-form")]
        [Route("~/{id}/kategori-form")]
        public IActionResult Form(string id="")
        {
            if (!string.IsNullOrEmpty(id) && id != "undefined")
            {
                var category = categoryManager.GetOne(a => a.ID == id);

                return PartialView(new CategoryDM { ID = category.ID, Name = category.Name });
            }

            return PartialView();
        }

        [HttpPost]
        [Route("~/kategori-ekle")]
        public IActionResult Add(CategoryDM category)
        {
            var _category = new Category
            {
                Name = category.Name
            };
            categoryManager.Add(_category);

            return RedirectToAction("~/kategori-listesi");
        }

        [HttpPost]
        [Route("~/kategori-düzenle")]
        public IActionResult Edit(CategoryDM category)
        {
            categoryManager.Update(category);

            return RedirectToAction("~/kategori-listesi");
        }
    }
}
