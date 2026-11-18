var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.front_Parqueadero_ApiService>("apiservice")
    .WithHttpHealthCheck("/health");

builder.AddProject<Projects.front_Parqueadero_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithHttpHealthCheck("/health")
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
