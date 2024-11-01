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
    public class D_Inventarios
    {

        public string Guardar_inv(int Ncodigo_al,
                                  DateTime fFecha_in,
                                  string cReferencia_in,
                                  string cObservacion,
                                  DataTable DT_ea)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("Usp_guardar_inv", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;              
                Comando.Parameters.Add("@Ncodigo_al", SqlDbType.Int).Value = Ncodigo_al;
                Comando.Parameters.Add("@fFecha_in", SqlDbType.Date).Value =fFecha_in;
                Comando.Parameters.Add("@cReferencia_in", SqlDbType.VarChar).Value = cReferencia_in;
                Comando.Parameters.Add("@cObservacion_in", SqlDbType.VarChar).Value = cObservacion;
                Comando.Parameters.Add("@tDetalle", SqlDbType.Structured).Value = DT_ea;
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

        public DataTable Listar_al()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USp_Listar_al_in", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
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

        public DataTable Listar_ar(int Ncodigo_al)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USp_Listar_ar_in", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
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
    }
}
