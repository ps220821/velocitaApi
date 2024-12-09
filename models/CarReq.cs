using System.Text.Json.Serialization;
namespace velocitaApi.models
{
    public class CarReq
    {
        public Car Car { get; set; }
        public List<CarOptionCustom> CarOptions { get; set; }
        public CarSpec CarSpecs { get; set; }
    }

    public class CarOptionCustom
    {
        public int Id { get; set; }
        public Option Option { get; set; }
        public bool Available { get; set; }
        public string Description { get; set; }
    }
}