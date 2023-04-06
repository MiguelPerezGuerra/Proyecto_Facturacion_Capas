using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_AccesoDatos; // anexamos la libreria de la clase.

namespace Capa_LogicaDeNegocios
{
    public class Validar_Usuario
    {
        // definimos los atributos de la clase
        public string C_StrUsuario { get; set; }
        public string C_StrClave { get; set; }
        public int C_IdEmpleado { get; set; }

        Cls_Acceso_Datos Acceso = new Cls_Acceso_Datos(); // creamos un objeto con la clase acceso a datos.
        DataTable Dt = new DataTable();

        public void ValidarUsuario() // metodo que valida el usuario, consulta en la BD el usuario y la clave.
        {
            try
            {
                string sentencia = $"SELECT IdEmpleado FROM TBLSEGURIDAD WHERE StrUsuario = '{C_StrUsuario}' AND StrClave = '{C_StrClave}'";
                Dt = Acceso.EjecutarConsulta(sentencia);
                foreach (DataRow row in Dt.Rows) { C_IdEmpleado = int.Parse(row[0].ToString()); } // acutalizamos el nro del id del cliente que se encontro en la BD.
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la consulta " + ex);
            }
        }
    }
}
