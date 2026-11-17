
# Cuestionario Conceptual - Programación 3

## Controllers

### 1. ¿Qué es una Web API?
Es una aplicación que permite que otros programas se comuniquen con ella mediante solicitudes HTTP. En nuestro proyecto, permite consultar productos almacenados en SQL Server.

### 2. ¿Qué función cumple un Controller?
Recibe las solicitudes HTTP y devuelve las respuestas correspondientes. En nuestro proyecto, ProductosController recibe las consultas y utiliza el Service para obtener los productos.

### 3. ¿Qué función cumple [ApiController]?
Indica que una clase funciona como un controlador de API y habilita comportamientos automáticos de ASP.NET Core, como la validación de datos recibidos.

### 4. ¿Qué función cumple [Route]?
Define la dirección o ruta mediante la cual podemos acceder a un Controller. Por ejemplo, api/productos.

### 5. ¿Qué función cumple [HttpGet]?
Indica que un método del Controller responde a solicitudes HTTP GET, utilizadas para consultar información.


## Models

### 6. ¿Qué representa la clase Producto?
La clase Producto representa un producto de nuestra aplicación. Contiene sus datos principales: Id, Nombre, Precio y Stock.

### 7. ¿Por qué utilizamos una clase para representar los datos de un producto?
Porque nos permite organizar la información de cada producto en un objeto de C#. Así podemos trabajar con los datos que obtenemos de SQL Server de manera más sencilla y ordenada.


## Services

### 8. ¿Qué responsabilidad tiene un Service?
Un Service se encarga de realizar las operaciones y aplicar la lógica de la aplicación. En nuestro proyecto, ProductoService recibe las solicitudes del Controller y utiliza el Repository para obtener los productos.

### 9. ¿Por qué no colocamos toda la lógica dentro del Controller?
Porque el Controller debe encargarse principalmente de recibir solicitudes y devolver respuestas. Separar la lógica en un Service permite tener un código más ordenado, fácil de mantener y modificar.


## Interfaces

### 10. ¿Qué es una interfaz?
Una interfaz es un contrato que establece qué métodos debe tener una clase, sin indicar cómo deben funcionar internamente.

### 11. ¿Qué diferencia existe entre una interfaz y una clase?
Una interfaz define qué operaciones deben existir, mientras que una clase puede implementar esas operaciones y establecer cómo se realizan.

### 12. ¿Por qué utilizamos IProductoService?
Porque permite que ProductosController trabaje con un contrato en lugar de depender directamente de ProductoService. Esto facilita modificar o reemplazar la implementación sin tener que cambiar el Controller.


## Inyección de Dependencias

### 13. ¿Qué es una dependencia?
Es una clase u objeto que otro componente necesita para funcionar. Por ejemplo, ProductosController necesita un Service para consultar productos.

### 14. ¿Qué es la Inyección de Dependencias?
Es un mecanismo que permite proporcionar automáticamente a una clase los objetos que necesita, sin que tenga que crearlos por su cuenta.

### 15. ¿Qué problema resuelve?
Evita que las clases tengan que crear directamente sus dependencias. Esto permite que el código sea más flexible, organizado y fácil de modificar.

### 16. ¿Qué significa AddScoped?
Es un método que registra una dependencia para que se cree una instancia por cada solicitud HTTP y se reutilice durante esa misma solicitud.

### 17. ¿Qué diferencia existe entre Transient, Scoped y Singleton?
- Transient: crea una nueva instancia cada vez que se solicita.
- Scoped: utiliza una misma instancia durante una solicitud HTTP.
- Singleton: utiliza una única instancia compartida durante toda la ejecución de la aplicación.

En nuestro proyecto utilizamos Scoped para registrar el Service y el Repository.



## Repository

### 18. ¿Qué responsabilidad tiene un Repository?
El Repository se encarga de acceder a la base de datos y obtener la información necesaria. En nuestro proyecto, ProductoRepository utiliza ADO.NET para consultar los productos en SQL Server.

### 19. ¿Por qué el Repository es independiente del Controller?
Porque cada uno tiene una responsabilidad diferente. El Controller recibe las solicitudes HTTP, mientras que el Repository se encarga de consultar la base de datos. Ambos se comunican a través del Service.

### 20. ¿Por qué el Service no debería contener directamente el código SQL?
Porque el Service debe encargarse de la lógica de la aplicación y no de los detalles de acceso a datos. Mantener el código SQL dentro del Repository permite organizar mejor el proyecto y facilita realizar modificaciones.


## ADO.NET

### 21. ¿Qué es ADO.NET?
ADO.NET es una tecnología de .NET que permite conectar una aplicación con una base de datos, ejecutar consultas y obtener información.

### 22. ¿Qué función cumple SqlConnection?
Permite establecer una conexión entre nuestra aplicación de C# y la base de datos SQL Server.

### 23. ¿Qué función cumple SqlCommand?
Permite preparar y ejecutar instrucciones SQL, como SELECT, utilizando una conexión a la base de datos.

### 24. ¿Qué función cumple SqlDataReader?
Permite leer los registros obtenidos de una consulta SQL, uno por uno, para convertirlos en objetos de nuestra aplicación.

### 25. ¿Qué función cumple una Connection String?
Contiene la información necesaria para conectarse a una base de datos, como el servidor, el nombre de la base de datos y los datos de autenticación.

En nuestro proyecto utilizamos la configuración ConexionSQL para establecer la conexión.


## SQL

### 26. ¿Por qué utilizamos parámetros SQL?
Porque permiten enviar valores a una consulta de forma segura, sin tener que unirlos directamente al código SQL. También ayudan a prevenir ataques de SQL Injection.

### 27. ¿Qué es SQL Injection?
Es un tipo de ataque en el que una persona intenta introducir instrucciones SQL maliciosas a través de los datos que recibe una aplicación, con el objetivo de consultar, modificar o eliminar información sin autorización.

### 28. ¿Qué problema podría existir al concatenar directamente valores dentro de una consulta SQL?
Si concatenamos directamente los valores ingresados por un usuario, alguien podría introducir código SQL malicioso y alterar el funcionamiento de la consulta.

Por eso, en nuestro proyecto utilizamos el parámetro @Id para buscar un producto de manera segura.



## Excepciones

### 29. ¿Qué es una excepción?
Es un problema que ocurre durante la ejecución de un programa y que puede interrumpir su funcionamiento normal. Por ejemplo, cuando no podemos conectarnos a SQL Server.

### 30. ¿Qué función cumple try?
Permite colocar el código que queremos ejecutar y que podría generar una excepción.

### 31. ¿Qué función cumple catch?
Permite capturar una excepción y manejarla para evitar que el programa falle sin control.

### 32. ¿Qué función cumple finally?
Permite ejecutar un bloque de código al finalizar el try y catch, independientemente de si ocurrió una excepción o no. Se utiliza, por ejemplo, para realizar tareas de limpieza.

### 33. ¿Por qué no debemos mostrar al usuario los detalles internos de una excepción de base de datos?
Porque podrían contener información sensible, como datos del servidor, consultas SQL o credenciales. Es más seguro mostrar un mensaje general y controlar el error internamente.

### 34. ¿Qué diferencia existe entre un producto inexistente y una falla de conexión con SQL Server?
Un producto inexistente significa que la consulta se realizó correctamente, pero no se encontró el registro. En ese caso, nuestra API devuelve 404 Not Found.

Una falla de conexión significa que ocurrió un problema al intentar acceder a la base de datos. En ese caso, nuestra API devuelve 500 Internal Server Error.



## Arquitectura

### 35. Explicar el recorrido completo de GET /api/productos/5
Cuando un usuario realiza la solicitud GET /api/productos/5, ProductosController recibe la petición y llama a IProductoService.

ProductoService utiliza IProductoRepository para solicitar el producto.

ProductoRepository ejecuta una consulta SQL mediante ADO.NET, utilizando el parámetro @Id con el valor 5.

SQL Server busca el producto y devuelve el resultado.

Finalmente, la información regresa desde el Repository al Service y luego al Controller, que responde al usuario con los datos en formato JSON y el código HTTP 200 OK.

Si el producto no existe, devuelve 404 Not Found.

### 36. ¿Qué responsabilidad tiene cada componente?
- Controller: recibe las solicitudes HTTP y devuelve las respuestas.
- Service: realiza las operaciones y aplica la lógica de la aplicación.
- Repository: se encarga del acceso a los datos.
- ADO.NET: permite conectarse y ejecutar consultas desde C#.
- SQL Server: almacena y administra los productos.

### 37. ¿Qué ventajas tiene separar estas responsabilidades?
Permite mantener el código organizado, facilitar las modificaciones, realizar pruebas y detectar errores más fácilmente.

Además, podemos modificar una parte de la aplicación sin tener que cambiar necesariamente las demás.

### 38. ¿Qué problemas podrían aparecer si colocáramos todo el código en ProductosController?
El Controller tendría demasiadas responsabilidades y sería más difícil de comprender, mantener y modificar.

También sería más complicado reutilizar código, realizar pruebas y detectar errores.




## Reflexión final

### 1. ¿Qué ventajas encontraron al separar la aplicación en Controller, Service y Repository en lugar de colocar todo el código en una única clase?

La principal ventaja es que cada componente tiene una responsabilidad específica.

El Controller recibe las solicitudes, el Service organiza las operaciones y el Repository consulta la base de datos.

Esto permite que nuestro código sea más ordenado, fácil de comprender, mantener y modificar.

### 2. ¿Qué relación existe entre la separación de responsabilidades y la Inyección de Dependencias?

La separación de responsabilidades permite que cada componente tenga una función específica.

La Inyección de Dependencias facilita la comunicación entre estos componentes sin que tengan que crear directamente los objetos que necesitan.

En nuestro proyecto, ASP.NET Core proporciona automáticamente el Service al Controller y el Repository al Service.

### 3. ¿Qué parte de la aplicación cambiarían si mañana se reemplazara ADO.NET por otra tecnología de acceso a datos?

Principalmente modificaríamos ProductoRepository, porque es el componente que utiliza ADO.NET para consultar SQL Server.

Si mantenemos los mismos métodos definidos en IProductoRepository, no sería necesario modificar el Controller ni el Service.

Esto demuestra una de las ventajas de separar las responsabilidades de nuestra aplicación.
