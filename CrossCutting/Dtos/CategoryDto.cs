namespace CrossCutting.Dtos
{
	public class CategoryDto
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Descripcion { get; set; }
		public List<QuestionDto> questions { get; set; }
	}
}
