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
    public partial class Frm_Articulos : Form
    {
        public Frm_Articulos()
        {
            InitializeComponent();
        }

        #region "Mis Variables"
        int EstadoGuarda = 0;
        #endregion

        #region "Mis Métodos"
        private void Formato()
        {
            Dgv_Listado.Columns[0].Width = 100;
            Dgv_Listado.Columns[0].Visible = false;
            Dgv_Listado.Columns[1].Width = 98;
            Dgv_Listado.Columns[1].HeaderText = "CÓDIGO AR";
            Dgv_Listado.Columns[2].Width = 270;
            Dgv_Listado.Columns[2].HeaderText = "ARTÍCULO";
            Dgv_Listado.Columns[3].Width = 190;
            Dgv_Listado.Columns[3].HeaderText = "MARCA";
            Dgv_Listado.Columns[4].Width = 80;
            Dgv_Listado.Columns[4].HeaderText = "MEDIDA";
            Dgv_Listado.Columns[5].Width = 180;
            Dgv_Listado.Columns[5].HeaderText = "SUBGRUPO";
            Dgv_Listado.Columns[6].Width = 89;
            Dgv_Listado.Columns[6].HeaderText = "STOCK MIN";
            Dgv_Listado.Columns[7].Width = 89;
            Dgv_Listado.Columns[7].HeaderText = "STOCK MAX";
            Dgv_Listado.Columns[8].Visible = false;
            Dgv_Listado.Columns[9].Visible = false;
            Dgv_Listado.Columns[10].Visible = false;

        }

        private void Mostrar(string Ctexto)
        {
            try
            {
                Dgv_Listado.DataSource = N_Articulos.Mostrar_ar(Ctexto);
                this.Formato();
                Lbl_total.Text = "Total registros: " + Convert.ToString(Dgv_Listado.Rows.Count);
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
                Txt_codigo_ar.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["codigo_ar"].Value);
                Txt_descripcion_ma.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["descripcion_ma"].Value);
                Txt_codigo_ma.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["codigo_ma"].Value);
                Txt_descripcion_um.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["descripcion_um"].Value);
                Txt_codigo_um.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["codigo_um"].Value);
                Txt_descripcion_sg.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["descripcion_sg"].Value);
                Txt_codigo_sg.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["codigo_sg"].Value);
                Txt_descripcion_ar.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["descripcion_ar"].Value);
                Txt_stock_min.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["stock_min"].Value);
                Txt_stock_max.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["stock_max"].Value);
            }
        }

        private void Estado_Limpiar(bool Lestado)
        {
            Btn_cancelar.Visible = Lestado;
            Btn_guardar.Visible = Lestado;
            Btn_retornar.Visible = !Lestado;

            Txt_buscar.Clear();
            Txt_codigo_ar.Text = "0";           
            Txt_descripcion_ar.Text = "";
            Txt_stock_min.Text = "0.00";
            Txt_stock_max.Text = "0.00";
            Txt_descripcion_ar.ReadOnly = !Lestado;
            Txt_stock_min.ReadOnly = !Lestado;
            Txt_stock_max.ReadOnly = !Lestado;
        }

        private void Estado_BotonesPrincipales(bool Lestado)
        {
            Btn_nuevo.Enabled = Lestado;
            Btn_actualizar.Enabled = Lestado;
            Btn_eliminar.Enabled = Lestado;
            Btn_reporte.Enabled = Lestado;
            Btn_salir.Enabled = Lestado;
            btn_lupa.Visible = !Lestado;
            btn_lupa2.Visible = !Lestado;
            btn_lupa3.Visible = !Lestado;

            if (this.EstadoGuarda > 0)
            {
                Dgv_Listado.Enabled = Lestado;
            }
            else
            {
                Dgv_Listado.Enabled = true;
            }
            Txt_buscar.Enabled = Lestado;
            Btn_buscar.Enabled = Lestado;
        }

        private void Formato_ma()
        {
            Dgv_Listado_ma.Columns[0].Width = 260;
            Dgv_Listado_ma.Columns[0].HeaderText = "MARCA";
            Dgv_Listado_ma.Columns[1].Visible = false;
        }

        private void Listar_ma(string Ctexto)
        {
            try
            {
                Dgv_Listado_ma.DataSource = N_Articulos.Listar_ma(Ctexto);
                this.Formato_ma();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Selecciona_dgv_ma()
        {
            Txt_codigo_ma.Text = Convert.ToString(Dgv_Listado_ma.CurrentRow.Cells["codigo_ma"].Value);
            Txt_descripcion_ma.Text = Convert.ToString(Dgv_Listado_ma.CurrentRow.Cells["descripcion_ma"].Value);
        }

        private void Formato_um()
        {
            Dgv_Listado_um.Columns[0].Width = 250;
            Dgv_Listado_um.Columns[0].HeaderText = "MEDIDA";
            Dgv_Listado_um.Columns[1].Visible = false;
        }

        private void Listar_um(string Ctexto)
        {
            try
            {
                Dgv_Listado_um.DataSource = N_Articulos.Listar_um(Ctexto);
                this.Formato_um();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Selecciona_dgv_um()
        {
            Txt_codigo_um.Text = Convert.ToString(Dgv_Listado_um.CurrentRow.Cells["codigo_um"].Value);
            Txt_descripcion_um.Text = Convert.ToString(Dgv_Listado_um.CurrentRow.Cells["descripcion_um"].Value);
        }

        private void Formato_sg()
        {
            Dgv_Listado_sg.Columns[0].Width = 250;
            Dgv_Listado_sg.Columns[0].HeaderText = "SUBGRUPO";
            Dgv_Listado_sg.Columns[1].Visible = false;
        }

        private void Listar_sg(string Ctexto)
        {
            try
            {
                Dgv_Listado_sg.DataSource = N_Articulos.Listar_sg(Ctexto);
                this.Formato_sg();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Selecciona_dgv_sg()
        {
            Txt_codigo_sg.Text = Convert.ToString(Dgv_Listado_sg.CurrentRow.Cells["codigo_sg"].Value);
            Txt_descripcion_sg.Text = Convert.ToString(Dgv_Listado_sg.CurrentRow.Cells["descripcion_sg"].Value);
        }
        #endregion
        private void Frm_Articulos_Load(object sender, EventArgs e)
        {
            this.Mostrar("%");
        }
       
        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            this.Mostrar(Txt_buscar.Text);
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Txt_codigo_ar.Text == string.Empty && Txt_codigo_ma.Text == string.Empty && Txt_codigo_um.Text == string.Empty && Txt_codigo_sg.Text == string.Empty && Txt_descripcion_ar.Text == string.Empty)
                {
                    MessageBox.Show("Falta ingresar datos requeridos (*)", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    E_Articulos Ear = new E_Articulos();
                    string Cduplica, Rpta = "";
                    Ear.Codigo_ar = Convert.ToInt32(Txt_codigo_ar.Text);
                    Ear.Codigo_ma = Convert.ToInt32(Txt_codigo_ma.Text);
                    Ear.Codigo_um = Convert.ToInt32(Txt_codigo_um.Text);
                    Ear.Codigo_sg = Convert.ToInt32(Txt_codigo_sg.Text);
                    Ear.Descripcion_ar = Txt_descripcion_ar.Text.Trim();
                    Ear.Stock_min = Convert.ToDecimal(Txt_stock_min.Text);
                    Ear.Stock_max = Convert.ToDecimal(Txt_stock_max.Text);
                    Ear.Estado = true;
                    // Verificamos si la información que se intenta guardar ya existe en la tabla
                    Cduplica = N_Articulos.Verifica_duplicado_ar(this.EstadoGuarda, Ear.Codigo_ar, Ear.Descripcion_ar);
                    if (Cduplica == "")
                    {
                        Rpta = N_Articulos.Guardar_ar(this.EstadoGuarda, Ear);
                        if (Rpta.Equals("OK"))
                        {
                            MessageBox.Show("Los datos han sido guardados correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Estado_Limpiar(false);
                            this.EstadoGuarda = 0;
                            this.Mostrar("%");
                            Tbp_general.SelectedIndex = 0;
                            this.Estado_BotonesPrincipales(true);
                        }
                        else
                        {
                            MessageBox.Show(Rpta, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Los datos que se intenta guardar ya existe en la base de datos con el código: " + Cduplica, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            this.EstadoGuarda = 1; //Nuevo registro
            this.Estado_BotonesPrincipales(false);
            this.Estado_Limpiar(true);
            Tbp_general.SelectedIndex = 1;
            Txt_descripcion_ar.Select();
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Estado_Limpiar(false);
            this.EstadoGuarda = 0;
            Tbp_general.SelectedIndex = 0;
            this.Estado_BotonesPrincipales(true);
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            if (this.Dgv_Listado.Rows.Count > 0)
            {
                this.EstadoGuarda = 2; //Actualizar registro
                this.Estado_BotonesPrincipales(false);
                this.Estado_Limpiar(true);
                this.Selecciona_dgv();
                Tbp_general.SelectedIndex = 1;
                Txt_descripcion_ar.Select();
            }

        }

        private void Dgv_Listado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Estado_Limpiar(false);
            this.Selecciona_dgv();
            Tbp_general.SelectedIndex = 1;
        }

        private void Btn_retornar_Click(object sender, EventArgs e)
        {
            this.Estado_Limpiar(false);
            this.EstadoGuarda = 0;
            Tbp_general.SelectedIndex = 0;
            this.Estado_BotonesPrincipales(true);
        }

        private void Dgv_Listado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Dgv_Listado.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)Dgv_Listado.Rows[e.RowIndex].Cells["Seleccionar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }

        }

        private void Btn_confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Estas seguro de eliminar los registros seleccionados?", "Aviso del Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    int Codigo;
                    string Rpta = "";
                    foreach (DataGridViewRow row in Dgv_Listado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Rpta = N_Articulos.Eliminar_ar(Codigo);
                            if (Rpta.Equals("OK"))
                            {
                                // por definir que mensaje ubicar
                            }
                            else
                            {
                                MessageBox.Show(Rpta, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    this.Mostrar("%");
                    Btn_cancelar2.Visible = false;
                    Btn_confirmar.Visible = false;
                    this.Estado_BotonesPrincipales(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            if (Dgv_Listado.Rows.Count > 0)
            {
                this.Estado_BotonesPrincipales(false);
                Dgv_Listado.Columns[0].Visible = true;
                Btn_cancelar2.Visible = true;
                Btn_confirmar.Visible = true;
                Tbp_general.SelectedIndex = 0;
            }
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_reporte_Click(object sender, EventArgs e)
        {

        }

        private void btn_lupa_Click(object sender, EventArgs e)
        {
            Pnl_listado_ma.Visible = true;
            Txt_buscar_ma.Select();
            this.Listar_ma(Txt_buscar_ma.Text);
        }

        private void btn_lupa2_Click(object sender, EventArgs e)
        {
            Pnl_listado_um.Location = Pnl_listado_ma.Location;
            Pnl_listado_um.Visible = true;
            Txt_buscar_um.Select();
            this.Listar_um(Txt_buscar_um.Text);
        }

        private void btn_lupa3_Click(object sender, EventArgs e)
        {
            Pnl_listado_sg.Location = Pnl_listado_ma.Location;
            Pnl_listado_sg.Visible = true;
            Txt_buscar_sg.Select();
            this.Listar_sg(Txt_buscar_sg.Text);
        }

        private void Btn_retornar_ma_Click(object sender, EventArgs e)
        {
            Pnl_listado_ma.Visible = false;
        }

        private void Btn_buscar_ma_Click(object sender, EventArgs e)
        {
            this.Listar_ma(Txt_buscar_ma.Text);
        }

        private void Dgv_Listado_ma_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_dgv_ma();
            Pnl_listado_ma.Visible = false;
        }


        private void Btn_retornar_um_Click(object sender, EventArgs e)
        {
            Pnl_listado_um.Visible = false;
        }

        private void Btn_buscar_um_Click(object sender, EventArgs e)
        {
            this.Listar_um(Txt_buscar_um.Text);
        }

        private void Dgv_Listado_um_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_dgv_um();
            Pnl_listado_um.Visible = false;
        }

        private void Btn_retornar_sg_Click(object sender, EventArgs e)
        {
            Pnl_listado_sg.Visible = false;
        }

        private void Btn_buscar_sg_Click(object sender, EventArgs e)
        {
            this.Listar_sg(Txt_buscar_sg.Text);
        }

        private void Dgv_Listado_sg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_dgv_sg();
            Pnl_listado_sg.Visible = false;
        }

        private void Btn_cancelar2_Click(object sender, EventArgs e)
        {
            this.Estado_BotonesPrincipales(true);
            Dgv_Listado.Columns[0].Visible = false;
            foreach (DataGridViewRow row in Dgv_Listado.Rows)
            {
                row.Cells["Seleccionar"].Value = false;
            }
            Btn_cancelar2.Visible = false;
            Btn_confirmar.Visible = false;
        }
    }
}
