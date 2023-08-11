
using CrossCutting.Dtos;
using CrossCutting.Dtos.Standar;

namespace Persistence.Repository.Interfaces
{
	public interface IQuestionRepository
	{
		public Task<List<QuestionDto>> Get();
		public Task<List<QuestionDto>> GetById(int id);
		public Task<ResponseDto> Create(QuestionCreationDto questionCreationDto);
		public  Task<ResponseDto> Update(int id, QuestionCreationDto questionCreationDto);
		public Task<ResponseDto> Delete(int id);
	}
}
