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
        public string C_DtmFecha { get; set; }
        public int C_IdCliente { get; set; }
        public int C_IdEmpleado { get; set; }
        public float C_NumDescuento { get; set; }
        public float C_NumImpuesto { get; set; }
        public float C_NumValorTotal { get; set; }
        public int C_IdEstado { get; set; }
        public string C_StrUsuarioModifica { get; set; }

        Cls_Acceso_Datos AccesoDatos = new Cls_Acceso_Datos();

        public DataTable ConsultarFactura()
        {
            string sentencia = string.Empty;
            try
            {
                sentencia = $"Exec [SpConsultaFactura]";
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
                sentencia = $"Exec [ConsultaFacturaFiltro] {Filtro}";
                DataTable Dt = new DataTable();
                Dt = AccesoDatos.EjecutarConsulta(sentencia);
                return Dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable ConsultarProductos()
        {
            try
            {
                Cls_Productos Productos = new Cls_Productos();
                DataTable Dt = new DataTable();
                Dt = Productos.ConsultarProducto();
                return Dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable ConsultarEmpleados()
        {
            try
            {
                Cls_Empleados empleados = new Cls_Empleados();
                DataTable Dt = new DataTable();
                Dt = empleados.ConsultaEmpleado();
                return Dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable ConsultarClientes()
        {
            try
            {
                Cls_Cliente Clientes = new Cls_Cliente();
                DataTable Dt = new DataTable();
                Dt = Clientes.ConsultarCliente();
                return Dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable ConsultarEstadoFactura()
        {
            try
            {
                Cls__EstadoFactura Estado = new Cls__EstadoFactura();
                DataTable Dt = new DataTable();
                Dt = Estado.ConsultarEstado();
                return Dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public string EliminarFactura()
        {
            string mensaje = string.Empty;
            try
            {
                List<Cls_Parametros> Lst = new List<Cls_Parametros>();
                Lst.Add(new Cls_Parametros("@IdFactura", C_IdFactura));
                mensaje = AccesoDatos.EjecutarProcedimiento("Eliminar_Factura", Lst);
            }
            catch (Exception ex)
            {
                mensaje = "Falló al Borrar la Factura " + ex.Message;
            }
            return mensaje;
        }

        public string ActualizarFactura()
        {
            string mensaje = string.Empty;
            try
            {
                List<Cls_Parametros> Lst = new List<Cls_Parametros>();
                Lst.Add(new Cls_Parametros("@IdFactura", C_IdFactura));
                Lst.Add(new Cls_Parametros("@DtmFecha", C_DtmFecha));
                Lst.Add(new Cls_Parametros("@IdCliente", C_IdCliente));
                Lst.Add(new Cls_Parametros("@IdEmpleado", C_IdEmpleado));
                Lst.Add(new Cls_Parametros("@NumDescuento", C_NumDescuento));
                Lst.Add(new Cls_Parametros("@NumImpuesto", C_NumImpuesto));
                Lst.Add(new Cls_Parametros("@NumValorTotal", C_NumValorTotal));
                Lst.Add(new Cls_Parametros("@IdEstado", C_IdEstado));
                Lst.Add(new Cls_Parametros("@DtmFechaModifica", DateTime.Now.Date.ToString("yyyy-MM-dd HH:mm:ss")));
                Lst.Add(new Cls_Parametros("@StrUsuarioModifica", C_StrUsuarioModifica));
                mensaje = AccesoDatos.EjecutarProcedimiento("actualizar_Factura", Lst);
            }
            catch (Exception ex)
            {
                mensaje = "Falló al Actualizar Factura " + ex.Message;
            }
            return mensaje;
        }
    }
}
