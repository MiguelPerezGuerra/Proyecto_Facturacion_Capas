using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_AccesoDatos;
using System.Data;

namespace Capa_LogicaDeNegocios
{
    public class Cls_Facturas
    {
        public int C_IdFactura { get; set; }
        public DateTime C_DtmFecha { get; set; }
        public int C_IdCliente { get; set; }
        public int C_IdEmpleado { get; set; }
        public float C_NumDescuento { get; set; }
        public float C_NumImpuesto { get; set; }
        public float C_NumValorTotal { get; set; }
        public int C_IdEstado { get; set; }
        public DateTime C_DtmFechaModifica { get; set; }
        public string C_StrUsuarioModifica { get; set; }

        Cls_Acceso_Datos AccesoDatos = new Cls_Acceso_Datos();

        public DataTable ConsultarFactura()
        {
            string sentencia = string.Empty;
            try
            {
                sentencia = "SELECT * FROM TBLFACTURA";
                DataTable Dt = new DataTable();
                Dt = AccesoDatos.EjecutarConsulta(sentencia);
                return Dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable ConsultarFactura(int IdFactura)
        {
            string sentencia = string.Empty;
            try
            {
                sentencia = $"SELECT * FROM TBLFACTURA WHERE IdFactura = {IdFactura}";
                DataTable Dt = new DataTable();
                Dt = AccesoDatos.EjecutarConsulta(sentencia);
                return Dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable FiltroFactura(string Filtro)
        {
            string sentencia = string.Empty;
            try
            {
                sentencia = $"SELECT * FROM TBLFACTURA WHERE IdFactura LIKE '%{Filtro}%'";
                DataTable Dt = new DataTable();
                Dt = AccesoDatos.EjecutarConsulta(sentencia);
                return Dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public string ActualizarFactura()
        {
            string mensaje = string.Empty;
            try
            {
                /*
                 C_IdFactura { get; set; }
        public DateTime C_DtmFecha { get; set; }
        public int C_IdCliente { get; set; }
        public int C_IdEmpleado { get; set; }
        public float C_NumDescuento { get; set; }
        public float C_NumImpuesto { get; set; }
        public float C_NumValorTotal { get; set; }
        public int C_IdEstado { get; set; }
        public DateTime C_DtmFechaModifica { get; set; }
        public string C_StrUsuarioModifica { get; set; }
                 */
                List<Cls_Parametros> Lst = new List<Cls_Parametros>();
                Lst.Add(new Cls_Parametros("@", ));
                Lst.Add(new Cls_Parametros("@", ));
                Lst.Add(new Cls_Parametros("@", ));
                Lst.Add(new Cls_Parametros("@", ));
                Lst.Add(new Cls_Parametros("@", ));
                Lst.Add(new Cls_Parametros("@", ));
                Lst.Add(new Cls_Parametros("@", ));
                Lst.Add(new Cls_Parametros("@", ));
                Lst.Add(new Cls_Parametros("@", ));
                Lst.Add(new Cls_Parametros("@", ));
                Lst.Add(new Cls_Parametros("@", ));
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
