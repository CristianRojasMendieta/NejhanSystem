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
    public partial class Frm_Inventarios : Form
    {
        public Frm_Inventarios()
        {
            InitializeComponent();
        }
        #region "Mis Variables"
        int nCodigo_al = 0;
        DataTable Dtdetalle = new DataTable();
        #endregion

        #region "Mis Métodos"
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
                Dgv_Listado_al.DataSource = N_Inventarios.Listar_al();
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
            this.nCodigo_al =Convert.ToInt32(Txt_codigo_al.Text);
            Txt_descripcion_al.Text = Convert.ToString(Dgv_Listado_al.CurrentRow.Cells["descripcion_al"].Value);
            this.Mostrar_inv(Convert.ToInt32(Txt_codigo_al.Text));
        }

         private void Formato_inv()
         {
            Dgv_detalle.Columns[0].Width = 280;
            Dgv_detalle.Columns[0].HeaderText = "ARTÍCULO";
            Dgv_detalle.Columns[1].Width = 180;
            Dgv_detalle.Columns[1].HeaderText = "MARCA";
            Dgv_detalle.Columns[2].Width = 75;
            Dgv_detalle.Columns[2].HeaderText = "U.MEDIDA";
            Dgv_detalle.Columns[3].Width = 100;
            Dgv_detalle.Columns[3].HeaderText = "STOCK TEÓRICO";
            Dgv_detalle.Columns[4].Width = 100;
            Dgv_detalle.Columns[4].HeaderText = "STOCK FÍSICO";
            Dgv_detalle.Columns[5].Width = 260;
            Dgv_detalle.Columns[5].HeaderText = "OBSERVACION";
            Dgv_detalle.Columns[6].Visible = false;
            Dgv_detalle.Columns[7].Visible = false;
            Dgv_detalle.Columns[8].Visible = false;

            Dgv_detalle.Columns[0].ReadOnly = true;
            Dgv_detalle.Columns[1].ReadOnly = true;
            Dgv_detalle.Columns[2].ReadOnly = true;
            Dgv_detalle.Columns[3].ReadOnly = true;
            Dgv_detalle.Columns[4].ReadOnly = true;
            Dgv_detalle.Columns[5].ReadOnly = true;           

        }
         
        private void Crear_Tabla_inv()
        {
            this.Dtdetalle = new DataTable("Detalle");
            this.Dtdetalle.Columns.Add("Descripcion_ar", System.Type.GetType("System.String"));
            this.Dtdetalle.Columns.Add("Descripcion_ma", System.Type.GetType("System.String"));
            this.Dtdetalle.Columns.Add("Descripcion_um", System.Type.GetType("System.String"));
            this.Dtdetalle.Columns.Add("Stock_teorico", System.Type.GetType("System.Decimal"));
            this.Dtdetalle.Columns.Add("Stock_fisico", System.Type.GetType("System.Decimal"));
            this.Dtdetalle.Columns.Add("Observacion", System.Type.GetType("System.String"));
            this.Dtdetalle.Columns.Add("Codigo_ar", System.Type.GetType("System.Int32"));
            this.Dtdetalle.Columns.Add("Codigo_al", System.Type.GetType("System.Int32"));
            this.Dtdetalle.Columns.Add("Descripcion_al", System.Type.GetType("System.String"));

            Dgv_detalle.DataSource = this.Dtdetalle;
            this.Formato_inv();
        }

        private void Agregar_item(string Descripcion_ar,
                                  string Descripcion_ma, 
                                  string Descripcion_um,
                                  decimal Stock_teorico,
                                  decimal Stock_fisico,
                                  string Observacion,
                                  int Codigo_ar,
                                  int Codigo_al,
                                  string Descripcion_al)
        {
            DataRow Fila = Dtdetalle.NewRow();
            Fila["Descripcion_ar"] = Descripcion_ar;
            Fila["Descripcion_ma"] = Descripcion_ma;
            Fila["Descripcion_um"] = Descripcion_um;
            Fila["Stock_teorico"] = Stock_teorico;
            Fila["Stock_fisico"] = Stock_fisico;
            Fila["Observacion"] = Observacion;
            Fila["Codigo_ar"] = Codigo_ar;
            Fila["Codigo_al"] = Codigo_al;
            Fila["Descripcion_al"] = Descripcion_al;
            this.Dtdetalle.Rows.Add(Fila);
        }

        private void Mostrar_inv(int Ncodigo_al)
        {
            try
            {
                DataTable Tablatemp = new DataTable();
                Tablatemp = N_Inventarios.Listar_ar(Ncodigo_al);
                Dtdetalle.Clear();
                for (int Nfila = 0; Nfila <= Tablatemp.Rows.Count - 1; Nfila++)
                {
                    this.Agregar_item(Convert.ToString(Tablatemp.Rows[Nfila][0]),
                                      Convert.ToString(Tablatemp.Rows[Nfila][1]), 
                                      Convert.ToString(Tablatemp.Rows[Nfila][2]),
                                      Convert.ToDecimal(Tablatemp.Rows[Nfila][3]),
                                      Convert.ToDecimal(Tablatemp.Rows[Nfila][4]),
                                      Convert.ToString(Tablatemp.Rows[Nfila][5]),
                                      Convert.ToInt32(Tablatemp.Rows[Nfila][6]),
                                      Convert.ToInt32(Tablatemp.Rows[Nfila][7]),
                                      Convert.ToString(Tablatemp.Rows[Nfila][8]));
                }

                Dgv_detalle.DataSource = Dtdetalle;              

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        #endregion

        private void Dgv_Listado_al_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_dgv_al();
            Pnl_listado_al.Visible = false;
        }

        private void btn_lupa3_Click(object sender, EventArgs e)
        {
            this.Listar_al();
            Pnl_listado_al.Visible = true;
        }

        private void Btn_retornar_al_Click(object sender, EventArgs e)
        {
            Pnl_listado_al.Visible = false;
        }

        private void Btn_imprimir_Click(object sender, EventArgs e)
        {
            Reportes.Frm_Rpt_Imprimir_Inventario_inicial ORpt_inv = new Reportes.Frm_Rpt_Imprimir_Inventario_inicial();
            ORpt_inv.Txt_p1.Text = this.nCodigo_al.ToString();
            ORpt_inv.ShowDialog();
        }

        private void Frm_Inventarios_Load(object sender, EventArgs e)
        {
            this.Crear_Tabla_inv();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            this.Dtdetalle.AcceptChanges();
            try
            {
                if (Txt_referencia_in.Text == string.Empty)
                {
                    MessageBox.Show("Falta ingresar datos requeridos (*)", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DateTime Fecha_in;
                    string Referencia_in = "";
                    string Observacion = "";
                    string Rpta;
                    Fecha_in = Dtp_fecha_in.Value;
                    Referencia_in = Txt_referencia_in.Text.Trim();
                    Observacion = Txt_observacion_in.Text.Trim();
                   
                    Dtdetalle.AcceptChanges();                    
                    Rpta = N_Inventarios.Guardar_inv(this.nCodigo_al,
                                                     Fecha_in,
                                                     Referencia_in,
                                                     Observacion,
                                                     Dtdetalle);
                    if (Rpta.Equals("OK"))
                    {
                        MessageBox.Show("Los datos han sido guardados correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Btn_ingresar_stock.Enabled = true;
                        Dtp_fecha_in.Enabled = false;
                        Txt_referencia_in.Enabled = false;
                        Txt_observacion_in.Enabled = false;                        
                        
                        Dgv_detalle.Columns[4].ReadOnly = true;
                        Dgv_detalle.Columns[5].ReadOnly = true;

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

        private void Btn_ingresar_stock_Click(object sender, EventArgs e)
        {
            Btn_ingresar_stock.Enabled = false;
            Dtp_fecha_in.Enabled = true;
            Txt_referencia_in.Enabled = true;
            Txt_observacion_in.Enabled = true;
            Dgv_detalle.Columns[4].ReadOnly = false;
            Dgv_detalle.Columns[5].ReadOnly = false;           
            Dgv_detalle.CurrentCell = Dgv_detalle.Rows[0].Cells[4];
        }
    }
}
