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
    public class N_Almacenes
    {
        public static DataTable Mostrar_al(string Valor)
        {
            D_Almacenes Datos = new D_Almacenes();
            return Datos.Mostrar_al(Valor);
        }

        public static string Guardar_al(int Nopcion, E_Almacenes Oalmacenes)
        {
            D_Almacenes Datos = new D_Almacenes();
            return Datos.Guardar_al(Nopcion, Oalmacenes);
        }

        public static string Eliminar_al(int Ncodigo)
        {
            D_Almacenes Datos = new D_Almacenes();
            return Datos.Eliminar_al(Ncodigo);
        }

        public static string Verifica_duplicado_al(int Nopcion, int Ncodigo, string Cdescripcion)
        {
            D_Almacenes Datos = new D_Almacenes();
            DataTable Tabla = new DataTable();
            Tabla = Datos.Verifica_duplicado_al(Nopcion, Ncodigo, Cdescripcion);
            if (Tabla.Rows.Count > 0)
            {
                return Tabla.Rows[0]["codigo_al"].ToString();
            }
            else
            {
                return "";
            }
        }

        public static DataTable Listar_em(string Valor)
        {
            D_Almacenes Datos = new D_Almacenes();
            return Datos.Listar_em(Valor);
        }
    }
}
