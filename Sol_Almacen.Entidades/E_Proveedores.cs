using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol_Almacen.Entidades
{
    public class E_Proveedores
    {
        public int Codigo_pr { get; set; }
        public int Codigo_tdn { get; set; }
        public string Nro_documento_pr { get; set; }
        public string Razonsocial_pr { get; set; }
        public string Nombres_pr { get; set; }
        public string Apellidos_pr { get; set; }
        public int Codigo_sx { get; set; }
        public string Email_pr { get; set; }
        public int Codigo_ru { get; set; }
        public int Codigo_di { get; set; }
        public string Direccion_pr { get; set; }
        public string Telefono_pr { get; set; }
        public string Movil_pr { get; set; }
        public bool Estado { get; set; }

    }
}
