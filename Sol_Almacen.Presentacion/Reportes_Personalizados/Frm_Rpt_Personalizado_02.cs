using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sol_Almacen.Presentacion.Reportes_Personalizados
{
    public partial class Frm_Rpt_Personalizado_02 : Form
    {
        public Frm_Rpt_Personalizado_02()
        {
            InitializeComponent();
        }

        private void Frm_Rpt_Personalizado_02_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet_Reportes_Personalizados.Reporte_personalizado_02' Puede moverla o quitarla según sea necesario.
            this.Reporte_personalizado_02TableAdapter.Fill(this.DataSet_Reportes_Personalizados.Reporte_personalizado_02,cTexto: Txt_p1.Text.Trim());

            this.reportViewer1.RefreshReport();
        }
    }
}
