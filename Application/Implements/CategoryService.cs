

using Application.Interfaces;
using CrossCutting.Dtos;
using CrossCutting.Dtos.Standar;
using Persistence.Repository.Interfaces;

namespace Application.Implements
{
	public class CategoryService : ICategoryService
	{
		private readonly ICategoryRepository categoryRepository;

		public CategoryService(ICategoryRepository categoryRepository)
        {
			this.categoryRepository = categoryRepository;
		}
		public async Task<List<CategoryDto>> Get()
		{
			try
			{
				return await categoryRepository.Get();
			}
			catch (Exception)
			{
				throw;
			}
		}
		public async Task<ResponseDto> Create(CategoryCreationDto categoryCreationDto)
		{
			var response = new ResponseDto();
			try
			{
				response = await categoryRepository.Create(categoryCreationDto);
			}
			catch (Exception)
			{
				throw;
			}
			return response;
		}

		public async Task<ResponseDto> Update(CategoryCreationDto categoryCreationDto, int id)
		{
			var response = new ResponseDto();
			try
			{
				response = await categoryRepository.Update(categoryCreationDto, id);
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
				response = await categoryRepository.Delete(id);
			}
			catch (Exception)
			{
				throw;
			}
			return response;
		}
	}
}
