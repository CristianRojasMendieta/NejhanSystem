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
    public class N_Rubros
    {
        public static DataTable Mostrar_ru(string Valor)
        {
            D_Rubros Datos = new D_Rubros();
            return Datos.Mostrar_ru(Valor);
        }

        public static string Guardar_ru(int Nopcion, E_Rubros Orubros)
        {
            D_Rubros Datos = new D_Rubros();
            return Datos.Guardar_ru(Nopcion, Orubros);
        }

        public static string Eliminar_ru(int Ncodigo)
        {
            D_Rubros Datos = new D_Rubros();
            return Datos.Eliminar_ru(Ncodigo);
        }

        public static string Verifica_duplicado_ru(int Nopcion, int Ncodigo, string Cdescripcion)
        {
            D_Rubros Datos = new D_Rubros();
            DataTable Tabla = new DataTable();
            Tabla = Datos.Verifica_duplicado_ru(Nopcion, Ncodigo, Cdescripcion);
            if (Tabla.Rows.Count > 0)
            {
                return Tabla.Rows[0]["codigo_ru"].ToString();
            }
            else
            {
                return "";
            }
        }
    }
}
