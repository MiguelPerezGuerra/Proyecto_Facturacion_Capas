using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Capa_AccesoDatos
{
    public class Cls_Parametros
    {
        //Definimos parámetros atributos
        public string Nombre { get; set; } //Nombre del parametro
        public object Valor { get; set; } //valor del parametro
        public SqlDbType TipoDato { get; set; } //tipo de dato
        public Int32 Tamano { get; set; } //longitud del parametro
        public ParameterDirection DireccionParametro { get; set; } //direccion del parametro Input, Output

        //Constructor Parametros ENTRADA
        public Cls_Parametros(string Objnombre, object ObjValor)
        {
            Nombre = Objnombre;
            Valor = ObjValor;
            DireccionParametro = ParameterDirection.Input;
        }

        //Constructo Parametros SALIDA
        public Cls_Parametros(string Objnombre, SqlDbType ObjTipoDato, Int32 ObjTamano)
        {
            Nombre = Objnombre;
            TipoDato = ObjTipoDato;
            Tamano = ObjTamano;
            DireccionParametro = ParameterDirection.Output;
        }

    }
    public class Cls_Acceso_Datos
    {
        SqlConnection Conexion; // se define la variable para la conexion de tipo sqlconnection.
        SqlCommand Cmd; // se defive la variable para realizar comandos en la DB.
        SqlDataReader LectorDatos; // utilizados para leer datos, suele estar acompañado de un objeto Command que contiene la consulta.
        SqlDataAdapter Da; // se utiliza como un puente entre DataSet y SQL Server para recuperaa y guardar datos.        
        DataTable Dt; // representa una tabla de datos relacionales en memoria.

        public string AbrirBD()
        {
            string Resultado = string.Empty;
            try
            {
                // creamos un objeto de tipo conexion a la base de datos y se pasa como parámetro la cadena de conexion.
                Conexion = new SqlConnection("Data Source=LAPTOP-MIGUEL;Initial Catalog=PractivaDB;Integrated Security=True");
                Conexion.Open();
            }
            catch (Exception ex)
            {
                // si hay algun error retornamos el siguiente mensaje.
                Resultado = "ERROR, No se establecion la conexion con la base de datos " + ex; 
            }

            return Resultado;
        }

        public string CerrarBD()
        {
            string Resultado = string.Empty;
            try
            {
                Conexion.Close(); // invocamos el metodo para cerrar la base de datos.
            }
            catch (Exception ex)
            {
                Resultado = "ERROR, Fallo al cerrar la conexion " + ex;
            }
            return Resultado;
        }

        // permite ejecutar procedimientos almacenados en la base de datos, los parametros se pasan por medio de una lista (list).
        public string EjecutarProcedimiento(string procedimiento, List<Cls_Parametros> lst)
        {
            string salida= string.Empty;

            try
            {
                int retornado;
                AbrirBD();
                // creamos el objeto comando con el nombre del procedimiento a ejecutar y ca comexion.
                Cmd = new SqlCommand(procedimiento, Conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                // asignamos al comando los valores de los parametros recibidos en la variable lst.
                if (lst != null)
                {
                    for (int i = 0; i < lst.Count; i++) // recoremos la lista de parametros recibidos en lst.
                    {
                        // analiza si el parametro es de entrada, osea que se lo enviamos a la base de datos.
                        if (lst[i].DireccionParametro == ParameterDirection.Input)
                        {
                            Cmd.Parameters.AddWithValue(lst[i].Nombre, lst[i].Valor);
                        }

                        if (lst[i].DireccionParametro == ParameterDirection.Output)
                        {
                            Cmd.Parameters.Add(lst[i].Nombre, lst[i].TipoDato, lst[i].Tamano).Direction = ParameterDirection.Output;
                        }
                    }
                }

                retornado = Cmd.ExecuteNonQuery(); // ejecutamos el procedimiento con sus parametros.

                if (retornado > 0)
                {
                    salida = "Los datos fueron Actualizados";
                }
                else 
                { 
                    salida = "Los datos no fueron Actualizados"; 
                }
                return salida;
            }
            catch (Exception ex)
            {
                salida = "ERROR: Falló la Operacion: " + ex;
                return salida;
            }
        }

        // recibe una sententencia SQL o un porcedimiento para  UPDATE, INSERT Y DELETE, retorna mensaje indicando si actualizo o no.
        public string EjecutarComando(string sentencia)
        {
            string salida = string.Empty;
            try
            {
                int retornado;
                AbrirBD();
                Cmd = new SqlCommand(sentencia, Conexion); // indicamos la sentencia a ejecutar y la conexion a la BD.
                retornado = Cmd.ExecuteNonQuery(); // en retornado recibe el Nro de filas afectados.
                CerrarBD();
                if (retornado > 0)
                {
                    salida = "Los datos fueron Actualizados";
                }
                else
                {
                    salida = "Los datos no fueron Actualizados";
                }
            }
            catch (Exception ex)
            {
                salida = "ERROR: Falló operación: " + ex;
            }
            return salida;
        }

        //Método que permite realizar una consulta en una o varias tablas y retorna un conjunto de registros en un DATATABLE - Ideal para llenar el datagrid y los combos.
        public DataTable EjecutarConsulta(string cmd)
        {
            try
            {
                AbrirBD();
                Da = new SqlDataAdapter(cmd, Conexion);
                Dt = new DataTable();
                Da.Fill(this.Dt);
                CerrarBD();
                return this.Dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
