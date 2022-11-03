using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTP
{
    public partial class frmPrincipal : Form
    {
        frmInicioDeSesion inicioDeSesion;
        frmRegistro registroUsuario;
        public bool _activo = false; //bandera que habilita o deshabilita los componentes
        
        public void activo() //metodo para controlar la bandera
        {
            _activo = true;
        }
        
        public frmPrincipal()
        {
            InitializeComponent();
        }

        public void Toggle () //Funcion que habilita o deshabilita los componentes
        {
            bool bandera = _activo;
            grpDatosEmpleado.Enabled = bandera;
            grpCategoria.Enabled = bandera;
            grpEmpleado.Enabled = bandera;
            grpGeneral.Enabled = bandera;
            lstEmpleados.Enabled = bandera;
            lstGeneral.Enabled = bandera;
            btnEliminarCategoria.Enabled = bandera;
            btnEliminarEmpleado.Enabled = bandera;

        }

        

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            inicioDeSesion = new frmInicioDeSesion(this);
            inicioDeSesion.ShowDialog();
            
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            registroUsuario = new frmRegistro();
            registroUsuario.ShowDialog();     
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            Toggle();
            ListarCategoria();
            ListarEmpleado();
        }

        private void btnCargarCategoria_Click(object sender, EventArgs e)
        {
            FileStream archivo = new FileStream(Directory.GetCurrentDirectory() + "/categoria.txt", FileMode.Append);
            StreamWriter escritor = new StreamWriter(archivo);
            string registro;

            if(txtCodigoCategoria.Text != "" && txtDescripcion.Text !="" && txtSueldoBasico.Text != "" && txtValorHoraExtra.Text !="")
            {
                registro = txtCodigoCategoria.Text + ";" + txtDescripcion.Text + ";" + txtSueldoBasico.Text + ";" + txtValorHoraExtra.Text + ";";
                escritor.WriteLine(registro);
            }
            else
            {
                MessageBox.Show("Hay campos vacios. Por favor introducir de nuevo");
                txtCodigoCategoria.Clear();
                txtDescripcion.Clear();
                txtSueldoBasico.Clear();
                txtValorHoraExtra.Clear();
                txtCodigoCategoria.Focus();
            }

            escritor.Close();
            archivo.Close();
            ListarCategoria();
            
        }

        public void ListarCategoria()
        {
            if(File.Exists(Directory.GetCurrentDirectory() + "/categoria.txt"))
            {
                lstGeneral.Items.Clear();
                FileStream archivo = new FileStream(Directory.GetCurrentDirectory() + "/categoria.txt", FileMode.Open);
                StreamReader lector = new StreamReader(archivo);
                string registro;

                while(lector.Peek() != -1)
                {
                    registro = lector.ReadLine();
                    lstGeneral.Items.Add(registro);
                }
                lector.Close();
                archivo.Close();

                txtCodigoCategoria.Clear();
                txtDescripcion.Clear();
                txtSueldoBasico.Clear();
                txtValorHoraExtra.Clear();
                txtCodigoCategoria.Focus();
            }
        }

        private void lstGeneral_SelectedIndexChanged(object sender, EventArgs e)
        {
            string registro;
            registro = lstGeneral.SelectedItem.ToString();
            string[] vector;
            vector = registro.Split(';');
            txtCodigoCategoria.Text = vector[0];
            txtDescripcion.Text = vector[1];
            txtSueldoBasico.Text = vector[2];
            txtValorHoraExtra.Text = vector[3];
        }

        private void btnModificarCategoria_Click(object sender, EventArgs e)
        {
            FileStream archivo = new FileStream(Directory.GetCurrentDirectory() + "/categoria.txt", FileMode.Open);
            FileStream archivoAux = new FileStream(Directory.GetCurrentDirectory() + "/categoriaAux.txt", FileMode.Create);
            StreamReader lector = new StreamReader(archivo);
            StreamWriter escritor = new StreamWriter(archivoAux);

            string registro;
            string[] vector;

            while(lector.Peek() != -1)
            {
                registro =lector.ReadLine();
                vector = registro.Split(';');

                if(txtCodigoCategoria.Text == vector[0])
                {
                    registro = txtCodigoCategoria.Text + ";" + txtDescripcion.Text + ";" + txtSueldoBasico.Text + ";" + txtValorHoraExtra.Text + ";";
                    
                }

                escritor.WriteLine(registro);
            }

            lector.Close();
            escritor.Close();
            archivo.Close();
            archivoAux.Close();

            File.Delete(Directory.GetCurrentDirectory() + "/categoria.txt");
            File.Move(Directory.GetCurrentDirectory() + "/categoriaAux.txt", Directory.GetCurrentDirectory() + "/categoria.txt");

            ListarCategoria();

        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            FileStream archivo = new FileStream(Directory.GetCurrentDirectory() + "/categoria.txt", FileMode.Open);
            FileStream archivoAux = new FileStream(Directory.GetCurrentDirectory() + "/categoriaAux.txt", FileMode.Create);
            StreamReader lector = new StreamReader(archivo);
            StreamWriter escritor = new StreamWriter(archivoAux);

            string registro;
            string[] vector;

            while(lector.Peek() != -1)
            {
                registro = lector.ReadLine();
                vector = registro.Split(';');

                if(txtCodigoCategoria.Text != vector[0])
                {
                    escritor.WriteLine(registro);
                }
            }

            lector.Close();
            escritor.Close();
            archivo.Close();
            archivoAux.Close();

            File.Delete(Directory.GetCurrentDirectory() + "/categoria.txt");
            File.Move(Directory.GetCurrentDirectory() + "/categoriaAux.txt", Directory.GetCurrentDirectory() + "/categoria.txt");
            ListarCategoria();
        }

        private void btnCargarEmpleado_Click(object sender, EventArgs e)
        {
            FileStream archivo = new FileStream(Directory.GetCurrentDirectory() + "/empleados.txt", FileMode.Append);
            StreamWriter escritor = new StreamWriter(archivo);

            string registro;

            if(txtLegajo.Text != "" && txtCategoria.Text != "" && txtCantidadHorasExtras.Text != "" && txtMes.Text != "")
            {
                registro= txtLegajo.Text + ";" + txtCategoria.Text + ";" + txtCantidadHorasExtras.Text + ";" + txtMes.Text + ";";
                escritor.WriteLine(registro);
            }

            escritor.Close();
            archivo.Close();
            ListarEmpleado();
        }

        void ListarEmpleado()
        {
            if(File.Exists(Directory.GetCurrentDirectory() + "/empleados.txt"))
            {
                FileStream archivo = new FileStream(Directory.GetCurrentDirectory() + "/empleados.txt", FileMode.Open);
                StreamReader lector = new StreamReader(archivo);

                lstEmpleados.Items.Clear();

                string registro;

                while(lector.Peek() != -1)
                {
                    registro = lector.ReadLine();
                    lstEmpleados.Items.Add(registro);
                }

                lector.Close();
                archivo.Close();

                txtLegajo.Clear();
                txtCategoria.Clear();
                txtCantidadHorasExtras.Clear();
                txtMes.Clear();
                txtLegajo.Focus();
            }
        }

        private void lstEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            string registro;
            string[] vector;

            registro = lstEmpleados.SelectedItem.ToString();
            vector = registro.Split(';');

            txtLegajo.Text = vector[0];
            txtCategoria.Text = vector[1];
            txtCantidadHorasExtras.Text = vector[2];
            txtMes.Text = vector[3];
        }

        private void btnModificarEmpleado_Click(object sender, EventArgs e)
        {
            FileStream archivo = new FileStream(Directory.GetCurrentDirectory() + "/empleados.txt", FileMode.Open);
            FileStream archivoAux = new FileStream(Directory.GetCurrentDirectory() + "/empleadosAux.txt", FileMode.Create);
            StreamReader lector = new StreamReader(archivo);
            StreamWriter escritor = new StreamWriter(archivoAux);

            string registro;
            string[] vector;

            while (lector.Peek() != -1)
            {
                registro = lector.ReadLine();
                vector = registro.Split(';');

                if (txtLegajo.Text == vector[0])
                {
                    registro = txtLegajo.Text + ";" + txtCategoria.Text + ";" + txtCantidadHorasExtras.Text + ";" + txtMes.Text + ";";

                }

                escritor.WriteLine(registro);
            }

            lector.Close();
            escritor.Close();
            archivo.Close();
            archivoAux.Close();

            File.Delete(Directory.GetCurrentDirectory() + "/empleados.txt");
            File.Move(Directory.GetCurrentDirectory() + "/empleadosAux.txt", Directory.GetCurrentDirectory() + "/empleados.txt");

            ListarEmpleado();
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            FileStream archivo = new FileStream(Directory.GetCurrentDirectory() + "/empleados.txt", FileMode.Open);
            FileStream archivoAux = new FileStream(Directory.GetCurrentDirectory() + "/empleadosAux.txt", FileMode.Create);
            StreamReader lector = new StreamReader(archivo);
            StreamWriter escritor = new StreamWriter(archivoAux);

            string registro;
            string[] vector;

            while (lector.Peek() != -1)
            {
                registro = lector.ReadLine();
                vector = registro.Split(';');

                if (txtLegajo.Text != vector[0])
                {
                    escritor.WriteLine(registro);
                }
            }

            lector.Close();
            escritor.Close();
            archivo.Close();
            archivoAux.Close();

            File.Delete(Directory.GetCurrentDirectory() + "/empleados.txt");
            File.Move(Directory.GetCurrentDirectory() + "/empleadosAux.txt", Directory.GetCurrentDirectory() + "/empleados.txt");
            ListarEmpleado();
        }
    }
}
