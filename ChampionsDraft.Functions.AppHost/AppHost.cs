var builder = DistributedApplication.CreateBuilder(args);

builder.AddAzureFunctionsProject<Projects.ChampionsDraft_Functions>("championsdraft-functions");

builder.Build().Run();
