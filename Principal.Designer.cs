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
            this.txtSueldosMayorPromedio = new System.Windows.Forms.TextBox();
            this.txtSueldoAnual = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnDatosIndividuales = new System.Windows.Forms.Button();
            this.grpGeneral = new System.Windows.Forms.GroupBox();
            this.txtMenosHorasExtras = new System.Windows.Forms.TextBox();
            this.txtCobroDiciembre = new System.Windows.Forms.TextBox();
            this.txtMaximoSueldo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnDatosGenerales = new System.Windows.Forms.Button();
            this.lblAntesDeIniciar = new System.Windows.Forms.Label();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.lblSaludo = new System.Windows.Forms.Label();
            this.btnEliminarCategoria = new System.Windows.Forms.Button();
            this.btnEliminarEmpleado = new System.Windows.Forms.Button();
            this.grpCategoria.SuspendLayout();
            this.grpEmpleado.SuspendLayout();
            this.grpDatosEmpleado.SuspendLayout();
            this.grpGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstGeneral
            // 
            this.lstGeneral.FormattingEnabled = true;
            this.lstGeneral.ItemHeight = 16;
            this.lstGeneral.Location = new System.Drawing.Point(44, 373);
            this.lstGeneral.Name = "lstGeneral";
            this.lstGeneral.Size = new System.Drawing.Size(297, 180);
            this.lstGeneral.TabIndex = 0;
            this.lstGeneral.SelectedIndexChanged += new System.EventHandler(this.lstGeneral_SelectedIndexChanged);
            // 
            // grpCategoria
            // 
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
            this.grpCategoria.Location = new System.Drawing.Point(44, 135);
            this.grpCategoria.Name = "grpCategoria";
            this.grpCategoria.Size = new System.Drawing.Size(297, 232);
            this.grpCategoria.TabIndex = 1;
            this.grpCategoria.TabStop = false;
            this.grpCategoria.Text = "Cargar Categoria";
            // 
            // txtValorHoraExtra
            // 
            this.txtValorHoraExtra.Location = new System.Drawing.Point(153, 149);
            this.txtValorHoraExtra.Name = "txtValorHoraExtra";
            this.txtValorHoraExtra.Size = new System.Drawing.Size(138, 22);
            this.txtValorHoraExtra.TabIndex = 4;
            // 
            // txtSueldoBasico
            // 
            this.txtSueldoBasico.Location = new System.Drawing.Point(153, 120);
            this.txtSueldoBasico.Name = "txtSueldoBasico";
            this.txtSueldoBasico.Size = new System.Drawing.Size(138, 22);
            this.txtSueldoBasico.TabIndex = 3;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(153, 69);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(138, 44);
            this.txtDescripcion.TabIndex = 2;
            // 
            // txtCodigoCategoria
            // 
            this.txtCodigoCategoria.Location = new System.Drawing.Point(153, 40);
            this.txtCodigoCategoria.Name = "txtCodigoCategoria";
            this.txtCodigoCategoria.Size = new System.Drawing.Size(138, 22);
            this.txtCodigoCategoria.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Valor Hora Extra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sueldo Basico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo de Categoria";
            // 
            // btnModificarCategoria
            // 
            this.btnModificarCategoria.Location = new System.Drawing.Point(153, 179);
            this.btnModificarCategoria.Name = "btnModificarCategoria";
            this.btnModificarCategoria.Size = new System.Drawing.Size(138, 47);
            this.btnModificarCategoria.TabIndex = 0;
            this.btnModificarCategoria.Text = "Modificar categoria";
            this.btnModificarCategoria.UseVisualStyleBackColor = true;
            this.btnModificarCategoria.Click += new System.EventHandler(this.btnModificarCategoria_Click);
            // 
            // btnCargarCategoria
            // 
            this.btnCargarCategoria.Location = new System.Drawing.Point(6, 179);
            this.btnCargarCategoria.Name = "btnCargarCategoria";
            this.btnCargarCategoria.Size = new System.Drawing.Size(138, 47);
            this.btnCargarCategoria.TabIndex = 5;
            this.btnCargarCategoria.Text = "Cargar categoria";
            this.btnCargarCategoria.UseVisualStyleBackColor = true;
            this.btnCargarCategoria.Click += new System.EventHandler(this.btnCargarCategoria_Click);
            // 
            // lstEmpleados
            // 
            this.lstEmpleados.FormattingEnabled = true;
            this.lstEmpleados.ItemHeight = 16;
            this.lstEmpleados.Location = new System.Drawing.Point(454, 373);
            this.lstEmpleados.Name = "lstEmpleados";
            this.lstEmpleados.Size = new System.Drawing.Size(297, 180);
            this.lstEmpleados.TabIndex = 0;
            this.lstEmpleados.SelectedIndexChanged += new System.EventHandler(this.lstEmpleados_SelectedIndexChanged);
            // 
            // grpEmpleado
            // 
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
            this.grpEmpleado.Location = new System.Drawing.Point(454, 135);
            this.grpEmpleado.Name = "grpEmpleado";
            this.grpEmpleado.Size = new System.Drawing.Size(297, 232);
            this.grpEmpleado.TabIndex = 1;
            this.grpEmpleado.TabStop = false;
            this.grpEmpleado.Text = "Cargar empleado por mes";
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(153, 134);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(138, 22);
            this.txtMes.TabIndex = 4;
            // 
            // txtCantidadHorasExtras
            // 
            this.txtCantidadHorasExtras.Location = new System.Drawing.Point(153, 106);
            this.txtCantidadHorasExtras.Name = "txtCantidadHorasExtras";
            this.txtCantidadHorasExtras.Size = new System.Drawing.Size(138, 22);
            this.txtCantidadHorasExtras.TabIndex = 3;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(153, 69);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(138, 22);
            this.txtCategoria.TabIndex = 2;
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(153, 40);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(138, 22);
            this.txtLegajo.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mes";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(21, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 38);
            this.label6.TabIndex = 1;
            this.label6.Text = "Cantidad de horas extras";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Categoria";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Numero de legajo";
            // 
            // btnModificarEmpleado
            // 
            this.btnModificarEmpleado.Location = new System.Drawing.Point(153, 179);
            this.btnModificarEmpleado.Name = "btnModificarEmpleado";
            this.btnModificarEmpleado.Size = new System.Drawing.Size(138, 47);
            this.btnModificarEmpleado.TabIndex = 0;
            this.btnModificarEmpleado.Text = "Modificar empleado";
            this.btnModificarEmpleado.UseVisualStyleBackColor = true;
            this.btnModificarEmpleado.Click += new System.EventHandler(this.btnModificarEmpleado_Click);
            // 
            // btnCargarEmpleado
            // 
            this.btnCargarEmpleado.Location = new System.Drawing.Point(6, 179);
            this.btnCargarEmpleado.Name = "btnCargarEmpleado";
            this.btnCargarEmpleado.Size = new System.Drawing.Size(138, 47);
            this.btnCargarEmpleado.TabIndex = 5;
            this.btnCargarEmpleado.Text = "Cargar empleado";
            this.btnCargarEmpleado.UseVisualStyleBackColor = true;
            this.btnCargarEmpleado.Click += new System.EventHandler(this.btnCargarEmpleado_Click);
            // 
            // grpDatosEmpleado
            // 
            this.grpDatosEmpleado.Controls.Add(this.txtSueldosMayorPromedio);
            this.grpDatosEmpleado.Controls.Add(this.txtSueldoAnual);
            this.grpDatosEmpleado.Controls.Add(this.label11);
            this.grpDatosEmpleado.Controls.Add(this.label12);
            this.grpDatosEmpleado.Controls.Add(this.btnDatosIndividuales);
            this.grpDatosEmpleado.Location = new System.Drawing.Point(448, 632);
            this.grpDatosEmpleado.Name = "grpDatosEmpleado";
            this.grpDatosEmpleado.Size = new System.Drawing.Size(297, 270);
            this.grpDatosEmpleado.TabIndex = 3;
            this.grpDatosEmpleado.TabStop = false;
            this.grpDatosEmpleado.Text = "Datos de un empleado";
            // 
            // txtSueldosMayorPromedio
            // 
            this.txtSueldosMayorPromedio.Location = new System.Drawing.Point(159, 69);
            this.txtSueldosMayorPromedio.Multiline = true;
            this.txtSueldosMayorPromedio.Name = "txtSueldosMayorPromedio";
            this.txtSueldosMayorPromedio.ReadOnly = true;
            this.txtSueldosMayorPromedio.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSueldosMayorPromedio.Size = new System.Drawing.Size(132, 84);
            this.txtSueldosMayorPromedio.TabIndex = 2;
            // 
            // txtSueldoAnual
            // 
            this.txtSueldoAnual.Location = new System.Drawing.Point(159, 40);
            this.txtSueldoAnual.Name = "txtSueldoAnual";
            this.txtSueldoAnual.ReadOnly = true;
            this.txtSueldoAnual.Size = new System.Drawing.Size(132, 22);
            this.txtSueldoAnual.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(21, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 56);
            this.label11.TabIndex = 1;
            this.label11.Text = "Sueldos que superan el promedio";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 16);
            this.label12.TabIndex = 1;
            this.label12.Text = "Sueldo anual";
            // 
            // btnDatosIndividuales
            // 
            this.btnDatosIndividuales.Location = new System.Drawing.Point(86, 211);
            this.btnDatosIndividuales.Name = "btnDatosIndividuales";
            this.btnDatosIndividuales.Size = new System.Drawing.Size(125, 34);
            this.btnDatosIndividuales.TabIndex = 0;
            this.btnDatosIndividuales.Text = "Mostrar datos";
            this.btnDatosIndividuales.UseVisualStyleBackColor = true;
            // 
            // grpGeneral
            // 
            this.grpGeneral.Controls.Add(this.txtMenosHorasExtras);
            this.grpGeneral.Controls.Add(this.txtCobroDiciembre);
            this.grpGeneral.Controls.Add(this.txtMaximoSueldo);
            this.grpGeneral.Controls.Add(this.label14);
            this.grpGeneral.Controls.Add(this.label15);
            this.grpGeneral.Controls.Add(this.label16);
            this.grpGeneral.Controls.Add(this.btnDatosGenerales);
            this.grpGeneral.Location = new System.Drawing.Point(38, 632);
            this.grpGeneral.Name = "grpGeneral";
            this.grpGeneral.Size = new System.Drawing.Size(297, 270);
            this.grpGeneral.TabIndex = 3;
            this.grpGeneral.TabStop = false;
            this.grpGeneral.Text = "Datos generales";
            // 
            // txtMenosHorasExtras
            // 
            this.txtMenosHorasExtras.Location = new System.Drawing.Point(159, 150);
            this.txtMenosHorasExtras.Name = "txtMenosHorasExtras";
            this.txtMenosHorasExtras.ReadOnly = true;
            this.txtMenosHorasExtras.Size = new System.Drawing.Size(132, 22);
            this.txtMenosHorasExtras.TabIndex = 2;
            // 
            // txtCobroDiciembre
            // 
            this.txtCobroDiciembre.Location = new System.Drawing.Point(159, 69);
            this.txtCobroDiciembre.Multiline = true;
            this.txtCobroDiciembre.Name = "txtCobroDiciembre";
            this.txtCobroDiciembre.ReadOnly = true;
            this.txtCobroDiciembre.Size = new System.Drawing.Size(132, 56);
            this.txtCobroDiciembre.TabIndex = 2;
            // 
            // txtMaximoSueldo
            // 
            this.txtMaximoSueldo.Location = new System.Drawing.Point(159, 40);
            this.txtMaximoSueldo.Name = "txtMaximoSueldo";
            this.txtMaximoSueldo.ReadOnly = true;
            this.txtMaximoSueldo.Size = new System.Drawing.Size(132, 22);
            this.txtMaximoSueldo.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(21, 131);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 61);
            this.label14.TabIndex = 1;
            this.label14.Text = "Quien trabajo menos horas extras el primer trimestre\r\n";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(21, 81);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 32);
            this.label15.TabIndex = 1;
            this.label15.Text = "Quien cobro mas en diciembre";
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(21, 43);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(115, 16);
            this.label16.TabIndex = 1;
            this.label16.Text = "Maximo sueldo pagado en un mes";
            // 
            // btnDatosGenerales
            // 
            this.btnDatosGenerales.Location = new System.Drawing.Point(86, 211);
            this.btnDatosGenerales.Name = "btnDatosGenerales";
            this.btnDatosGenerales.Size = new System.Drawing.Size(125, 34);
            this.btnDatosGenerales.TabIndex = 0;
            this.btnDatosGenerales.Text = "Mostrar datos";
            this.btnDatosGenerales.UseVisualStyleBackColor = true;
            // 
            // lblAntesDeIniciar
            // 
            this.lblAntesDeIniciar.AutoSize = true;
            this.lblAntesDeIniciar.Location = new System.Drawing.Point(41, 9);
            this.lblAntesDeIniciar.Name = "lblAntesDeIniciar";
            this.lblAntesDeIniciar.Size = new System.Drawing.Size(253, 16);
            this.lblAntesDeIniciar.TabIndex = 4;
            this.lblAntesDeIniciar.Text = "Por favor inicie sesion antes de proseguir";
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Location = new System.Drawing.Point(263, 40);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(125, 34);
            this.btnIniciarSesion.TabIndex = 5;
            this.btnIniciarSesion.Text = "Iniciar Sesion";
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.Location = new System.Drawing.Point(412, 40);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(125, 34);
            this.btnRegistrarse.TabIndex = 5;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = true;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // lblSaludo
            // 
            this.lblSaludo.AutoSize = true;
            this.lblSaludo.Location = new System.Drawing.Point(41, 49);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(44, 16);
            this.lblSaludo.TabIndex = 6;
            this.lblSaludo.Text = "label9";
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.Location = new System.Drawing.Point(44, 559);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(297, 31);
            this.btnEliminarCategoria.TabIndex = 7;
            this.btnEliminarCategoria.Text = "Eliminar categoria";
            this.btnEliminarCategoria.UseVisualStyleBackColor = true;
            this.btnEliminarCategoria.Click += new System.EventHandler(this.btnEliminarCategoria_Click);
            // 
            // btnEliminarEmpleado
            // 
            this.btnEliminarEmpleado.Location = new System.Drawing.Point(454, 559);
            this.btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            this.btnEliminarEmpleado.Size = new System.Drawing.Size(297, 31);
            this.btnEliminarEmpleado.TabIndex = 7;
            this.btnEliminarEmpleado.Text = "Eliminar empleado";
            this.btnEliminarEmpleado.UseVisualStyleBackColor = true;
            this.btnEliminarEmpleado.Click += new System.EventHandler(this.btnEliminarEmpleado_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 957);
            this.Controls.Add(this.btnEliminarEmpleado);
            this.Controls.Add(this.btnEliminarCategoria);
            this.Controls.Add(this.lblSaludo);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.lblAntesDeIniciar);
            this.Controls.Add(this.grpGeneral);
            this.Controls.Add(this.grpDatosEmpleado);
            this.Controls.Add(this.grpEmpleado);
            this.Controls.Add(this.grpCategoria);
            this.Controls.Add(this.lstEmpleados);
            this.Controls.Add(this.lstGeneral);
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
            this.grpGeneral.ResumeLayout(false);
            this.grpGeneral.PerformLayout();
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
        private System.Windows.Forms.TextBox txtSueldosMayorPromedio;
        private System.Windows.Forms.TextBox txtSueldoAnual;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnDatosIndividuales;
        private System.Windows.Forms.GroupBox grpGeneral;
        private System.Windows.Forms.TextBox txtMenosHorasExtras;
        private System.Windows.Forms.TextBox txtCobroDiciembre;
        private System.Windows.Forms.TextBox txtMaximoSueldo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnDatosGenerales;
        private System.Windows.Forms.Label lblAntesDeIniciar;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.Label lblSaludo;
        private System.Windows.Forms.Button btnModificarCategoria;
        private System.Windows.Forms.Button btnModificarEmpleado;
        private System.Windows.Forms.Button btnEliminarCategoria;
        private System.Windows.Forms.Button btnEliminarEmpleado;
    }
}