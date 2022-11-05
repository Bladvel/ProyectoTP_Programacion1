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
using System.IO;

namespace ProyectoTP
{
    public partial class frmInicioDeSesion : Form
    {
        frmPrincipal principal;
        public frmInicioDeSesion()
        {
            InitializeComponent();
        }

        public frmInicioDeSesion(frmPrincipal _principal)
        {
            InitializeComponent();
            principal = _principal;
        }

        

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            
           
            
            if(File.Exists(Directory.GetCurrentDirectory() + "/usuarios.txt"))
            {
                FileStream archivo = new FileStream(Directory.GetCurrentDirectory() + "/usuarios.txt", FileMode.Open);
                StreamReader lector = new StreamReader(archivo);
                string[] vector;
                string registo;

                bool bandera = false;


                do
                {
                    registo = lector.ReadLine();
                    vector = registo.Split(';');

                    if (vector[0] == txtUsuario.Text && vector[1] == txtContrasena.Text)
                    {

                        principal.activo();//Variable que habilita si esta activo o no los botones de principal
                        principal.Show();
                        principal.Toggle(vector);
                        this.Hide();
                        bandera = true;


                    }
                    
                } while (lector.Peek() != -1);

                if (!bandera)
                {                  
                        MessageBox.Show("Datos de ingreso incorrectos. Por favor introducir de nuevo");
                        txtUsuario.Clear();
                        txtContrasena.Clear();
                        txtUsuario.Focus();
                }

                lector.Close();
                archivo.Close();

            }
            
        }
    }
}
