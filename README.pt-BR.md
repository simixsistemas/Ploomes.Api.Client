
![Nuget](https://img.shields.io/nuget/v/Ploomes.Api.Client.svg)

> Read this in other languages: [English](README.md)

# Ploomes.Api.Client
 Biblioteca .net para consumo da api Ploomes


# Iniciando com o pacote

```
PM> Install-Package Ploomes.Api.Client
```

## Criando o cliente

```c#
var options = new PloomesApiClientOptions { Token = "seu-token-ploomes" };
var client = new PloomesClient(options);
```

### Buscando negócios

```c#
...
var deals = await client.Deals.GetAsync(new OData { Top = 50 });
```

### Buscando Clientes

```c#
...
var contacts = await client.Contacts.GetAsync(new OData { Top = 50 });
```


## Usando filtros

```c#
...
var deals = await client.Deals.GetAsync(new OData { Filter = "statusId eq 1" });
```