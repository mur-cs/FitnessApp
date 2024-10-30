using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Web_app_fitness.Models;
using Web_app_fitness.Services;

namespace Web_app_fitness.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryService categoryService;
        private readonly IArticleService articleService;

        public HomeController(ICategoryService categoryService, IArticleService articleService)
        { 
            this.categoryService = categoryService;
            this.articleService = articleService;
        }
        public IActionResult Index()
        {
            return View(categoryService.GetCategories());
        }
        public IActionResult Category(int id)
        {
            if(id==0)
            {
                return View(nameof(Index), categoryService.GetCategories());
            }
            else
            {
                Category category = categoryService.GetCategories().Find(x => x.Id==id);

                if(category==null)
                {
                    return View(nameof(Error));
                }
                else
                {
                    List<Article> articles = new List<Article>(articleService.GetArticles().Where(x=>x.CategoryId==id));
                    ArticleViewModel viewModel = new ArticleViewModel(articles,category);
                    return View(viewModel);
                }
			}
        }
        public IActionResult Details(int articleId)
        {
            Article? article = articleService.GetArticles().FirstOrDefault(x => x.Id==articleId);
            return View(article);
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}
