namespace dotnet_grpc_service.Domain.ValueObjects;

public class OrderItemUnitPrice
{
    public decimal Price { get; set; }

    public OrderItemUnitPrice(decimal price)
    {
        if(price <= 0)
            throw new ArgumentException("Price must be greater than 0", nameof(price));
        Price = price;
    }
}