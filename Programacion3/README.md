
# Trabajo Práctico Integrador - Programación 3

## Descripción
API REST desarrollada en ASP.NET Core con C# y SQL Server para consultar productos.

## Tecnologías utilizadas
- Visual Studio 2022
- C# y ASP.NET Core Web API
- SQL Server
- ADO.NET
- Swagger
- Git y GitHub

## Funcionalidades
- Consultar todos los productos.
- Consultar un producto por su ID.
- Manejo de errores HTTP (404 y 500).
- Acceso a datos mediante Repository y Service.
- Inyección de dependencias.

## Base de datos
Base de datos: Programacion3

Tabla: Productos

Los scripts SQL se encuentran en la carpeta ScriptsSQL.

## Configuración
La aplicación utiliza una cadena de conexión llamada ConexionSQL.

Las credenciales de acceso a SQL Server deben configurarse localmente mediante User Secrets de .NET. No deben publicarse en GitHub.

## Ejecución
1. Abrir el proyecto en Visual Studio 2022.
2. Configurar la conexión a SQL Server.
3. Ejecutar la API.
4. Acceder a Swagger para probar los endpoints.

## Endpoints
- GET /api/productos
- GET /api/productos/{id}
