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
    public class N_Unidades_Medidas
    {
        public static DataTable Mostrar_um(string Valor)
        {
            D_Unidades_Medidas Datos = new D_Unidades_Medidas();
            return Datos.Mostrar_um(Valor);
        }

        public static string Guardar_um(int Nopcion, E_Unidades_Medidas Ounidades_medidas)
        {
            D_Unidades_Medidas Datos = new D_Unidades_Medidas();
            return Datos.Guardar_um(Nopcion, Ounidades_medidas);
        }

        public static string Eliminar_um(int Ncodigo)
        {
            D_Unidades_Medidas Datos = new D_Unidades_Medidas();
            return Datos.Eliminar_um(Ncodigo);
        }

        public static string Verifica_duplicado_um(int Nopcion, int Ncodigo, string Cdescripcion)
        {
            D_Unidades_Medidas Datos = new D_Unidades_Medidas();
            DataTable Tabla = new DataTable();
            Tabla = Datos.Verifica_duplicado_um(Nopcion, Ncodigo, Cdescripcion);
            if (Tabla.Rows.Count > 0)
            {
                return Tabla.Rows[0]["codigo_um"].ToString();
            }
            else
            {
                return "";
            }
        }
    }
}
