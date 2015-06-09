using System;
using AutoMapper;

namespace AutoMapperDemo.Utility
{
    public class Convert
    {
        public static object MapModel<TSource, TDestination>(TSource mySourceModel)
        {
            Mapper.CreateMap<TSource, TDestination>();
            var model = Mapper.Map<TDestination>(mySourceModel);
            return model;
        }
    }
}