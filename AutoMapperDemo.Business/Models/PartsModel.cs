namespace AutoMapperDemo.Business.Models
{
    public class PartsModel
    {
        public int Id { get; set; }
        public string PartName { get; set; }

        public string PartRefId
        {
            get { return Id + PartName; }
        }

        public bool IsAvailable { get; set; }
    }
}