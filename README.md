# Agenda Personal construida con ASP.NET Core MVC Code First

Utilizamos Entity Framework que es un ORM (object relational mapping) para
automatizar las operaciones CRUD (Create, Read, Update, Delete) que realiza la aplicación sobre una base de datos.

El patron MVC (Model View Controller = Modelo Vista Controlador), es un estilo de arquitectura de software que separa
los datos de una aplicación, la interfaz de usuario, y la lógica de control en tres componentes distintos.
Se trata de un modelo muy maduro y que ha demostrado su validez a lo largo de los años
en todo tipo de aplicaciones, y sobre multitud de lenguajes y plataformas de desarrollo.

• El Modelo que contiene una representación de los datos que maneja el sistema,
su lógica/reglas de negocio, y sus mecanismos de persistencia de datos hacia un
repositorio de datos.

• La Vista, o interfaz de usuario, que compone la información que se envía al cliente
y los mecanismos de interacción con éste.

• El Controlador, que actúa como intermediario entre el Modelo y la Vista,
gestionando el flujo de información entre ellos y las transformaciones para adaptar
los datos a las necesidades de cada uno.

## Detalles para probar el proyecto:

• En el archivo appsettings.json modificar la ruta de acceso a tu base de datos en la linea 
"AgendaDBConnection": "Server='Aca va el nombre de tu server';Database=AgendaDB;Trusted_Connection=True;"

• En la consola de administracion de paquetes ejecutar la linea "update-database"


