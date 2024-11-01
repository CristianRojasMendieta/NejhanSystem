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
    public partial class Frm_Reportes_Personalizados : Form
    {
        public Frm_Reportes_Personalizados()
        {
            InitializeComponent();
        }

        #region "Métodos"
        private void Cargar_Almacenes()
        {
            try
            {                

                Cmb_Almacenes2.DataSource = N_ReportesPersonalizados.Listar_Almacenes2();
                Cmb_Almacenes2.ValueMember = "codigo_al";
                Cmb_Almacenes2.DisplayMember = "descripcion_al";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        #endregion

        private void Frm_Reportes_Personalizados_Load(object sender, EventArgs e)
        {
            this.Cargar_Almacenes();
        }
                

        private void Btn_reporte2_Click(object sender, EventArgs e)
        {
            string cTexto = "";

            if (Chk_todos.Checked==true ) // Todos los Almacenes
            {
                cTexto = "%";
            }
            else if (Cmb_Almacenes2.Text == string.Empty)
            {
                MessageBox.Show("Seleccione un Almacén para el reporte", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                cTexto= Convert.ToString(Cmb_Almacenes2.SelectedValue).Trim();                
            }

            Reportes_Personalizados.Frm_Rpt_Personalizado_02 oRpt_p02 = new Reportes_Personalizados.Frm_Rpt_Personalizado_02();

            oRpt_p02.Txt_p1.Text = cTexto;
            oRpt_p02.ShowDialog();
        }

        private void Chk_todos_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_todos.Checked==true)
            {
                Cmb_Almacenes2.SelectedItem = null;
            }
        }

        private void Btn_reporte_Click(object sender, EventArgs e)
        {
           if(Chk_todos_articulos1.Checked==false && Txt_descripcion1.Text== string.Empty)
            {
                MessageBox.Show("Seleccione artículos para generar el reporte", "Aviso del Sistema");
            }
            else
            {
                if (Chk_todos_articulos1.Checked == true)
                {
                    Busqueda.MisVariables_Buscar.v1Codigo_ar = 0;
                }
                Reportes_Personalizados.Frm_Rpt_Personalizado_01 oRpt_p01 = new Reportes_Personalizados.Frm_Rpt_Personalizado_01();
                oRpt_p01.Txt_p1.Text = Dtp_fecha_ini.Text;
                oRpt_p01.Txt_p2.Text = Dtp_fecha_fin.Text;
                oRpt_p01.Txt_p3.Text = Convert.ToString(Busqueda.MisVariables_Buscar.v1Codigo_ar);
                oRpt_p01.ShowDialog();
            }            
        }

        private void Btn_reporte1_Click(object sender, EventArgs e)
        {
            if (Chk_todos_articulos2.Checked == false && Txt_descripcion2.Text == string.Empty)
            {
                MessageBox.Show("Seleccione artículos para generar el reporte", "Aviso del Sistema");
            }
            else
            {
                if (Chk_todos_articulos2.Checked == true)
                {
                    Busqueda.MisVariables_Buscar.v2Codigo_ar = 0;
                }
                Reportes_Personalizados.Frm_Rpt_Personalizado_03 oRpt_p03 = new Reportes_Personalizados.Frm_Rpt_Personalizado_03();
                oRpt_p03.Txt_p1.Text = Dtp_fecha_ini2.Text;
                oRpt_p03.Txt_p2.Text = Dtp_fecha_fin2.Text;
                oRpt_p03.Txt_p3.Text = Convert.ToString(Busqueda.MisVariables_Buscar.v2Codigo_ar);
                oRpt_p03.ShowDialog();
            }
        }

        private void btn_lupa1_Click(object sender, EventArgs e)
        {
            Chk_todos_articulos1.Checked = false;
            Busqueda.MisVariables_Buscar.v1Codigo_ar = 0;
            Busqueda.MisVariables_Buscar.v1Descripcion_ar = "";
            Busqueda.Frm_Buscar_ar oFrm_Buscar_ar1 = new Busqueda.Frm_Buscar_ar();
            oFrm_Buscar_ar1.ShowDialog();
            Txt_descripcion1.Text = Busqueda.MisVariables_Buscar.v1Descripcion_ar;
        }

        private void Chk_todos_articulos1_Click(object sender, EventArgs e)
        {
            Txt_descripcion1.Text = "";
        }

        private void btn_lupa2_Click(object sender, EventArgs e)
        {
            Chk_todos_articulos2.Checked = false;
            Busqueda.MisVariables_Buscar.v2Codigo_ar = 0;
            Busqueda.MisVariables_Buscar.v2Descripcion_ar = "";
            Busqueda.Frm_Buscar_ar2 oFrm_Buscar_ar2 = new Busqueda.Frm_Buscar_ar2();
            oFrm_Buscar_ar2.ShowDialog();
            Txt_descripcion2.Text = Busqueda.MisVariables_Buscar.v2Descripcion_ar;
        }

        private void Chk_todos_articulos2_Click(object sender, EventArgs e)
        {
            Txt_descripcion2.Text = "";
        }
    }
}
