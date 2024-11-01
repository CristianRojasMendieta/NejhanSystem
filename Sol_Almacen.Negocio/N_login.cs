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
    public class N_login
    {
        public static DataTable Acceder_us(int Ncodigo_si, string Cemail_us, string Cpassword_us)
        {
            D_Login Datos = new D_Login();
            return Datos.Acceder_us(Ncodigo_si, Cemail_us, Cpassword_us);
        }

        public static string recoverPassword(string Cemail, string Ccodigo_verificacion)
        {
            D_Login Datos = new D_Login();
            return Datos.recoverPassword(Cemail, Ccodigo_verificacion);
        }

        public static string Restablecer_clave_us(string Cemail, string Cpassword)
        {
            D_Login Datos = new D_Login();
            return Datos.Restablecer_clave_us(Cemail, Cpassword);
        }

        public static string Restablecer_clave_us2(int Ccodigo_us, string Cpassword)
        {
            D_Login Datos = new D_Login();
            return Datos.Restablecer_clave_us2(Ccodigo_us, Cpassword);
        }
    }
}
