
using AutoMapper;
using CrossCutting.Dtos;
using CrossCutting.Dtos.Standar;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Persistence.Entities;
using Persistence.Repository.Interfaces;

namespace Persistence.Repository.Implements
{
	public class QuestionRepository : IQuestionRepository
	{
		private readonly ApplicationDbContext context;
		private readonly IMapper mapper;

		public QuestionRepository(ApplicationDbContext context,IMapper mapper)
        {
			this.context = context;
			this.mapper = mapper;
		}

		public async Task<List<QuestionDto>> Get()
		{
			try
			{
				var question  = await context.Questions.Include(a=>a.Answers).ToListAsync();
				return mapper.Map<List<QuestionDto>>(question);
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
				var question = await context.Questions.Include(a=>a.Answers).Where(q => q.CategoryId == id).ToListAsync();
				return mapper.Map<List<QuestionDto>>(question);
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
				var question = mapper.Map<Question>(questionCreationDto);
				context.Add(question);
				await context.SaveChangesAsync();
			}
			catch (Exception)
			{
				throw;
			}
			return response;
		}

		public async Task<ResponseDto> Update(int id, QuestionCreationDto questionCreationDto)
		{
			var response = new ResponseDto();
			try
			{
				var question = mapper.Map<Question>(questionCreationDto);
				question.Id = id;
				context.Update(question);
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
				context.Remove(new Question() { Id = id });
				await context.SaveChangesAsync();
			}
			catch
			{
				throw;
			}
			return response;
		}
	}
}
