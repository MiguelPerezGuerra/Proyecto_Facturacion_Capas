using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_AccesoDatos;
using System.Security.Policy;
using System.Runtime.CompilerServices;

namespace Capa_LogicaDeNegocios
{
    public class Cls_Roles
    {
        //Definimos los atributos de la clase
        public int C_IdRolEmpleado { get; set; }
        public string C_StrDescripcion { get; set; }

        Cls_Acceso_Datos AccesoDatos = new Cls_Acceso_Datos();

        public DataTable ConsultaRol()
        {
            string sententcia = string.Empty;
            try
            {
                sententcia = "SELECT * FROM TBLROLES";
                DataTable Dt = new DataTable();
                Dt = AccesoDatos.EjecutarConsulta(sententcia);
                return Dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        
        public DataTable ConsultaRol(int id)
        {
            string sentencia = string.Empty;
            try
            {
                sentencia = $"SELECT * FROM TBLROLES WHERE IdRolEmpleado = {id}";
                DataTable Dt = new DataTable();
                Dt = AccesoDatos.EjecutarConsulta(sentencia);
                return Dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable FiltrarRol(string Filtro)
        {
            string sentencia = string.Empty;
            try
            {
                sentencia = $"SELECT * FROM TBLROLES WHERE StrDescripcion LIKE  '%{Filtro}%'";
                DataTable Dt = new DataTable();
                Dt = AccesoDatos.EjecutarConsulta(sentencia);
                return Dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public string EliminarRol()
        {
            string mensaje = string.Empty;
            try
            {
                List<Cls_Parametros> Lst = new List<Cls_Parametros>();
                Lst.Add(new Cls_Parametros("@IdRolEmpleado", C_IdRolEmpleado));
                mensaje = AccesoDatos.EjecutarProcedimiento("eliminar_Rol", Lst);
            }
            catch (Exception ex)
            {
                mensaje = "Falló Borrando el Rol " + ex.Message;
            }
            return mensaje;
        }

        public string ActualizarRol()
        {
            string mensaje = string.Empty;
            try
            {
                List<Cls_Parametros> Lst = new List<Cls_Parametros>();
                Lst.Add(new Cls_Parametros("@IdRolEmpleado", C_IdRolEmpleado));
                Lst.Add(new Cls_Parametros("@StrDescripcion", C_StrDescripcion));
                mensaje = AccesoDatos.EjecutarProcedimiento("actualizar_Rol", Lst);
            }
            catch (Exception ex)
            {
                mensaje = "Fallo Actualizando el Rol " + ex.Message;
            }
            return mensaje;
        }
    }
}
