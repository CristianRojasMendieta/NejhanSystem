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
    public class N_Grupos
    {
        public static DataTable Mostrar_gr(string Valor)
        {
            D_Grupos Datos = new D_Grupos();
            return Datos.Mostrar_gr(Valor);
        }

        public static string Guardar_gr(int Nopcion, E_Grupos Ogrupos)
        {
            D_Grupos Datos = new D_Grupos();
            return Datos.Guardar_gr(Nopcion, Ogrupos);
        }

        public static string Eliminar_gr(int Ncodigo)
        {
            D_Grupos Datos = new D_Grupos();
            return Datos.Eliminar_gr(Ncodigo);
        }

        public static string Verifica_duplicado_gr(int Nopcion, int Ncodigo, string Cdescripcion)
        {
            D_Grupos Datos = new D_Grupos();
            DataTable Tabla = new DataTable();
            Tabla = Datos.Verifica_duplicado_gr(Nopcion, Ncodigo, Cdescripcion);
            if (Tabla.Rows.Count > 0)
            {
                return Tabla.Rows[0]["codigo_gr"].ToString();
            }
            else
            {
                return "";
            }
        }
    }
}
