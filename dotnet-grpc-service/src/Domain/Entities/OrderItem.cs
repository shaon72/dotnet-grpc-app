using dotnet_grpc_service.Domain.ValueObjects;

namespace dotnet_grpc_service.Domain.Entities;

public class OrderItem
{
    public OrderItemQuantity Quantity { get; }
    public OrderItemUnitPrice UnitPrice { get; }

    public OrderItem(int quantity, decimal unitPrice)
    {
        Quantity = new OrderItemQuantity(quantity);
        UnitPrice = new OrderItemUnitPrice(unitPrice);
    }
}