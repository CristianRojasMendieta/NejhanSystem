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
    public class N_SubGrupos
    {
        public static DataTable Mostrar_sg(string Valor)
        {
           D_SubGrupos Datos = new D_SubGrupos();
            return Datos.Mostrar_sg(Valor);
        }

        public static string Guardar_sg(int Nopcion, E_SubGrupos Osubgrupos)
        {
            D_SubGrupos Datos = new D_SubGrupos();
            return Datos.Guardar_sg(Nopcion, Osubgrupos);
        }

        public static string Eliminar_sg(int Ncodigo)
        {
            D_SubGrupos Datos = new D_SubGrupos();
            return Datos.Eliminar_sg(Ncodigo);
        }

        public static string Verifica_duplicado_sg(int Nopcion, int Ncodigo, string Cdescripcion)
        {
            D_SubGrupos Datos = new D_SubGrupos();
            DataTable Tabla = new DataTable();
            Tabla = Datos.Verifica_duplicado_sg(Nopcion, Ncodigo, Cdescripcion);
            if (Tabla.Rows.Count > 0)
            {
                return Tabla.Rows[0]["codigo_sg"].ToString();
            }
            else
            {
                return "";
            }
        }

        public static DataTable Listar_gr(string Valor)
        {
            D_SubGrupos Datos = new D_SubGrupos();
            return Datos.Listar_gr(Valor);
        }
    }
}
