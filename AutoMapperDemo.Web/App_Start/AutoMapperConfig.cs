using AutoMapper;
using AutoMapperDemo.Business.Models;
using AutoMapperDemo.Web.Areas.Scheduling.Models;

namespace AutoMapperDemo.Web
{
    public static class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.CreateMap<ProgramModel, ProgramViewModel>()
                  .ForMember(dest => dest.ProgramId,
                      opts => opts.MapFrom(src => src.Id));
        }
    }
}