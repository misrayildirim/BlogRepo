using Blog.Business.Manager;
using Blog.Entities.Entities;
using Blog.UI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blog.UI.Controllers
{
    public class SubcategoryController: Controller
    {
        private ISubcategoryManager subcategoryManager;

        public SubcategoryController(ISubcategoryManager _subcategoryManager)
        {
            this.subcategoryManager = _subcategoryManager;
        }
        public IActionResult Subcategory()
        {
            return View();
        }
        public IActionResult Add(SubcategoryModel subcategory)
        {
            var _subcategory = new Subcategory
            {
                Name = subcategory.Name,
                CategoryID = subcategory.CategoryID
            };

            subcategoryManager.Add(_subcategory);

            return View(subcategory);
        }

    }
}
