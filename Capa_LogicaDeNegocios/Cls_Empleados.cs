using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_AccesoDatos; // anexamos las librerias de la clase.
using System.Data; // anexamos las librerias de la clase.

namespace Capa_LogicaDeNegocios
{
    public class Cls_Empleados
    {
        // Definimos los atributos de la clase.
        public int C_IdEmpleado { get; set; }
        public string C_StrNombre { get; set; }
        public double C_NumDocumento { get; set; }
        public string C_StrDireccion { get; set; }
        public string C_StrTelefono { get; set; }
        public string C_StrEmail { get; set; }
        public int C_IdRolEmpleado { get; set; }
        public string C_DtmIngreso { get; set; }
        public string C_DtmRetiro { get; set; }
        public string C_StrDatosAdicionales { get; set; }
        public string C_StrUsuarioModifico { get; set; }

        Cls_Acceso_Datos AccesoDatos = new Cls_Acceso_Datos();

        // Consultamos todos los datos de la tavla empleados.

        public DataTable ConsultaEmpleado()
        {
            string sentencia;
            try
            {
                sentencia = "SELECT * FROM TBLEMPLEADO";
                DataTable Dt = new DataTable(); 
                Dt = AccesoDatos.EjecutarConsulta(sentencia);
                return Dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataTable ConsultaEmpleado(int IdEmpleado)
        {
            string sentencia;
            try
            {
                sentencia = $"SELECT * FROM TBLEMPLEADO WHERE IdEmpleado = {IdEmpleado}";
                DataTable Dt = new DataTable();
                Dt = AccesoDatos.EjecutarConsulta(sentencia);
                return Dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable FiltrarEmpleado(string filtro)
        {
            string sentencia;
            try
            {
                sentencia = $"SELECT * FROM TBLEMPLEADO WHERE StrNombre LIKE '%{filtro}%' ";
                DataTable Dt = new DataTable();
                Dt = AccesoDatos.EjecutarConsulta(sentencia);
                return Dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable ConsultarRol()
        {
            string sentencia;
            try
            {
                sentencia = "SELECT * FROM TBLROLES";
                DataTable Dt = new DataTable();
                Dt = AccesoDatos.EjecutarConsulta(sentencia);
                return Dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        // ELIMINAMOS un registro de la BD
        public string EliminarEmpleado()
        {
            string mensaje = string.Empty;
            try
            {
                // creamos una estructura de tipo lista que tendra los parametros que necesitan los porcedimientos almacenados.
                List<Cls_Parametros> Lst = new List<Cls_Parametros>();

                // adicionamos el parametro que permite indicar el IdEmpleado que borraremos
                Lst.Add(new Cls_Parametros("@IdEmpleado", C_IdEmpleado));
                // ejecutamos el procedimiento y pasamos lst con los parametros anteriores.
                mensaje = AccesoDatos.EjecutarProcedimineto("eliminar_Empleado", Lst);

            }
            catch (Exception ex)
            {
                mensaje = "Falló Borrando en Empleado" + ex.Message;
            }
            return mensaje;
        }

        // Metodo que permite tanto INSERTAR como ACTUALIZAR los datos de un empleado.
        public string ActualizarEmpleado()
        {
            string mensaje = string.Empty;
            try
            {
                // Creamos el objeto lst que tendra los vombre de parametros y valores.
                List<Cls_Parametros> Lst = new List<Cls_Parametros>();
                Lst.Add(new Cls_Parametros("@IdEmpleado", C_IdEmpleado));
                Lst.Add(new Cls_Parametros("@StrNombre", C_StrNombre));
                Lst.Add(new Cls_Parametros("@NumDocumento", C_NumDocumento));
                Lst.Add(new Cls_Parametros("@StrDireccion", C_StrDireccion));
                Lst.Add(new Cls_Parametros("@StrTelefono", C_StrTelefono));
                Lst.Add(new Cls_Parametros("@StrEmail", C_StrEmail));
                Lst.Add(new Cls_Parametros("@IdRolEmpleado", C_IdRolEmpleado));
                Lst.Add(new Cls_Parametros("@DtmIngreso", C_DtmIngreso));
                Lst.Add(new Cls_Parametros("@DtmRetiro", C_DtmRetiro));
                Lst.Add(new Cls_Parametros("@StrDatosAdicionales", C_StrDatosAdicionales));
                Lst.Add(new Cls_Parametros("@DtmFechaModifica", DateTime.Now));
                Lst.Add(new Cls_Parametros("@StrUsuarioModifico", C_StrUsuarioModifico));

                // ejecutamos el procedimiento y pasamos lst con todos los parametros.
                mensaje = AccesoDatos.EjecutarProcedimineto("actualizar_Empleado", Lst);


            }
            catch (Exception ex)
            {
                mensaje = "Falló la Actualización Empleado " + ex.Message;
            }
            return mensaje;
        }
    }
}
