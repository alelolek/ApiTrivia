
namespace Persistence.Entities
{
	public class Question
	{
		public int Id { get; set; }
		public string Description { get; set; }
		public int CategoryId { get; set; }
		public Category Category { get; set; }
		public List<Answer> Answers { get; set; }
	}
}
