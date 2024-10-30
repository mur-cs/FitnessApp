namespace Web_app_fitness.Models
{
	public class ArticleViewModel
	{
		public List<Article> Articles { get; set; }
		public Category Category { get; set; }

		public ArticleViewModel(List<Article> articles, Category category) 
		{
			this.Articles = articles;
			this.Category = category;
		}
	}
}
