

namespace Persistence.Entities
{
	public class Category
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Descripcion { get; set; }
		public List<Question> Questions { get; set; }

	}
}
