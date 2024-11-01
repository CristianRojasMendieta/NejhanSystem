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
    public partial class Frm_Rpt_Imprimir_Inventario_inicial : Form
    {
        public Frm_Rpt_Imprimir_Inventario_inicial()
        {
            InitializeComponent();
        }

        private void Frm_Rpt_Imprimir_Inventario_inicial_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet_MiAlmacen.USp_Listar_ar_in' Puede moverla o quitarla según sea necesario.
            this.USp_Listar_ar_inTableAdapter.Fill(this.DataSet_MiAlmacen.USp_Listar_ar_in,Ncodigo_al:Convert.ToInt32(Txt_p1.Text.Trim()));

            this.reportViewer1.RefreshReport();
        }
    }
}
