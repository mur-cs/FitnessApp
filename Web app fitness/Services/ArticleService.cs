using Web_app_fitness.Models;

namespace Web_app_fitness.Services
{
	public interface IArticleService
	{
		public List<Article> GetArticles();
	}
    public class ArticleService : IArticleService
    {
        List<Article> _articles;

        public ArticleService()
        {
            _articles = new List<Article>()
        {
            new Article()
            {
                Id = 1,
                Name = "Активное похудение",
                Description = "Диетолог Алина Клочко составила рецепт идеального похудения",
                CategoryId = 2
            },
            new Article()
            {
                Id = 2,
                Name = "Секреты здорового питания",
                Description = "Как правильно сбалансировать рацион для достижения максимальных результатов.",
                CategoryId = 3
            },
            new Article()
            {
                Id = 3,
                Name = "Основы медитации",
                Description = "Как медитация может помочь в повседневной жизни и улучшить ваше психоэмоциональное состояние.",
                CategoryId = 4
            },
            new Article()
            {
                Id = 4,
                Name = "Фитнес для начинающих",
                Description = "Программа тренировок для тех, кто только начинает заниматься спортом.",
                CategoryId = 2
            },
            new Article()
            {
                Id = 5,
                Name = "Психология похудения",
                Description = "Как настроиться на успех и преодолеть психологические барьеры.",
                CategoryId = 1
            },
            new Article() { Id = 6, Name = "Как правильно бегать", Description = "Техника бега для новичков.", CategoryId = 2 },
            new Article() { Id = 7, Name = "Топ 10 диет", Description = "Популярные диеты и их особенности.", CategoryId = 1 },
            new Article() { Id = 8, Name = "Важность растяжки", Description = "Почему растяжка важна для здоровья.", CategoryId = 2 },
            new Article() { Id = 9, Name = "Здоровые перекусы", Description = "Идеи для здоровых перекусов между приемами пищи.", CategoryId = 3 },
            new Article() { Id = 10, Name = "Польза йоги", Description = "Как йога помогает улучшить здоровье.", CategoryId = 4 },
            new Article() { Id = 11, Name = "Силовые тренировки для женщин", Description = "Тренировки, которые помогут женщинам стать сильнее.", CategoryId = 2 },
            new Article() { Id = 12, Name = "Как выбрать спортивную обувь", Description = "Рекомендации по выбору обуви для тренировок.", CategoryId = 2 },
            new Article() { Id = 13, Name = "План питания для похудения", Description = "Как составить план питания для достижения результатов.", CategoryId = 1 },
            new Article() { Id = 14, Name = "Техники медитации", Description = "Разные техники медитации и их преимущества.", CategoryId = 4 },
            new Article() { Id = 15, Name = "Кардионагрузки: что это?", Description = "Все о кардионагрузках и их пользе.", CategoryId = 2 },
            new Article() { Id = 16, Name = "Секреты успешного похудения", Description = "Советы от экспертов по похудению.", CategoryId = 1 },
            new Article() { Id = 17, Name = "Правильное дыхание во время тренировки", Description = "Как дышать правильно во время физической активности.", CategoryId = 2 },
            new Article() { Id = 18, Name = "Способы борьбы со стрессом", Description = "Как медитация и физическая активность помогают справиться со стрессом.", CategoryId = 4 },
            new Article() { Id = 19, Name = "Как избежать травм при тренировках", Description = "Советы по безопасным тренировкам.", CategoryId = 2 },
            new Article() { Id = 20, Name = "Витамины и минералы для здоровья", Description = "Необходимые витамины и минералы для поддержания здоровья.", CategoryId = 3 },
            new Article() { Id = 21, Name = "Польза отдыха для восстановления", Description = "Как важен отдых для восстановления после тренировок.", CategoryId = 2 },
            new Article() { Id = 22, Name = "Здоровое питание для всей семьи", Description = "Советы по здоровому питанию для всей семьи.", CategoryId = 3 },
            new Article() { Id = 23, Name = "Медитация для начинающих", Description = "Как начать медитировать.", CategoryId = 4 },
            new Article() { Id = 24, Name = "Фитнес в домашних условиях", Description = "Эффективные тренировки без тренажеров.", CategoryId = 2 },
            new Article() { Id = 25, Name = "Как управлять своим временем", Description = "Советы по эффективному управлению временем.", CategoryId = 1 },
            new Article() { Id = 26, Name = "Питание перед тренировкой", Description = "Что есть перед тренировкой для лучшего результата.", CategoryId = 3 },
            new Article() { Id = 27, Name = "Как выбрать спортзал", Description = "Рекомендации по выбору спортзала.", CategoryId = 2 },
            new Article() { Id = 28, Name = "Тренировка на выносливость", Description = "Упражнения для повышения выносливости.", CategoryId = 2 },
            new Article() { Id = 29, Name = "Как найти мотивацию для тренировок", Description = "Способы поддержания мотивации.", CategoryId = 1 },
            new Article() { Id = 30, Name = "Питание для спортсменов", Description = "Особенности питания для людей, занимающихся спортом.", CategoryId = 3 },
            new Article() { Id = 31, Name = "Как восстановиться после травмы", Description = "Советы по восстановлению после травм.", CategoryId = 2 },
            new Article() { Id = 32, Name = "Гидратация во время тренировки", Description = "Почему важно пить воду во время физической активности.", CategoryId = 2 },
            new Article() { Id = 33, Name = "Медитация и ее влияние на здоровье", Description = "Как медитация может улучшить здоровье.", CategoryId = 4 },
            new Article() { Id = 34, Name = "Физическая активность для детей", Description = "Как привить любовь к физической активности детям.", CategoryId = 2 },
            new Article() { Id = 35, Name = "Польза здорового сна", Description = "Как качественный сон влияет на здоровье.", CategoryId = 3 }
        };
        }

        public List<Article> GetArticles()
        {
            return _articles;
        }
    }

}
