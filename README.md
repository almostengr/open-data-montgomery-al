# Open Data Montgomery, AL API Library

C# API Client library for Open Data Montgomery, AL. This allows you to access endpoints 
to retrieve the requested information from the city. Additional information
about the portal can be found at
[https://opendata.montgomeryal.gov](https://opendata.montgomeryal.gov).



## Implementation

To make the endpoints available for your application, add the below to the Program.cs
file in your application.

```csharp
builder.Services.AddOpenDataMontgomeryAlServies();
```

### HttpClient

Your application will also need to have an instance of ```HttpClient``` created. This can be implemented using a new 
instance of ```HttpClient``` or through ```IHttpClientFactory```. 

## License

See LICENSE file for more information and the allowed usage of this project.
