namespace App.Models.Dto
{
    public class OrderDto
    {
        public int OrderID { get; set; }
        public string ClientLastName { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? FulfilledAt { get; set; }

        public string Status { get; set; }

        public List<ProductDto> Products { get; set; }

        public static OrderDto From(Order order)
        {
            return new OrderDto
            {
                OrderID = order.Id,
                ClientLastName = order.Client.LastName,
                CreatedAt = order.CreatedAt,
                FulfilledAt = order.UpdatedAt,
                Status = order.Status.Name,
                Products = order.ProductOrders.Select(ProductDto.From).ToList()
            };
        }
    }
}
