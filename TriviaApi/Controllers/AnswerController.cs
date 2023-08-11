using Application.Interfaces;
using CrossCutting.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TriviaApi.Controllers
{
	[ApiController]
	[Route("/api/v1/answers")]
	[Authorize]
	public class AnswerController : ControllerBase
	{
		private readonly IAnswerService answerService;

		public AnswerController(IAnswerService answerService)
        {
			this.answerService = answerService;
		}

		[HttpGet]
		[AllowAnonymous]
		public async Task<ActionResult<List<AnswerDto>>> Get()
		{
			return await answerService.Get();
		}

		[HttpGet("{idQuestion:int}")]
		[AllowAnonymous]
		public async Task<ActionResult<List<AnswerDto>>> GetById(int idQuestion)
		{
			return await answerService.GetById(idQuestion);
		}

		[HttpPost]
		public async Task<ActionResult> Post(AnswerCreationDto answerCreationDto)
		{
			try
			{
				var response = await answerService.Create(answerCreationDto);
			}
			catch (Exception)
			{

				throw;
			}
			return Ok();
		}

		[HttpPut("{id:int}")]
		public async Task<ActionResult> Put(int id,AnswerCreationDto answerCreationDto)
		{
			try
			{
				var response = await answerService.Update(id,answerCreationDto);
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
				var response = await answerService.Delete(id);
			}
			catch (Exception)
			{

				throw;
			}
			return Ok();
		}
	}
}
