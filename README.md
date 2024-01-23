# SKYNET API

###### (Readme under construction!)

SKYNET API es un proyecto desarrollado en .NET y C# con Clean Architecture, aplicando los principios SOLID. 
API con Swagger que conecta con diversas API'S (TMDB, GoogleBooks, OpenLibra, StarTrekAPI...) para obtener los datos de éstas y guardarlos en SQL Server. Este proyecto, también; esta pensado para que se vayan actualizando los datos de esta API de forma recurrente (cada X días) y así tener los datos en SQL Server siempre actualizados. API pensada para ofrecer los endpoints y funcionalidades necesarias a los Front-Ends de mis diferentes proyectos personales para que obtengan datos de mi API (SQL Server) y no de las APIS propias.

Deploy Environment: Ubuntu Server con Docker
Backend: .NET, C#, Entity Framework (code-first), LinQ, SQL Server
FrontEnd: Swagger
Pipeline con GitHub Workflow configurado para facilitar el despliegue de la solución dockerizando la imagen y haciendo deploy a Docker Hub

## Estructura de la solución

Esta solución pretende seguir los principios SOLID y aplica Clean Architecture como patrón de diseño, 
específicamente la arquitectura "N-Tier": UI (Swagger) > BussinesLayer (BL) > DataAccessLayer (DA)

```
Ionos Updater
├── Data Access Layer/
│   ├── DataAccess/
|   |       ├── Interfaces/
|   |       |   ├── ICertificateDA.cs
|   |       |   └── ...
|   |       └── Services/
|   |           ├── CertificateDA.cs
|   |           └── ...
│   └── Entities/
|           ├── Certificates/
|           |   ├── Certificate.cs
|           |   └── ...
|           └── Domains/
|               ├── Domain.cs
|               └── ...
├── Domain Layer/
│   ├── Domain Service/
|   |       └── Services/
|   |           ├── DomainBL.cs
|   |           └── ...
│   └── Domain Contracts/
|           ├── ICertificateContract/
|           └── ...
├── Infraestructure/
│   └── Infraestructure Factories
|           ├── HttpClientFactory/
|           └── ...
├── Presentation Layer/
│   └── Ubuntu Server API
|           ├── Controllers/
|           ├── appsettings.json/
|           ├── Program.cs/
|           └── ...
├── Tests Layer/
│   └── Domain Layer Tests
|           ├── IonosServiceTest.cs/
|           └── ...
├── .github/
│   └── workflows
|           └── build-docker-image.yml/  
├── Dockerfile
├── .gitignore
├── .dockerignore
└── README.md
```

## Ejecutando la solución

Para poder ejecutar la solución y poder conectar tanto con la API de IONOS como enviar mensajes hacia Telegram,necesitarás las respectivas claves de las API's. Cómo crear una clave de API en IONOS para activar el acceso a la API, o cómo crear un bot en Telegram y un chat con tu servidor escapa del "scope" de esta guía.
Para ello, puedes visitar mi blog (https://blog.carloscurtido.es), donde encontrarás una guía paso a paso de cómo hacerlo. 
Una vez tengas las claves de las API's, debes crear un archivo appsettings.json en el proyecto Ubuntu.Server.API y copiar este contenido:

```
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "ConnectionStrings": {
    "DefaultConnection": "Server=IPSERVIDOR,PUERTOSERVIDOR;DataBase=openbooksDB;TrustServerCertificate=True;MultipleActiveResultSets=True;User ID=myUser;Password=yourPassword;",
    "TMDBConnection": "Server=IPSERVIDOR,PUERTOSERVIDOR;DataBase=moviesDB;TrustServerCertificate=True;MultipleActiveResultSets=True;User ID=myUser;Password=yourPassword;"
  },
  "ApiKeys": {
    "Tmdb": "tu_api_key_de_TMDB",
    "GoogleBooks": "tu_api_key_de_GoogleBooks",
    "TmdbBaseUrl" : "https://api.themoviedb.org/3"
  },
  "AllowedHosts": "*"
}
```
Cambia "tu_api_key_de_GoogleBooks" y "tu_api_key_de_TMDB" por las claves de tus APIS
Cambia myUser por tu super usuario de SQL Server y cambia yourPassword por la contraseña de SQL Server y ya estarás listo para comenzar

## Build

Ejecuta `dotnet build -tl` para hacer build de la solucion.

## Run

Para iniciar la aplicación:

```bash
cd .\SkynetAPI\
dotnet run
```

Navega a https://localhost:9187/swagger/index.html.

## Github Actions Workflow

En la ruta /github/workflows, encontrarás el pipeline correspondiente a este proyecto. Este pipeline está configurado para que cuando se realice PR hacia master, se ejecuten los tests de la solución. En caso de fallo, denegará y cerrará la PR. En caso de que todo haya ido bien, creará una imagen de docker de la solución y la subirá a Docker Hub

Para que el pipeline funcione, debes configurar las variables SECRET en el repositorio. Ve a los Settings de tu repo y añade las tres variables necesarias:

- **DOCKER_USERNAME:** Usuario de Docker Hub
- **DOCKER_PSSWORD:** Password de Docker Hub
- **TOKEN_GITHUB:** Token de GitHub
- **DOCKER_REPO_NAME:** Nombre del repositorio en Docker Hub 

## Test

El proyecto solo incluye (de momento) los tests funcionales.

Para ejecutar los tests:
```bash
dotnet test
```

## Metas y objetivos

El objetivo de este proyecto es reforzar y mejorar los patrones de diseño y arquitectura de software siguiendo los principios SOLID basado en el diseño orientado al dominio (DDD).
Aplicación hosteada en Docker en servidor Ubuntu Server

Aquí te dejo algunos recursos que me han parecido muy interesantes y creo que pueden ser de gran ayuda(obtenido de [Ardalis](https://github.com/ardalis)):

- [SOLID Principles for C# Developers](https://www.pluralsight.com/courses/csharp-solid-principles)
- [SOLID Principles of Object Oriented Design](https://www.pluralsight.com/courses/principles-oo-design) (el original, curso lago)
- [Domain-Driven Design Fundamentals](https://www.pluralsight.com/courses/domain-driven-design-fundamentals)

Si estás acostumbrado a construir aplicaciones como proyecto único o como conjunto de proyectos que siguen la arquitectura tradicional UI -> Business Layer -> Data Access Layer "N-Tier", te recomiendo que eches un vistazo a estos dos cursos (idealmente antes de DDD Fundamentals):

- [Creating N-Tier Applications in C#, Part 1](https://www.pluralsight.com/courses/n-tier-apps-part1)
- [Creating N-Tier Applications in C#, Part 2](https://www.pluralsight.com/courses/n-tier-csharp-part2)

Steve Smith también mantiene la aplicación de referencia de Microsoft, eShopOnWeb, y su libro electrónico gratuito asociado. Consúltalo aquí:

- [eShopOnWeb on GitHub](https://github.com/dotnet-architecture/eShopOnWeb)
- [Architecting Modern Web Applications with ASP.NET Core and Microsoft Azure](https://aka.ms/webappebook) (eBook)

## Disclaimer

Por favor, entiende que este proyecto no es un proyecto cerrrado.
Actualmente el proyecto aún está en desarrollo, y debido a que me encuentro en constante mejora y actualización tanto de éste como de todos mis proyectos personales, desde la manera de estructurar la solución hasta la estructura y capas aplicadas; todo es susceptible de cambiar en un futuro.
Por favor, si tienes alguna mejora o fix, no dudes en realizar una propuesta de cambio

## Contacto

Si te parece interesante mi perfil, ponte en contacto conmigo

- [LinkedIn](https://linkedin.com/in/carlos-curtido).
- [Portfolio](https://carloscurtido.es).
- [Blog](https://blog.carloscurtido.es).
