
![Nuget](https://img.shields.io/nuget/v/Ploomes.Api.Client.svg)

> Veja essa documentação em: [Português](README.pt-BR.md)

# Ploomes.Api.Client
 Ploomes api .net client library


# Getting started

```
PM> Install-Package Ploomes.Api.Client
```

## Building api client

```c#
var options = new PloomesApiClientOptions { Token = "your-ploomes-token" };
var client = new PloomesClient(options);
```

### Getting Deals

```c#
...
var deals = await client.Deals.GetAsync(new OData { Top = 50 });
```

### Getting Contacts

```c#
...
var contacts = await client.Contacts.GetAsync(new OData { Top = 50 });
```


## Filtering

```c#
...
var deals = await client.Deals.GetAsync(new OData { Filter = "statusId eq 1" });
```