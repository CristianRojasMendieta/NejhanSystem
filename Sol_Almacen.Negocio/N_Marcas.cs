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
    public class N_Marcas
    {
        public static DataTable Mostrar_ma(string Valor)
        {
            D_Marcas Datos = new D_Marcas();
            return Datos.Mostrar_ma(Valor);
        }

        public static string Guardar_ma(int Nopcion, E_Marcas Omarcas)
        {
            D_Marcas Datos = new D_Marcas();
            return Datos.Guardar_ma(Nopcion, Omarcas);
        }

        public static string Eliminar_ma(int Ncodigo)
        {
            D_Marcas Datos = new D_Marcas();
            return Datos.Eliminar_ma(Ncodigo);
        }

        public static string Verifica_duplicado_ma(int Nopcion, int Ncodigo, string Cdescripcion)
        {
            D_Marcas Datos = new D_Marcas();
            DataTable Tabla = new DataTable();
            Tabla = Datos.Verifica_duplicado_ma(Nopcion, Ncodigo, Cdescripcion);
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
