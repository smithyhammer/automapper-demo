using AutoMapper;
using AutoMapperDemo.Interfaces;

namespace AutoMapperDemo.Utility
{
    public class Convert2 : IConvert
    {
        public object MapModel<TSource, TDestination>(TSource mySourceModel)
        {
            Mapper.CreateMap<TSource, TDestination>();
            var model = Mapper.Map<TDestination>(mySourceModel);
            return model;
        }
    }
}