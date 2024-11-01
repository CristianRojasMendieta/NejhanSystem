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
    public class N_Salida_Articulos
    {
        public static DataTable Mostrar_sa(string Valor)
        {
            D_Salida_Articulos Datos = new D_Salida_Articulos();
            return Datos.Mostrar_sa(Valor);
        }

        public static DataTable Mostrar_detalle_sa(int Ncodigo_sa)
        {
            D_Salida_Articulos Datos = new D_Salida_Articulos();
            return Datos.Mostrar_detalle_sa(Ncodigo_sa);
        }
        public static string Guardar_sa(int Nopcion,E_Salida_Articulos Osalida_articulos, DataTable DT_sa)
        {
            D_Salida_Articulos Datos = new D_Salida_Articulos();
            return Datos.Guardar_sa(Nopcion,Osalida_articulos, DT_sa);
        }

        public static string Eliminar_sa(int Ncodigo)
        {
            D_Salida_Articulos Datos = new D_Salida_Articulos();
            return Datos.Eliminar_sa(Ncodigo);
        }

        public static DataTable Listar_al(string Valor)
        {
            D_Salida_Articulos Datos = new D_Salida_Articulos();
            return Datos.Listar_al(Valor);
        }

        public static DataTable Listar_ar(string Valor, int Ncodigo_al)
        {
            D_Salida_Articulos Datos = new D_Salida_Articulos();
            return Datos.Listar_ar(Valor,Ncodigo_al);
        }

        public static string Actualizar_aprobado_sa(int Ncodigo_sa, bool Baprobado, int Ncodigo_us)
        {
            D_Salida_Articulos Datos = new D_Salida_Articulos();
            return Datos.Actualizar_aprobado_sa(Ncodigo_sa,Baprobado,Ncodigo_us);
        }

        public static string Actualizar_entregado_sa(int Ncodigo_sa, bool Bentregado, int Ncodigo_us)
        {
            D_Salida_Articulos Datos = new D_Salida_Articulos();
            return Datos.Actualizar_entregado_sa(Ncodigo_sa, Bentregado,Ncodigo_us);
        }
    }
}
