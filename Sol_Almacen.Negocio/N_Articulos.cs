using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Sol_Almacen.Entidades;
using Sol_Almacen.Datos;

namespace Sol_Almacen.Negocio
{
   public class N_Articulos
    {
        public static DataTable Mostrar_ar(string Valor)
        {
            D_Articulos Datos = new D_Articulos();
            return Datos.Mostrar_ar(Valor);
        }

        public static string Guardar_ar(int Nopcion, E_Articulos Oarticulos,DataTable TB_AL)
        {
            D_Articulos Datos = new D_Articulos();
            return Datos.Guardar_ar(Nopcion, Oarticulos,TB_AL);
        }

        public static string Eliminar_ar(int Ncodigo)
        {
            D_Articulos Datos = new D_Articulos();
            return Datos.Eliminar_ar(Ncodigo);
        }

        public static string Verifica_duplicado_ar(int Nopcion, int Ncodigo, string Cdescripcion)
        {
            D_Articulos Datos = new D_Articulos();
            DataTable Tabla = new DataTable();
            Tabla = Datos.Verifica_duplicado_ar(Nopcion, Ncodigo, Cdescripcion);
            if (Tabla.Rows.Count > 0)
            {
                return Tabla.Rows[0]["codigo_ar"].ToString();
            }
            else
            {
                return "";
            }
        }

        public static DataTable Listar_ma(string Valor)
        {
            D_Articulos Datos = new D_Articulos();
            return Datos.Listar_ma(Valor);
        }

        public static DataTable Listar_um(string Valor)
        {
            D_Articulos Datos = new D_Articulos();
            return Datos.Listar_um(Valor);
        }

        public static DataTable Listar_sg(string Valor)
        {
            D_Articulos Datos = new D_Articulos();
            return Datos.Listar_sg(Valor);
        }

        public static DataTable Mostrar_AL(int Nopcion, int Ncodigo)
        {
            D_Articulos Datos = new D_Articulos();
            return Datos.Mostrar_AL(Nopcion, Ncodigo);
        }
    }
}
