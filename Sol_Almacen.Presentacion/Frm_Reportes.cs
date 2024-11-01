using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sol_Almacen.Negocio;
using Sol_Almacen.Entidades;

namespace Sol_Almacen.Presentacion
{
    public partial class Frm_Reportes : Form
    {
        public Frm_Reportes()
        {
            InitializeComponent();
        }

        #region "Métodos"
        private void Cargar_Almacenes()
        {
            try
            {
                Cmb_Almacenes.DataSource = N_Reportes.Listar_Almacenes();
                Cmb_Almacenes.ValueMember = "codigo_al";
                Cmb_Almacenes.DisplayMember = "descripcion_al";               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        #endregion

        private void Btn_reporte_Click(object sender, EventArgs e)
        {
            if (Cmb_Almacenes.Text == string.Empty)
            {
                MessageBox.Show("Seleccione un Almacén para el reporte", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Reportes_libre.Frm_Rpt_Libre_01 oRpt_p01 = new Reportes_libre.Frm_Rpt_Libre_01();
                oRpt_p01.Txt_p1.Text = Dtp_fecha_ini2.Text;
                oRpt_p01.Txt_p2.Text = Dtp_fecha_fin2.Text;
                oRpt_p01.Txt_p3.Text = Convert.ToString(Cmb_Almacenes.SelectedValue);
                oRpt_p01.ShowDialog();
            }
        }

        private void Frm_Reportes_Load(object sender, EventArgs e)
        {
            this.Cargar_Almacenes();
        }
    }
}
