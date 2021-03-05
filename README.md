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
