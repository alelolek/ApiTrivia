
using Application.Interfaces;
using CrossCutting.Dtos;
using CrossCutting.Dtos.Standar;
using Persistence.Repository.Implements;
using Persistence.Repository.Interfaces;

namespace Application.Implements
{
	public class QuestionService : IQuestionService
	{
		private readonly IQuestionRepository questionRepository;

		public QuestionService(IQuestionRepository questionRepository)
		{
			this.questionRepository = questionRepository;
		}

		public async Task<List<QuestionDto>> Get()
		{
			try
			{
				return await questionRepository.Get();
			}
			catch (Exception)
			{
				throw;
			}
		}

		public async Task<List<QuestionDto>> GetById(int id)
		{
			try
			{
				return await questionRepository.GetById(id);
			}
			catch (Exception)
			{

				throw;
			}
		}


		public async Task<ResponseDto> Create(QuestionCreationDto questionCreationDto)
		{
			var response = new ResponseDto();
			try
			{
				response = await questionRepository.Create( questionCreationDto);
			}
			catch (Exception)
			{
				throw;
			}
			return response;
		}
		public async Task<ResponseDto> Update(int id,QuestionCreationDto questionCreationDto)
		{
			var response = new ResponseDto();
			try
			{
				response = await questionRepository.Update(id, questionCreationDto);
			}
			catch (Exception)
			{
				throw;
			}
			return response;
		}

		public async Task<ResponseDto> Delete(int id)
		{
			var response = new ResponseDto();
			try
			{
				response = await questionRepository.Delete(id);
			}
			catch (Exception)
			{
				throw;
			}
			return response;
		}
	}
}
