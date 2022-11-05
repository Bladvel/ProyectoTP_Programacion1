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
            this.btnDatosIndividuales = new System.Windows.Forms.Button();
            this.lblAntesDeIniciar = new System.Windows.Forms.Label();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.lblSaludo = new System.Windows.Forms.Label();
            this.btnEliminarCategoria = new System.Windows.Forms.Button();
            this.btnEliminarEmpleado = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.grpCategoria.SuspendLayout();
            this.grpEmpleado.SuspendLayout();
            this.grpDatosEmpleado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstGeneral
            // 
            this.lstGeneral.FormattingEnabled = true;
            this.lstGeneral.Location = new System.Drawing.Point(33, 303);
            this.lstGeneral.Margin = new System.Windows.Forms.Padding(2);
            this.lstGeneral.Name = "lstGeneral";
            this.lstGeneral.Size = new System.Drawing.Size(224, 147);
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
            this.grpCategoria.Location = new System.Drawing.Point(33, 110);
            this.grpCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.grpCategoria.Name = "grpCategoria";
            this.grpCategoria.Padding = new System.Windows.Forms.Padding(2);
            this.grpCategoria.Size = new System.Drawing.Size(223, 188);
            this.grpCategoria.TabIndex = 1;
            this.grpCategoria.TabStop = false;
            this.grpCategoria.Text = "Cargar Categoria";
            // 
            // txtValorHoraExtra
            // 
            this.txtValorHoraExtra.Location = new System.Drawing.Point(115, 121);
            this.txtValorHoraExtra.Margin = new System.Windows.Forms.Padding(2);
            this.txtValorHoraExtra.Name = "txtValorHoraExtra";
            this.txtValorHoraExtra.Size = new System.Drawing.Size(104, 20);
            this.txtValorHoraExtra.TabIndex = 4;
            // 
            // txtSueldoBasico
            // 
            this.txtSueldoBasico.Location = new System.Drawing.Point(115, 98);
            this.txtSueldoBasico.Margin = new System.Windows.Forms.Padding(2);
            this.txtSueldoBasico.Name = "txtSueldoBasico";
            this.txtSueldoBasico.Size = new System.Drawing.Size(104, 20);
            this.txtSueldoBasico.TabIndex = 3;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(115, 56);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(104, 36);
            this.txtDescripcion.TabIndex = 2;
            // 
            // txtCodigoCategoria
            // 
            this.txtCodigoCategoria.Location = new System.Drawing.Point(115, 32);
            this.txtCodigoCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoCategoria.Name = "txtCodigoCategoria";
            this.txtCodigoCategoria.Size = new System.Drawing.Size(104, 20);
            this.txtCodigoCategoria.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Valor Hora Extra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sueldo Basico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo de Categoria";
            // 
            // btnModificarCategoria
            // 
            this.btnModificarCategoria.Location = new System.Drawing.Point(115, 145);
            this.btnModificarCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarCategoria.Name = "btnModificarCategoria";
            this.btnModificarCategoria.Size = new System.Drawing.Size(104, 38);
            this.btnModificarCategoria.TabIndex = 0;
            this.btnModificarCategoria.Text = "Modificar categoria";
            this.btnModificarCategoria.UseVisualStyleBackColor = true;
            this.btnModificarCategoria.Click += new System.EventHandler(this.btnModificarCategoria_Click);
            // 
            // btnCargarCategoria
            // 
            this.btnCargarCategoria.Location = new System.Drawing.Point(4, 145);
            this.btnCargarCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.btnCargarCategoria.Name = "btnCargarCategoria";
            this.btnCargarCategoria.Size = new System.Drawing.Size(104, 38);
            this.btnCargarCategoria.TabIndex = 5;
            this.btnCargarCategoria.Text = "Cargar categoria";
            this.btnCargarCategoria.UseVisualStyleBackColor = true;
            this.btnCargarCategoria.Click += new System.EventHandler(this.btnCargarCategoria_Click);
            // 
            // lstEmpleados
            // 
            this.lstEmpleados.FormattingEnabled = true;
            this.lstEmpleados.Location = new System.Drawing.Point(340, 303);
            this.lstEmpleados.Margin = new System.Windows.Forms.Padding(2);
            this.lstEmpleados.Name = "lstEmpleados";
            this.lstEmpleados.Size = new System.Drawing.Size(224, 147);
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
            this.grpEmpleado.Location = new System.Drawing.Point(340, 110);
            this.grpEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.grpEmpleado.Name = "grpEmpleado";
            this.grpEmpleado.Padding = new System.Windows.Forms.Padding(2);
            this.grpEmpleado.Size = new System.Drawing.Size(223, 188);
            this.grpEmpleado.TabIndex = 1;
            this.grpEmpleado.TabStop = false;
            this.grpEmpleado.Text = "Cargar empleado por mes";
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(115, 109);
            this.txtMes.Margin = new System.Windows.Forms.Padding(2);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(104, 20);
            this.txtMes.TabIndex = 4;
            // 
            // txtCantidadHorasExtras
            // 
            this.txtCantidadHorasExtras.Location = new System.Drawing.Point(115, 86);
            this.txtCantidadHorasExtras.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidadHorasExtras.Name = "txtCantidadHorasExtras";
            this.txtCantidadHorasExtras.Size = new System.Drawing.Size(104, 20);
            this.txtCantidadHorasExtras.TabIndex = 3;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(115, 56);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(104, 20);
            this.txtCategoria.TabIndex = 2;
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(115, 32);
            this.txtLegajo.Margin = new System.Windows.Forms.Padding(2);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(104, 20);
            this.txtLegajo.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 111);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mes";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(16, 80);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 31);
            this.label6.TabIndex = 1;
            this.label6.Text = "Cantidad de horas extras";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 58);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Categoria";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 35);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Numero de legajo";
            // 
            // btnModificarEmpleado
            // 
            this.btnModificarEmpleado.Location = new System.Drawing.Point(115, 145);
            this.btnModificarEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarEmpleado.Name = "btnModificarEmpleado";
            this.btnModificarEmpleado.Size = new System.Drawing.Size(104, 38);
            this.btnModificarEmpleado.TabIndex = 0;
            this.btnModificarEmpleado.Text = "Modificar empleado";
            this.btnModificarEmpleado.UseVisualStyleBackColor = true;
            this.btnModificarEmpleado.Click += new System.EventHandler(this.btnModificarEmpleado_Click);
            // 
            // btnCargarEmpleado
            // 
            this.btnCargarEmpleado.Location = new System.Drawing.Point(4, 145);
            this.btnCargarEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.btnCargarEmpleado.Name = "btnCargarEmpleado";
            this.btnCargarEmpleado.Size = new System.Drawing.Size(104, 38);
            this.btnCargarEmpleado.TabIndex = 5;
            this.btnCargarEmpleado.Text = "Cargar empleado";
            this.btnCargarEmpleado.UseVisualStyleBackColor = true;
            this.btnCargarEmpleado.Click += new System.EventHandler(this.btnCargarEmpleado_Click);
            // 
            // grpDatosEmpleado
            // 
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
            this.grpDatosEmpleado.Controls.Add(this.btnDatosIndividuales);
            this.grpDatosEmpleado.Location = new System.Drawing.Point(135, 502);
            this.grpDatosEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.grpDatosEmpleado.Name = "grpDatosEmpleado";
            this.grpDatosEmpleado.Padding = new System.Windows.Forms.Padding(2);
            this.grpDatosEmpleado.Size = new System.Drawing.Size(330, 462);
            this.grpDatosEmpleado.TabIndex = 3;
            this.grpDatosEmpleado.TabStop = false;
            this.grpDatosEmpleado.Text = "Datos a saber";
            // 
            // lstSueldosMayorPromedio
            // 
            this.lstSueldosMayorPromedio.FormattingEnabled = true;
            this.lstSueldosMayorPromedio.Location = new System.Drawing.Point(112, 119);
            this.lstSueldosMayorPromedio.Margin = new System.Windows.Forms.Padding(2);
            this.lstSueldosMayorPromedio.Name = "lstSueldosMayorPromedio";
            this.lstSueldosMayorPromedio.Size = new System.Drawing.Size(204, 95);
            this.lstSueldosMayorPromedio.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(10, 331);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 50);
            this.label14.TabIndex = 1;
            this.label14.Text = "Quien trabajo menos horas extras el primer trimestre\r\n";
            // 
            // txtCobroDiciembre
            // 
            this.txtCobroDiciembre.Location = new System.Drawing.Point(112, 264);
            this.txtCobroDiciembre.Margin = new System.Windows.Forms.Padding(2);
            this.txtCobroDiciembre.Multiline = true;
            this.txtCobroDiciembre.Name = "txtCobroDiciembre";
            this.txtCobroDiciembre.ReadOnly = true;
            this.txtCobroDiciembre.Size = new System.Drawing.Size(204, 46);
            this.txtCobroDiciembre.TabIndex = 2;
            // 
            // lstPrimerTrimestre
            // 
            this.lstPrimerTrimestre.FormattingEnabled = true;
            this.lstPrimerTrimestre.Location = new System.Drawing.Point(112, 331);
            this.lstPrimerTrimestre.Margin = new System.Windows.Forms.Padding(2);
            this.lstPrimerTrimestre.Name = "lstPrimerTrimestre";
            this.lstPrimerTrimestre.Size = new System.Drawing.Size(204, 69);
            this.lstPrimerTrimestre.TabIndex = 2;
            // 
            // lstSueldoAnual
            // 
            this.lstSueldoAnual.FormattingEnabled = true;
            this.lstSueldoAnual.Location = new System.Drawing.Point(112, 35);
            this.lstSueldoAnual.Margin = new System.Windows.Forms.Padding(2);
            this.lstSueldoAnual.Name = "lstSueldoAnual";
            this.lstSueldoAnual.Size = new System.Drawing.Size(204, 69);
            this.lstSueldoAnual.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(10, 264);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 43);
            this.label15.TabIndex = 1;
            this.label15.Text = "Quien cobro mas en diciembre";
            // 
            // txtMaximoSueldo
            // 
            this.txtMaximoSueldo.Location = new System.Drawing.Point(112, 230);
            this.txtMaximoSueldo.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaximoSueldo.Name = "txtMaximoSueldo";
            this.txtMaximoSueldo.ReadOnly = true;
            this.txtMaximoSueldo.Size = new System.Drawing.Size(204, 20);
            this.txtMaximoSueldo.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(16, 137);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 58);
            this.label11.TabIndex = 1;
            this.label11.Text = "Sueldos que superan el promedio de cada uno";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 63);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Sueldo anual";
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(10, 232);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Maximo sueldo pagado en un mes";
            // 
            // btnDatosIndividuales
            // 
            this.btnDatosIndividuales.Location = new System.Drawing.Point(118, 414);
            this.btnDatosIndividuales.Margin = new System.Windows.Forms.Padding(2);
            this.btnDatosIndividuales.Name = "btnDatosIndividuales";
            this.btnDatosIndividuales.Size = new System.Drawing.Size(94, 28);
            this.btnDatosIndividuales.TabIndex = 0;
            this.btnDatosIndividuales.Text = "Mostrar datos";
            this.btnDatosIndividuales.UseVisualStyleBackColor = true;
            this.btnDatosIndividuales.Click += new System.EventHandler(this.btnDatosIndividuales_Click);
            // 
            // lblAntesDeIniciar
            // 
            this.lblAntesDeIniciar.AutoSize = true;
            this.lblAntesDeIniciar.Location = new System.Drawing.Point(31, 7);
            this.lblAntesDeIniciar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAntesDeIniciar.Name = "lblAntesDeIniciar";
            this.lblAntesDeIniciar.Size = new System.Drawing.Size(200, 13);
            this.lblAntesDeIniciar.TabIndex = 4;
            this.lblAntesDeIniciar.Text = "Por favor inicie sesion antes de proseguir";
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Location = new System.Drawing.Point(197, 32);
            this.btnIniciarSesion.Margin = new System.Windows.Forms.Padding(2);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(94, 28);
            this.btnIniciarSesion.TabIndex = 5;
            this.btnIniciarSesion.Text = "Iniciar Sesion";
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.Location = new System.Drawing.Point(309, 32);
            this.btnRegistrarse.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(94, 28);
            this.btnRegistrarse.TabIndex = 5;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = true;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // lblSaludo
            // 
            this.lblSaludo.AutoSize = true;
            this.lblSaludo.Location = new System.Drawing.Point(34, 9);
            this.lblSaludo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(35, 13);
            this.lblSaludo.TabIndex = 6;
            this.lblSaludo.Text = "label9";
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.Location = new System.Drawing.Point(33, 454);
            this.btnEliminarCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(223, 25);
            this.btnEliminarCategoria.TabIndex = 7;
            this.btnEliminarCategoria.Text = "Eliminar categoria";
            this.btnEliminarCategoria.UseVisualStyleBackColor = true;
            this.btnEliminarCategoria.Click += new System.EventHandler(this.btnEliminarCategoria_Click);
            // 
            // btnEliminarEmpleado
            // 
            this.btnEliminarEmpleado.Location = new System.Drawing.Point(340, 454);
            this.btnEliminarEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            this.btnEliminarEmpleado.Size = new System.Drawing.Size(223, 25);
            this.btnEliminarEmpleado.TabIndex = 7;
            this.btnEliminarEmpleado.Text = "Eliminar empleado";
            this.btnEliminarEmpleado.UseVisualStyleBackColor = true;
            this.btnEliminarEmpleado.Click += new System.EventHandler(this.btnEliminarEmpleado_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(253, 32);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(94, 28);
            this.btnCerrarSesion.TabIndex = 8;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(600, 990);
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
        private System.Windows.Forms.Button btnDatosIndividuales;
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
    }
}