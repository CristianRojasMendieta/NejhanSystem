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
    public partial class Frm_Proveedores : Form
    {
        public Frm_Proveedores()
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
            Dgv_Listado.Columns[1].HeaderText = "CÓDIGO PR";
            Dgv_Listado.Columns[2].Width = 100;
            Dgv_Listado.Columns[2].HeaderText = "TIPO DOC.";
            Dgv_Listado.Columns[3].Width = 120;
            Dgv_Listado.Columns[3].HeaderText = "NRO.DOC.";
            Dgv_Listado.Columns[4].Width = 300;
            Dgv_Listado.Columns[4].HeaderText = "PROVEEDOR";
            Dgv_Listado.Columns[5].Width = 250;
            Dgv_Listado.Columns[5].HeaderText = "EMAIL";
            Dgv_Listado.Columns[6].Width = 120;
            Dgv_Listado.Columns[6].HeaderText = "RUBRO";           
            Dgv_Listado.Columns[7].Visible = false;
            Dgv_Listado.Columns[8].Visible = false;
            Dgv_Listado.Columns[9].Visible = false;
            Dgv_Listado.Columns[10].Visible = false;
            Dgv_Listado.Columns[11].Visible = false;
            Dgv_Listado.Columns[12].Visible = false;
            Dgv_Listado.Columns[13].Visible = false;
            Dgv_Listado.Columns[14].Visible = false;
            Dgv_Listado.Columns[15].Visible = false;
            Dgv_Listado.Columns[16].Visible = false;
            Dgv_Listado.Columns[17].Visible = false;
            Dgv_Listado.Columns[18].Visible = false;
        }

        private void Mostrar(string Ctexto)
        {
            try
            {
                Dgv_Listado.DataSource = N_Proveedores.Mostrar_pr(Ctexto);
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
            if (String.IsNullOrEmpty(Convert.ToString(Dgv_Listado.CurrentRow.Cells["codigo_pr"].Value)))
            {
                MessageBox.Show("Seleccione un registro ", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Txt_codigo_pr.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["codigo_pr"].Value);
                Txt_descripcion_tdn.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["descripcion_tdn"].Value);
                Txt_codigo_tdn.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["codigo_tdn"].Value);
                Txt_nrodocumento_pr.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["nrodocumento_pr"].Value);
                Txt_razonsocial_pr.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["razonsocial_pr"].Value);
                Txt_nombres_pr.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["nombres_pr"].Value);
                Txt_apellidos_pr.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["apellidos_pr"].Value);
                Txt_descripcion_sx.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["descripcion_sx"].Value);
                Txt_codigo_sx.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["codigo_sx"].Value);
                Txt_email_pr.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["email_pr"].Value);
                Txt_descripcion_ru.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["descripcion_ru"].Value);
                Txt_codigo_ru.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["codigo_ru"].Value);
                Txt_descripcion_di.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["distrito"].Value);
                Txt_codigo_di.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["codigo_di"].Value);               
                Txt_direccion_pr.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["direccion_pr"].Value);
                Txt_telefono_pr.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["telefono_pr"].Value);
                Txt_movil_pr.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["movil_pr"].Value);
            }
        }

        private void Estado_Limpiar(bool Lestado)
        {
            Btn_cancelar.Visible = Lestado;
            Btn_guardar.Visible = Lestado;
            Btn_retornar.Visible = !Lestado;

            Txt_buscar.Clear();
            Txt_codigo_pr.Text = "0";
            Txt_nrodocumento_pr.Text = "";
            Txt_razonsocial_pr.Text = "";
            Txt_nombres_pr.Text = "";
            Txt_apellidos_pr.Text = "";
            Txt_email_pr.Text = "";
            Txt_direccion_pr.Text = "";
            Txt_telefono_pr.Text = "";
            Txt_movil_pr.Text = "";
            Txt_nrodocumento_pr.ReadOnly = !Lestado;
            Txt_razonsocial_pr.ReadOnly = !Lestado;
            Txt_nombres_pr.ReadOnly = !Lestado;
            Txt_apellidos_pr.ReadOnly = !Lestado;
            Txt_email_pr.ReadOnly = !Lestado;
            Txt_direccion_pr.ReadOnly = !Lestado;
            Txt_telefono_pr.ReadOnly = !Lestado;
            Txt_movil_pr.ReadOnly = !Lestado;            
        }

        private void Estado_BotonesPrincipales(bool Lestado)
        {
            Btn_nuevo.Enabled = Lestado;
            Btn_actualizar.Enabled = Lestado;
            Btn_eliminar.Enabled = Lestado;
            Btn_reporte.Enabled = Lestado;
            Btn_salir.Enabled = Lestado;
            btn_lupa1.Visible = !Lestado;
            btn_lupa2.Visible = !Lestado;
            btn_lupa3.Visible = !Lestado;
            btn_lupa4.Visible = !Lestado;

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

        private void Formato_tdn()
        {
            Dgv_Listado_tdn.Columns[0].Width = 200;
            Dgv_Listado_tdn.Columns[0].HeaderText = "TIPO DOCUMENTO";
            Dgv_Listado_tdn.Columns[1].Visible = false;
        }

        private void Listar_tdn(string Ctexto)
        {
            try
            {
                Dgv_Listado_tdn.DataSource = N_Proveedores.Listar_tdn(Ctexto);
                this.Formato_tdn();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Selecciona_dgv_tdn()
        {
            Txt_codigo_tdn.Text = Convert.ToString(Dgv_Listado_tdn.CurrentRow.Cells["codigo_tdn"].Value);
            Txt_descripcion_tdn.Text = Convert.ToString(Dgv_Listado_tdn.CurrentRow.Cells["descripcion_tdn"].Value);
        }

        private void Formato_sx()
        {
            Dgv_Listado_sx.Columns[0].Width = 200;
            Dgv_Listado_sx.Columns[0].HeaderText = "SEXO";
            Dgv_Listado_sx.Columns[1].Visible = false;
        }

        private void Listar_sx(string Ctexto)
        {
            try
            {
                Dgv_Listado_sx.DataSource = N_Proveedores.Listar_sx(Ctexto);
                this.Formato_sx();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Selecciona_dgv_sx()
        {
            Txt_codigo_sx.Text = Convert.ToString(Dgv_Listado_sx.CurrentRow.Cells["codigo_sx"].Value);
            Txt_descripcion_sx.Text = Convert.ToString(Dgv_Listado_sx.CurrentRow.Cells["descripcion_sx"].Value);
        }

        private void Formato_ru()
        {
            Dgv_Listado_ru.Columns[0].Width = 200;
            Dgv_Listado_ru.Columns[0].HeaderText = "RUBRO";
            Dgv_Listado_ru.Columns[1].Visible = false;
        }

        private void Listar_ru(string Ctexto)
        {
            try
            {
                Dgv_Listado_ru.DataSource = N_Proveedores.Listar_ru(Ctexto);
                this.Formato_ru();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Selecciona_dgv_ru()
        {
            Txt_codigo_ru.Text = Convert.ToString(Dgv_Listado_ru.CurrentRow.Cells["codigo_ru"].Value);
            Txt_descripcion_ru.Text = Convert.ToString(Dgv_Listado_ru.CurrentRow.Cells["descripcion_ru"].Value);
        }

        private void Formato_di()
        {
            Dgv_Listado_di.Columns[0].Width = 400;
            Dgv_Listado_di.Columns[0].HeaderText = "DISTRITO";
            Dgv_Listado_di.Columns[1].Visible = false;
        }

        private void Listar_di(string Ctexto)
        {
            try
            {
                Dgv_Listado_di.DataSource = N_Proveedores.Listar_di(Ctexto);
                this.Formato_di();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Selecciona_dgv_di()
        {
            Txt_codigo_di.Text = Convert.ToString(Dgv_Listado_di.CurrentRow.Cells["codigo_di"].Value);
            Txt_descripcion_di.Text = Convert.ToString(Dgv_Listado_di.CurrentRow.Cells["distrito"].Value);
        }
        #endregion
        private void Frm_Proveedores_Load(object sender, EventArgs e)
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
                if (Txt_codigo_pr.Text == string.Empty && 
                    Txt_codigo_tdn.Text == string.Empty &&
                    Txt_nrodocumento_pr.Text == string.Empty &&
                    Txt_razonsocial_pr.Text == string.Empty && 
                    Txt_codigo_sx.Text == string.Empty && 
                    Txt_codigo_ru.Text == string.Empty && 
                    Txt_codigo_di.Text == string.Empty)
                {
                    MessageBox.Show("Falta ingresar datos requeridos (*)", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    E_Proveedores Epr = new E_Proveedores();
                    string Cduplica, Rpta = "";
                    Epr.Codigo_pr = Convert.ToInt32(Txt_codigo_pr.Text);
                    Epr.Codigo_tdn = Convert.ToInt32(Txt_codigo_tdn.Text);
                    Epr.Nro_documento_pr = Txt_nrodocumento_pr.Text.Trim();
                    Epr.Razonsocial_pr = Txt_razonsocial_pr.Text.Trim();
                    Epr.Nombres_pr = Txt_nombres_pr.Text.Trim();
                    Epr.Apellidos_pr = Txt_apellidos_pr.Text.Trim();
                    Epr.Codigo_sx = Convert.ToInt32(Txt_codigo_sx.Text);
                    Epr.Email_pr = Txt_email_pr.Text.Trim();
                    Epr.Codigo_ru = Convert.ToInt32(Txt_codigo_ru.Text);
                    Epr.Codigo_di = Convert.ToInt32(Txt_codigo_di.Text);
                    Epr.Direccion_pr = Txt_direccion_pr.Text.Trim();
                    Epr.Telefono_pr = Txt_telefono_pr.Text.Trim();
                    Epr.Movil_pr = Txt_movil_pr.Text.Trim();                    
                    Epr.Estado = true;
                    // Verificamos si la información que se intenta guardar ya existe en la tabla
                    Cduplica = N_Proveedores.Verifica_duplicado_pr(this.EstadoGuarda, Epr.Codigo_pr, Epr.Razonsocial_pr);
                    if (Cduplica == "")
                    {
                        Rpta = N_Proveedores.Guardar_pr(this.EstadoGuarda, Epr);
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
            Txt_nrodocumento_pr.Select();
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
                Txt_nrodocumento_pr.Select();
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
                            Rpta = N_Proveedores.Eliminar_pr(Codigo);
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

        private void btn_lupa1_Click(object sender, EventArgs e)
        {
            Pnl_listado_tdn.Visible = true;
            Txt_buscar_tdn.Select();
            this.Listar_tdn(Txt_buscar_tdn.Text);
        }

        private void btn_lupa2_Click(object sender, EventArgs e)
        {            
            Pnl_listado_sx.Visible = true;
            Txt_buscar_sx.Select();
            this.Listar_sx(Txt_buscar_sx.Text);
        }

        private void btn_lupa3_Click(object sender, EventArgs e)
        {
            Pnl_listado_ru.Location = Pnl_listado_sx.Location;
            Pnl_listado_ru.Visible = true;
            Txt_buscar_ru.Select();
            this.Listar_ru(Txt_buscar_ru.Text);
        }

        private void btn_lupa4_Click(object sender, EventArgs e)
        {
            Pnl_listado_di.Location = Pnl_listado_sx.Location;
            Pnl_listado_di.Visible = true;
            Txt_buscar_di.Select();
            this.Listar_di(Txt_buscar_di.Text);
        }

        private void Btn_retornar_tdn_Click(object sender, EventArgs e)
        {
            Pnl_listado_tdn.Visible = false;
        }

        private void Btn_buscar_tdn_Click(object sender, EventArgs e)
        {
            this.Listar_tdn(Txt_buscar_tdn.Text);
        }

        private void Dgv_Listado_tdn_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_dgv_tdn();
            Pnl_listado_tdn.Visible = false;
            Txt_nrodocumento_pr.Select();
        }


        private void Btn_retornar_sx_Click(object sender, EventArgs e)
        {
            Pnl_listado_sx.Visible = false;
        }

        private void Btn_buscar_sx_Click(object sender, EventArgs e)
        {
            this.Listar_sx(Txt_buscar_sx.Text);
        }

        private void Dgv_Listado_sx_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_dgv_sx();
            Pnl_listado_sx.Visible = false;
            Txt_email_pr.Select();
        }

        private void Btn_retornar_ru_Click(object sender, EventArgs e)
        {
            Pnl_listado_ru.Visible = false;
        }

        private void Btn_buscar_ru_Click(object sender, EventArgs e)
        {
            this.Listar_ru(Txt_buscar_ru.Text);
        }

        private void Dgv_Listado_ru_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_dgv_ru();
            Pnl_listado_ru.Visible = false;
        }

        private void Btn_retornar_di_Click(object sender, EventArgs e)
        {
            Pnl_listado_di.Visible = false;
        }

        private void Btn_buscar_di_Click(object sender, EventArgs e)
        {
            this.Listar_di(Txt_buscar_di.Text);
        }

        private void Dgv_Listado_di_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_dgv_di();
            Pnl_listado_di.Visible = false;
            Txt_direccion_pr.Select();
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
