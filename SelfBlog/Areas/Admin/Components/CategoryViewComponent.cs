using Microsoft.AspNetCore.Mvc;
using SelfBolg.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace SelfBlog.Areas.Admin.Components
{
    [Area("Admin")]
    public class CategoryViewComponent: ViewComponent
    {
        private readonly ICategoryService _categoryService;
        public CategoryViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public IViewComponentResult Invoke(int categoryId)
        {
            ViewBag.CategoryId = categoryId;
            return View(_categoryService.GetAll());
        }
    }
}
