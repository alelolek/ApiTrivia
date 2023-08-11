using CrossCutting.Dtos;
using CrossCutting.Dtos.Standar;

namespace Persistence.Repository.Interfaces
{
	public interface IAnswerRepository
	{
		public Task<List<AnswerDto>> Get();
		public Task<List<AnswerDto>> GetById(int id);
		public Task<ResponseDto> Create(AnswerCreationDto answerCreationDto);
		public Task<ResponseDto> Update(int id, AnswerCreationDto answerCreationDto);
		public Task<ResponseDto> Delete(int id);
	}
}
