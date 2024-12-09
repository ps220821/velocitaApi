namespace velocitaApi.Dtos.CarOption;

public class CarOptionDto
{
    public int CarId { get; set; }
    public int OptionId { get; set; }
    public bool Available { get; set; }
    public string Description { get; set; }
}