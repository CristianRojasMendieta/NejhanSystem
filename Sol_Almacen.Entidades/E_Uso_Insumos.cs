using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol_Almacen.Entidades
{
    public class E_Uso_Insumos
    {
        public int Codigo_al { get; set; }
        public DateTime Fecha_in { get; set; }
        public string Referencia_in { get; set; }
        public string Observacion_in { get; set; }
        public int Codigo_us { get; set; }
    }
}
