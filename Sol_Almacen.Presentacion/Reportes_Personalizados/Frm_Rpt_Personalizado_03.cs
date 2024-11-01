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
    public partial class Frm_Rpt_Personalizado_03 : Form
    {
        public Frm_Rpt_Personalizado_03()
        {
            InitializeComponent();
        }

        private void Frm_Rpt_Personalizado_03_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet_Reportes_Personalizados.Reporte_personalizado_03' Puede moverla o quitarla según sea necesario.
            this.Reporte_personalizado_03TableAdapter.Fill(this.DataSet_Reportes_Personalizados.Reporte_personalizado_03, Fecha_ini: Convert.ToDateTime(Txt_p1.Text), Fecha_fin: Convert.ToDateTime(Txt_p2.Text),nCodigo_ar:Convert.ToInt32(Txt_p3.Text));

            this.reportViewer1.RefreshReport();
        }
    }
}
