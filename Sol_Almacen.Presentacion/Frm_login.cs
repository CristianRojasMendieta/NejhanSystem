using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Sol_Almacen.Negocio;
using Sol_Almacen.Entidades;
using System.IO;

namespace Sol_Almacen.Presentacion
{
    public partial class Frm_login : Form
    {
        #region "Métodos"
        private void Acceder_us(int Ncodigo_si, string Cemail_us, string Cpassword_us)
        {
            try
            {
                DataTable Tablatemp = new DataTable();
                Tablatemp = N_login.Acceder_us(Ncodigo_si, Cemail_us, Cpassword_us);
                if (Tablatemp.Rows.Count > 0)
                {
                    MisVariables.Ncodigo_us= Convert.ToInt32(Tablatemp.Rows[0][0]);
                    MisVariables.Cnombres = Convert.ToString(Tablatemp.Rows[0][2]);
                    MisVariables.Cdescripcion_ca = Convert.ToString(Tablatemp.Rows[0][3]);
                    MisVariables.Ncodigo_ru = Convert.ToInt32(Tablatemp.Rows[0][4]);
                    MisVariables.Ncodigo_ca = Convert.ToInt32(Tablatemp.Rows[0][5]); 
                   
                                       

                    Frm_MiDashBoard Omidashboard = new Frm_MiDashBoard();
                    Omidashboard.Lbl_codigo_us.Text =Convert.ToString(MisVariables.Ncodigo_us);
                    Omidashboard.Lbl_nombre_us.Text = MisVariables.Cnombres;
                    Omidashboard.Lbl_descripcion_ca.Text = MisVariables.Cdescripcion_ca;
                    Omidashboard.Lbl_codigo_ru.Text =Convert.ToString(MisVariables.Ncodigo_ru);

                    if (MisVariables.Ncodigo_ca ==1 ||
                        MisVariables.Ncodigo_ca==2 ||
                        MisVariables.Ncodigo_ca==10) // Gerente /Administrador / Sistemas(Full a todo)
                    {
                        Omidashboard.Btn_dashboard.Enabled = true;
                        Omidashboard.Btn_procesos.Enabled = true;
                        Omidashboard.Btn_reportes.Enabled = true;
                        Omidashboard.Btn_datosmaestros.Enabled = true;
                    }
                    else if (MisVariables.Ncodigo_ca ==11 ||
                             MisVariables.Ncodigo_ca==18) // Almacén / Contabilidad (Acceso a todo, menos a autorizar salida de almacén)
                    {
                        Omidashboard.Btn_dashboard.Enabled = true;
                        Omidashboard.Btn_procesos.Enabled = true;
                        Omidashboard.Btn_reportes.Enabled = true;
                        Omidashboard.Btn_datosmaestros.Enabled = true;
                    }else  // Usuarios normales (Solo permiso para crear salida de artículos)
                    {
                        Omidashboard.Btn_dashboard.Enabled = false;
                        Omidashboard.Btn_procesos.Enabled = true;
                        Omidashboard.PR_entrada_articulo.Enabled = false;
                        Omidashboard.PR_salida_articulo.Enabled = true;
                        Omidashboard.PR_stock_articulos.Enabled = false;
                        Omidashboard.PR_inventarios.Enabled = false;
                        Omidashboard.PR_usoinsumos.Enabled = true;
                        Omidashboard.Btn_reportes.Enabled = true;
                        Omidashboard.Rp_Reportes.Enabled = true;
                        Omidashboard.Rp_ReportesPersonalizados.Enabled = false;
                        Omidashboard.Btn_datosmaestros.Enabled = false;
                    }
                    

                    Omidashboard.Show();
                    Omidashboard.FormClosed += Logout;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario y/o Clave son incorrecto ... verifique", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        #endregion
        public Frm_login()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Pct_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Pct_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Frm_login_Load(object sender, EventArgs e)
        {
            this.Txt_email_us.Select();
        }

        private void Frm_login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Btn_acceder_Click(object sender, EventArgs e)
        {
            MisVariables.Ncodigo_us = 0;
            MisVariables.Ncodigo_ca = 0;
            MisVariables.Ncodigo_ru = 0;
            this.Acceder_us(1, Txt_email_us.Text.Trim(), Txt_password_us.Text.Trim());
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            Txt_email_us.Text = "";
            Txt_password_us.Text = "";
            this.Show();
            Txt_email_us.Select();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var VFrm_RP = new Frm_Recuperar_Password();
            VFrm_RP.ShowDialog();
        }

        private void Txt_email_us_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.Acceder_us(2, Txt_email_us.Text.Trim(), Txt_password_us.Text.Trim());
            }
        }

        private void Txt_password_us_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.Acceder_us(1, Txt_email_us.Text.Trim(), Txt_password_us.Text.Trim());
            }
        }
    }
}
