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
    public class N_Inventarios
    {
        public static string Guardar_inv(int Ncodigo_al,
                                  DateTime fFecha_in,
                                  string cReferencia_in,
                                  string cObservacion,
                                  DataTable DT_ea)
        {
            D_Inventarios Datos = new D_Inventarios();
            return Datos.Guardar_inv(Ncodigo_al,
                                     fFecha_in,
                                     cReferencia_in,
                                     cObservacion,
                                     DT_ea);
        }
        public static DataTable Listar_al()
        {
            D_Inventarios Datos = new D_Inventarios();
            return Datos.Listar_al();
        }

        public static DataTable Listar_ar(int Ncodigo_al)
        {
            D_Inventarios Datos = new D_Inventarios();
            return Datos.Listar_ar(Ncodigo_al);
        }
    }
}
