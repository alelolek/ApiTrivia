
using Application.Interfaces;
using CrossCutting.Dtos;
using CrossCutting.Dtos.Standar;
using Persistence.Repository.Interfaces;

namespace Application.Implements
{
	public class AnswerService : IAnswerService
	{
		private readonly IAnswerRepository answerRepository;

		public AnswerService(IAnswerRepository answerRepository)
        {
			this.answerRepository = answerRepository;
		}

		public async Task<ResponseDto> Create(AnswerCreationDto answerCreationDto)
		{
			var response = new ResponseDto();
			try
			{
				response = await answerRepository.Create(answerCreationDto);
				
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
				response = await answerRepository.Delete(id);	
			}
			catch (Exception)
			{

				throw;
			}
			return response;
		}

		public async Task<List<AnswerDto>> Get()
		{
			try
			{
				return await answerRepository.Get();
			}
			catch (Exception)
			{

				throw;
			}
		}

		public async Task<List<AnswerDto>> GetById(int id)
		{
			try
			{
				return await answerRepository.GetById(id);
			}
			catch (Exception)
			{

				throw;
			}
		}

		public async Task<ResponseDto> Update(int id, AnswerCreationDto answerCreationDto)
		{
			var response = new ResponseDto();
			try
			{
				response = await answerRepository.Update(id, answerCreationDto);
			}
			catch (Exception)
			{

				throw;
			}
			return response;
		}
	}
}
