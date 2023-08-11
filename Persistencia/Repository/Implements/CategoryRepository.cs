
using AutoMapper;
using CrossCutting.Dtos;
using CrossCutting.Dtos.Standar;
using Microsoft.EntityFrameworkCore;
using Persistence.Entities;
using Persistence.Repository.Interfaces;

namespace Persistence.Repository.Implements
{
	public class CategoryRepository : ICategoryRepository
	{
		private readonly ApplicationDbContext context;
		private readonly IMapper mapper;

		public CategoryRepository(ApplicationDbContext context,IMapper mapper)
        {
			this.context = context;
			this.mapper = mapper;
		}

		public async Task<List<CategoryDto>> Get()
		{
			try
			{
				var categories = await context.Categories.ToListAsync();
				return mapper.Map<List<CategoryDto>>(categories);
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
				var category = mapper.Map<Category>(categoryCreationDto);
				context.Add(category);
				await context.SaveChangesAsync();
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
				var exist = await context.Categories.AnyAsync(x => x.Id == id);
				var category = mapper.Map<Category>(categoryCreationDto);
				category.Id = id;

				context.Update(category);
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
				var existe = await context.Categories.AnyAsync(x => x.Id == id);
				context.Remove(new Category() { Id = id });
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
