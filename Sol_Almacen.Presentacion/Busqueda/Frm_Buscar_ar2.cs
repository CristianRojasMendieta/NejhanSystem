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

namespace Sol_Almacen.Presentacion.Busqueda
{
    public partial class Frm_Buscar_ar2 : Form
    {
        public Frm_Buscar_ar2()
        {
            InitializeComponent();
        }

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
            Dgv_Listado.Columns[5].Visible = false;
            Dgv_Listado.Columns[6].Visible = false;
            Dgv_Listado.Columns[7].Visible = false;
            Dgv_Listado.Columns[8].Visible = false;
            Dgv_Listado.Columns[9].Visible = false;
        }
        private void Mostrar(string Ctexto)
        {
            try
            {
                Dgv_Listado.DataSource = N_Articulos.Mostrar_ar(Ctexto);
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
               MisVariables_Buscar.v2Codigo_ar= Convert.ToInt32(Dgv_Listado.CurrentRow.Cells["codigo_ar"].Value);
               MisVariables_Buscar.v2Descripcion_ar= Convert.ToString(Dgv_Listado.CurrentRow.Cells["descripcion_ar"].Value) + "  |  "+
                                                     Convert.ToString(Dgv_Listado.CurrentRow.Cells["descripcion_ma"].Value) + "  |  "+
                                                     Convert.ToString(Dgv_Listado.CurrentRow.Cells["descripcion_um"].Value);  
            }
        }
        #endregion

        private void Frm_Buscar_ar2_Load(object sender, EventArgs e)
        {
            this.Mostrar("%");
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            this.Mostrar(Txt_buscar.Text.Trim());
        }

        private void Dgv_Listado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_dgv();
            this.Close();
        }
    }
}
