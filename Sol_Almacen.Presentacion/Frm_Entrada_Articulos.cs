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
    public partial class Frm_Entrada_Articulos : Form
    {
        public Frm_Entrada_Articulos()
        {
            InitializeComponent();
        }

        #region "Mis Variables"
        int Codigo_ea = 0;
        int EstadoGuarda = 0;           
        DataTable TablaDetalle = new DataTable(); // esta tabla es para el detalle
        #endregion

        #region "Detalle de la entrada de artículos"
        private void Crear_TablaDetalle()
        {
            this.TablaDetalle = new DataTable("TablaDetalle");
            this.TablaDetalle.Columns.Add("Descripcion_ar", System.Type.GetType("System.String"));
            this.TablaDetalle.Columns.Add("Descripcion_ma", System.Type.GetType("System.String"));
            this.TablaDetalle.Columns.Add("Descripcion_um", System.Type.GetType("System.String"));
            this.TablaDetalle.Columns.Add("Cantidad_ea", System.Type.GetType("System.Decimal"));
            this.TablaDetalle.Columns.Add("Preciounitario_ea", System.Type.GetType("System.Decimal"));
            this.TablaDetalle.Columns.Add("Total_ea", System.Type.GetType("System.Decimal"));
            this.TablaDetalle.Columns.Add("Codigo_ar", System.Type.GetType("System.Int32"));
            this.TablaDetalle.Columns.Add("Codigo_ea", System.Type.GetType("System.Int32"));
            
            
            Dgv_detalle.DataSource = this.TablaDetalle;

            Dgv_detalle.Columns[0].Width = 320;
            Dgv_detalle.Columns[0].HeaderText = "ARTÍCULO";
            Dgv_detalle.Columns[1].Width = 220;
            Dgv_detalle.Columns[1].HeaderText = "MARCA";
            Dgv_detalle.Columns[2].Width = 100;
            Dgv_detalle.Columns[2].HeaderText = "U.MEDIDA";
            Dgv_detalle.Columns[3].Width = 80;
            Dgv_detalle.Columns[3].HeaderText = "CANTIDAD";
            Dgv_detalle.Columns[4].Width = 120;
            Dgv_detalle.Columns[4].HeaderText = "P.UNITARIO S/.";
            Dgv_detalle.Columns[5].Width = 120;
            Dgv_detalle.Columns[5].HeaderText = "TOTAL S/.";            
            Dgv_detalle.Columns[6].Visible = false;
            Dgv_detalle.Columns[7].Visible = false;
            Dgv_detalle.Columns[0].ReadOnly = true;
            Dgv_detalle.Columns[1].ReadOnly = true;
            Dgv_detalle.Columns[2].ReadOnly = true;
            Dgv_detalle.Columns[5].ReadOnly = true;            
        }

        private void Agregar_Item(string Cdescripcion_ar,
                                  string Cdescripcion_ma,
                                  string Cdescripcion_um,
                                  decimal Ncantidad_ea,
                                  decimal NPreciounitario_ea,
                                  decimal Ntotal_ea,
                                  int Ncodigo_ar,
                                  int Ncodigo_ea)
        {
            DataRow xFila = TablaDetalle.NewRow();
            xFila["Descripcion_ar"] = Cdescripcion_ar;
            xFila["Descripcion_ma"] = Cdescripcion_ma;
            xFila["Descripcion_um"] = Cdescripcion_um;
            xFila["Cantidad_ea"] = Ncantidad_ea;
            xFila["Preciounitario_ea"] = NPreciounitario_ea;
            xFila["Total_ea"] = Ntotal_ea;          
            xFila["Codigo_ar"] = Ncodigo_ar;
            xFila["Codigo_ea"] = Ncodigo_ea;
            this.TablaDetalle.Rows.Add(xFila);
        }

        #endregion

        #region "Mis Métodos"
        private void Formato()
        {
            Dgv_Listado.Columns[0].Width = 100;
            Dgv_Listado.Columns[0].Visible = false;
            Dgv_Listado.Columns[1].Width = 90;
            Dgv_Listado.Columns[1].HeaderText = "CÓDIGO EA";
            Dgv_Listado.Columns[2].Width = 300;
            Dgv_Listado.Columns[2].HeaderText = "PROVEEDOR";
            Dgv_Listado.Columns[3].Width = 90;
            Dgv_Listado.Columns[3].HeaderText = "TIPO DOC.";            
            Dgv_Listado.Columns[4].Width = 100;
            Dgv_Listado.Columns[4].HeaderText = "NRO. DOC.";
            Dgv_Listado.Columns[5].Width = 120;
            Dgv_Listado.Columns[5].HeaderText = "T. IMPORTE S/.";
            Dgv_Listado.Columns[6].Width = 150;
            Dgv_Listado.Columns[6].HeaderText = "FECHA DOCUMENTO";
            Dgv_Listado.Columns[7].Width = 150;
            Dgv_Listado.Columns[7].HeaderText = "ALMACEN";
            Dgv_Listado.Columns[8].Visible = false;
            Dgv_Listado.Columns[9].Visible = false;
            Dgv_Listado.Columns[10].Visible = false;
            Dgv_Listado.Columns[11].Visible = false;

        }

        private void Mostrar(string Ctexto)
        {
            try
            {
                Dgv_Listado.DataSource = N_Entrada_Articulos.Mostrar_ea(Ctexto);
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
            if (String.IsNullOrEmpty(Convert.ToString(Dgv_Listado.CurrentRow.Cells["codigo_ea"].Value)))
            {
                MessageBox.Show("Seleccione un registro ", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Txt_codigo_ea.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["codigo_ea"].Value);
                Txt_codigo_co.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["codigo_co"].Value);
                Txt_descripcion_co.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["descripcion_co"].Value);
                Txt_proveedor.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["proveedor"].Value);
                Txt_codigo_pr.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["codigo_pr"].Value);
                Txt_descripcion_al.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["descripcion_al"].Value);
                Txt_codigo_al.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["codigo_al"].Value);
                Dtp_fecha_ea.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["fecha_ea"].Value);
                Txt_nrodocumento_ea.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["nrodocumento_ea"].Value);
                Txt_subtotal.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["subtotal"].Value);
                Txt_igv.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["igv"].Value);
                Txt_total_importe.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["total_importe"].Value);
                Txt_observacion_ea.Text= Convert.ToString(Dgv_Listado.CurrentRow.Cells["observacion_ea"].Value);

                Dgv_detalle.DataSource = N_Entrada_Articulos.Mostrar_detalle_ea(Convert.ToInt32(Txt_codigo_ea.Text));
            }
        }

        private void Estado_Limpiar(bool Lestado)
        {
            Btn_cancelar.Visible = Lestado;
            Btn_guardar.Visible = Lestado;
            Btn_retornar.Visible = !Lestado;
            Txt_buscar.Clear();
            Txt_codigo_ea.Text = "0";            
            Txt_proveedor.Text = "";
            Txt_codigo_pr.Text = "";
            Txt_nrodocumento_ea.Text = "";
            Txt_subtotal.Text = "0";
            Txt_igv.Text = "0";
            Txt_total_importe.Text = "0";
            Txt_observacion_ea.Text = "";
            TablaDetalle.Clear();
            TablaDetalle.AcceptChanges();
            Txt_nrodocumento_ea.ReadOnly = !Lestado;
            Dtp_fecha_ea.Enabled = Lestado;          
            Txt_observacion_ea.ReadOnly = !Lestado;           
        }

        private void Estado_BotonesPrincipales(bool Lestado)
        {
            Btn_nuevo.Enabled = Lestado;           
            Btn_eliminar.Enabled = Lestado;
            Btn_reporte.Enabled = Lestado;
            Btn_salir.Enabled = Lestado;
            btn_lupa.Visible = !Lestado;
            btn_lupa2.Visible = !Lestado;
            btn_lupa3.Visible = !Lestado;
            Btn_agregar.Visible = !Lestado;
            Btn_quitar.Visible = !Lestado;

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

        private void Formato_pr()
        {
            Dgv_Listado_pr.Columns[0].Width = 320;
            Dgv_Listado_pr.Columns[0].HeaderText = "PROVEEDOR";
            Dgv_Listado_pr.Columns[1].Width = 100;
            Dgv_Listado_pr.Columns[1].HeaderText = "NRO DOC.";
            Dgv_Listado_pr.Columns[2].Visible = false;
        }

        private void Listar_pr(string Ctexto)
        {
            try
            {
                Dgv_Listado_pr.DataSource = N_Entrada_Articulos.Listar_pr(Ctexto);
                this.Formato_pr();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Selecciona_dgv_pr()
        {
            Txt_codigo_pr.Text = Convert.ToString(Dgv_Listado_pr.CurrentRow.Cells["codigo_pr"].Value);
            Txt_proveedor.Text = Convert.ToString(Dgv_Listado_pr.CurrentRow.Cells["proveedor"].Value);
        }

        private void Formato_co()
        {
            Dgv_Listado_co.Columns[0].Width = 250;
            Dgv_Listado_co.Columns[0].HeaderText = "TIPO DOC.";
            Dgv_Listado_co.Columns[1].Visible = false;
        }

        private void Listar_co(string Ctexto)
        {
            try
            {
                Dgv_Listado_co.DataSource = N_Entrada_Articulos.Listar_co(Ctexto);
                this.Formato_co();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Selecciona_dgv_co()
        {
            Txt_codigo_co.Text = Convert.ToString(Dgv_Listado_co.CurrentRow.Cells["codigo_co"].Value);
            Txt_descripcion_co.Text = Convert.ToString(Dgv_Listado_co.CurrentRow.Cells["descripcion_co"].Value);
        }

        private void Formato_al()
        {
            Dgv_Listado_al.Columns[0].Width = 300;
            Dgv_Listado_al.Columns[0].HeaderText = "ALMACÉN";
            Dgv_Listado_al.Columns[1].Visible = false;
        }

        private void Listar_al()
        {
            try
            {
                Dgv_Listado_al.DataSource = N_Entrada_Articulos.Listar_al();
                this.Formato_al();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Selecciona_dgv_al()
        {
            Txt_codigo_al.Text = Convert.ToString(Dgv_Listado_al.CurrentRow.Cells["codigo_al"].Value);
            Txt_descripcion_al.Text = Convert.ToString(Dgv_Listado_al.CurrentRow.Cells["descripcion_al"].Value);
        }

        private void Formato_ar()
        {
            Dgv_Listado_ar.Columns[0].Width = 280;
            Dgv_Listado_ar.Columns[0].HeaderText = "ARTÍCULO";
            Dgv_Listado_ar.Columns[1].Width = 180;
            Dgv_Listado_ar.Columns[1].HeaderText = "MARCA.";
            Dgv_Listado_ar.Columns[2].Width = 80;
            Dgv_Listado_ar.Columns[2].HeaderText = "U.MEDIDA";
            Dgv_Listado_ar.Columns[3].Width = 180;
            Dgv_Listado_ar.Columns[3].HeaderText = "SUBGRUPO";
            Dgv_Listado_ar.Columns[4].Visible = false;
        }

        private void Listar_ar(string Ctexto)
        {
            try
            {
                Dgv_Listado_ar.DataSource = N_Entrada_Articulos.Listar_ar(Ctexto);
                this.Formato_ar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void CalcularTotales()
        {                       
            decimal Total = 0;
            decimal SubTotal = 0;
            decimal Igv = 0;
            if (Dgv_detalle.Rows.Count==0)
            {
                Total = 0;
            }
            else
            {
                TablaDetalle.AcceptChanges();
                foreach (DataRow FilaTemp in TablaDetalle.Rows)
                {
                    Total = Total + Convert.ToDecimal(FilaTemp["Total_ea"]);
                }
            }            
                 
            SubTotal = Total / (1 + Convert.ToDecimal("0.18"));
            Igv = (Total - SubTotal);
            Txt_total_importe.Text = decimal.Round(Total,2).ToString("#0.00");
            Txt_igv.Text = decimal.Round(Igv,2).ToString("#0.00#");
            Txt_subtotal.Text = decimal.Round(SubTotal, 2).ToString("#0.00");
        }

        private void Selecciona_dgv_ar()
        {

            bool Agregar = true;
            int Vcodigo_ar= Convert.ToInt32(Dgv_Listado_ar.CurrentRow.Cells["codigo_ar"].Value);
            foreach (DataRow FilaTemp in TablaDetalle.Rows)
            {
                if (Convert.ToInt32(FilaTemp["codigo_ar"])== Vcodigo_ar)
                {
                    Agregar = false;
                    MessageBox.Show("El artículo ya se encuentra agregado", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            if (Agregar==true)
            {
                string Xdescripcion_ar, Xdescripcion_ma, Xdescripcion_um;
                int Xcodigo_ar, Xcodigo_ea;
                decimal Xcantidad_ea = Convert.ToDecimal("0.00"), Xpreciounitario_ea = Convert.ToDecimal("0.00"), Xtotal_ea = Convert.ToDecimal("0.00");
                Xdescripcion_ar = Convert.ToString(Dgv_Listado_ar.CurrentRow.Cells["descripcion_ar"].Value);
                Xdescripcion_ma = Convert.ToString(Dgv_Listado_ar.CurrentRow.Cells["descripcion_ma"].Value);
                Xdescripcion_um = Convert.ToString(Dgv_Listado_ar.CurrentRow.Cells["descripcion_um"].Value);

                Xcodigo_ar = Convert.ToInt32(Dgv_Listado_ar.CurrentRow.Cells["codigo_ar"].Value);
                Xcodigo_ea = 0;
                this.Agregar_Item(Xdescripcion_ar, Xdescripcion_ma, Xdescripcion_um, Xcantidad_ea, Xpreciounitario_ea, Xtotal_ea, Xcodigo_ar, Xcodigo_ea);
                TablaDetalle.AcceptChanges();
                int nRegistro = Dgv_detalle.Rows.Count;
                Dgv_detalle.CurrentCell = Dgv_detalle.Rows[nRegistro - 1].Cells[3];                             
            }            

        }
        #endregion
        private void Frm_Entrada_Articulos_Load(object sender, EventArgs e)
        {
            this.Mostrar("%");
            this.Crear_TablaDetalle();
        }
       
        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            this.Mostrar(Txt_buscar.Text);
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Txt_codigo_ea.Text == string.Empty ||
                    Txt_codigo_pr.Text == string.Empty || 
                    Txt_codigo_co.Text == string.Empty || 
                    Txt_codigo_al.Text == string.Empty || 
                    Txt_nrodocumento_ea.Text == string.Empty)
                {
                    MessageBox.Show("Falta ingresar datos requeridos (*)", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    E_Entrada_Articulos Eea = new E_Entrada_Articulos();
                    string Rpta;
                    Eea.Codigo_al = Convert.ToInt32(Txt_codigo_al.Text);
                    Eea.Codigo_co = Convert.ToInt32(Txt_codigo_co.Text);
                    Eea.Codigo_pr = Convert.ToInt32(Txt_codigo_pr.Text);
                    Eea.Codigo_us = MisVariables.Ncodigo_us;
                    Eea.Fecha_emision_doc = Dtp_fecha_ea.Value;
                    Eea.Nrodocumento_ea = Txt_nrodocumento_ea.Text.Trim();
                    Eea.Subtotal = Convert.ToDecimal(Txt_subtotal.Text);
                    Eea.Igv = Convert.ToDecimal(Txt_igv.Text);
                    Eea.Total_importe = Convert.ToDecimal(Txt_total_importe.Text);
                    Eea.Observacion_ea = Txt_observacion_ea.Text.Trim();
                    Eea.Estado = true;
                    TablaDetalle.AcceptChanges();
                    // Verificamos si la información que se intenta guardar ya existe en la tabla
                        Rpta = N_Entrada_Articulos.Guardar_ea(Eea, TablaDetalle);
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
            Txt_nrodocumento_ea.Select();
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
                Txt_nrodocumento_ea.Select();
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
                            Rpta = N_Entrada_Articulos.Eliminar_ea(Codigo);
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
            if (Dgv_Listado.Rows.Count>0)
            {
                this.Codigo_ea = Convert.ToInt32(Convert.ToString(Dgv_Listado.CurrentRow.Cells["codigo_ea"].Value));
                Reportes.Frm_Rpt_Imprimir_Entrada_Articulos oRpt_ea = new Reportes.Frm_Rpt_Imprimir_Entrada_Articulos();

                oRpt_ea.Txt_p1.Text = Convert.ToString(this.Codigo_ea);
                oRpt_ea.ShowDialog();
            }
            
        }

        private void btn_lupa_Click(object sender, EventArgs e)
        {
            Pnl_listado_pr.Location = btn_lupa.Location;
            Pnl_listado_pr.Visible = true;
            Txt_buscar_pr.Select();
            this.Listar_pr(Txt_buscar_pr.Text);
        }

        private void btn_lupa2_Click(object sender, EventArgs e)
        {
            Pnl_listado_co.Location = btn_lupa2.Location;
            Pnl_listado_co.Visible = true;
            Txt_buscar_co.Select();
            this.Listar_co(Txt_buscar_pr.Text);
        }

        private void btn_lupa3_Click(object sender, EventArgs e)
        {
            Pnl_listado_al.Location = btn_lupa3.Location;
            Pnl_listado_al.Visible = true;           
            this.Listar_al();
        }

        private void Btn_retornar_ma_Click(object sender, EventArgs e)
        {
            Pnl_listado_co.Visible = false;
        }

        private void Btn_buscar_ma_Click(object sender, EventArgs e)
        {
            this.Listar_co(Txt_buscar_co.Text);
        }

        private void Dgv_Listado_co_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_dgv_co();
            Pnl_listado_co.Visible = false;
        }


        private void Btn_retornar_um_Click(object sender, EventArgs e)
        {
            Pnl_listado_pr.Visible = false;
        }

        private void Btn_buscar_pr_Click(object sender, EventArgs e)
        {
            this.Listar_pr(Txt_buscar_pr.Text);
        }

        private void Dgv_Listado_pr_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_dgv_pr();
            Pnl_listado_pr.Visible = false;
        }       

        private void Dgv_Listado_al_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_dgv_al();
            Pnl_listado_al.Visible = false;
            Txt_nrodocumento_ea.Focus();
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

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            this.Pnl_listado_ar.Location = this.Txt_descripcion_al.Location;
            this.Pnl_listado_ar.Visible = true;
            Txt_buscar_ar.Select();
            this.Listar_ar(Txt_buscar_ar.Text);
        }

        private void Btn_buscar_ar_Click(object sender, EventArgs e)
        {
            this.Listar_ar(Txt_buscar_ar.Text);
        }

        private void Btn_retornar_ar_Click(object sender, EventArgs e)
        {
            Pnl_listado_ar.Visible = false;
        }

        private void Dgv_Listado_ar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.TablaDetalle.AcceptChanges();
            this.Dgv_detalle.Refresh();
            this.Selecciona_dgv_ar();
            Pnl_listado_ar.Visible = false;
        }

        private void Dgv_detalle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if  (this.EstadoGuarda > 0)
            {
                DataRow Fila = (DataRow)TablaDetalle.Rows[e.RowIndex];
                decimal Precio = Convert.ToDecimal(Fila["Preciounitario_ea"]);
                decimal Cantidad = Convert.ToDecimal(Fila["Cantidad_ea"]);
                Fila["Total_ea"] = decimal.Round(Precio * Cantidad, 2).ToString("#0.00");

                this.CalcularTotales();
            }          
        }

        private void Dgv_detalle_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (this.EstadoGuarda > 0)
            {
                this.CalcularTotales();
            }                
        }

        private void Btn_quitar_Click(object sender, EventArgs e)
        {
            if (Dgv_detalle.SelectedRows.Count > 0)
            {
                Dgv_detalle.Rows.Remove(Dgv_detalle.CurrentRow);
                Dgv_detalle.Refresh();
                TablaDetalle.AcceptChanges();
                this.CalcularTotales();
            }
        }

        private void Btn_retornar_al_Click(object sender, EventArgs e)
        {
            Pnl_listado_al.Visible = false;
        }
                
    }
}
