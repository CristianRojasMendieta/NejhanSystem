using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sol_Almacen.Presentacion.Reportes_libre
{
    public partial class Frm_Rpt_Libre_01 : Form
    {
        public Frm_Rpt_Libre_01()
        {
            InitializeComponent();
        }

        private void Frm_Rpt_Libre_01_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet_Reportes_libre.Reporte_libre_01' Puede moverla o quitarla según sea necesario.
            this.Reporte_libre_01TableAdapter.Fill(this.DataSet_Reportes_libre.Reporte_libre_01, Fecha_ini: Convert.ToDateTime(Txt_p1.Text), Fecha_fin: Convert.ToDateTime(Txt_p1.Text), cTexto: Txt_p3.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
