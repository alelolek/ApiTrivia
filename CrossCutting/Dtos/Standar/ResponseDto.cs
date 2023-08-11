
namespace CrossCutting.Dtos.Standar
{
	public class ResponseDto
	{
		public Dictionary<string, string> Errors { get; set; }

		public bool IsInValid { get => Errors.Any(); }

		public ResponseDto()
		{
			Errors = new Dictionary<string, string>();
		}
	}
}
