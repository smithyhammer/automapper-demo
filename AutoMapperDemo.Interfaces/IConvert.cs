namespace AutoMapperDemo.Interfaces
{
    public interface IConvert
    {
        object MapModel<TSource, TDestination>(TSource mySourceModel);
    }
}