
using AutoMapper;
using CrossCutting.Dtos;
using CrossCutting.Dtos.Standar;
using Microsoft.EntityFrameworkCore;
using Persistence.Entities;
using Persistence.Repository.Interfaces;

namespace Persistence.Repository.Implements
{
	public class AnswerRepository : IAnswerRepository
	{
		private readonly ApplicationDbContext context;
		private readonly IMapper mapper;

		public AnswerRepository(ApplicationDbContext context,IMapper mapper)
        {
			this.context = context;
			this.mapper = mapper;
		}

		public async Task<List<AnswerDto>> Get()
		{
			try
			{
				
				var answer = await context.Answers.ToListAsync();
				return mapper.Map<List<AnswerDto>>(answer);
			}
			catch (Exception)
			{
				throw;
			}
		}
		public async Task<List<AnswerDto>> GetByIdQuestion(int id)
		{
			try
			{
				var answer = await context.Answers.Where(a => a.QuestionId == id).ToListAsync();
				return mapper.Map<List<AnswerDto>>(answer);

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
				var answer = await context.Answers.Where(a => a.Id== id).ToListAsync();
				return mapper.Map<List<AnswerDto>>(answer);

			}
			catch (Exception)
			{

				throw;
			}
		}

		public async Task<ResponseDto> Create(AnswerCreationDto answerCreationDto)
		{
			var response = new ResponseDto();
			try
			{
				var answer = mapper.Map<Answer>(answerCreationDto);
				context.Add(answer);
				await context.SaveChangesAsync();
			}
			catch (Exception)
			{

				throw;
			}
			return response;
		}

		public async Task<ResponseDto> Update(int id , AnswerCreationDto answerCreationDto)
		{
			var response = new ResponseDto();
			try
			{
				var answer = mapper.Map<Answer>(answerCreationDto);
				answer.Id = id;
				context.Update(answer);
				await context.SaveChangesAsync();
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
				context.Remove(new Answer() { Id = id });
				await context.SaveChangesAsync();
			}
			catch (Exception)
			{

				throw;
			}
			return response;
		}
    }
}
