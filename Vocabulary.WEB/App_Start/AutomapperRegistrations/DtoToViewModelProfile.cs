using AutoMapper;
using Vocabulary.BLL.DTO;
using Vocabulary.WEB.ViewModels;

namespace Vocabulary.WEB.AutomapperRegistrations
{
    public class DtoToViewModelProfile : Profile
    {
        public DtoToViewModelProfile()
        {
            CreateMap<ExampleDto, ExampleViewModel>();
        }
    }
}