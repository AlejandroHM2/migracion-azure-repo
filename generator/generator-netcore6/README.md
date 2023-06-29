# Generator Net 6

Proyecto generado para la configuración automática de microservicios con net 6

## Requisitos

* [Instalar NodeJs LTS](https://nodejs.org/es/)
* Instalar Yeoman
    `npm install -g yo`
* Descargar dependencias 
    `npm install`
* Ejecutar dentro de generator-netcore6/
    `npm link`

## Instalar proyecto

- Ejecutar el comando: `yo netcore6`  

- Aparece un prompt donde debemos colocar el nombre de nuestro proyecto en formato PascalCase sin espacios

- Esto genera un proyecto llamado: [nombre ingresado]-service

## Docker

Docker automatiza el despliegue de aplicaciones dentro de contenedores.

El archivo Dockerfile contiene las instrucciones para crear la imagen.

Pasos para desplegar la aplicación:
1. **Generar imagen**
```sh
docker build -t nameImage .
```
2. **Consultar imagenes**
```sh
docker images
```
3. **Ejecutar imagen**
```sh
docker run -p 9090:9090 -e ASPNETCORE_ENVIRONMENT="Development" -d nameImage
```
4. **Mostrar contenedores en ejecución**
```sh
docker ps
```
5. **Obtener los registros de un contenedor**
```sh
docker container logs [containerid]
```
6. **Aplicación desplegada**
- Validar que la aplicación se este ejecutando por el puerto 9090 http://localhost:9090/

## Configuración

1. **Configurar variables de entorno**  
En el archivo **launchSettings.json** configure las variables de entorno para su proyecto.
```json
{
    "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development", // Indicar el entorno en tiempo de ejecución
        "SEQ_URL": "http://localhost:5341", // Host para logging
        "DB_CONNECTION_STRING": "Server=127.0.0.1;Port=5432;Database=test;service ID=postgres;password=ppl123", // Host para la base de dato
        "REDIS_URL": "127.0.0.1:6379"// Host para la base de redis
      }
}
```
## ¿Cómo usarlo?

1. **Redis:** Con redis almacenamos estructuras de datos de valores de clave en memoria.
- Obtiene el valor de la clave, si la clave no existe devuelve nulo.
```csharp
var redisKey = $"List-ProjectResponseDto";
var result = await this.database.StringGetAsync(redisKey);
```
- Almacena el valor de la cadena estableciendo un tiempo de vencimiento. Si la clave ya tiene un valor, se sobrescribe.
```csharp
var redisKey = $"List-ProjectResponseDto";
var response = await this.projectFacade.GetAllAsync();
await this.database.StringSetAsync(redisKey, JsonConvert.SerializeObject(response), TimeSpan.FromHours(1));
```
2. **Operaciones a la base de datos**
  - Consulta de datos por llave primaria
```csharp
/// <inheritdoc/>
public async Task<ExampleModel> GetExampleAsync(int id)
{
    return await this.databaseContext.CatExample.FirstOrDefaultAsync(p => p.Id.Equals(id));
}
```
  - Consulta de una lista de datos
```csharp
/// <inheritdoc/>
public async Task<IEnumerable<ExampleModel>> GetAllExampleAsync()
{
    return await this.databaseContext.CatExample.ToListAsync();
}
```
  - Inserción a base de datos
```csharp
/// <inheritdoc/>
public async Task<bool> InsertExample(ExampleModel model)
{
    var response = await this.databaseContext.CatExample.AddAsync(model);
    bool result = response.State.Equals(EntityState.Added);
    await ((DatabaseContext)this.databaseContext).SaveChangesAsync();
    return result;
}
```
## Capas del proyecto
1. **Api:** Se manejan únicamente controladores y configuración.
2. **Backgrounds:** Generación de servicios que se ejecutan en segundo plano.
3. **DTOs:** En esta capa se encuentran DTO (Data Transfer Object).
4. **Entities:** Interfaces, Excepciones, Enums y Pocos.
5. **IoC:** Inyección de dependencias del proyecto.
6. **Presenters:** Handlers para manejo de patron mediador.
7. **Repositories:** Conexión con BD.
8. **Test:** Capa para pruebas unitarias (TDD).
9. **UseCases:** Capa para generación de lógica de negocio.
8. **WebExceptionsPresenter:** Filtros y Excepciones del servicio.

## Colaboradores

**Hugo Meraz**  
*[hugo.meraz@sovos.com]*  

## Licencia

[MIT](https://opensource.org/licenses/MIT)