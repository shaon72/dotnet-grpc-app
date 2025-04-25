using Grpc.Core;
using dotnet_grpc_service;

namespace dotnet_grpc_service.Services;

public class GrpcService : Grpc.GrpcBase
{
    private readonly ILogger<GrpcService> _logger;

    public GrpcService(ILogger<GrpcService> logger)
    {
        _logger = logger;
    }

    public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
    {
        return Task.FromResult(new HelloReply
        {
            Message = "Hello " + request.Name
        });
    }
}