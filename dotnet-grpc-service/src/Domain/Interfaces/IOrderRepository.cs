using dotnet_grpc_service.Domain.Entities;

namespace dotnet_grpc_service.Domain.Interfaces;

public interface IOrderRepository
{
    Task<Order> GetOrderById(Guid id);
}