namespace dotnet_grpc_service.Domain.ValueObjects;

public class OrderItemQuantity
{
    public int Value { get; set; }

    public OrderItemQuantity(int quantity)
    {
        if(quantity <= 0)
            throw new ArgumentException("Quantity must be greater than 0", nameof(quantity));
        Value = quantity;
    }
}