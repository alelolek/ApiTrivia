
using CrossCutting.Dtos;
using CrossCutting.Dtos.Standar;

namespace Persistence.Repository.Interfaces
{
	public interface ICategoryRepository
	{
		public  Task<List<CategoryDto>> Get();
		public  Task<ResponseDto> Create(CategoryCreationDto categoryCreationDto);
		public Task<ResponseDto> Update(CategoryCreationDto categoryCreationDto, int id);
		public  Task<ResponseDto> Delete(int id);
	}
}
