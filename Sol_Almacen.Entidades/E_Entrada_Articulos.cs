using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Sol_Almacen.Entidades
{
    public class E_Entrada_Articulos
    {       
        public int Codigo_co { get; set; }
        public int Codigo_pr { get; set; }        
        public DateTime Fecha_emision_doc { get; set; }      
        public string Nrodocumento_ea { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Igv { get; set; }
        public decimal Total_importe { get; set; }
        public int Codigo_al { get; set; }
        public string Observacion_ea { get; set; }       
        public int Codigo_us { get; set; }
        public bool Estado { get; set; }
        public DataTable Detalles { get; set; }
    }
}
