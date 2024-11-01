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
    public class N_Entrada_Articulos
    {
        public static DataTable Mostrar_ea(string Valor)
        {
            D_Entrada_Articulos Datos = new D_Entrada_Articulos();
            return Datos.Mostrar_ea(Valor);
        }

        public static DataTable Mostrar_detalle_ea(int Ncodigo_ea)
        {
            D_Entrada_Articulos Datos = new D_Entrada_Articulos();
            return Datos.Mostrar_detalle_ea(Ncodigo_ea);
        }
        public static string Guardar_ea(E_Entrada_Articulos Oentrada_articulos, DataTable DT_ea)
        {
            D_Entrada_Articulos Datos = new D_Entrada_Articulos();
            return Datos.Guardar_ea(Oentrada_articulos, DT_ea);
        }

        public static string Eliminar_ea(int Ncodigo)
        {
            D_Entrada_Articulos Datos = new D_Entrada_Articulos();
            return Datos.Eliminar_ea(Ncodigo);
        }     

        public static DataTable Listar_co(string Valor)
        {
            D_Entrada_Articulos Datos = new D_Entrada_Articulos();
            return Datos.Listar_co(Valor);
        }

        public static DataTable Listar_pr(string Valor)
        {
            D_Entrada_Articulos Datos = new D_Entrada_Articulos();
            return Datos.Listar_pr(Valor);
        }

        public static DataTable Listar_al()
        {
            D_Entrada_Articulos Datos = new D_Entrada_Articulos();
            return Datos.Listar_al();
        }

        public static DataTable Listar_ar(string Valor)
        {
            D_Entrada_Articulos Datos = new D_Entrada_Articulos();
            return Datos.Listar_ar(Valor);
        }
    }
}
