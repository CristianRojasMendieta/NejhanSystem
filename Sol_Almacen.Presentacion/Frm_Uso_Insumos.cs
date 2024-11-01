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
    public partial class Frm_Uso_Insumos : Form
    {
        public Frm_Uso_Insumos()
        {
            InitializeComponent();
        }

        #region "Mis Variables"
        int EstadoGuarda = 0;
        DataTable TablaDetalle = new DataTable(); // esta tabla es para el detalle
        #endregion

        #region "Detalle de la entrada de artículos"

        private void Formato_detalle()
        {
            Dgv_detalle.Columns[0].Width = 320;
            Dgv_detalle.Columns[0].HeaderText = "ARTÍCULO";
            Dgv_detalle.Columns[1].Width = 220;
            Dgv_detalle.Columns[1].HeaderText = "MARCA";
            Dgv_detalle.Columns[2].Width = 80;
            Dgv_detalle.Columns[2].HeaderText = "CANTIDAD";
            Dgv_detalle.Columns[3].Width = 100;
            Dgv_detalle.Columns[3].HeaderText = "U.MEDIDA";

            Dgv_detalle.Columns[4].Visible = false;
            Dgv_detalle.Columns[0].ReadOnly = true;
            Dgv_detalle.Columns[1].ReadOnly = true;
            Dgv_detalle.Columns[2].ReadOnly = true;
            Dgv_detalle.Columns[3].ReadOnly = true;
        }
        private void Crear_TablaDetalle()
        {
            this.TablaDetalle = new DataTable("TablaDetalle");
            this.TablaDetalle.Columns.Add("Descripcion_ar", System.Type.GetType("System.String"));
            this.TablaDetalle.Columns.Add("Descripcion_ma", System.Type.GetType("System.String"));
            this.TablaDetalle.Columns.Add("Cantidad", System.Type.GetType("System.Decimal"));
            this.TablaDetalle.Columns.Add("Descripcion_um", System.Type.GetType("System.String"));                   
            this.TablaDetalle.Columns.Add("Codigo_ar", System.Type.GetType("System.Int32"));                      
            
            Dgv_detalle.DataSource = this.TablaDetalle;
            this.Formato_detalle();
           
        }

        private void Agregar_Item(string Cdescripcion_ar,
                                  string Cdescripcion_ma,
                                  decimal Ncantidad,
                                  string Cdescripcion_um,    
                                  int Ncodigo_ar)
        {
            DataRow xFila = TablaDetalle.NewRow();
            xFila["Descripcion_ar"] = Cdescripcion_ar;
            xFila["Descripcion_ma"] = Cdescripcion_ma;
            xFila["Cantidad"] = Ncantidad;
            xFila["Descripcion_um"] = Cdescripcion_um;                    
            xFila["Codigo_ar"] = Ncodigo_ar;           
            this.TablaDetalle.Rows.Add(xFila);
        }

        #endregion

        #region "Mis Métodos"
        private void Formato()
        {
            Dgv_Listado.Columns[0].Width = 100;
            Dgv_Listado.Columns[0].Visible = false;
            Dgv_Listado.Columns[1].Width = 90;
            Dgv_Listado.Columns[1].HeaderText = "CÓDIGO IN";
            Dgv_Listado.Columns[2].Width = 220;
            Dgv_Listado.Columns[2].HeaderText = "REFERENCIA";
            Dgv_Listado.Columns[3].Width = 120;
            Dgv_Listado.Columns[3].HeaderText = "FECHA REGISTRO";            
            Dgv_Listado.Columns[4].Width = 150;
            Dgv_Listado.Columns[4].HeaderText = "ALMACEN";
            Dgv_Listado.Columns[5].Width = 160;
            Dgv_Listado.Columns[5].HeaderText = "USUARIO";
            Dgv_Listado.Columns[6].Visible = false;
            Dgv_Listado.Columns[7].Visible = false;         

        }

        private void Mostrar(string Ctexto)
        {
            try
            {
                Dgv_Listado.DataSource = N_Uso_Insumos.Mostrar_in(Ctexto);
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
            if (String.IsNullOrEmpty(Convert.ToString(Dgv_Listado.CurrentRow.Cells["codigo_in"].Value)))
            {
                MessageBox.Show("Seleccione un registro ", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Txt_codigo_in.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["codigo_in"].Value);               
                Txt_descripcion_al.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["descripcion_al"].Value);
                Txt_codigo_al.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["codigo_al"].Value);
                Dtp_fecha_in.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["fecha_in"].Value);
                Txt_referencia_in.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["referencia_in"].Value);              
                Txt_observacion_in.Text= Convert.ToString(Dgv_Listado.CurrentRow.Cells["observacion_in"].Value);
                Dgv_detalle.DataSource = N_Uso_Insumos.Mostrar_detalle_in(Convert.ToInt32(Txt_codigo_in.Text));
                this.Formato_detalle();
            }
        }

        private void Estado_Limpiar(bool Lestado)
        {
            Btn_cancelar.Visible = Lestado;
            Btn_guardar.Visible = Lestado;           
            Txt_buscar.Clear();
            Txt_codigo_in.Text = "0";
            Txt_referencia_in.Text = "";           
            Txt_observacion_in.Text = "";
            TablaDetalle.Clear();
            TablaDetalle.AcceptChanges();
            Txt_referencia_in.ReadOnly = !Lestado;
            Dtp_fecha_in.Enabled = Lestado;          
            Txt_observacion_in.ReadOnly = !Lestado;           
        }

        private void Estado_BotonesPrincipales(bool Lestado)
        {
            Btn_nuevo.Enabled = Lestado;           
            Btn_eliminar.Enabled = Lestado;           
            Btn_salir.Enabled = Lestado;            
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

        private void Formato_al()
        {
            Dgv_Listado_al.Columns[0].Width = 300;
            Dgv_Listado_al.Columns[0].HeaderText = "ALMACÉN";
            Dgv_Listado_al.Columns[1].Visible = false;
        }

        private void Listar_al(string Ctexto)
        {
            try
            {
                Dgv_Listado_al.DataSource = N_Salida_Articulos.Listar_al(Ctexto);
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
            Dgv_Listado_ar.Columns[0].Width = 260;
            Dgv_Listado_ar.Columns[0].HeaderText = "ARTÍCULO";
            Dgv_Listado_ar.Columns[1].Width = 160;
            Dgv_Listado_ar.Columns[1].HeaderText = "MARCA.";
            Dgv_Listado_ar.Columns[2].Width = 120;
            Dgv_Listado_ar.Columns[2].HeaderText = "STOCK ACTUAL";
            Dgv_Listado_ar.Columns[3].Width = 80;
            Dgv_Listado_ar.Columns[3].HeaderText = "U.MEDIDA";
            Dgv_Listado_ar.Columns[4].Width = 160;
            Dgv_Listado_ar.Columns[4].HeaderText = "SUBGRUPO";
            Dgv_Listado_ar.Columns[5].Visible = false;
        }

        private void Listar_ar(string Ctexto, int Ncodigo_al)
        {
            try
            {
                Dgv_Listado_ar.DataSource = N_Uso_Insumos.Listar_ar(Ctexto,Ncodigo_al);
                this.Formato_ar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
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
                int Xcodigo_ar;
                decimal Xcantidad = Convert.ToDecimal(Dgv_Listado_ar.CurrentRow.Cells["stock_actual"].Value);                 
                Xdescripcion_ar = Convert.ToString(Dgv_Listado_ar.CurrentRow.Cells["descripcion_ar"].Value);
                Xdescripcion_ma = Convert.ToString(Dgv_Listado_ar.CurrentRow.Cells["descripcion_ma"].Value);
                Xdescripcion_um = Convert.ToString(Dgv_Listado_ar.CurrentRow.Cells["descripcion_um"].Value);
                Xcodigo_ar = Convert.ToInt32(Dgv_Listado_ar.CurrentRow.Cells["codigo_ar"].Value);           
                
                this.Agregar_Item(Xdescripcion_ar, Xdescripcion_ma, Xcantidad, Xdescripcion_um, Xcodigo_ar);
                TablaDetalle.AcceptChanges();
                int nRegistro = Dgv_detalle.Rows.Count;
                Dgv_detalle.CurrentCell = Dgv_detalle.Rows[nRegistro - 1].Cells[2];                           
            }  
        }      
        #endregion
        private void Frm_Uso_Insumos_Load(object sender, EventArgs e)
        {
            //this.Mostrar("%");
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
                if (Txt_codigo_al.Text == string.Empty )
                {
                    MessageBox.Show("Falta ingresar datos requeridos (*)", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    E_Uso_Insumos Eui = new E_Uso_Insumos();
                    string Rpta;
                    Eui.Codigo_us = MisVariables.Ncodigo_us;
                    Eui.Fecha_in = Dtp_fecha_in.Value;
                    Eui.Referencia_in = Txt_referencia_in.Text.Trim();
                    Eui.Codigo_al = Convert.ToInt32(Txt_codigo_al.Text);
                    Eui.Observacion_in = Txt_observacion_in.Text.Trim();                    
                    TablaDetalle.AcceptChanges();
                    // Verificamos si la información que se intenta guardar ya existe en la tabla
                        Rpta = N_Uso_Insumos.Guardar_in(Eui, TablaDetalle);
                    if (Rpta != String.Empty)
                    {
                        MessageBox.Show("Los datos han sido guardados correctamente con el código # " + Rpta, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Estado_Limpiar(false);
                            this.EstadoGuarda = 0;                            
                            //this.Mostrar("%");
                        Dgv_detalle.Columns[2].ReadOnly = true;
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
            Dgv_detalle.Columns[2].ReadOnly = false;
            Tbp_general.SelectedIndex = 0;
            Txt_referencia_in.Select();
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Estado_Limpiar(false);
            this.EstadoGuarda = 0;
            Dgv_detalle.Columns[2].ReadOnly = true;
            Tbp_general.SelectedIndex = 0;
            this.Estado_BotonesPrincipales(true);
        }      

        private void Dgv_Listado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Estado_Limpiar(false);
            this.Selecciona_dgv();
            Tbp_general.SelectedIndex = 0;
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
                            Rpta = N_Uso_Insumos.Eliminar_in(Codigo);
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
    

        private void btn_lupa3_Click(object sender, EventArgs e)
        {
            Pnl_listado_al.Location = btn_lupa3.Location;
            Pnl_listado_al.Visible = true;
            Txt_buscar_al.Select();
            this.Listar_al(Txt_buscar_al.Text);
        }       

        private void Btn_retornar_sg_Click(object sender, EventArgs e)
        {
            Pnl_listado_al.Visible = false;
        }

        private void Btn_buscar_sg_Click(object sender, EventArgs e)
        {
            this.Listar_al(Txt_buscar_al.Text);
        }

        private void Dgv_Listado_al_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_dgv_al();
            Pnl_listado_al.Visible = false;
            Txt_referencia_in.Focus();
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
            if (Txt_codigo_al.Text == string.Empty)
            {
                MessageBox.Show("Seleccione el Almacén antes de agregar artículos", "Aviso del Sistema");
            }
            else
            {
                this.Pnl_listado_ar.Location = this.Txt_referencia_in.Location;
                this.Pnl_listado_ar.Visible = true;
                Txt_buscar_ar.Select();
                this.Listar_ar(Txt_buscar_ar.Text, Convert.ToInt32(Txt_codigo_al.Text));
            }
            
        }

        private void Btn_buscar_ar_Click(object sender, EventArgs e)
        {
            this.Listar_ar(Txt_buscar_ar.Text,Convert.ToInt32(Txt_codigo_al.Text));
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
           /* if  (this.EstadoGuarda > 0)
            {
                DataRow Fila = (DataRow)TablaDetalle.Rows[e.RowIndex];
                decimal Precio = Convert.ToDecimal(Fila["Preciounitario_ea"]);
                decimal Cantidad = Convert.ToDecimal(Fila["Cantidad_ea"]);
                Fila["Total_ea"] = decimal.Round(Precio * Cantidad, 2).ToString("#0.00");              
            }   */       
        }

        private void Dgv_detalle_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (this.EstadoGuarda > 0)
            {
                //this.CalcularTotales();
            }                
        }

        private void Btn_quitar_Click(object sender, EventArgs e)
        {
            if (Dgv_detalle.SelectedRows.Count > 0)
            {
                Dgv_detalle.Rows.Remove(Dgv_detalle.CurrentRow);
                Dgv_detalle.Refresh();
                TablaDetalle.AcceptChanges();                
            }
        }
       
    }
}
