# NubimetricsApp

Nubimetrics Challenge

## Tecnologias

* [ASP.NET Core 5](https://docs.microsoft.com/en-us/aspnet/core/introduction-to-aspnet-core?view=aspnetcore-5.0)
* [Entity Framework Core 5](https://docs.microsoft.com/en-us/ef/core/)
* [AutoMapper](https://automapper.org/)

## Info

### Domain

Esta capa contiene todas las entidades pertenecientes al dominio.

### Application

Esta capa contiene toda la lógica de la aplicacion.

### Infrastructure

Esta capa contiene el ORM *Entity Framework Core* encargado de la persistencia. Adicionalmente posee una configuracion de la entidad *User* que al momento de ejecutarse el update popula la tabla con data. Se utilizo code first.

### .Api

Esta capa contiene las apis que exponen los endpoint necesarios.

## Patterns

Capa capa hace uso del patrón DI exponiendo una clase de extension que seran declaradas en el *Startup.cs*.