using Application.Implements;
using Application.Interfaces;
using CrossCutting.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Persistence.Entities;

namespace TriviaApi.Controllers
{
	[ApiController]
	[Route("api/v1/questions")]
	[Authorize]
	public class QuestionController : ControllerBase
	{
		private readonly IQuestionService questionService;

		public QuestionController(IQuestionService questionService)
		{
			this.questionService = questionService;
		}
		[AllowAnonymous]
		[HttpGet]
		public async Task<ActionResult<List<QuestionDto>>> Get()
		{
			return await questionService.Get();
		}

		[AllowAnonymous]
		[HttpGet("{idCategory:int}")]
		public async Task<ActionResult<List<QuestionDto>>> GetById(int idCategory)
		{
			return await questionService.GetById(idCategory);
		}
		

		[HttpPost]
		public async Task<ActionResult> Post(QuestionCreationDto questionCreationDto)
		{
			try
			{
				var response = await questionService.Create(questionCreationDto);
			}
			catch (Exception)
			{
				throw;
			}
			return Ok();
		}

		[HttpPut("{id:int}")]
		public async Task<ActionResult> Put(int id,QuestionCreationDto questionCreationDto)
		{
			try
			{
				var response = await questionService.Update(id,questionCreationDto);
			}
			catch (Exception)
			{

				throw;
			}
			return Ok();
		}

		[HttpDelete("{id:int}")]
		public async Task<ActionResult> Delete(int id)
		{
			try
			{
				var response = await questionService.Delete(id);
			}
			catch (Exception)
			{
				throw;
			}
			return Ok();
		}
	}
}
