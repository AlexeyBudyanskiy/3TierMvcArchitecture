using AutoMapper;
using Vocabulary.BLL.DTO;
using Vocabulary.DAL.Entities;

namespace Vocabulary.BLL.Infrastructure.AutomapperRegistration
{
    public class EnitityToDtoProfile : Profile
    {
        public EnitityToDtoProfile()
        {
            CreateMap<Example, ExampleDto>();        
        }
    }
}
