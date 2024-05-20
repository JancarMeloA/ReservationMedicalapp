### Implementacion de JWT Para las Autenticaciones:
ya se puede generar un token con los datos del cliente de la plataforma y
tengo los endpoints para el registrarme y logearme.

### Proximo a implementar:
* Implementacion de un metodo para validar el token en  "TokenJWT".
* La Autorizacion: limitar la accesibilidad dependiendo el rol, si es cliente o Profesional.
* Crear los endpoints para iniciar sesion como profesional.
*

### Para El Realizar Migraciones Usar Los Siguentes Comandos CLI:

**Nuget Package Manager Console**:

para crear una migracion:
* Add-Migration NombreDeLaMigracion


Para Aplicar La Migracion:
* Update-Database

**En el Command Prompt Terminal**:

para crear una migracion:
* dotnet ef add migration NombreDeLaMigracion

Para Aplicar La Migracion:
* dotnet ef database update NombreDeLaMigracion
