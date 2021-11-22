using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol_Almacen.Entidades
{
    public class E_Articulos
    {
        public int Codigo_ar { get; set; }
        public string Descripcion_ar { get; set; }
        public int Codigo_ma { get; set; }
        public int Codigo_um { get; set; }
        public int Codigo_sg { get; set; }
        public decimal Stock_min { get; set; }
        public decimal Stock_max { get; set; }
        public bool Estado { get; set; }
    }
}
