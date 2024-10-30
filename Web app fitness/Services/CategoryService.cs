using Web_app_fitness.Models;

namespace Web_app_fitness.Services
{
    public interface ICategoryService
    {
        public List<Category> GetCategories();
    }
    public class CategoryService : ICategoryService
    {
        private List<Category> categories;

        public CategoryService()
        {
            categories = new List<Category>()
        {
            new Category
            {
                Id = 1,
                Name = "Похудение",
                Description = "Программа, созданная для похудение лучшими экспертами в этой сфере, которая практически идеально подходит для каждой девушки"
            },
            new Category
            {
                Id = 2,
                Name = "Фитнес",
                Description = "Программа для тех, кто хочет поддерживать физическую форму и развивать выносливость."
            },
            new Category
            {
                Id = 3,
                Name = "Здоровое питание",
                Description = "Система питания, основанная на принципах здорового образа жизни и правильного питания."
            },
            new Category
            {
                Id = 4,
                Name = "Медитация",
                Description = "Программа для снятия стресса и улучшения психоэмоционального состояния."
            }
        };
        }

        public List<Category> GetCategories()
        {
            return categories;
        }
    }

}
