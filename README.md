# Open Data Montgomery, AL API Library

C# API Client library for Open Data Montgomery, AL. This allows you to access endpoints 
to retrieve the requested information from the city. Additional information
about the portal can be found at
[https://opendata.montgomeryal.gov](https://opendata.montgomeryal.gov).

## Table of Contents

* Installation
* Usage
* Contributions
* License

## Installation

### Requirements

Your application must be using .NET 9.0 or later.

### Nuget Package

Package can be installed into your project from NuGet by running the command

```bash
dotnet add package Almostengr.OpenDataMontgomeryAlGov.ApiClient
```

## Usage

To make the endpoints available for your application, add the below to the Program.cs
file in your application.

```csharp
builder.Services.AddOpenDataMontgomeryAlServices();
```

## Contributions

Any issues or feature requests should be submitted the repository at 
[https://github.com/almostengr/open-data-montgomery-al](https://github.com/almostengr/open-data-montgomery-al).

## License

See LICENSE file for more information and the allowed usage of this project.
