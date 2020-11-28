# ProyectoProgra

## Crear un proyecto mvc con login

- dotnet new mvc -au Individiual

## migrations
- Remover la carpeta Migrations
- Cambiar la cadena de conexion
- dotnet ef migrations add Initial --context EsportshubApi.Models.ApplicationDbContext -o YourFolderPath

- example:

dotnet ef migrations add CreateIdentitySchema --context ProyectoProgra.Data.ApplicationDbContext -o "D:\Descargas\Trabajos Universidad\ProyectoProgra\Data\Migrations"

- dotnet ef database update
