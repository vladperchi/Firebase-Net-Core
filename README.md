## Firebase

### Configuración del servicio

* [Iniciar sesión](https://console.firebase.google.com/u/1/) y navega a la consola
* Crea un nuevo proyecto
* Abrir la sección de autenticación
    * Cambiar a la pestaña "Método de inicio de sesión"
        * Habilitar "Correo electrónico / Contraseña"
    * Cambiar a la pestaña "Usuarios"
        * Agregar nuevo usuario


### Configuración de la API WEB .NET Core

* En `Startup.ConfigureServices(..)` establece `firebaseProjectId` dado el id de tu proyecto.


### Implementación

El proyecto define un controlador llamado `DataController` con dos extremos:

   * `/api/data/public`: accesible sin ninguna autenticación
   * `/api/data/protected`: solo accesible si se proporciona un token OAuth correcto

Ponemos a correr la Api, accedemos mediante `Swagger` al punto final público con la solicitud `GET` sin ningún token:

```
GET https://localhost:44323/api/Data/public
```
Y obtenemos

```
200 OK
```

Sin embargo, si intentamos llegar al segundo punto final sin un token:

```
GET https://localhost:44323/api/Data/protected
```
Obtenemos

```
401 Unauthorized
```

Para acceder al punto final protegido, necesitamos proporcionar el token OAuth en el encabezado `Autorización`:

```
GET https://localhost:44323/api/Data/protected
Authorization: Bearer [OAUTH_TOKEN]
```
