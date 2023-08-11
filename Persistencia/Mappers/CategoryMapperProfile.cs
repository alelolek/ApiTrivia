
using AutoMapper;
using CrossCutting.Dtos;
using Persistence.Entities;

namespace Persistence.Mappers
{
	public class CategoryMapperProfile : Profile
	{
		public CategoryMapperProfile()
		{
			CreateMap<CategoryCreationDto, Category>();
			CreateMap<Category, CategoryDto>();
		}
	}
}
