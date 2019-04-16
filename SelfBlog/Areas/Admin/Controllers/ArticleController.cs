using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SelfBlog.Entities;
using SelfBlog.Models;
using SelfBlog.ViewModels;
using SelfBolg.Services;

namespace SelfBlog.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ArticleController : Controller
    {
        private readonly IArticleService _service;
        private readonly ICategoryService _categoryService;
        public ArticleController(IArticleService service,
            ICategoryService categoryService)
        {
            _service = service;
            _categoryService = categoryService;
        }
        [HttpGet]
        public IActionResult List(PagerItem pager, int categoryId = 2)
        {
            PagedList<ArticleEntity> entities = _service.GetPagedList(pager.Page, pager.PageSize, categoryId);
            PagedList<ArticleModel> models = entities.ToPagedModel(entity =>
            {
                ArticleModel model = new ArticleModel
                {
                    Id = entity.Id,
                    CategoryId = entity.CategoryId,
                    Title = entity.Title,
                    Content = entity.Content,
                    CreateTime = entity.CreateTime
                };

                var category = _categoryService.Get(entity.CategoryId);
                model.CategoryTitle = category.Title;
                return model;
            });

            ViewBag.CategoryId = categoryId;
            return View(models);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View(new ArticleEntity());
        }

        [HttpPost]
        public IActionResult Add(ArticleEntity entity)
        {
            //entity.AccountId = Convert.ToInt32(User.FindFirst(x => x.Type == ClaimTypes.Sid).Value);            
            entity.AccountId = 1;//TODO
            entity.CreateTime = DateTime.Now;
            int result = _service.Add(entity);
            return Redirect("/admin/article/list");
        }
        [HttpGet]
        public IActionResult Modify(int id)
        {
            return View(_service.Get(id));
        }

        [HttpPost]
        public IActionResult Modify(ArticleEntity entity)
        {
            int result = _service.Update(entity);
            return Redirect($"/admin/article/modify/{entity.Id}");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            int result = _service.Delete(id);
            return Redirect("/admin/article/list");
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}