
using CrossCutting.Dtos.Standar;
using CrossCutting.Dtos;

namespace Application.Interfaces
{
	public interface IAnswerService
	{
		public Task<List<AnswerDto>> Get();
		public Task<List<AnswerDto>> GetById(int id);
		public Task<ResponseDto> Create(AnswerCreationDto answerCreationDto);
		public Task<ResponseDto> Update(int id, AnswerCreationDto answerCreationDto);
		public Task<ResponseDto> Delete(int id);
	}
}
