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
    public partial class Frm_Salida_Articulos : Form
    {
        public Frm_Salida_Articulos()
        {
            InitializeComponent();
        }

        #region "Mis Variables"
        int nCodigo_sa = 0;
        int EstadoGuarda = 0;
        DataTable TablaDetalle = new DataTable(); // esta tabla es para el detalle
        #endregion

        #region "Detalle de la entrada de artículos"
        private void Crear_TablaDetalle()
        {
            this.TablaDetalle = new DataTable("TablaDetalle");
            this.TablaDetalle.Columns.Add("Descripcion_ar", System.Type.GetType("System.String"));
            this.TablaDetalle.Columns.Add("Descripcion_ma", System.Type.GetType("System.String"));
            this.TablaDetalle.Columns.Add("Cantidad_sa", System.Type.GetType("System.Decimal"));
            this.TablaDetalle.Columns.Add("Descripcion_um", System.Type.GetType("System.String"));
            this.TablaDetalle.Columns.Add("Observacion", System.Type.GetType("System.String"));
            this.TablaDetalle.Columns.Add("Codigo_ar", System.Type.GetType("System.Int32"));
            this.TablaDetalle.Columns.Add("Codigo_sa", System.Type.GetType("System.Int32"));            
            
            Dgv_detalle.DataSource = this.TablaDetalle;

            Dgv_detalle.Columns[0].Width = 320;
            Dgv_detalle.Columns[0].HeaderText = "ARTÍCULO";
            Dgv_detalle.Columns[1].Width = 220;
            Dgv_detalle.Columns[1].HeaderText = "MARCA";
            Dgv_detalle.Columns[2].Width = 80;
            Dgv_detalle.Columns[2].HeaderText = "CANTIDAD";
            Dgv_detalle.Columns[3].Width = 100;
            Dgv_detalle.Columns[3].HeaderText = "U.MEDIDA";
            Dgv_detalle.Columns[4].Width = 250;
            Dgv_detalle.Columns[4].HeaderText = "OBSERVACIÓN";

            Dgv_detalle.Columns[5].Visible = false;
            Dgv_detalle.Columns[6].Visible = false;
            Dgv_detalle.Columns[0].ReadOnly = true;
            Dgv_detalle.Columns[1].ReadOnly = true;
            Dgv_detalle.Columns[3].ReadOnly = true;
            Dgv_detalle.Columns[4].ReadOnly = true;
        }

        private void Agregar_Item(string Cdescripcion_ar,
                                  string Cdescripcion_ma,
                                  decimal Ncantidad_sa,
                                  string Cdescripcion_um,
                                  string Cobservacion,
                                  int Ncodigo_ar,
                                  int Ncodigo_sa)
        {
            DataRow xFila = TablaDetalle.NewRow();
            xFila["Descripcion_ar"] = Cdescripcion_ar;
            xFila["Descripcion_ma"] = Cdescripcion_ma;
            xFila["Cantidad_sa"] = Ncantidad_sa;
            xFila["Descripcion_um"] = Cdescripcion_um;
            xFila["Observacion"] = Cobservacion;
            xFila["Codigo_ar"] = Ncodigo_ar;
            xFila["Codigo_sa"] = Ncodigo_sa;
            this.TablaDetalle.Rows.Add(xFila);
        }

        #endregion

        #region "Mis Métodos"
        private void Formato()
        {
            Dgv_Listado.Columns[0].Width = 100;
            Dgv_Listado.Columns[0].Visible = false;
            Dgv_Listado.Columns[1].Width = 90;
            Dgv_Listado.Columns[1].HeaderText = "CÓDIGO SA";
            Dgv_Listado.Columns[2].Width = 220;
            Dgv_Listado.Columns[2].HeaderText = "REFERENCIA";
            Dgv_Listado.Columns[3].Width = 120;
            Dgv_Listado.Columns[3].HeaderText = "FECHA PEDIDO";            
            Dgv_Listado.Columns[4].Width = 150;
            Dgv_Listado.Columns[4].HeaderText = "ALMACEN";
            Dgv_Listado.Columns[5].Width = 160;
            Dgv_Listado.Columns[5].HeaderText = "USUARIO";
            Dgv_Listado.Columns[6].Width = 130;
            Dgv_Listado.Columns[6].HeaderText = "EST. APROBADO";
            Dgv_Listado.Columns[7].Width = 130;
            Dgv_Listado.Columns[7].HeaderText = "EST. ENTREGADO";
            Dgv_Listado.Columns[8].Visible = false;
            Dgv_Listado.Columns[9].Visible = false;         

        }

        private void Mostrar(string Ctexto)
        {
            try
            {
                Dgv_Listado.DataSource = N_Salida_Articulos.Mostrar_sa(Ctexto);
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
            if (String.IsNullOrEmpty(Convert.ToString(Dgv_Listado.CurrentRow.Cells["codigo_sa"].Value)))
            {
                MessageBox.Show("Seleccione un registro ", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Txt_codigo_sa.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["codigo_sa"].Value);               
                Txt_descripcion_al.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["descripcion_al"].Value);
                Txt_codigo_al.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["codigo_al"].Value);
                Dtp_fecha_pe.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["fecha_pe"].Value);
                Txt_referencia_sa.Text = Convert.ToString(Dgv_Listado.CurrentRow.Cells["referencia_sa"].Value);              
                Txt_observacion_sa.Text= Convert.ToString(Dgv_Listado.CurrentRow.Cells["observacion_sa"].Value);
                
                this.Mostrar_Detalle_sa(this.EstadoGuarda, Convert.ToInt32(Txt_codigo_sa.Text));
            }
        }

        private void Estado_Limpiar(bool Lestado)
        {
            Btn_cancelar.Visible = Lestado;
            Btn_guardar.Visible = Lestado;
            Btn_retornar.Visible = !Lestado;
            Txt_buscar.Clear();
            Txt_codigo_sa.Text = "0";
            Txt_referencia_sa.Text = "";           
            Txt_observacion_sa.Text = "";
            TablaDetalle.Clear();
            TablaDetalle.AcceptChanges();
            Txt_referencia_sa.ReadOnly = !Lestado;
            Dtp_fecha_pe.Enabled = Lestado;          
            Txt_observacion_sa.ReadOnly = !Lestado;           
        }

        private void Estado_BotonesPrincipales(bool Lestado)
        {
            Btn_nuevo.Enabled = Lestado;
            Btn_actualizar.Enabled = Lestado;
            Btn_eliminar.Enabled = Lestado;
            Btn_reporte.Enabled = Lestado;
            Btn_salir.Enabled = Lestado;
            if (this.EstadoGuarda==1)
            {
                btn_lupa3.Visible = true;
            }
            else
            {
                btn_lupa3.Visible = false;
            }
           
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
                Dgv_Listado_ar.DataSource = N_Salida_Articulos.Listar_ar(Ctexto,Ncodigo_al);
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
                string Xdescripcion_ar, Xdescripcion_ma, Xdescripcion_um, Xobservacion;
                int Xcodigo_ar, Xcodigo_sa;
                decimal Xcantidad_ea = Convert.ToDecimal(Dgv_Listado_ar.CurrentRow.Cells["stock_actual"].Value);                 
                Xdescripcion_ar = Convert.ToString(Dgv_Listado_ar.CurrentRow.Cells["descripcion_ar"].Value);
                Xdescripcion_ma = Convert.ToString(Dgv_Listado_ar.CurrentRow.Cells["descripcion_ma"].Value);
                Xdescripcion_um = Convert.ToString(Dgv_Listado_ar.CurrentRow.Cells["descripcion_um"].Value);
                Xobservacion = " ";

                Xcodigo_ar = Convert.ToInt32(Dgv_Listado_ar.CurrentRow.Cells["codigo_ar"].Value);
                Xcodigo_sa = 0;
                this.Agregar_Item(Xdescripcion_ar, 
                                  Xdescripcion_ma, 
                                  Xcantidad_ea, 
                                  Xdescripcion_um, 
                                  Xobservacion,
                                  Xcodigo_ar, 
                                  Xcodigo_sa);
                TablaDetalle.AcceptChanges();
                int nRegistro = Dgv_detalle.Rows.Count;
                Dgv_detalle.CurrentCell = Dgv_detalle.Rows[nRegistro - 1].Cells[2];                           
            }            

        }

        private void Evalua_Aprobar_Entregar()
        {
            if (MisVariables.Ncodigo_ru==1 && (MisVariables.Ncodigo_ca==1 || MisVariables.Ncodigo_ca==2) || MisVariables.Ncodigo_ca==10)
            {
                Btn_aprobar.Visible = true;
                Btn_quitar_aprobar.Visible = true;
            }
            else
            {
                Btn_aprobar.Visible = false;
                Btn_quitar_aprobar.Visible = false;
            }

            if (MisVariables.Ncodigo_ca==11 || MisVariables.Ncodigo_ca==10) //Encargado de Almacén o IT Sistemas
            {
                Btn_entregar.Visible = true;
                Btn_reimprimir.Visible = true;
            }
            else
            {
                Btn_entregar.Visible = false;
                Btn_reimprimir.Visible = false;
            }
        }

        private void Mostrar_Detalle_sa(int Nopcion, int Ncodigo)
        {
            try
            {
                DataTable Tablatemp = new DataTable();
                Tablatemp = N_Salida_Articulos.Mostrar_detalle_sa(Ncodigo);
                TablaDetalle.Clear();
                TablaDetalle.AcceptChanges();
               
                for (int Nfila = 0; Nfila <= Tablatemp.Rows.Count - 1; Nfila++)
                {
                    this.Agregar_Item(Convert.ToString(Tablatemp.Rows[Nfila][0]),
                                      Convert.ToString(Tablatemp.Rows[Nfila][1]),
                                      Convert.ToDecimal(Tablatemp.Rows[Nfila][2]),
                                      Convert.ToString(Tablatemp.Rows[Nfila][3]),
                                      Convert.ToString(Tablatemp.Rows[Nfila][4]),
                                      Convert.ToInt32(Tablatemp.Rows[Nfila][5]),
                                      Convert.ToInt32(Tablatemp.Rows[Nfila][6]));

                }
                TablaDetalle.AcceptChanges();

                Dgv_detalle.DataSource = TablaDetalle;
                if (Nopcion >= 1)
                {
                    Dgv_detalle.Columns["cantidad_sa"].ReadOnly = false;
                    Dgv_detalle.Columns["observacion"].ReadOnly = false;
                }
                else
                {
                    Dgv_detalle.Columns["cantidad_sa"].ReadOnly = true;
                    Dgv_detalle.Columns["observacion"].ReadOnly = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        #endregion
        private void Frm_Salida_Articulos_Load(object sender, EventArgs e)
        {
            this.Mostrar("%");
            this.Crear_TablaDetalle();
            this.Evalua_Aprobar_Entregar();
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
                    E_Salida_Articulos Esa = new E_Salida_Articulos();
                    string Rpta;
                    Esa.Codigo_sa = this.nCodigo_sa;
                    Esa.Codigo_us = MisVariables.Ncodigo_us;
                    Esa.Fecha_pe = Dtp_fecha_pe.Value;
                    Esa.Referencia_sa = Txt_referencia_sa.Text.Trim();
                    Esa.Codigo_al = Convert.ToInt32(Txt_codigo_al.Text); 
                    Esa.Observacion_sa = Txt_observacion_sa.Text.Trim();
                    Esa.Estado = true;
                    Esa.Aprobado = false;
                    Esa.Entregado = false;
                    TablaDetalle.AcceptChanges();
                    // Verificamos si la información que se intenta guardar ya existe en la tabla
                        Rpta = N_Salida_Articulos.Guardar_sa(this.EstadoGuarda,Esa, TablaDetalle);
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
            this.nCodigo_sa = 0;
            this.Estado_BotonesPrincipales(false);
            this.Estado_Limpiar(true);
            Tbp_general.SelectedIndex = 1;
            Dgv_detalle.Columns["cantidad_sa"].ReadOnly = false;
            Dgv_detalle.Columns["observacion"].ReadOnly = false;
            Txt_referencia_sa.Select();
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Estado_Limpiar(false);
            this.EstadoGuarda = 0;
            Dgv_detalle.Columns["cantidad_sa"].ReadOnly = true;
            Dgv_detalle.Columns["observacion"].ReadOnly = true;
            Tbp_general.SelectedIndex = 0;
            this.Estado_BotonesPrincipales(true);
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            this.EstadoGuarda = 2; //Actualizar registro
            try
            {
                if (Dgv_Listado.Rows.Count > 0)
                {
                    
                    String Referencia;
                    string Est_Aprobado;               
                  
                    this.nCodigo_sa = Convert.ToInt32(Dgv_Listado.CurrentRow.Cells["codigo_sa"].Value);
                    Referencia = Convert.ToString(Dgv_Listado.CurrentRow.Cells["referencia_sa"].Value);
                    Est_Aprobado = Convert.ToString(Dgv_Listado.CurrentRow.Cells["aprobado"].Value).Trim();                    

                    if (Est_Aprobado.Equals("PENDIENTE"))
                    {
                        this.Estado_Limpiar(true);                        
                        this.Selecciona_dgv();
                        this.Estado_BotonesPrincipales(false);
                        Tbp_general.SelectedIndex = 1;
                    }
                    else //Aplicar este caso cuando no tiene aprobación el pedido
                    {
                        MessageBox.Show("Pedido # " + this.nCodigo_sa + " con Referencia: " + Referencia + " No se puede actualizar. Se requiere que quiten la aprobación para actualizar el pedido", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
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
                            Rpta = N_Salida_Articulos.Eliminar_sa(Codigo);
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
            MessageBox.Show("Se encuentra en mantenimiento", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //if (Dgv_Listado.Rows.Count > 0)
            //{
                //this.Estado_BotonesPrincipales(false);
                //Dgv_Listado.Columns[0].Visible = true;
                //Btn_cancelar2.Visible = true;
                //Btn_confirmar.Visible = true;
                //Tbp_general.SelectedIndex = 0;
            //}

        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_reporte_Click(object sender, EventArgs e)
        {

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
            Txt_referencia_sa.Focus();
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
            this.Pnl_listado_ar.Location = this.Txt_referencia_sa.Location;
            this.Pnl_listado_ar.Visible = true;
            Txt_buscar_ar.Select();
            this.Listar_ar(Txt_buscar_ar.Text,Convert.ToInt32(Txt_codigo_al.Text));
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

        private void Btn_aprobar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Dgv_Listado.Rows.Count>0)
                {
                    int Codigo;
                    string Referencia;
                    string Est_Aprobado;
                    string Rpta = "";
                    Codigo = Convert.ToInt32(Dgv_Listado.CurrentRow.Cells["codigo_sa"].Value);
                    Referencia = Convert.ToString(Dgv_Listado.CurrentRow.Cells["referencia_sa"].Value);
                    Est_Aprobado= Convert.ToString(Dgv_Listado.CurrentRow.Cells["aprobado"].Value).Trim();

                    if (Est_Aprobado.Equals("PENDIENTE"))
                    {
                        DialogResult Opcion;
                        Opcion = MessageBox.Show("¿Aprobar el Nro de Salida # " + Codigo + " con Referencia: " + Referencia, "Aviso del Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (Opcion == DialogResult.OK)
                        {
                            Rpta = N_Salida_Articulos.Actualizar_aprobado_sa(Codigo, true,MisVariables.Ncodigo_us);
                            if (Rpta.Equals("OK"))
                            {
                                this.Mostrar(Txt_buscar.Text);
                                MessageBox.Show("Aprobación realizada", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show(Rpta, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }       
                }                             
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Btn_entregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Dgv_Listado.Rows.Count > 0)
                {
                    int Codigo;
                    string Referencia;
                    string Est_Aprobado;
                    string Est_Entregado;
                    string Rpta = "";
                    Codigo = Convert.ToInt32(Dgv_Listado.CurrentRow.Cells["codigo_sa"].Value);
                    Referencia = Convert.ToString(Dgv_Listado.CurrentRow.Cells["referencia_sa"].Value);
                    Est_Aprobado = Convert.ToString(Dgv_Listado.CurrentRow.Cells["aprobado"].Value).Trim();
                    Est_Entregado = Convert.ToString(Dgv_Listado.CurrentRow.Cells["entregado"].Value).Trim();

                    if (Est_Aprobado.Equals("APROBADO"))
                    {
                        if (Est_Entregado.Equals("PENDIENTE"))
                        {
                            DialogResult Opcion;
                            Opcion = MessageBox.Show("¿Entregar los artículos del Nro de Salida # " + Codigo + " con Referencia: " + Referencia, "Aviso del Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                            if (Opcion == DialogResult.OK)
                            {
                                Rpta = N_Salida_Articulos.Actualizar_entregado_sa(Codigo, true, MisVariables.Ncodigo_us);
                                if (Rpta.Equals("OK"))
                                {
                                    this.Mostrar(Txt_buscar.Text);
                                    Reportes.Frm_Rpt_Imprimir_Salida_Articulos ORpt_im_ar = new Reportes.Frm_Rpt_Imprimir_Salida_Articulos();
                                    ORpt_im_ar.Txt_p1.Text = Convert.ToString(Codigo).Trim();
                                    ORpt_im_ar.ShowDialog();
                                    MessageBox.Show("Salida de pedido entregado", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show(Rpta, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }                        
                       
                    }
                    else //Aplicar este caso cuando no tiene aprobación el pedido
                    {
                        MessageBox.Show("Pedido # " + Codigo + " con Referencia: " + Referencia+" no cuenta con aprobación. Se requiere aprobación para dar la entrega del pedido", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Btn_reimprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Dgv_Listado.Rows.Count > 0)
                {
                    int Codigo;
                    string Referencia;
                    string Est_Entregado;                  
                    Codigo = Convert.ToInt32(Dgv_Listado.CurrentRow.Cells["codigo_sa"].Value);
                    Referencia = Convert.ToString(Dgv_Listado.CurrentRow.Cells["referencia_sa"].Value);
                    Est_Entregado = Convert.ToString(Dgv_Listado.CurrentRow.Cells["entregado"].Value).Trim();

                    if (Est_Entregado.Equals("ENTREGADO"))
                    {
                        
                        Reportes.Frm_Rpt_Imprimir_Salida_Articulos ORpt_im_ar = new Reportes.Frm_Rpt_Imprimir_Salida_Articulos();
                        ORpt_im_ar.Txt_p1.Text = Convert.ToString(Codigo).Trim();
                        ORpt_im_ar.ShowDialog();
                              
                    }                    
                    else //Aplicar este caso cuando no tiene aprobación el pedido
                    {
                        MessageBox.Show("Pedido # " + Codigo + " con Referencia: " + Referencia + " no ha sido entregado aún", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Btn_quitar_aprobar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Dgv_Listado.Rows.Count > 0)
                {
                    int Codigo;
                    string Referencia;
                    string Est_Aprobado;
                    string Est_Entregado;
                    string Rpta = "";
                    Codigo = Convert.ToInt32(Dgv_Listado.CurrentRow.Cells["codigo_sa"].Value);
                    Referencia = Convert.ToString(Dgv_Listado.CurrentRow.Cells["referencia_sa"].Value);
                    Est_Aprobado = Convert.ToString(Dgv_Listado.CurrentRow.Cells["aprobado"].Value).Trim();
                    Est_Entregado = Convert.ToString(Dgv_Listado.CurrentRow.Cells["entregado"].Value).Trim();

                    if (Est_Aprobado.Equals("APROBADO") && Est_Entregado.Equals("PENDIENTE"))
                    {
                        DialogResult Opcion;
                        Opcion = MessageBox.Show("¿Quitar Aprobación al Nro de Salida # " + Codigo + " con Referencia: " + Referencia, "Aviso del Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (Opcion == DialogResult.OK)
                        {
                            Rpta = N_Salida_Articulos.Actualizar_aprobado_sa(Codigo, false, MisVariables.Ncodigo_us);
                            if (Rpta.Equals("OK"))
                            {
                                this.Mostrar(Txt_buscar.Text);
                                MessageBox.Show("Proceso realizado correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show(Rpta, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }else if (Est_Aprobado.Equals("APROBADO") && Est_Entregado.Equals("ENTREGADO"))
                    {
                        MessageBox.Show("No se puede quitar la aprobación, el pedido ya se encuentra entregado por Almacén", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    } 
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Btn_reporte_Click_1(object sender, EventArgs e)
        {

        }
    }
}
