
namespace CrossCutting.Dtos
{
	public class QuestionDto
	{
		public int Id { get; set; }
		public string Description { get; set; }
		public int CategoryId { get; set; }
		public List<AnswerDto> Answers { get; set; }
	}
}
