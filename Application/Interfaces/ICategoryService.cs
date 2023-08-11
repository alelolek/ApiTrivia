
using CrossCutting.Dtos;
using CrossCutting.Dtos.Standar;

namespace Application.Interfaces
{
	public interface ICategoryService
	{
		public  Task<List<CategoryDto>> Get();
		public Task<ResponseDto> Create(CategoryCreationDto categoryCreationDto);
		public Task<ResponseDto> Update(CategoryCreationDto categoryCreationDto, int id);
		public Task<ResponseDto> Delete(int id);

	}
}
