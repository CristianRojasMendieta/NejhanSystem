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

namespace Sol_Almacen.Presentacion
{
    public partial class Frm_Stock_Actual : Form
    {
        public Frm_Stock_Actual()
        {
            InitializeComponent();
        }
        #region "Mis Variables"
        int Codigo_ar = 0;
        string Descripcion_ar = "";
        #endregion

        #region "Mis Métodos"
        private void Formato()
        {
            Dgv_Listado.Columns[0].Width = 98;
            Dgv_Listado.Columns[0].HeaderText = "CÓDIGO AR";
            Dgv_Listado.Columns[1].Width = 270;
            Dgv_Listado.Columns[1].HeaderText = "ARTÍCULO";
            Dgv_Listado.Columns[2].Width = 190;
            Dgv_Listado.Columns[2].HeaderText = "MARCA";
            Dgv_Listado.Columns[3].Width = 80;
            Dgv_Listado.Columns[3].HeaderText = "MEDIDA";
            Dgv_Listado.Columns[4].Width = 180;
            Dgv_Listado.Columns[4].HeaderText = "SUBGRUPO";
            Dgv_Listado.Columns[5].Width = 89;
            Dgv_Listado.Columns[5].HeaderText = "STOCK MIN";
            Dgv_Listado.Columns[6].Width = 89;
            Dgv_Listado.Columns[6].HeaderText = "STOCK MAX";
            Dgv_Listado.Columns[7].Visible = false;
            Dgv_Listado.Columns[8].Visible = false;
            Dgv_Listado.Columns[9].Visible = false;

        }

        private void Formato_de()
        {           
            Dgv_detalle.Columns[0].Width = 250;
            Dgv_detalle.Columns[0].HeaderText = "ALMACÉN";
            Dgv_detalle.Columns[1].Width = 150;
            Dgv_detalle.Columns[1].HeaderText = "STOCK ACTUAL";
            Dgv_detalle.Columns[2].Width = 150;
            Dgv_detalle.Columns[2].HeaderText = "PRECIO COMPRA S/.";                

        }
        private void Mostrar(string Ctexto)
        {
            try
            {
                Dgv_Listado.DataSource = N_Stock_Actual.Mostrar_ar(Ctexto);
                this.Formato();                
                Dgv_Listado.Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Selecciona_dgv()
        {
            if (String.IsNullOrEmpty(Convert.ToString(Dgv_Listado.CurrentRow.Cells["codigo_ar"].Value)))
            {
                MessageBox.Show("Seleccione un registro ", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                this.Codigo_ar=Convert.ToInt32(Dgv_Listado.CurrentRow.Cells["codigo_ar"].Value);
                this.Descripcion_ar = Convert.ToString(Dgv_Listado.CurrentRow.Cells["descripcion_ar"].Value);
                Lbl_descripcion_ar.Text = ".:. ARTÍCULO: " + this.Descripcion_ar;
                Dgv_detalle.DataSource = N_Stock_Actual.Mostrar_Detalle_Stock_Actual_Articulo(this.Codigo_ar);
                this.Formato_de();
            }
        }
        #endregion

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            this.Mostrar(Txt_buscar.Text);
        }

        private void Dgv_Listado_Click(object sender, EventArgs e)
        {
           // this.Selecciona_dgv();
        }

        private void Dgv_Listado_SelectionChanged(object sender, EventArgs e)
        {
            this.Selecciona_dgv();
        }
    }
}
