using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using System.Text.Json.Serialization;
using velocitaApi.models;

namespace velocitaApi.models
{
    public class CarSpec
    {
        public int Id { get; set; }

        public string Engine { get; set; }

        public TransmissionEnum Transmission { get; set; }

        public DriveTrainEnum DriveTrain { get; set; }

        public FuelTypeEnum FuelType { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal? FuelEconomy { get; set; }

        public int? Horsepower { get; set; }

        public int? Torque { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal? ZeroToSixty { get; set; }

        public int? TopSpeed { get; set; }

        public int? Weight { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal? Length { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal? Width { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal? Height { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal? Wheelbase { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal? GroundClearance { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal? CargoSpace { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal? PassengerSpace { get; set; }

        public Seating Seating { get; set; }

        public int? TowingCapacity { get; set; }

        public int? MaxPayload { get; set; }

        [ForeignKey("CarId")]
        public int CarId { get; set; }

        [JsonIgnore]
        public Car Car { get; set; }
    }

    public enum DriveTrainEnum
    {
        FWD = 1,
        RWD = 2,
        AWD = 3,
        FourWD = 4
    }

    public enum FuelTypeEnum
    {
        Gasoline = 1,
        Diesel = 2,
        Electric = 3,
        Hybrid = 4
    }

    public enum TransmissionEnum
    {
        Manual = 1,
        Automatic = 2,
        CVT = 3,
        DCT = 4
    }

    public enum Seating
    {
        Two = 1,
        Four = 2,
        Five = 3,
        Six = 4,
        Seven = 5,
        Eight = 6,
        Nine = 7,
        Ten = 8
    }
}
