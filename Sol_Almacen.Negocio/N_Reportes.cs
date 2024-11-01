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
    public class N_Reportes
    {
        public static DataTable Listar_Almacenes()
        {
            D_Reportes Datos = new D_Reportes();
            return Datos.Listar_Almacenes();
        }      
    }
}
