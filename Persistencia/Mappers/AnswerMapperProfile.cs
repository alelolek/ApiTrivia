
using AutoMapper;
using CrossCutting.Dtos;
using Persistence.Entities;

namespace Persistence.Mappers
{
	public class AnswerMapperProfile : Profile
	{
        public AnswerMapperProfile()
        {
            CreateMap<AnswerCreationDto, Answer>();
            CreateMap<Answer, AnswerDto>();
        }
    }
}
