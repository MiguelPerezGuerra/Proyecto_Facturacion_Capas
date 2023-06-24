# Proyecto_Facturacion_Capas
_Aplicacion CRUD basica de un sistema de facturación, donde se implemetan programación por capas, utilizando las tecnologias C#, ADO.NET, windows forms, Material Skin._

## Pre-requisitos 

_Para el funcionacionamiento del aplicativo se requiere instalacion de [MS SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) o base de datos a convenir, Adjunto archivo Script de la [BBFACTURAS](https://drive.google.com/file/d/14fE9tqQflnmB01Hbxw0fHH6UVYZkuHyp/view?usp=sharing), para Conectar el aplicativo a la base de datos dentro de la solucion dirigase a la Capa_AccesoDatos dentro del elemento Cls_Acceso_Datos.cs._

![image](https://github.com/MiguelPerezGuerra/Proyecto_Facturacion_Capas/assets/117006163/23146a22-a925-4c7f-9d2d-4ae8a379ad26)

_En el metodo AbrirDB modifique la seccion de codigo con el nombre del servidor:_

```C#
Conexion = new SqlConnection("Data Source=|Nombre-Server|;Initial Catalog=[DBFACTURAS];Integrated Security=True");
```
![image](https://github.com/MiguelPerezGuerra/Proyecto_Facturacion_Capas/assets/117006163/85d35ee7-bc8d-4da2-bf0a-027200085342)


## Desarrollo del Aplicativo

### Capa Presentación

_Se desarrolla la interfaz grafica con windows forms, en la que se elabora un menu principal y de mas sudmenus para desplegar listas con los datos recuperados de la base
de datos._

#### Menu Principal
![image](https://github.com/MiguelPerezGuerra/Proyecto_Facturacion_Capas/assets/117006163/e0bee34e-21c0-4cbf-8fb7-8620d521de8f)
#### Login
_la Aplicacicon cuenta con un login de validacion de seguridad, el cual esta desactivado para praciticidad en caso de querer visualizar dirigirse a Capa_Presentacion, abrir elemento Program.cs en Application.Run(new frmPrincipal()), Cambiar a:_

  ```c#
Application.Run(new frmLogin());
  ```
![image](https://github.com/MiguelPerezGuerra/Proyecto_Facturacion_Capas/assets/117006163/e55d9632-0fde-46d7-9bf3-b6d93e176acd)

#### Submenus 
_cada submenu cuenta con los botones para las opciones de CRUD_
![image](https://github.com/MiguelPerezGuerra/Proyecto_Facturacion_Capas/assets/117006163/97ec447b-b8d3-4c59-9be7-0952a49bdc2b)

---
### Capa Acceso a Datos

_Esta capa es la encargada de acceder a los datos, dentro contiene dos clases._

_la cls_Parametros: tiene la funcionalidad del manejo de paso de parámetro cuando se requiere ejecutar un procedimiento almacenado en la base de datos, específicamente la utilizaremos cuando invoquemos la clase Cls_Acceso_datos y en esta llamemos el método Ejecutar_procedimiento._

_la Cls_Acceso_Datos: contiene la funcionalidad para realizar operaciones sobre la base de datos, conexión, desconexión, ejecutar consultas, ejecutar procedimientos almacenados. Esta clase tiene como primer Método AbrirBD() que permite iniciar la conexión con la base de datos._

![image](https://github.com/MiguelPerezGuerra/Proyecto_Facturacion_Capas/assets/117006163/ba024c13-5599-450d-a6f9-f2c18f36b34a)


---
### Capa Lógica de Negocio

_Esta capa es donde reside la programación principal del sistema, Aquí se recibe o se envía información a la capa de presentación y se accede a la Capa de datos para actualizar o recuperar información. En la Capa_lógicaDeNegocios se creo una clase por cada una de las tablas del proyecto, con estas se realizan las diferentes operaciones requeridas para la gestión del CRUD._

![image](https://github.com/MiguelPerezGuerra/Proyecto_Facturacion_Capas/assets/117006163/683a72f6-7e50-47e2-aeb3-a90ed3e2085d)
