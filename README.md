## biovirt

# .NET SDK 9.0 is required: https://dotnet.microsoft.com/en-us/download

There are two options how to run it.

1. Run API project. The following command will execute both API + Blazor WebAssembly application. 
`dotnet run --project BioVirt.Api/BioVirt.Api.csproj`
Both will run on `https://localhost:7265`
Please note, for API Swagger is enabled when you running it on localhost `https://localhost:7265/swagger`

2. Alternatively you can run only client project
`dotnet run --project biovirt.client/biovirt.client.csproj`
But in this case only Blazor WebAssembly app will be executed (no API access)
Application will be accessible on `https://localhost:7269`