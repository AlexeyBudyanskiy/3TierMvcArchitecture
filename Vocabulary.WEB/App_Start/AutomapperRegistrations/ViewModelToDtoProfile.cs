using AutoMapper;
using Vocabulary.BLL.DTO;
using Vocabulary.WEB.ViewModels;

namespace Vocabulary.WEB.AutomapperRegistrations
{
    public class ViewModelToDtoProfile : Profile
    {
        public ViewModelToDtoProfile()
        {
            CreateMap<ExampleViewModel, ExampleDto>();
        }
    }
}