using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_AccesoDatos;
using System.Runtime.CompilerServices;
using System.Security.Policy;

namespace Capa_LogicaDeNegocios
{
    public class Cls_Categoria_Prod
    {
        //Definimos los atributos de la clase
        public int C_IdCategoria { get; set; }
        public string C_StrDescripcion { get; set; }
        public DateTime C_DtmFechaModifica { get; set; }
        public string C_StrUsuarioModifico { get; set; }

        Cls_Acceso_Datos AccesoDatos = new Cls_Acceso_Datos();

        public DataTable ConsultarCategoria()
        {
            string sentencia = string.Empty;
            try
            {
                sentencia = "SELECT * FROM TBLCATEGORIA_PROD";
                DataTable Dt = new DataTable();
                Dt = AccesoDatos.EjecutarConsulta(sentencia);
                return Dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable ConsultarCategoria(int IdCategoria) 
        {
            string sentencia = string.Empty;
            try
            {
                sentencia = $"SELECT * FROM TBLCATEGORIA_PROD WHERE IdCategoria = {IdCategoria}";
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
            string sentencia = string.Empty;
            try
            {
                sentencia = $"SELECT * FROM TBLCATEGORIA_PROD WHERE StrDescripcion LIKE '%{filtro}%' ";
                DataTable Dt = new DataTable();
                Dt = AccesoDatos.EjecutarConsulta(sentencia);
                return Dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public string EliminarCategoria()
        {
            string mensaje = string.Empty;
            try
            {
                List<Cls_Parametros> Lst = new List<Cls_Parametros>();
                Lst.Add(new Cls_Parametros("@IdCategoria", C_IdCategoria));
                mensaje = AccesoDatos.EjecutarProcedimiento("Eliminar_CategoriaProducto", Lst);
            }
            catch (Exception ex)
            {
                mensaje = "Falló Borrando en Categoria " + ex.Message;
            }

            return mensaje;
        }

        public string ActualizarCategoria()
        {
            string mensaje = string.Empty;
            try
            {
                List<Cls_Parametros> Lst = new List<Cls_Parametros>();
                Lst.Add(new Cls_Parametros("@IdCategoria", C_IdCategoria));
                Lst.Add(new Cls_Parametros("@StrDescripcion", C_StrDescripcion));
                Lst.Add(new Cls_Parametros("@DtmFechaModifica", DateTime.Now.Date.ToString("yyyy-MM-dd HH:mm:ss")));
                Lst.Add(new Cls_Parametros("@StrUsuarioModifico", C_StrUsuarioModifico));
                mensaje = AccesoDatos.EjecutarProcedimiento("actualizar_CategoriaProducto", Lst);
            }
            catch (Exception ex)
            {
                mensaje = "Fallo la Actualización Categoria " + ex.Message;
            }

            return mensaje;
        }



    }
}
