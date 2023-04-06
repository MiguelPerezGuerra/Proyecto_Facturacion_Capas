using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_AccesoDatos;
using System.Data;

namespace Capa_LogicaDeNegocios
{
    public class Cls_Seguridad
    {
        //Definimos los atributos de la clase.
        public int C_IdEmpleado { get; set; }
        public string C_StrUsuario { get; set; }
        public string C_StrClave { get; set; }
        public string C_StrUsuarioModifico { get; set; }

        Cls_Acceso_Datos AccesoDatos = new Cls_Acceso_Datos();

        //Consultamos los empleados para mostrar en combo.
        public DataTable ConsultarEmpleados()
        {
            string sentencia = string.Empty;
            try
            {
                sentencia = "SELECT IdEmpleado, StrNombre FROM TBLEMPLEADO";
                DataTable Dt = new DataTable();
                Dt = AccesoDatos.EjecutarConsulta(sentencia);
                return Dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable ConsultaSeguridadEmpleado(int IdEmpleado)
        {
            string sentencia = string.Empty;
            try
            {
                sentencia = $"SELECT StrUsuario, StrClave FROM TBLSEGURIDAD WHERE IdEmpleado = '{IdEmpleado}'";
                DataTable Dt = new DataTable() ;
                Dt = AccesoDatos.EjecutarConsulta(sentencia );
                return Dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        //Eliminamos un registro de la base de datos.
        public string EliminarSeguridadEmpleados()
        {
            string mensaje = string.Empty;
            try
            {
                //Creamos una estructura de tipo lista que tendra los parametros que necesitan los procedimientos.
                List<Cls_Parametros> Lst = new List<Cls_Parametros>();

                //adicinamos el parametro que permite indicar el idempleado que borraremos. Contiene el nombre y el valor del parametro.
                Lst.Add(new Cls_Parametros("@IdEmpleado", C_IdEmpleado));
                // ejecutamos al procedimiento y pasamos lst con los parametros y valores.
                mensaje = AccesoDatos.EjecutarProcedimiento("Eliminar_Seguridad", Lst);
            }
            catch (Exception ex)
            {
                mensaje = "FALLÓ BORRADO EN EMPLEADO " + ex.Message;
            }

            return mensaje;
        }
        
        public string ActualizarSeguridadEmpleado()
        {
            string mensaje = string.Empty;
            try
            {
                // creamos el objeto lista lst que tendra los nombres de parametros y valores.
                List<Cls_Parametros> Lst = new List<Cls_Parametros>();
                // adicionamos los parametros con nombre y valores al objeto creado lst.
                Lst.Add(new Cls_Parametros("@IdEmpleado", C_IdEmpleado));
                Lst.Add(new Cls_Parametros("@StrUsuario", C_StrUsuario));
                Lst.Add(new Cls_Parametros("@StrClave", C_StrClave));
                Lst.Add(new Cls_Parametros("@DtmFechaModifica", DateTime.Now));
                Lst.Add(new Cls_Parametros("@StrUsuarioModifico", C_StrUsuarioModifico));

                // ejecutamos el procedimiento y pasamos lst con todos los parametros.
                mensaje = AccesoDatos.EjecutarProcedimiento("actualizar_Seguridad", Lst);
            }
            catch (Exception ex)
            {
                mensaje = "FALLÓ LA ACTUALIZACION EMPLEADO " + ex.Message;
            }

            return mensaje;
        }
    }
}
