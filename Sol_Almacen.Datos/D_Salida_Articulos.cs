using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Sol_Almacen.Entidades;

namespace Sol_Almacen.Datos
{
    public class D_Salida_Articulos
    {
        public DataTable Mostrar_sa(string Valor)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("Usp_mostrar_sa", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Ctexto", SqlDbType.VarChar).Value = Valor;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        public DataTable Mostrar_detalle_sa(int Ncodigo_sa)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Mostrar_Detalle_sa", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Ncodigo_sa", SqlDbType.VarChar).Value = Ncodigo_sa;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }
        public string Guardar_sa(int Nopcion, E_Salida_Articulos Osalida_articulos, DataTable DT_sa)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("Usp_guardar_sa2", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Nopcion", SqlDbType.Int).Value = Nopcion;
                Comando.Parameters.Add("@Ncodigo_sa", SqlDbType.Int).Value = Osalida_articulos.Codigo_sa;
                Comando.Parameters.Add("@Ncodigo_us", SqlDbType.Int).Value = Osalida_articulos.Codigo_us;
                Comando.Parameters.Add("@Ffecha_pe", SqlDbType.Date).Value = Osalida_articulos.Fecha_pe;
                Comando.Parameters.Add("@Creferencia_sa", SqlDbType.VarChar).Value = Osalida_articulos.Referencia_sa;
                Comando.Parameters.Add("@Ncodigo_al", SqlDbType.Int).Value = Osalida_articulos.Codigo_al;
                Comando.Parameters.Add("@Cobservacion_sa", SqlDbType.Text).Value = Osalida_articulos.Observacion_sa;               ;
                Comando.Parameters.Add("@Bestado", SqlDbType.Bit).Value = Osalida_articulos.Estado;
                Comando.Parameters.Add("@Baprobado", SqlDbType.Bit).Value = Osalida_articulos.Aprobado;
                Comando.Parameters.Add("@Bentregado", SqlDbType.Bit).Value = Osalida_articulos.Entregado;
                Comando.Parameters.Add("@DT_DET", SqlDbType.Structured).Value = DT_sa;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo ingresar el registro";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        public string Eliminar_sa(int Ncodigo)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("Usp_eliminar_sa", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("Ncodigo", SqlDbType.Int).Value = Ncodigo;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo eliminar el registro";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        public DataTable Listar_al(string Valor)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USp_Listar_al_sa", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Ctexto", SqlDbType.VarChar).Value = Valor;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        public DataTable Listar_ar(string Valor, int Ncodigo_al)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USp_Listar_ar_sa", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Ctexto", SqlDbType.VarChar).Value = Valor;
                Comando.Parameters.Add("@Ncodigo_al", SqlDbType.Int).Value = Ncodigo_al;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        public string Actualizar_aprobado_sa(int Ncodigo_sa, bool Baprobado, int Ncodigo_us)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Actualizar_aprobado_sa", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("Ncodigo_sa", SqlDbType.Int).Value = Ncodigo_sa;
                Comando.Parameters.Add("Baprobado", SqlDbType.Bit).Value = Baprobado;
                Comando.Parameters.Add("Ncodigo_us", SqlDbType.Int).Value = Ncodigo_us;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo eliminar el registro";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        public string Actualizar_entregado_sa(int Ncodigo_sa, bool Bentregado, int Ncodigo_us)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Actualizar_entregado_sa", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("Ncodigo_sa", SqlDbType.Int).Value = Ncodigo_sa;
                Comando.Parameters.Add("Bentregado", SqlDbType.Bit).Value = Bentregado;
                Comando.Parameters.Add("Ncodigo_us", SqlDbType.Int).Value = Ncodigo_us;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo eliminar el registro";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }
    }
}
