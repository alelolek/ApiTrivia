
namespace CrossCutting.Dtos
{
	public class AnswerDto
	{
		public int Id { get; set; }
		public bool IsValid { get; set; }
		public string Description { get; set; }
		public int QuestionId { get; set; }
		//public Question Question { get; set; }
	}
}
