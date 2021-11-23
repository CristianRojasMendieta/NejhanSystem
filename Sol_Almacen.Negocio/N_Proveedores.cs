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
    public class N_Proveedores
    {
        public static DataTable Mostrar_pr(string Valor)
        {
            D_Proveedores Datos = new D_Proveedores();
            return Datos.Mostrar_pr(Valor);
        }

        public static string Guardar_pr(int Nopcion, E_Proveedores Oproveedores)
        {
            D_Proveedores Datos = new D_Proveedores();
            return Datos.Guardar_pr(Nopcion, Oproveedores);
        }

        public static string Eliminar_pr(int Ncodigo)
        {
            D_Proveedores Datos = new D_Proveedores();
            return Datos.Eliminar_pr(Ncodigo);
        }

        public static string Verifica_duplicado_pr(int Nopcion, int Ncodigo, string Cdescripcion)
        {
            D_Proveedores Datos = new D_Proveedores();
            DataTable Tabla = new DataTable();
            Tabla = Datos.Verifica_duplicado_pr(Nopcion, Ncodigo, Cdescripcion);
            if (Tabla.Rows.Count > 0)
            {
                return Tabla.Rows[0]["codigo_pr"].ToString();
            }
            else
            {
                return "";
            }
        }

        public static DataTable Listar_tdn(string Valor)
        {
            D_Proveedores Datos = new D_Proveedores();
            return Datos.Listar_tdn(Valor);
        }

        public static DataTable Listar_sx(string Valor)
        {
            D_Proveedores Datos = new D_Proveedores();
            return Datos.Listar_sx(Valor);
        }

        public static DataTable Listar_ru(string Valor)
        {
            D_Proveedores Datos = new D_Proveedores();
            return Datos.Listar_ru(Valor);
        }

        public static DataTable Listar_di(string Valor)
        {
            D_Proveedores Datos = new D_Proveedores();
            return Datos.Listar_di(Valor);
        }

    }
}
