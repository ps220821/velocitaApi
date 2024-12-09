using velocitaApi.models;
namespace velocitaApi.Dtos.CarOption
{
    public class CarSpecDto
    {
        public string Engine { get; set; }
        public TransmissionEnum Transmission { get; set; } = TransmissionEnum.Automatic;
        public DriveTrainEnum DriveTrain { get; set; } = DriveTrainEnum.FWD;
        public FuelTypeEnum FuelType { get; set; } = FuelTypeEnum.Gasoline;
        public decimal? FuelEconomy { get; set; }
        public int? Horsepower { get; set; }
        public int? Torque { get; set; }
        public decimal? ZeroToSixty { get; set; }
        public int? TopSpeed { get; set; }
        public int? Weight { get; set; }
        public decimal? Length { get; set; }
        public decimal? Width { get; set; }
        public decimal? Height { get; set; }
        public decimal? Wheelbase { get; set; }
        public decimal? GroundClearance { get; set; }
        public decimal? CargoSpace { get; set; }
        public decimal? PassengerSpace { get; set; }
        public int? SeatingCapacity { get; set; }
        public int? TowingCapacity { get; set; }
        public int? MaxPayload { get; set; }
        public int CarId { get; set; } // Foreign key if needed
    }
}
