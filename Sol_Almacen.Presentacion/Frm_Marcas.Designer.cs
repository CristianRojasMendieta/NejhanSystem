﻿
namespace Sol_Almacen.Presentacion
{
    partial class Frm_Marcas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Marcas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Img_principal = new System.Windows.Forms.ImageList(this.components);
            this.Img_procesos = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.Tbp_general = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Dgv_Listado = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Btn_confirmar = new System.Windows.Forms.Button();
            this.Btn_cancelar2 = new System.Windows.Forms.Button();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Txt_buscar = new System.Windows.Forms.TextBox();
            this.Lbl_total = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_descripcion_ma = new System.Windows.Forms.TextBox();
            this.Btn_retornar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_codigo_ma = new System.Windows.Forms.TextBox();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.Btn_reporte = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.Btn_nuevo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.Tbp_general.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Listado)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.panel1.Controls.Add(this.lblTitleChildForm);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1089, 42);
            this.panel1.TabIndex = 12;
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.White;
            this.lblTitleChildForm.Location = new System.Drawing.Point(62, 14);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(87, 18);
            this.lblTitleChildForm.TabIndex = 7;
            this.lblTitleChildForm.Text = ".:. Marcas";
            // 
            // Tbp_general
            // 
            this.Tbp_general.Controls.Add(this.tabPage1);
            this.Tbp_general.Controls.Add(this.tabPage2);
            this.Tbp_general.ItemSize = new System.Drawing.Size(96, 32);
            this.Tbp_general.Location = new System.Drawing.Point(12, 79);
            this.Tbp_general.Name = "Tbp_general";
            this.Tbp_general.SelectedIndex = 0;
            this.Tbp_general.Size = new System.Drawing.Size(651, 431);
            this.Tbp_general.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.Tbp_general.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Dgv_Listado);
            this.tabPage1.Controls.Add(this.Btn_confirmar);
            this.tabPage1.Controls.Add(this.Btn_cancelar2);
            this.tabPage1.Controls.Add(this.Btn_buscar);
            this.tabPage1.Controls.Add(this.Txt_buscar);
            this.tabPage1.Controls.Add(this.Lbl_total);
            this.tabPage1.Location = new System.Drawing.Point(4, 36);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(643, 391);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            // 
            // Dgv_Listado
            // 
            this.Dgv_Listado.AllowUserToAddRows = false;
            this.Dgv_Listado.AllowUserToDeleteRows = false;
            this.Dgv_Listado.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.Dgv_Listado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_Listado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Dgv_Listado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv_Listado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.Dgv_Listado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(99)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Listado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_Listado.ColumnHeadersHeight = 30;
            this.Dgv_Listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dgv_Listado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.Dgv_Listado.EnableHeadersVisualStyles = false;
            this.Dgv_Listado.GridColor = System.Drawing.Color.SteelBlue;
            this.Dgv_Listado.Location = new System.Drawing.Point(7, 63);
            this.Dgv_Listado.Name = "Dgv_Listado";
            this.Dgv_Listado.ReadOnly = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(111)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.Dgv_Listado.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_Listado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Dgv_Listado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Listado.Size = new System.Drawing.Size(630, 277);
            this.Dgv_Listado.TabIndex = 7;
            this.Dgv_Listado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Listado_CellContentClick);
            this.Dgv_Listado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Listado_CellDoubleClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Seleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Btn_confirmar
            // 
            this.Btn_confirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(78)))), ((int)(((byte)(105)))));
            this.Btn_confirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_confirmar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(103)))), ((int)(((byte)(112)))));
            this.Btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_confirmar.ForeColor = System.Drawing.Color.White;
            this.Btn_confirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_confirmar.Location = new System.Drawing.Point(124, 356);
            this.Btn_confirmar.Name = "Btn_confirmar";
            this.Btn_confirmar.Size = new System.Drawing.Size(110, 30);
            this.Btn_confirmar.TabIndex = 6;
            this.Btn_confirmar.Text = "Confirmar";
            this.Btn_confirmar.UseVisualStyleBackColor = false;
            this.Btn_confirmar.Visible = false;
            this.Btn_confirmar.Click += new System.EventHandler(this.Btn_confirmar_Click);
            // 
            // Btn_cancelar2
            // 
            this.Btn_cancelar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.Btn_cancelar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_cancelar2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(103)))), ((int)(((byte)(112)))));
            this.Btn_cancelar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cancelar2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.Btn_cancelar2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_cancelar2.Location = new System.Drawing.Point(7, 356);
            this.Btn_cancelar2.Name = "Btn_cancelar2";
            this.Btn_cancelar2.Size = new System.Drawing.Size(110, 30);
            this.Btn_cancelar2.TabIndex = 5;
            this.Btn_cancelar2.Text = "Cancelar";
            this.Btn_cancelar2.UseVisualStyleBackColor = false;
            this.Btn_cancelar2.Visible = false;
            this.Btn_cancelar2.Click += new System.EventHandler(this.Btn_cancelar2_Click);
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(52)))), ((int)(((byte)(72)))));
            this.Btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_buscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(103)))), ((int)(((byte)(112)))));
            this.Btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_buscar.ForeColor = System.Drawing.Color.White;
            this.Btn_buscar.Location = new System.Drawing.Point(331, 27);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(110, 30);
            this.Btn_buscar.TabIndex = 3;
            this.Btn_buscar.Text = "Buscar";
            this.Btn_buscar.UseVisualStyleBackColor = false;
            this.Btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // Txt_buscar
            // 
            this.Txt_buscar.Location = new System.Drawing.Point(7, 31);
            this.Txt_buscar.Name = "Txt_buscar";
            this.Txt_buscar.Size = new System.Drawing.Size(318, 20);
            this.Txt_buscar.TabIndex = 2;
            // 
            // Lbl_total
            // 
            this.Lbl_total.AutoSize = true;
            this.Lbl_total.Location = new System.Drawing.Point(492, 356);
            this.Lbl_total.Name = "Lbl_total";
            this.Lbl_total.Size = new System.Drawing.Size(34, 13);
            this.Lbl_total.TabIndex = 1;
            this.Lbl_total.Text = "Total:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.Txt_descripcion_ma);
            this.tabPage2.Controls.Add(this.Btn_retornar);
            this.tabPage2.Controls.Add(this.Btn_guardar);
            this.tabPage2.Controls.Add(this.Btn_cancelar);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.Txt_codigo_ma);
            this.tabPage2.Location = new System.Drawing.Point(4, 36);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(643, 391);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Rubro: (*):";
            // 
            // Txt_descripcion_ma
            // 
            this.Txt_descripcion_ma.Location = new System.Drawing.Point(127, 78);
            this.Txt_descripcion_ma.MaxLength = 50;
            this.Txt_descripcion_ma.Name = "Txt_descripcion_ma";
            this.Txt_descripcion_ma.ReadOnly = true;
            this.Txt_descripcion_ma.Size = new System.Drawing.Size(237, 20);
            this.Txt_descripcion_ma.TabIndex = 21;
            // 
            // Btn_retornar
            // 
            this.Btn_retornar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(52)))), ((int)(((byte)(72)))));
            this.Btn_retornar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_retornar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(103)))), ((int)(((byte)(112)))));
            this.Btn_retornar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_retornar.ForeColor = System.Drawing.Color.White;
            this.Btn_retornar.Location = new System.Drawing.Point(301, 141);
            this.Btn_retornar.Name = "Btn_retornar";
            this.Btn_retornar.Size = new System.Drawing.Size(110, 30);
            this.Btn_retornar.TabIndex = 25;
            this.Btn_retornar.Text = "Retornar";
            this.Btn_retornar.UseVisualStyleBackColor = false;
            this.Btn_retornar.Visible = false;
            this.Btn_retornar.Click += new System.EventHandler(this.Btn_retornar_Click);
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(176)))), ((int)(((byte)(128)))));
            this.Btn_guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_guardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(103)))), ((int)(((byte)(112)))));
            this.Btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_guardar.ForeColor = System.Drawing.Color.White;
            this.Btn_guardar.Location = new System.Drawing.Point(174, 141);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(110, 30);
            this.Btn_guardar.TabIndex = 24;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.UseVisualStyleBackColor = false;
            this.Btn_guardar.Visible = false;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.Btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(103)))), ((int)(((byte)(112)))));
            this.Btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.Btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_cancelar.Location = new System.Drawing.Point(52, 141);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(110, 30);
            this.Btn_cancelar.TabIndex = 22;
            this.Btn_cancelar.Text = "Cancelar";
            this.Btn_cancelar.UseVisualStyleBackColor = false;
            this.Btn_cancelar.Visible = false;
            this.Btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Código:";
            this.label1.Visible = false;
            // 
            // Txt_codigo_ma
            // 
            this.Txt_codigo_ma.Location = new System.Drawing.Point(127, 43);
            this.Txt_codigo_ma.Name = "Txt_codigo_ma";
            this.Txt_codigo_ma.Size = new System.Drawing.Size(100, 20);
            this.Txt_codigo_ma.TabIndex = 19;
            this.Txt_codigo_ma.Visible = false;
            // 
            // Btn_salir
            // 
            this.Btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(221)))), ((int)(((byte)(235)))));
            this.Btn_salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_salir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(103)))), ((int)(((byte)(112)))));
            this.Btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_salir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.Btn_salir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_salir.ImageKey = "salir.ico";
            this.Btn_salir.ImageList = this.Img_principal;
            this.Btn_salir.Location = new System.Drawing.Point(336, 532);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(75, 56);
            this.Btn_salir.TabIndex = 18;
            this.Btn_salir.Text = "Salir";
            this.Btn_salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_salir.UseVisualStyleBackColor = false;
            this.Btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // Btn_reporte
            // 
            this.Btn_reporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(221)))), ((int)(((byte)(235)))));
            this.Btn_reporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_reporte.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(103)))), ((int)(((byte)(112)))));
            this.Btn_reporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_reporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.Btn_reporte.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_reporte.ImageKey = "reporte.ico";
            this.Btn_reporte.ImageList = this.Img_principal;
            this.Btn_reporte.Location = new System.Drawing.Point(255, 532);
            this.Btn_reporte.Name = "Btn_reporte";
            this.Btn_reporte.Size = new System.Drawing.Size(75, 56);
            this.Btn_reporte.TabIndex = 17;
            this.Btn_reporte.Text = "Reporte";
            this.Btn_reporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_reporte.UseVisualStyleBackColor = false;
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(221)))), ((int)(((byte)(235)))));
            this.Btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_eliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(103)))), ((int)(((byte)(112)))));
            this.Btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_eliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.Btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_eliminar.ImageKey = "eliminar.ico";
            this.Btn_eliminar.ImageList = this.Img_principal;
            this.Btn_eliminar.Location = new System.Drawing.Point(174, 532);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(75, 56);
            this.Btn_eliminar.TabIndex = 16;
            this.Btn_eliminar.Text = "Eliminar";
            this.Btn_eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_eliminar.UseVisualStyleBackColor = false;
            this.Btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(221)))), ((int)(((byte)(235)))));
            this.Btn_actualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_actualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(103)))), ((int)(((byte)(112)))));
            this.Btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_actualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.Btn_actualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_actualizar.ImageKey = "actualizar.ico";
            this.Btn_actualizar.ImageList = this.Img_principal;
            this.Btn_actualizar.Location = new System.Drawing.Point(93, 532);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(75, 56);
            this.Btn_actualizar.TabIndex = 15;
            this.Btn_actualizar.Text = "Actualizar";
            this.Btn_actualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_actualizar.UseVisualStyleBackColor = false;
            this.Btn_actualizar.Click += new System.EventHandler(this.Btn_actualizar_Click);
            // 
            // Btn_nuevo
            // 
            this.Btn_nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(221)))), ((int)(((byte)(235)))));
            this.Btn_nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_nuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(103)))), ((int)(((byte)(112)))));
            this.Btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_nuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.Btn_nuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_nuevo.ImageKey = "nuevo.ico";
            this.Btn_nuevo.ImageList = this.Img_principal;
            this.Btn_nuevo.Location = new System.Drawing.Point(12, 532);
            this.Btn_nuevo.Name = "Btn_nuevo";
            this.Btn_nuevo.Size = new System.Drawing.Size(75, 56);
            this.Btn_nuevo.TabIndex = 14;
            this.Btn_nuevo.Text = "Nuevo";
            this.Btn_nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_nuevo.UseVisualStyleBackColor = false;
            this.Btn_nuevo.Click += new System.EventHandler(this.Btn_nuevo_Click);
            // 
            // Frm_Marcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 600);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.Btn_reporte);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Btn_actualizar);
            this.Controls.Add(this.Btn_nuevo);
            this.Controls.Add(this.Tbp_general);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Marcas";
            this.Text = "Frm_Marcas";
            this.Load += new System.EventHandler(this.Frm_Marcas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Tbp_general.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Listado)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList Img_principal;
        private System.Windows.Forms.ImageList Img_procesos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.TabControl Tbp_general;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView Dgv_Listado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.Button Btn_confirmar;
        private System.Windows.Forms.Button Btn_cancelar2;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.TextBox Txt_buscar;
        private System.Windows.Forms.Label Lbl_total;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Btn_retornar;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_codigo_ma;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.Button Btn_reporte;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_actualizar;
        private System.Windows.Forms.Button Btn_nuevo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_descripcion_ma;
    }
}