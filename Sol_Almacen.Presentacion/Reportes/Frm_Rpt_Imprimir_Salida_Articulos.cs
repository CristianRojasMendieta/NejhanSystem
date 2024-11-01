using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sol_Almacen.Presentacion.Reportes
{
    public partial class Frm_Rpt_Imprimir_Salida_Articulos : Form
    {
        public Frm_Rpt_Imprimir_Salida_Articulos()
        {
            InitializeComponent();
        }

        private void Frm_Rpt_Imprimir_Salida_Articulos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet_MiAlmacen.USP_Imprimir_Salida_Articulos' Puede moverla o quitarla según sea necesario.
            this.USP_Imprimir_Salida_ArticulosTableAdapter.Fill(this.DataSet_MiAlmacen.USP_Imprimir_Salida_Articulos,nCodigo_sa:Convert.ToInt32(Txt_p1.Text.Trim()));

            this.reportViewer1.RefreshReport();
        }
    }
}
