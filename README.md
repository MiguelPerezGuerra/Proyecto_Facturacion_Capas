# Proyecto_Facturacion_Capas
_Aplicacion CRUD basica de un sistema de facturación, donde se implemetan programación por capas, utilizando las tecnologias C#, ADO.NET, windows forms, Material Skin._

## Pre-requisitos 

_Para el funcionacionamiento del aplicativo se requiere instalacion de [MS SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) o base de datos a convenir, Adjunto archivo Script de la [BBFACTURAS](https://drive.google.com/file/d/14fE9tqQflnmB01Hbxw0fHH6UVYZkuHyp/view?usp=sharing), para Conectar el aplicativo a la base de datos dentro de la solucion dirigase a la Capa_AccesoDatos dentro del elemento Cls_Acceso_Datos.cs._

![image](https://github.com/MiguelPerezGuerra/Proyecto_Facturacion_Capas/assets/117006163/56df23f9-ddeb-4874-b251-8c3f4cdc72c6)


_En el metodo AbrirDB modifique la seccion de codigo con el nombre del servidor:_

```C#
Conexion = new SqlConnection("Data Source=|Nombre-Server|;Initial Catalog=[DBFACTURAS];Integrated Security=True");
```
![image](https://github.com/MiguelPerezGuerra/Proyecto_Facturacion_Capas/assets/117006163/c880e439-029f-4cac-abc0-b22a60bcd2e9)



## Desarrollo del Aplicativo

### Capa Presentación

_Se desarrolla la interfaz grafica con windows forms, en la que se elabora un menu principal y de mas sudmenus para desplegar listas con los datos recuperados de la base
de datos._

#### Menu Principal
![menupricipal](https://github.com/MiguelPerezGuerra/Proyecto_Facturacion_Capas/assets/117006163/673be0c2-4c0d-4905-b5d5-286b01f2b50e)

#### Login
_la Aplicacicon cuenta con un login de validacion de seguridad, el cual esta desactivado para praciticidad en caso de querer visualizar dirigirse a Capa_Presentacion, abrir elemento Program.cs en Application.Run(new frmPrincipal()), Cambiar a:_

  ```c#
Application.Run(new frmLogin());
  ```

![image](https://github.com/MiguelPerezGuerra/Proyecto_Facturacion_Capas/assets/117006163/43935c01-2179-41a0-8068-de8b277cf902)


#### Submenus 
_cada submenu cuenta con los botones para las opciones de CRUD_

![image](https://github.com/MiguelPerezGuerra/Proyecto_Facturacion_Capas/assets/117006163/02ceb5c6-2d5f-4d49-805b-dc3ffb6f5901)


---
### Capa Acceso a Datos

_Esta capa es la encargada de acceder a los datos, dentro contiene dos clases._

_la cls_Parametros: tiene la funcionalidad del manejo de paso de parámetro cuando se requiere ejecutar un procedimiento almacenado en la base de datos, específicamente la utilizaremos cuando invoquemos la clase Cls_Acceso_datos y en esta llamemos el método Ejecutar_procedimiento._

_la Cls_Acceso_Datos: contiene la funcionalidad para realizar operaciones sobre la base de datos, conexión, desconexión, ejecutar consultas, ejecutar procedimientos almacenados. Esta clase tiene como primer Método AbrirBD() que permite iniciar la conexión con la base de datos._


![image](https://github.com/MiguelPerezGuerra/Proyecto_Facturacion_Capas/assets/117006163/a01e0770-85e4-49bc-bff9-c22bca2dfa65)


---
### Capa Lógica de Negocio

_Esta capa es donde reside la programación principal del sistema, Aquí se recibe o se envía información a la capa de presentación y se accede a la Capa de datos para actualizar o recuperar información. En la Capa_lógicaDeNegocios se creo una clase por cada una de las tablas del proyecto, con estas se realizan las diferentes operaciones requeridas para la gestión del CRUD._


![image](https://github.com/MiguelPerezGuerra/Proyecto_Facturacion_Capas/assets/117006163/843f49f8-e2b4-423f-9feb-5e61b85d45ea)

