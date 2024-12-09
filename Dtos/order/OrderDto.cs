using velocitaApi.models;

namespace velocitaApi.Dtos.order
{
    public class OrderDto
    {
        public int OrderNumber { get; private set; }
        public string Discrption { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public ServiceType ServiceType { get; set; }
        public decimal TotalCost { get; set; }
        public int CustomerId { get; set; }
        public int? CarId { get; set; }
    }
}
