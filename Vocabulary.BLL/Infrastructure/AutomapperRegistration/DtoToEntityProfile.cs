using AutoMapper;
using Vocabulary.BLL.DTO;
using Vocabulary.DAL.Entities;

namespace Vocabulary.BLL.Infrastructure.AutomapperRegistration
{
    public class DtoToEntityProfile : Profile
    {
        public DtoToEntityProfile()
        {
            CreateMap<ExampleDto, Example>();
        }
    }
}
