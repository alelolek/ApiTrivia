using AutoMapper;
using CrossCutting.Dtos;
using Persistence.Entities;

namespace Persistence.Mappers
{
	public class QuestionMapperProfile : Profile
	{
        public QuestionMapperProfile()
        {
            CreateMap<QuestionCreationDto, Question>();
            CreateMap<Question, QuestionDto>();
        }
    }
}
