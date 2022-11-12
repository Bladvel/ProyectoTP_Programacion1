namespace ProyectoTP
{
    partial class frmPrincipal
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
            this.lstGeneral = new System.Windows.Forms.ListBox();
            this.grpCategoria = new System.Windows.Forms.GroupBox();
            this.txtValorHoraExtra = new System.Windows.Forms.TextBox();
            this.txtSueldoBasico = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCodigoCategoria = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModificarCategoria = new System.Windows.Forms.Button();
            this.btnCargarCategoria = new System.Windows.Forms.Button();
            this.lstEmpleados = new System.Windows.Forms.ListBox();
            this.grpEmpleado = new System.Windows.Forms.GroupBox();
            this.lblInformacionEmpleado = new System.Windows.Forms.Label();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.txtCantidadHorasExtras = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnModificarEmpleado = new System.Windows.Forms.Button();
            this.btnCargarEmpleado = new System.Windows.Forms.Button();
            this.grpDatosEmpleado = new System.Windows.Forms.GroupBox();
            this.lstSueldosMayorPromedio = new System.Windows.Forms.ListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCobroDiciembre = new System.Windows.Forms.TextBox();
            this.lstPrimerTrimestre = new System.Windows.Forms.ListBox();
            this.lstSueldoAnual = new System.Windows.Forms.ListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMaximoSueldo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnMostrarDatos = new System.Windows.Forms.Button();
            this.lblAntesDeIniciar = new System.Windows.Forms.Label();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.lblSaludo = new System.Windows.Forms.Label();
            this.btnEliminarCategoria = new System.Windows.Forms.Button();
            this.btnEliminarEmpleado = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picUsuario = new System.Windows.Forms.PictureBox();
            this.lblInformacionCategoria = new System.Windows.Forms.Label();
            this.grpCategoria.SuspendLayout();
            this.grpEmpleado.SuspendLayout();
            this.grpDatosEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // lstGeneral
            // 
            this.lstGeneral.FormattingEnabled = true;
            this.lstGeneral.ItemHeight = 15;
            this.lstGeneral.Location = new System.Drawing.Point(33, 377);
            this.lstGeneral.Margin = new System.Windows.Forms.Padding(2);
            this.lstGeneral.Name = "lstGeneral";
            this.lstGeneral.Size = new System.Drawing.Size(238, 169);
            this.lstGeneral.TabIndex = 0;
            this.lstGeneral.SelectedIndexChanged += new System.EventHandler(this.lstGeneral_SelectedIndexChanged);
            // 
            // grpCategoria
            // 
            this.grpCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.grpCategoria.Controls.Add(this.lblInformacionCategoria);
            this.grpCategoria.Controls.Add(this.txtValorHoraExtra);
            this.grpCategoria.Controls.Add(this.txtSueldoBasico);
            this.grpCategoria.Controls.Add(this.txtDescripcion);
            this.grpCategoria.Controls.Add(this.txtCodigoCategoria);
            this.grpCategoria.Controls.Add(this.label4);
            this.grpCategoria.Controls.Add(this.label3);
            this.grpCategoria.Controls.Add(this.label2);
            this.grpCategoria.Controls.Add(this.label1);
            this.grpCategoria.Controls.Add(this.btnModificarCategoria);
            this.grpCategoria.Controls.Add(this.btnCargarCategoria);
            this.grpCategoria.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(27)))), ((int)(((byte)(82)))));
            this.grpCategoria.Location = new System.Drawing.Point(33, 127);
            this.grpCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.grpCategoria.Name = "grpCategoria";
            this.grpCategoria.Padding = new System.Windows.Forms.Padding(2);
            this.grpCategoria.Size = new System.Drawing.Size(238, 246);
            this.grpCategoria.TabIndex = 1;
            this.grpCategoria.TabStop = false;
            this.grpCategoria.Text = "Cargar Categoria";
            // 
            // txtValorHoraExtra
            // 
            this.txtValorHoraExtra.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorHoraExtra.Location = new System.Drawing.Point(130, 170);
            this.txtValorHoraExtra.Margin = new System.Windows.Forms.Padding(2);
            this.txtValorHoraExtra.Name = "txtValorHoraExtra";
            this.txtValorHoraExtra.Size = new System.Drawing.Size(104, 22);
            this.txtValorHoraExtra.TabIndex = 4;
            this.txtValorHoraExtra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorHoraExtra_KeyPress);
            // 
            // txtSueldoBasico
            // 
            this.txtSueldoBasico.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSueldoBasico.Location = new System.Drawing.Point(130, 144);
            this.txtSueldoBasico.Margin = new System.Windows.Forms.Padding(2);
            this.txtSueldoBasico.Name = "txtSueldoBasico";
            this.txtSueldoBasico.Size = new System.Drawing.Size(104, 22);
            this.txtSueldoBasico.TabIndex = 3;
            this.txtSueldoBasico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSueldoBasico_KeyPress);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(130, 99);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(104, 41);
            this.txtDescripcion.TabIndex = 2;
            // 
            // txtCodigoCategoria
            // 
            this.txtCodigoCategoria.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoCategoria.Location = new System.Drawing.Point(130, 68);
            this.txtCodigoCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoCategoria.MaxLength = 1;
            this.txtCodigoCategoria.Name = "txtCodigoCategoria";
            this.txtCodigoCategoria.Size = new System.Drawing.Size(104, 22);
            this.txtCodigoCategoria.TabIndex = 1;
            this.txtCodigoCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoCategoria_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 173);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Valor Hora Extra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sueldo Basico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo de Categoria";
            // 
            // btnModificarCategoria
            // 
            this.btnModificarCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(57)))), ((int)(((byte)(168)))));
            this.btnModificarCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarCategoria.FlatAppearance.BorderSize = 0;
            this.btnModificarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificarCategoria.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCategoria.ForeColor = System.Drawing.Color.White;
            this.btnModificarCategoria.Location = new System.Drawing.Point(130, 197);
            this.btnModificarCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarCategoria.Name = "btnModificarCategoria";
            this.btnModificarCategoria.Size = new System.Drawing.Size(104, 44);
            this.btnModificarCategoria.TabIndex = 0;
            this.btnModificarCategoria.Text = "Modificar categoria";
            this.btnModificarCategoria.UseVisualStyleBackColor = false;
            this.btnModificarCategoria.Click += new System.EventHandler(this.btnModificarCategoria_Click);
            // 
            // btnCargarCategoria
            // 
            this.btnCargarCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(57)))), ((int)(((byte)(168)))));
            this.btnCargarCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarCategoria.FlatAppearance.BorderSize = 0;
            this.btnCargarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCargarCategoria.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarCategoria.ForeColor = System.Drawing.Color.White;
            this.btnCargarCategoria.Location = new System.Drawing.Point(4, 197);
            this.btnCargarCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.btnCargarCategoria.Name = "btnCargarCategoria";
            this.btnCargarCategoria.Size = new System.Drawing.Size(104, 44);
            this.btnCargarCategoria.TabIndex = 5;
            this.btnCargarCategoria.Text = "Cargar categoria";
            this.btnCargarCategoria.UseVisualStyleBackColor = false;
            this.btnCargarCategoria.Click += new System.EventHandler(this.btnCargarCategoria_Click);
            // 
            // lstEmpleados
            // 
            this.lstEmpleados.FormattingEnabled = true;
            this.lstEmpleados.ItemHeight = 15;
            this.lstEmpleados.Location = new System.Drawing.Point(340, 377);
            this.lstEmpleados.Margin = new System.Windows.Forms.Padding(2);
            this.lstEmpleados.Name = "lstEmpleados";
            this.lstEmpleados.Size = new System.Drawing.Size(238, 169);
            this.lstEmpleados.TabIndex = 0;
            this.lstEmpleados.SelectedIndexChanged += new System.EventHandler(this.lstEmpleados_SelectedIndexChanged);
            // 
            // grpEmpleado
            // 
            this.grpEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.grpEmpleado.Controls.Add(this.lblInformacionEmpleado);
            this.grpEmpleado.Controls.Add(this.txtMes);
            this.grpEmpleado.Controls.Add(this.txtCantidadHorasExtras);
            this.grpEmpleado.Controls.Add(this.txtCategoria);
            this.grpEmpleado.Controls.Add(this.txtLegajo);
            this.grpEmpleado.Controls.Add(this.label5);
            this.grpEmpleado.Controls.Add(this.label6);
            this.grpEmpleado.Controls.Add(this.label7);
            this.grpEmpleado.Controls.Add(this.label8);
            this.grpEmpleado.Controls.Add(this.btnModificarEmpleado);
            this.grpEmpleado.Controls.Add(this.btnCargarEmpleado);
            this.grpEmpleado.Cursor = System.Windows.Forms.Cursors.Default;
            this.grpEmpleado.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(27)))), ((int)(((byte)(82)))));
            this.grpEmpleado.Location = new System.Drawing.Point(340, 127);
            this.grpEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.grpEmpleado.Name = "grpEmpleado";
            this.grpEmpleado.Padding = new System.Windows.Forms.Padding(2);
            this.grpEmpleado.Size = new System.Drawing.Size(238, 246);
            this.grpEmpleado.TabIndex = 1;
            this.grpEmpleado.TabStop = false;
            this.grpEmpleado.Text = "Cargar empleado por mes";
            // 
            // lblInformacionEmpleado
            // 
            this.lblInformacionEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblInformacionEmpleado.Font = new System.Drawing.Font("Roboto", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacionEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(140)))), ((int)(((byte)(228)))));
            this.lblInformacionEmpleado.Location = new System.Drawing.Point(16, 24);
            this.lblInformacionEmpleado.Name = "lblInformacionEmpleado";
            this.lblInformacionEmpleado.Size = new System.Drawing.Size(203, 35);
            this.lblInformacionEmpleado.TabIndex = 7;
            this.lblInformacionEmpleado.Text = "INFORMACION IMPORTANTE ANTES DE CARGAR UN MES";
            this.lblInformacionEmpleado.Click += new System.EventHandler(this.lblInformacionEmpleado_Click);
            // 
            // txtMes
            // 
            this.txtMes.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMes.Location = new System.Drawing.Point(130, 154);
            this.txtMes.Margin = new System.Windows.Forms.Padding(2);
            this.txtMes.MaxLength = 2;
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(104, 22);
            this.txtMes.TabIndex = 4;
            this.txtMes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMes_KeyPress);
            // 
            // txtCantidadHorasExtras
            // 
            this.txtCantidadHorasExtras.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadHorasExtras.Location = new System.Drawing.Point(130, 127);
            this.txtCantidadHorasExtras.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidadHorasExtras.Name = "txtCantidadHorasExtras";
            this.txtCantidadHorasExtras.Size = new System.Drawing.Size(104, 22);
            this.txtCantidadHorasExtras.TabIndex = 3;
            this.txtCantidadHorasExtras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadHorasExtras_KeyPress);
            // 
            // txtCategoria
            // 
            this.txtCategoria.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.Location = new System.Drawing.Point(130, 93);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.txtCategoria.MaxLength = 1;
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(104, 22);
            this.txtCategoria.TabIndex = 2;
            this.txtCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCategoria_KeyPress);
            // 
            // txtLegajo
            // 
            this.txtLegajo.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLegajo.Location = new System.Drawing.Point(130, 65);
            this.txtLegajo.Margin = new System.Windows.Forms.Padding(2);
            this.txtLegajo.MaxLength = 2;
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(104, 22);
            this.txtLegajo.TabIndex = 1;
            this.txtLegajo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLegajo_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 156);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mes";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 120);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 36);
            this.label6.TabIndex = 1;
            this.label6.Text = "Cantidad de horas extras";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 95);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Categoria";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 68);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Numero de legajo";
            // 
            // btnModificarEmpleado
            // 
            this.btnModificarEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(57)))), ((int)(((byte)(168)))));
            this.btnModificarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarEmpleado.FlatAppearance.BorderSize = 0;
            this.btnModificarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificarEmpleado.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnModificarEmpleado.Location = new System.Drawing.Point(130, 195);
            this.btnModificarEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarEmpleado.Name = "btnModificarEmpleado";
            this.btnModificarEmpleado.Size = new System.Drawing.Size(104, 44);
            this.btnModificarEmpleado.TabIndex = 0;
            this.btnModificarEmpleado.Text = "Modificar mes";
            this.btnModificarEmpleado.UseVisualStyleBackColor = false;
            this.btnModificarEmpleado.Click += new System.EventHandler(this.btnModificarEmpleado_Click);
            // 
            // btnCargarEmpleado
            // 
            this.btnCargarEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(57)))), ((int)(((byte)(168)))));
            this.btnCargarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarEmpleado.FlatAppearance.BorderSize = 0;
            this.btnCargarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCargarEmpleado.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnCargarEmpleado.Location = new System.Drawing.Point(4, 195);
            this.btnCargarEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.btnCargarEmpleado.Name = "btnCargarEmpleado";
            this.btnCargarEmpleado.Size = new System.Drawing.Size(104, 44);
            this.btnCargarEmpleado.TabIndex = 5;
            this.btnCargarEmpleado.Text = "Cargar mes";
            this.btnCargarEmpleado.UseVisualStyleBackColor = false;
            this.btnCargarEmpleado.Click += new System.EventHandler(this.btnCargarEmpleado_Click);
            // 
            // grpDatosEmpleado
            // 
            this.grpDatosEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.grpDatosEmpleado.Controls.Add(this.lstSueldosMayorPromedio);
            this.grpDatosEmpleado.Controls.Add(this.label14);
            this.grpDatosEmpleado.Controls.Add(this.txtCobroDiciembre);
            this.grpDatosEmpleado.Controls.Add(this.lstPrimerTrimestre);
            this.grpDatosEmpleado.Controls.Add(this.lstSueldoAnual);
            this.grpDatosEmpleado.Controls.Add(this.label15);
            this.grpDatosEmpleado.Controls.Add(this.txtMaximoSueldo);
            this.grpDatosEmpleado.Controls.Add(this.label11);
            this.grpDatosEmpleado.Controls.Add(this.label12);
            this.grpDatosEmpleado.Controls.Add(this.label16);
            this.grpDatosEmpleado.Controls.Add(this.btnMostrarDatos);
            this.grpDatosEmpleado.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatosEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(27)))), ((int)(((byte)(82)))));
            this.grpDatosEmpleado.Location = new System.Drawing.Point(644, 127);
            this.grpDatosEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.grpDatosEmpleado.Name = "grpDatosEmpleado";
            this.grpDatosEmpleado.Padding = new System.Windows.Forms.Padding(2);
            this.grpDatosEmpleado.Size = new System.Drawing.Size(395, 562);
            this.grpDatosEmpleado.TabIndex = 3;
            this.grpDatosEmpleado.TabStop = false;
            this.grpDatosEmpleado.Text = "Datos a saber";
            // 
            // lstSueldosMayorPromedio
            // 
            this.lstSueldosMayorPromedio.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSueldosMayorPromedio.FormattingEnabled = true;
            this.lstSueldosMayorPromedio.ItemHeight = 15;
            this.lstSueldosMayorPromedio.Location = new System.Drawing.Point(112, 137);
            this.lstSueldosMayorPromedio.Margin = new System.Windows.Forms.Padding(2);
            this.lstSueldosMayorPromedio.Name = "lstSueldosMayorPromedio";
            this.lstSueldosMayorPromedio.Size = new System.Drawing.Size(279, 109);
            this.lstSueldosMayorPromedio.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(10, 402);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 63);
            this.label14.TabIndex = 1;
            this.label14.Text = "Quien trabajo menos horas extras el primer trimestre\r\n del año";
            // 
            // txtCobroDiciembre
            // 
            this.txtCobroDiciembre.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCobroDiciembre.Location = new System.Drawing.Point(112, 324);
            this.txtCobroDiciembre.Margin = new System.Windows.Forms.Padding(2);
            this.txtCobroDiciembre.Multiline = true;
            this.txtCobroDiciembre.Name = "txtCobroDiciembre";
            this.txtCobroDiciembre.ReadOnly = true;
            this.txtCobroDiciembre.Size = new System.Drawing.Size(279, 52);
            this.txtCobroDiciembre.TabIndex = 2;
            // 
            // lstPrimerTrimestre
            // 
            this.lstPrimerTrimestre.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPrimerTrimestre.FormattingEnabled = true;
            this.lstPrimerTrimestre.ItemHeight = 15;
            this.lstPrimerTrimestre.Location = new System.Drawing.Point(112, 402);
            this.lstPrimerTrimestre.Margin = new System.Windows.Forms.Padding(2);
            this.lstPrimerTrimestre.Name = "lstPrimerTrimestre";
            this.lstPrimerTrimestre.Size = new System.Drawing.Size(279, 79);
            this.lstPrimerTrimestre.TabIndex = 2;
            // 
            // lstSueldoAnual
            // 
            this.lstSueldoAnual.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSueldoAnual.FormattingEnabled = true;
            this.lstSueldoAnual.ItemHeight = 15;
            this.lstSueldoAnual.Location = new System.Drawing.Point(112, 40);
            this.lstSueldoAnual.Margin = new System.Windows.Forms.Padding(2);
            this.lstSueldoAnual.Name = "lstSueldoAnual";
            this.lstSueldoAnual.Size = new System.Drawing.Size(279, 79);
            this.lstSueldoAnual.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(10, 324);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 50);
            this.label15.TabIndex = 1;
            this.label15.Text = "Quien cobro mas en diciembre";
            // 
            // txtMaximoSueldo
            // 
            this.txtMaximoSueldo.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaximoSueldo.Location = new System.Drawing.Point(112, 265);
            this.txtMaximoSueldo.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaximoSueldo.Name = "txtMaximoSueldo";
            this.txtMaximoSueldo.ReadOnly = true;
            this.txtMaximoSueldo.Size = new System.Drawing.Size(279, 22);
            this.txtMaximoSueldo.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 137);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 74);
            this.label11.TabIndex = 1;
            this.label11.Text = "Sueldos que superan el salario promedio de cada empleado";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(10, 40);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 38);
            this.label12.TabIndex = 1;
            this.label12.Text = "Sueldo anual de cada empleado";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(10, 265);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 40);
            this.label16.TabIndex = 1;
            this.label16.Text = "Sueldo maximo pagado en un mes";
            // 
            // btnMostrarDatos
            // 
            this.btnMostrarDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(57)))), ((int)(((byte)(168)))));
            this.btnMostrarDatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarDatos.FlatAppearance.BorderSize = 0;
            this.btnMostrarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMostrarDatos.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarDatos.ForeColor = System.Drawing.Color.White;
            this.btnMostrarDatos.Location = new System.Drawing.Point(163, 497);
            this.btnMostrarDatos.Margin = new System.Windows.Forms.Padding(2);
            this.btnMostrarDatos.Name = "btnMostrarDatos";
            this.btnMostrarDatos.Size = new System.Drawing.Size(94, 32);
            this.btnMostrarDatos.TabIndex = 0;
            this.btnMostrarDatos.Text = "Mostrar datos";
            this.btnMostrarDatos.UseVisualStyleBackColor = false;
            this.btnMostrarDatos.Click += new System.EventHandler(this.btnMostrarDatos_Click);
            // 
            // lblAntesDeIniciar
            // 
            this.lblAntesDeIniciar.AutoSize = true;
            this.lblAntesDeIniciar.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAntesDeIniciar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lblAntesDeIniciar.Location = new System.Drawing.Point(28, 22);
            this.lblAntesDeIniciar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAntesDeIniciar.Name = "lblAntesDeIniciar";
            this.lblAntesDeIniciar.Size = new System.Drawing.Size(408, 28);
            this.lblAntesDeIniciar.TabIndex = 4;
            this.lblAntesDeIniciar.Text = "Por favor inicie sesion antes de proseguir";
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(27)))), ((int)(((byte)(87)))));
            this.btnIniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciarSesion.FlatAppearance.BorderSize = 0;
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion.Location = new System.Drawing.Point(428, 50);
            this.btnIniciarSesion.Margin = new System.Windows.Forms.Padding(2);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(124, 46);
            this.btnIniciarSesion.TabIndex = 5;
            this.btnIniciarSesion.Text = "Iniciar Sesion";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(27)))), ((int)(((byte)(87)))));
            this.btnRegistrarse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarse.FlatAppearance.BorderSize = 0;
            this.btnRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrarse.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarse.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarse.Location = new System.Drawing.Point(566, 50);
            this.btnRegistrarse.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(124, 46);
            this.btnRegistrarse.TabIndex = 5;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = false;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // lblSaludo
            // 
            this.lblSaludo.AutoSize = true;
            this.lblSaludo.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaludo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lblSaludo.Location = new System.Drawing.Point(78, 59);
            this.lblSaludo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(139, 28);
            this.lblSaludo.TabIndex = 6;
            this.lblSaludo.Text = "Hola usuario!";
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(27)))), ((int)(((byte)(87)))));
            this.btnEliminarCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarCategoria.FlatAppearance.BorderSize = 0;
            this.btnEliminarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarCategoria.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCategoria.ForeColor = System.Drawing.Color.White;
            this.btnEliminarCategoria.Location = new System.Drawing.Point(33, 551);
            this.btnEliminarCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(238, 29);
            this.btnEliminarCategoria.TabIndex = 7;
            this.btnEliminarCategoria.Text = "Eliminar categoria";
            this.btnEliminarCategoria.UseVisualStyleBackColor = false;
            this.btnEliminarCategoria.Click += new System.EventHandler(this.btnEliminarCategoria_Click);
            // 
            // btnEliminarEmpleado
            // 
            this.btnEliminarEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(27)))), ((int)(((byte)(87)))));
            this.btnEliminarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarEmpleado.FlatAppearance.BorderSize = 0;
            this.btnEliminarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarEmpleado.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnEliminarEmpleado.Location = new System.Drawing.Point(340, 551);
            this.btnEliminarEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            this.btnEliminarEmpleado.Size = new System.Drawing.Size(238, 29);
            this.btnEliminarEmpleado.TabIndex = 7;
            this.btnEliminarEmpleado.Text = "Eliminar mes";
            this.btnEliminarEmpleado.UseVisualStyleBackColor = false;
            this.btnEliminarEmpleado.Click += new System.EventHandler(this.btnEliminarEmpleado_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(27)))), ((int)(((byte)(87)))));
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Location = new System.Drawing.Point(915, 50);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(124, 46);
            this.btnCerrarSesion.TabIndex = 8;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(211, 617);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(216, 35);
            this.label9.TabIndex = 10;
            this.label9.Text = "MADA Creations";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoTP.Resource1.icons8_phoenix_framework_125px_1;
            this.pictureBox1.Location = new System.Drawing.Point(52, 593);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // picUsuario
            // 
            this.picUsuario.Image = global::ProyectoTP.Resource1.Groupicon;
            this.picUsuario.Location = new System.Drawing.Point(33, 53);
            this.picUsuario.Name = "picUsuario";
            this.picUsuario.Size = new System.Drawing.Size(40, 40);
            this.picUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picUsuario.TabIndex = 11;
            this.picUsuario.TabStop = false;
            // 
            // lblInformacionCategoria
            // 
            this.lblInformacionCategoria.Font = new System.Drawing.Font("Roboto", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacionCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(140)))), ((int)(((byte)(228)))));
            this.lblInformacionCategoria.Location = new System.Drawing.Point(16, 24);
            this.lblInformacionCategoria.Name = "lblInformacionCategoria";
            this.lblInformacionCategoria.Size = new System.Drawing.Size(203, 35);
            this.lblInformacionCategoria.TabIndex = 6;
            this.lblInformacionCategoria.Text = "INFORMACION IMPORTANTE ANTES DE CARGAR UNA CATEGORIA";
            this.lblInformacionCategoria.Click += new System.EventHandler(this.lblInformacionCategoria_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(118)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(1118, 710);
            this.Controls.Add(this.picUsuario);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnEliminarEmpleado);
            this.Controls.Add(this.btnEliminarCategoria);
            this.Controls.Add(this.lblSaludo);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.lblAntesDeIniciar);
            this.Controls.Add(this.grpDatosEmpleado);
            this.Controls.Add(this.grpEmpleado);
            this.Controls.Add(this.grpCategoria);
            this.Controls.Add(this.lstEmpleados);
            this.Controls.Add(this.lstGeneral);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ",";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.grpCategoria.ResumeLayout(false);
            this.grpCategoria.PerformLayout();
            this.grpEmpleado.ResumeLayout(false);
            this.grpEmpleado.PerformLayout();
            this.grpDatosEmpleado.ResumeLayout(false);
            this.grpDatosEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstGeneral;
        private System.Windows.Forms.GroupBox grpCategoria;
        private System.Windows.Forms.TextBox txtValorHoraExtra;
        private System.Windows.Forms.TextBox txtSueldoBasico;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCodigoCategoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCargarCategoria;
        private System.Windows.Forms.ListBox lstEmpleados;
        private System.Windows.Forms.GroupBox grpEmpleado;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.TextBox txtCantidadHorasExtras;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCargarEmpleado;
        private System.Windows.Forms.GroupBox grpDatosEmpleado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnMostrarDatos;
        private System.Windows.Forms.TextBox txtCobroDiciembre;
        private System.Windows.Forms.TextBox txtMaximoSueldo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblAntesDeIniciar;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.Label lblSaludo;
        private System.Windows.Forms.Button btnModificarCategoria;
        private System.Windows.Forms.Button btnModificarEmpleado;
        private System.Windows.Forms.Button btnEliminarCategoria;
        private System.Windows.Forms.Button btnEliminarEmpleado;
        private System.Windows.Forms.ListBox lstSueldosMayorPromedio;
        private System.Windows.Forms.ListBox lstSueldoAnual;
        private System.Windows.Forms.ListBox lstPrimerTrimestre;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox picUsuario;
        private System.Windows.Forms.Label lblInformacionEmpleado;
        private System.Windows.Forms.Label lblInformacionCategoria;
    }
}