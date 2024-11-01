using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;


namespace Sol_Almacen.Presentacion
{
    public partial class Frm_MiDashBoard : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        //Constructor
        public Frm_MiDashBoard()
        {
            InitializeComponent();
            customizeDesing();

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 46);
            Pnl_menu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                //leftBorderBtn.BackColor = color;
                //leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                //leftBorderBtn.Visible = true;
                //leftBorderBtn.BringToFront();
                //Current Child Form Icon

                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
                lblTitleChildForm.Text = currentBtn.Text;
                lblTitleChildForm.ForeColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(60, 99, 130);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(24, 161, 251);
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;

            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.Black;
            lblTitleChildForm.Text = "Home";
        }

        private void customizeDesing()
        {
            Pnl_procesos.Visible = false;
            Pnl_reportes.Visible = false;
            Pnl_datosmaestros.Visible = false;
        }

        private void hideSubMenu()
        {
            if (Pnl_procesos.Visible == true)
                Pnl_procesos.Visible = false;
            if (Pnl_reportes.Visible == true)
                Pnl_reportes.Visible = false;
            if (Pnl_datosmaestros.Visible == true)
                Pnl_datosmaestros.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Pnl_escritorio.Controls.Add(childForm);
            Pnl_escritorio.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();

            Reset();
            customizeDesing();
        }

        private void Btn_dashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            customizeDesing();
        }
        private void Btn_procesos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            showSubMenu(Pnl_procesos);
        }

        private void Btn_reportes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            showSubMenu(Pnl_reportes);
        }

        private void Btn_datosmaestros_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            showSubMenu(Pnl_datosmaestros);
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Pnl_titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Btn_maximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_cerrarsesion_Click(object sender, EventArgs e)
        {
            DialogResult Opcion;
            Opcion = MessageBox.Show("Deseas cerrar sesión el Sistema?", "Sistema de Punto de Venta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Opcion == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void DM_proveedores_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Proveedores());
            //hideSubMenu();
        }

        private void DM_articulos_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Articulos());
            //hideSubMenu();
        }

        private void DM_marcas_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Marcas());
            //hideSubMenu();
        }

        private void DM_subgrupos_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_SubGrupos());
            //hideSubMenu();
        }

        private void DM_grupos_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Grupos());
            //hideSubMenu();
        }

        private void DM_medida_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Unidades_Medidas());
            //hideSubMenu();
        }

        private void DM_almacenes_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Almacenes());
            //hideSubMenu();
        }

        private void DM_rubros_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Rubros());
            //hideSubMenu();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            var VFrm_AP = new Controles.Frm_ActualizarPasswordUsuario();
            VFrm_AP.Txt_codigo_us.Text = Lbl_codigo_us.Text;
            VFrm_AP.Txt_nombres_us.Text = Lbl_nombre_us.Text;
            VFrm_AP.Txt_password_us.Text = "";
            VFrm_AP.Txt_password_us.Select();
            VFrm_AP.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            var VFrm_AP = new Controles.Frm_ActualizarPasswordUsuario();
            VFrm_AP.Txt_codigo_us.Text = Lbl_codigo_us.Text;
            VFrm_AP.Txt_nombres_us.Text = Lbl_nombre_us.Text;
            VFrm_AP.Txt_password_us.Text = "";
            VFrm_AP.Txt_password_us.Select();
            VFrm_AP.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Lbl_hora.Text = DateTime.Now.ToLongTimeString();
            Lbl_Fecha.Text = DateTime.Now.ToLongDateString();
        }

        private void PR_entrada_articulo_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Entrada_Articulos());
            //hideSubMenu();
        }

        private void PR_salida_articulo_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Salida_Articulos());
            //hideSubMenu();
        }

        private void PR_stock_articulos_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Stock_Actual());
            //hideSubMenu();
        }

        private void PR_inventarios_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Inventarios());
            //hideSubMenu();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PR_usoinsumos_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Uso_Insumos());
            //hideSubMenu();
        }

        private void Rp_ReportesPersonalizados_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Reportes_Personalizados());
            //hideSubMenu();
        }

        private void Rp_Reportes_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Reportes());
            //hideSubMenu();
        }
    }
}
