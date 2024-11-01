using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Sol_Almacen.Entidades
{
    public class E_Salida_Articulos
    {   
        public int Codigo_sa { get; set; }
        public int Codigo_us { get; set; }
        public DateTime Fecha_pe { get; set; }  
        public string Referencia_sa { get; set; }
        public int Codigo_al { get; set; }
        public string Observacion_sa { get; set; }        
        public bool Estado { get; set; }
        public bool Aprobado { get; set; }
        public bool Entregado { get; set; }
        public DataTable Detalles { get; set; }
    }
}
