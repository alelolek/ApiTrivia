
using CrossCutting.Dtos;
using CrossCutting.Dtos.Standar;

namespace Application.Interfaces
{
	public interface IQuestionService
	{
		public  Task<List<QuestionDto>> Get();
		public Task<List<QuestionDto>> GetById(int id);
		public Task<ResponseDto> Create(QuestionCreationDto questionCreationDto);
		public  Task<ResponseDto> Update(int id, QuestionCreationDto questionCreationDto);
		public Task<ResponseDto> Delete(int id);

	}
}
