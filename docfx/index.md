# Octopus.Client
Octopus.Client is an [open source](https://github.com/OctopusDeploy/OctopusClients) .NET library that makes it easy to write C# programs or PowerShell scripts that manipulate the [Octopus Deploy REST API](https://octopus.com/docs/octopus-rest-api).

The library targets:
- .NET Framework 4.5.2
- .NET Standard 2.0

Details for where to find the API, how to authenticate, and the resources that are available can be found on [the API documentation site](https://g.octopushq.com/ApiDocs), and [swagger documentation is also available](https://samples.octopus.app/swaggerui).

## Installation

```pwsh
Install-Package Octopus.Client
```

## Usage

In PowerShell, you can load the DLLs into your session using the [`Add-Type`](https://docs.microsoft.com/en-us/powershell/module/microsoft.powershell.utility/add-type?view=powershell-7.1) cmdlet.

```pwsh
$path = Join-Path (Get-Item ((Get-Package Octopus.Client).source)).Directory.FullName "lib/net452/Octopus.Client.dll"
Add-Type -Path $path
```

Using the DLL that targets netstandard may require additional types:

```pwsh
$path = Join-Path (Get-Item ((Get-Package NewtonSoft.Json).source)).Directory.FullName "lib/netstandard2.0/NewtonSoft.Json.dll"
Add-Type -Path $path
$path = Join-Path (Get-Item ((Get-Package Octodiff).source)).Directory.FullName "lib/netstandard2.0/Octodiff.dll"
Add-Type -Path $path
```

## Authentication

### Api Key
See our documentation on [how to create an API key](https://octopus.com/docs/octopus-rest-api/how-to-create-an-api-key).

```csharp
var server = "https://myoctopus.example.com/";
var apiKey = "API-YOURKEY";
var endpoint = new OctopusServerEndpoint(server, apiKey);
using (var client = await OctopusAsyncClient.Create(endpoint))
{
    // client is ready to use
}
```

### Username and password
```csharp
await client.Repository.Users.SignIn(new LoginCommand { Username = "me", Password = "secret" });
```

## Octopus.Client Examples

We have many examples showing how to use Octopus.Client in both our [API examples](/docs/octopus-rest-api/examples/index.md), and on the [OctopusDeploy-API GitHub repository](https://github.com/OctopusDeploy/OctopusDeploy-Api/tree/master/Octopus.Client).
