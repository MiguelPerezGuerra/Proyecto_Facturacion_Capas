using Capa_AccesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_LogicaDeNegocios
{
    public class Cls_Cliente
    {
        public int C_IdCliente { get; set; }
        public string C_StrNombre { get; set;}
        public int C_NumDocumento { get; set;}
        public string C_StrDireccion { get; set;}
        public string C_StrTelefono { get; set;}
        public string C_StrEmail { get; set;}
        public string C_StrUsuarioModifica { get; set;}

        Cls_Acceso_Datos AccesoDatos = new Cls_Acceso_Datos();

        public DataTable ConsultarCliente()
        {
            string sentencia = string.Empty;
            try
            {
                sentencia = "SELECT * FROM TBLCLIENTES";
                DataTable Dt = new DataTable();
                Dt = AccesoDatos.EjecutarConsulta(sentencia);
                return Dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable ConsultarCliente(int IdCliente)
        {
            string sentencia = string.Empty;
            try
            {
                sentencia = $"SELECT * FROM TBLCLIENTES WHERE IdCliente = {IdCliente}";
                DataTable Dt = new DataTable();
                Dt = AccesoDatos.EjecutarConsulta(sentencia);
                return Dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable FiltrarCliente (string filtro)
        {
            string sentencia = string.Empty;
            try
            {
                sentencia = $"SELECT * FROM TBLCLIENTES WHERE StrNombre LIKE '%{filtro}%'";
                DataTable Dt = new DataTable();
                Dt = AccesoDatos.EjecutarConsulta(sentencia);
                return Dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public string EliminarCliente()
        {
            string mensaje = string.Empty;
            try
            {
                List<Cls_Parametros> Lst = new List<Cls_Parametros>();
                Lst.Add(new Cls_Parametros("@IdCliente", C_IdCliente));
                mensaje = AccesoDatos.EjecutarProcedimiento("Eliminar_Cliente", Lst);
            }
            catch (Exception ex)
            {
                mensaje = "Falló Borrado en Cliente " + ex.Message;
            }
            return mensaje;
        }

        public string ActualizarCliente()
        {
            string mensaje = string.Empty;
            try
            {
                List<Cls_Parametros> Lst = new List<Cls_Parametros>();
                Lst.Add(new Cls_Parametros("@IdCliente", C_IdCliente));
                Lst.Add(new Cls_Parametros("@StrNombre", C_StrNombre));
                Lst.Add(new Cls_Parametros("@NumDocumento", C_NumDocumento));
                Lst.Add(new Cls_Parametros("@StrDireccion", C_StrDireccion));
                Lst.Add(new Cls_Parametros("@StrTelefono", C_StrTelefono));
                Lst.Add(new Cls_Parametros("@StrEmail", C_StrEmail));
                Lst.Add(new Cls_Parametros("@StrUsuarioModifica", C_StrUsuarioModifica));
                Lst.Add(new Cls_Parametros("@DtmFechaModifica", DateTime.Now.Date.ToString("yyyy-MM-dd HH:mm:ss")));
                mensaje = AccesoDatos.EjecutarProcedimiento("actualizar_Cliente", Lst);
            }
            catch (Exception ex)
            {
                mensaje = "Falló la Actualización Cliente " + ex.Message;
            }
            return mensaje;
        }
    }
}
