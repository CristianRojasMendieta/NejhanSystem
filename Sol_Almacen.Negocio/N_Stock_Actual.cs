using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Sol_Almacen.Datos;

namespace Sol_Almacen.Negocio
{
    public class N_Stock_Actual
    {
        public static DataTable Mostrar_ar(string Valor)
        {
            D_Stock_Actual Datos = new D_Stock_Actual();
            return Datos.Mostrar_ar(Valor);
        }

        public static DataTable Mostrar_Detalle_Stock_Actual_Articulo(int Ncodigo_ar)
        {
            D_Stock_Actual Datos = new D_Stock_Actual();
            return Datos.Mostrar_Detalle_Stock_Actual_Articulo(Ncodigo_ar);
        }
    }
}
