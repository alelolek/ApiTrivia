using Application.Interfaces;
using CrossCutting.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TriviaApi.Controllers
{
	[ApiController]
	[Route("/api/v1/categories")]
	[Authorize]
	public class CategoryController : ControllerBase
	{
		private readonly ICategoryService categoryService;

		public CategoryController(ICategoryService categoryService)
        {
			this.categoryService = categoryService;
		}
		[AllowAnonymous]
		[HttpGet]
		public async Task<ActionResult<List<CategoryDto>>> Get()
		{
			return await categoryService.Get();
		}


		[HttpPost]
		public async Task<ActionResult> Post(CategoryCreationDto categoryCreacionDto)
		{
			try
			{
				var response = await categoryService.Create(categoryCreacionDto);
			}
			catch (Exception)
			{
				throw;
			}
			return Ok();
		}

		[HttpPut("{id:int}")]
		public async Task<ActionResult> Put(CategoryCreationDto categoryCreacionDto, int id)
		{
			try
			{
				var response = await categoryService.Update(categoryCreacionDto, id);
			}
			catch (Exception)
			{
				throw;
			}
			return NoContent();
		}

		[HttpDelete("{id:int}")]
		public async Task<ActionResult> Delete(int id)
		{
			try
			{
				var response = await categoryService.Delete(id);
			}
			catch (Exception)
			{
				throw;
			}
			return NoContent();
		}
	}
}
