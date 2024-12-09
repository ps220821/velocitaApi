using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace velocitaApi.models
{
    public class Order
    {
        public int id { get; set; }
        public string Discrption { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus OrderStatus { get; set; } = OrderStatus.Pending;
        public ServiceType ServiceType { get; set; } = ServiceType.Repair;
        public decimal TotalCost { get; set; }

        [ForeignKey("CustomerId")]
        public int? CustomerId { get; set; }  // Nullable
        public Customer? Customer { get; set; }

        [ForeignKey("CarId")]
        public int? carId { get; set; }
        public Car? Car { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }


    public enum OrderStatus
    {
        Pending = 1,
        InProgress = 2,
        Completed = 3,
        Cancelled = 4
    }

    public enum ServiceType
    {
        Repair = 1,
        Maintenance = 2,
        Inspection = 3,
        Cleaning = 4,
        NewCarSale = 5,
        UsedCarSale = 6,
        TradeIn = 7,
    }
}
