using Aspire.Hosting;

var builder = DistributedApplication.CreateBuilder(args);


var api = builder.AddProject<Projects.Healthcare_API>("healthcare-api")
                 .WithExternalHttpEndpoints();

var frontend = builder.AddExecutable(
                    name: "frontend-dev",
                    command: "npm",
                    args: "start",
                    workingDirectory: "../healthcare-frontend")
                .WithExternalHttpEndpoints();

frontend.WithReference(api);

builder.Build().Run();
