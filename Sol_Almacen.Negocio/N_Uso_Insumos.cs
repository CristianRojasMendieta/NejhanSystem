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
    public class N_Uso_Insumos
    {
        public static DataTable Mostrar_in(string Valor)
        {
            D_Uso_Insumos Datos = new D_Uso_Insumos();
            return Datos.Mostrar_in(Valor);
        }

        public static DataTable Mostrar_detalle_in(int Ncodigo_in)
        {
            D_Uso_Insumos Datos = new D_Uso_Insumos();
            return Datos.Mostrar_detalle_in(Ncodigo_in);
        }
        public static string Guardar_in(E_Uso_Insumos oUI, DataTable DT_DET)
        {
            D_Uso_Insumos Datos = new D_Uso_Insumos();
            return Datos.Guardar_in(oUI, DT_DET);
        }

        public static string Eliminar_in(int Ncodigo)
        {
            D_Uso_Insumos Datos = new D_Uso_Insumos();
            return Datos.Eliminar_in(Ncodigo);
        }

        public static DataTable Listar_al(string Valor)
        {
            D_Uso_Insumos Datos = new D_Uso_Insumos();
            return Datos.Listar_al(Valor);
        }

        public static DataTable Listar_ar(string Valor, int Ncodigo_al)
        {
            D_Uso_Insumos Datos = new D_Uso_Insumos();
            return Datos.Listar_ar(Valor, Ncodigo_al);
        }        
    }
}
