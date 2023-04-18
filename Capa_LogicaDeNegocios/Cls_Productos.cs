using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_AccesoDatos;
using System.Data;

namespace Capa_LogicaDeNegocios
{
    public class Cls_Productos
    {
        public int C_IdProducto { get; set; }
        public string C_StrNombre { get; set; }
        public string C_StrCodigo { get; set; }
        public float C_NumPrecioCompra { get; set; }
        public float C_NumPrecioVenta { get; set; }
        public int C_IdCategoria { get; set; }
        public string C_StrDetalle { get; set; }
        public string C_StrFoto { get; set; }
        public int C_NumStock { get; set; }
        public string C_StrUsuarioModifica { get; set; }

        Cls_Acceso_Datos AccesoDatos = new Cls_Acceso_Datos();

        public DataTable ConsultarProducto()
        {
            string sentencia = string.Empty;
            try
            {
                sentencia = "SELECT * FROM TBLPRODUCTO";
                DataTable Dt = new DataTable();
                Dt = AccesoDatos.EjecutarConsulta(sentencia);
                return Dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable ConsultarProducto(int IdProducto)
        {
            string sentencia = string.Empty;
            try
            {
                sentencia = $"SELECT * FROM TBLPRODUCTO WHERE IdProducto = {IdProducto}";
                DataTable Dt = new DataTable();
                Dt = AccesoDatos.EjecutarConsulta(sentencia);
                return Dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable ConsultarCategoria()
        {
            try
            {
                Cls_Categoria_Prod Categoria = new Cls_Categoria_Prod();
                DataTable Dt = new DataTable();
                Dt = Categoria.ConsultarCategoria();
                return Dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable FiltrarProducto(string Filtro)
        {
            string sentencia = string.Empty;
            try
            {
                sentencia = $"SELECT * FROM TBLPRODUCTO WHERE StrNombre LIKE '%{Filtro}%' ";
                DataTable Dt = new DataTable();
                Dt = AccesoDatos.EjecutarConsulta(sentencia);
                return Dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public string EliminarProducto()
        {
            string mensaje = string.Empty;
            try
            {
                List<Cls_Parametros> Lst = new List<Cls_Parametros>();
                Lst.Add(new Cls_Parametros("@IdProducto", C_IdProducto));
                mensaje = AccesoDatos.EjecutarProcedimiento("Eliminar_Producto", Lst);

            }
            catch (Exception ex)
            {
                mensaje = "Falló Borrado en Producto " + ex.Message;
            }
            return mensaje;
        }

        public string ActualizarProducto()
        {
            string mensaje = string.Empty;
            try
            {
                List<Cls_Parametros> Lst = new List<Cls_Parametros>();

                Lst.Add(new Cls_Parametros("@IdProducto", C_IdProducto));
                Lst.Add(new Cls_Parametros("@StrNombre", C_StrNombre));
                Lst.Add(new Cls_Parametros("@StrCodigo", C_StrCodigo));
                Lst.Add(new Cls_Parametros("@NumPrecioCompra", C_NumPrecioCompra));
                Lst.Add(new Cls_Parametros("@NumPrecioVenta", C_NumPrecioVenta));
                Lst.Add(new Cls_Parametros("@IdCategoria", C_IdCategoria));
                Lst.Add(new Cls_Parametros("@StrDetalle", C_StrDetalle));
                Lst.Add(new Cls_Parametros("@strFoto", C_StrFoto));
                Lst.Add(new Cls_Parametros("@NumStock", C_NumStock));
                Lst.Add(new Cls_Parametros("@DtmFechaModifica", DateTime.Now.Date.ToString("yyyy-MM-dd HH:mm:ss")));
                Lst.Add(new Cls_Parametros("@StrUsuarioModifica", C_StrUsuarioModifica));

                mensaje = AccesoDatos.EjecutarProcedimiento("actualizar_Producto", Lst);
            }
            catch (Exception ex)
            {
                mensaje = "Falló la Actualización Producto " + ex.Message;
            }
            return mensaje;
        }
    }
}
