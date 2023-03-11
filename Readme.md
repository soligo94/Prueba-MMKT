Como usuario de tienda, necesitamos crear una aplicación en la cual tengamos la posibilidad
de añadir productos y poder listar y consultar sus características.

La prueba consta en crear una aplicación utilizando .NET 5 C# con Microsoft SQL Server Express
y ReactJS para la capa de cliente con Typescript. (En caso de no saber ReactJS/TS, realizar la
parte front en HTML5, CSS3 y JS).

La aplicación debe tener 2 vistas, la primera para listar productos y buscar alguno en cuestión y
una segunda vista donde encontraremos un formulario para añadir productos nuevos a la base
de datos.

Estos productos tendrán las siguientes propiedades:
  • Nombre
  • Descripción
  • Precio
  • Familia de producto (entiéndase como familia Smartphones, TV, Portátiles...)

En la vista del listado de productos tendremos un input de búsqueda, donde si encontramos el
término escrito dentro del nombre o la descripción nos mostrará los productos en forma de
lista y si clicamos sobre uno de ellos nos tiene que mostrar toda la información referente al
producto seleccionado ya sea en una modal o en una vista nueva.

Requisitos para la construcción de la aplicación:
  • La aplicación de cliente debe contener componentes de PrimeReact.
  • Utilizar en medida de lo posible los hooks de ReactJS añadidos en la versión 16.8.
  • Utilizar Redux para guardar estados generales de la aplicación, dentro de Redux
  tendremos guardado el estado del loading de la aplicación y la lista de productos que
  obtenemos al buscar.
  • En .NET 5 crearemos 2 métodos, un método GET para obtener los productos y un
método POST para añadir nuevos productos. Esta API estará construida con C#.
  • La base de datos tendrá una sola tabla que tendrá los campos:
    o Id
    o Nombre
    o Descripción
    o Precio
    o Familia de producto
  • El proyecto deberá de estar alojado en GitHub donde tendremos versionados los
  cambios realizados en la aplicación durante su construcción en una rama llamada
  “develop”. Esta rama “develop” contendrá los cambios “merges” de otras ramas que
  hayamos creado mientras se va desarrollando la aplicación.
  • Crear un Readme en Github de cómo funciona la aplicación creada y cómo podemos
  arrancar el proyecto.
  • Controlar el consumo de peticiones a la API.
  • El diseño de la aplicación se deja a elección del desarrollador.

  • Extra / Opcional: Crear un Swagger con la documentación de la API para poder
  consumirla.
  • Extra / Opcional: Crear algún testing funcional o unitario.
  
En la entrega del proyecto adjuntar una copia de la base de datos que se ha utilizado en la
aplicación.

Enlaces de interés:
ReactJS: https://reactjs.org/
PrimeReact: https://www.primefaces.org/primereact/
Redux: https://redux.js.org/
GitHub: https://github.com/
Swagger: https://swagger.io/tools/swagger-editor/
