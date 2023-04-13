using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_AccesoDatos;

namespace Capa_LogicaDeNegocios
{
    public class Cls__EstadoFactura
    {
        public int C_IdEstadoFactura { get; set; }
        public string C_StrDescripcion { get; set; }

        Cls_Acceso_Datos AccesoDatos = new Cls_Acceso_Datos();

        public DataTable ConsultarEstado()
        {
            string sentencia = string.Empty;
            try
            {
                sentencia = "SELECT * FROM TBLESTADO_FACTURA";
                DataTable Dt = new DataTable();
                Dt = AccesoDatos.EjecutarConsulta(sentencia);
                return Dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
