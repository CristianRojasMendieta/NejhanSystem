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
    public partial class Frm_Rpt_Articulos : Form
    {
        public Frm_Rpt_Articulos()
        {
            InitializeComponent();
        }

        private void Frm_Rpt_Articulos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet_MiAlmacen.Usp_mostrar_ar' Puede moverla o quitarla según sea necesario.
            this.Usp_mostrar_arTableAdapter.Fill(this.DataSet_MiAlmacen.Usp_mostrar_ar, Ctexto: Txt_p1.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
