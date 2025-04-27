namespace dotnet_grpc_service.Domain.Entities;

public class Order
{
    public Guid Id { get; set; }
    public DateTime OrderDate { get; set; }
    public string ShippingAddress { get; set; }
    private readonly List<OrderItem> items = new();
}