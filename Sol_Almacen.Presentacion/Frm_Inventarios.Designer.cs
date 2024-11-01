
namespace Sol_Almacen.Presentacion
{
    partial class Frm_Inventarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Inventarios));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Img_procesos = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.Btn_imprimir = new System.Windows.Forms.Button();
            this.Img_principal = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Pnl_listado_al = new System.Windows.Forms.Panel();
            this.Dgv_Listado_al = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.Btn_retornar_al = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_observacion_in = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_referencia_in = new System.Windows.Forms.TextBox();
            this.Dtp_fecha_in = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_lupa3 = new System.Windows.Forms.Button();
            this.Txt_codigo_al = new System.Windows.Forms.TextBox();
            this.Txt_descripcion_al = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Dgv_detalle = new System.Windows.Forms.DataGridView();
            this.Btn_ingresar_stock = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Pnl_listado_al.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Listado_al)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_detalle)).BeginInit();
            this.SuspendLayout();
            // 
            // Img_procesos
            // 
            this.Img_procesos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Img_procesos.ImageStream")));
            this.Img_procesos.TransparentColor = System.Drawing.Color.Transparent;
            this.Img_procesos.Images.SetKeyName(0, "cancelar.png");
            this.Img_procesos.Images.SetKeyName(1, "guardar.png");
            this.Img_procesos.Images.SetKeyName(2, "confirmar.png");
            this.Img_procesos.Images.SetKeyName(3, "eliminar.png");
            this.Img_procesos.Images.SetKeyName(4, "agregar.png");
            this.Img_procesos.Images.SetKeyName(5, "buscar.png");
            this.Img_procesos.Images.SetKeyName(6, "quitar.png");
            this.Img_procesos.Images.SetKeyName(7, "retornar.png");
            this.Img_procesos.Images.SetKeyName(8, "lupa.png");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.panel1.Controls.Add(this.lblTitleChildForm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1085, 42);
            this.panel1.TabIndex = 65;
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.White;
            this.lblTitleChildForm.Location = new System.Drawing.Point(62, 14);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(124, 18);
            this.lblTitleChildForm.TabIndex = 7;
            this.lblTitleChildForm.Text = ".:. Inventarios";
            // 
            // Btn_imprimir
            // 
            this.Btn_imprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(221)))), ((int)(((byte)(235)))));
            this.Btn_imprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_imprimir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(103)))), ((int)(((byte)(112)))));
            this.Btn_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_imprimir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.Btn_imprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_imprimir.ImageKey = "imprimir2.png";
            this.Btn_imprimir.ImageList = this.Img_principal;
            this.Btn_imprimir.Location = new System.Drawing.Point(14, 426);
            this.Btn_imprimir.Name = "Btn_imprimir";
            this.Btn_imprimir.Size = new System.Drawing.Size(103, 74);
            this.Btn_imprimir.TabIndex = 66;
            this.Btn_imprimir.Text = "Imprimir Inventario Inicial";
            this.Btn_imprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_imprimir.UseVisualStyleBackColor = false;
            this.Btn_imprimir.Click += new System.EventHandler(this.Btn_imprimir_Click);
            // 
            // Img_principal
            // 
            this.Img_principal.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Img_principal.ImageStream")));
            this.Img_principal.TransparentColor = System.Drawing.Color.Transparent;
            this.Img_principal.Images.SetKeyName(0, "nuevo.ico");
            this.Img_principal.Images.SetKeyName(1, "actualizar.ico");
            this.Img_principal.Images.SetKeyName(2, "eliminar.ico");
            this.Img_principal.Images.SetKeyName(3, "reporte.ico");
            this.Img_principal.Images.SetKeyName(4, "salir.ico");
            this.Img_principal.Images.SetKeyName(5, "aprobado.png");
            this.Img_principal.Images.SetKeyName(6, "entregado.png");
            this.Img_principal.Images.SetKeyName(7, "imprimir.png");
            this.Img_principal.Images.SetKeyName(8, "imprimir2.png");
            this.Img_principal.Images.SetKeyName(9, "cargar.png");
            this.Img_principal.Images.SetKeyName(10, "Guadar.png");
            this.Img_principal.Images.SetKeyName(11, "salir2.png");
            this.Img_principal.Images.SetKeyName(12, "salir3.png");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Pnl_listado_al);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Txt_observacion_in);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Txt_referencia_in);
            this.groupBox1.Controls.Add(this.Dtp_fecha_in);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btn_lupa3);
            this.groupBox1.Controls.Add(this.Txt_codigo_al);
            this.groupBox1.Controls.Add(this.Txt_descripcion_al);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Dgv_detalle);
            this.groupBox1.Location = new System.Drawing.Point(14, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1056, 361);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inventario de Almacenes disponibles";
            // 
            // Pnl_listado_al
            // 
            this.Pnl_listado_al.BackColor = System.Drawing.Color.Silver;
            this.Pnl_listado_al.Controls.Add(this.Dgv_Listado_al);
            this.Pnl_listado_al.Controls.Add(this.label10);
            this.Pnl_listado_al.Controls.Add(this.Btn_retornar_al);
            this.Pnl_listado_al.Location = new System.Drawing.Point(248, 34);
            this.Pnl_listado_al.Name = "Pnl_listado_al";
            this.Pnl_listado_al.Size = new System.Drawing.Size(316, 170);
            this.Pnl_listado_al.TabIndex = 65;
            this.Pnl_listado_al.Visible = false;
            // 
            // Dgv_Listado_al
            // 
            this.Dgv_Listado_al.AllowUserToAddRows = false;
            this.Dgv_Listado_al.AllowUserToDeleteRows = false;
            this.Dgv_Listado_al.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.Dgv_Listado_al.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_Listado_al.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Dgv_Listado_al.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv_Listado_al.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.Dgv_Listado_al.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(99)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Listado_al.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_Listado_al.ColumnHeadersHeight = 30;
            this.Dgv_Listado_al.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dgv_Listado_al.EnableHeadersVisualStyles = false;
            this.Dgv_Listado_al.GridColor = System.Drawing.Color.SteelBlue;
            this.Dgv_Listado_al.Location = new System.Drawing.Point(13, 39);
            this.Dgv_Listado_al.Name = "Dgv_Listado_al";
            this.Dgv_Listado_al.ReadOnly = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(111)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.Dgv_Listado_al.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_Listado_al.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Dgv_Listado_al.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Listado_al.Size = new System.Drawing.Size(295, 119);
            this.Dgv_Listado_al.TabIndex = 20;
            this.Dgv_Listado_al.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Listado_al_CellDoubleClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(52)))), ((int)(((byte)(72)))));
            this.label10.Location = new System.Drawing.Point(10, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "LISTADO DE ALMACEN";
            // 
            // Btn_retornar_al
            // 
            this.Btn_retornar_al.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(52)))), ((int)(((byte)(72)))));
            this.Btn_retornar_al.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_retornar_al.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(103)))), ((int)(((byte)(112)))));
            this.Btn_retornar_al.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_retornar_al.ForeColor = System.Drawing.Color.White;
            this.Btn_retornar_al.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_retornar_al.ImageKey = "retornar.png";
            this.Btn_retornar_al.ImageList = this.Img_procesos;
            this.Btn_retornar_al.Location = new System.Drawing.Point(285, 3);
            this.Btn_retornar_al.Name = "Btn_retornar_al";
            this.Btn_retornar_al.Size = new System.Drawing.Size(34, 30);
            this.Btn_retornar_al.TabIndex = 17;
            this.Btn_retornar_al.UseVisualStyleBackColor = false;
            this.Btn_retornar_al.Click += new System.EventHandler(this.Btn_retornar_al_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(735, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 76;
            this.label1.Text = "Observación:";
            // 
            // Txt_observacion_in
            // 
            this.Txt_observacion_in.Enabled = false;
            this.Txt_observacion_in.Location = new System.Drawing.Point(738, 34);
            this.Txt_observacion_in.MaxLength = 50;
            this.Txt_observacion_in.Name = "Txt_observacion_in";
            this.Txt_observacion_in.Size = new System.Drawing.Size(306, 20);
            this.Txt_observacion_in.TabIndex = 75;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(607, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 74;
            this.label3.Text = "Referencia:(*)";
            // 
            // Txt_referencia_in
            // 
            this.Txt_referencia_in.Enabled = false;
            this.Txt_referencia_in.Location = new System.Drawing.Point(609, 34);
            this.Txt_referencia_in.MaxLength = 50;
            this.Txt_referencia_in.Name = "Txt_referencia_in";
            this.Txt_referencia_in.Size = new System.Drawing.Size(122, 20);
            this.Txt_referencia_in.TabIndex = 73;
            // 
            // Dtp_fecha_in
            // 
            this.Dtp_fecha_in.Enabled = false;
            this.Dtp_fecha_in.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_fecha_in.Location = new System.Drawing.Point(494, 34);
            this.Dtp_fecha_in.Name = "Dtp_fecha_in";
            this.Dtp_fecha_in.Size = new System.Drawing.Size(101, 20);
            this.Dtp_fecha_in.TabIndex = 72;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(492, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 13);
            this.label11.TabIndex = 71;
            this.label11.Text = "Fecha inventario: (*)";
            // 
            // btn_lupa3
            // 
            this.btn_lupa3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(99)))), ((int)(((byte)(106)))));
            this.btn_lupa3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_lupa3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(103)))), ((int)(((byte)(112)))));
            this.btn_lupa3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lupa3.ForeColor = System.Drawing.Color.White;
            this.btn_lupa3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_lupa3.ImageKey = "lupa.png";
            this.btn_lupa3.ImageList = this.Img_procesos;
            this.btn_lupa3.Location = new System.Drawing.Point(390, 24);
            this.btn_lupa3.Name = "btn_lupa3";
            this.btn_lupa3.Size = new System.Drawing.Size(34, 30);
            this.btn_lupa3.TabIndex = 66;
            this.btn_lupa3.UseVisualStyleBackColor = false;
            this.btn_lupa3.Click += new System.EventHandler(this.btn_lupa3_Click);
            // 
            // Txt_codigo_al
            // 
            this.Txt_codigo_al.Location = new System.Drawing.Point(396, 30);
            this.Txt_codigo_al.Name = "Txt_codigo_al";
            this.Txt_codigo_al.Size = new System.Drawing.Size(44, 20);
            this.Txt_codigo_al.TabIndex = 69;
            this.Txt_codigo_al.Visible = false;
            // 
            // Txt_descripcion_al
            // 
            this.Txt_descripcion_al.Location = new System.Drawing.Point(142, 30);
            this.Txt_descripcion_al.Name = "Txt_descripcion_al";
            this.Txt_descripcion_al.ReadOnly = true;
            this.Txt_descripcion_al.Size = new System.Drawing.Size(237, 20);
            this.Txt_descripcion_al.TabIndex = 68;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 67;
            this.label6.Text = "Almacen disponible:";
            // 
            // Dgv_detalle
            // 
            this.Dgv_detalle.AllowUserToAddRows = false;
            this.Dgv_detalle.AllowUserToDeleteRows = false;
            this.Dgv_detalle.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.Dgv_detalle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Dgv_detalle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Dgv_detalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv_detalle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.Dgv_detalle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(99)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(176)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_detalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Dgv_detalle.ColumnHeadersHeight = 30;
            this.Dgv_detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dgv_detalle.EnableHeadersVisualStyles = false;
            this.Dgv_detalle.GridColor = System.Drawing.Color.SteelBlue;
            this.Dgv_detalle.Location = new System.Drawing.Point(22, 71);
            this.Dgv_detalle.Name = "Dgv_detalle";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(111)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.Dgv_detalle.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.Dgv_detalle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Dgv_detalle.Size = new System.Drawing.Size(1022, 268);
            this.Dgv_detalle.TabIndex = 70;
            // 
            // Btn_ingresar_stock
            // 
            this.Btn_ingresar_stock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(221)))), ((int)(((byte)(235)))));
            this.Btn_ingresar_stock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ingresar_stock.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(103)))), ((int)(((byte)(112)))));
            this.Btn_ingresar_stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ingresar_stock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.Btn_ingresar_stock.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_ingresar_stock.ImageKey = "cargar.png";
            this.Btn_ingresar_stock.ImageList = this.Img_principal;
            this.Btn_ingresar_stock.Location = new System.Drawing.Point(123, 426);
            this.Btn_ingresar_stock.Name = "Btn_ingresar_stock";
            this.Btn_ingresar_stock.Size = new System.Drawing.Size(133, 74);
            this.Btn_ingresar_stock.TabIndex = 68;
            this.Btn_ingresar_stock.Text = "Ingresar Stock físico al Inventario";
            this.Btn_ingresar_stock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_ingresar_stock.UseVisualStyleBackColor = false;
            this.Btn_ingresar_stock.Click += new System.EventHandler(this.Btn_ingresar_stock_Click);
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(221)))), ((int)(((byte)(235)))));
            this.Btn_guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_guardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(103)))), ((int)(((byte)(112)))));
            this.Btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_guardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.Btn_guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_guardar.ImageKey = "Guadar.png";
            this.Btn_guardar.ImageList = this.Img_principal;
            this.Btn_guardar.Location = new System.Drawing.Point(262, 426);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(133, 74);
            this.Btn_guardar.TabIndex = 69;
            this.Btn_guardar.Text = "Guardar Stock Físico Inventario";
            this.Btn_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_guardar.UseVisualStyleBackColor = false;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Btn_salir
            // 
            this.Btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(221)))), ((int)(((byte)(235)))));
            this.Btn_salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_salir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(103)))), ((int)(((byte)(112)))));
            this.Btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_salir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.Btn_salir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_salir.ImageKey = "salir3.png";
            this.Btn_salir.ImageList = this.Img_principal;
            this.Btn_salir.Location = new System.Drawing.Point(401, 426);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(103, 74);
            this.Btn_salir.TabIndex = 70;
            this.Btn_salir.Text = "Salir";
            this.Btn_salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_salir.UseVisualStyleBackColor = false;
            this.Btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // Frm_Inventarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 600);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Btn_ingresar_stock);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btn_imprimir);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Inventarios";
            this.Text = "Frm_Inventarios";
            this.Load += new System.EventHandler(this.Frm_Inventarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Pnl_listado_al.ResumeLayout(false);
            this.Pnl_listado_al.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Listado_al)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_detalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList Img_procesos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Button Btn_imprimir;
        private System.Windows.Forms.ImageList Img_principal;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Panel Pnl_listado_al;
        private System.Windows.Forms.DataGridView Dgv_Listado_al;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Button Btn_retornar_al;
        internal System.Windows.Forms.Button btn_lupa3;
        private System.Windows.Forms.TextBox Txt_codigo_al;
        private System.Windows.Forms.TextBox Txt_descripcion_al;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView Dgv_detalle;
        private System.Windows.Forms.Button Btn_ingresar_stock;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_salir;
        internal System.Windows.Forms.DateTimePicker Dtp_fecha_in;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_observacion_in;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_referencia_in;
    }
}