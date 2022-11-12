using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProyectoTP
{
    public partial class frmRegistro : Form
    {
        

        public frmRegistro()
        {
            InitializeComponent();
        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            FileStream archivo = new FileStream(Directory.GetCurrentDirectory() + "/usuarios.txt", FileMode.Append);
            StreamWriter escritor = new StreamWriter(archivo);
            string registro = txtUsuario.Text + ";" + txtContrasena.Text + ";";
            
            if(txtUsuario.Text == "" || txtContrasena.Text == "")
            {
                MessageBox.Show("Por favor introduzca un dato valido no vacio");
            }
            else
            {
                MessageBox.Show("Se ha registrado exitosamente");
                escritor.WriteLine(registro);
                this.Hide();
                frmInicioDeSesion inicioSesion = new frmInicioDeSesion();
                inicioSesion.ShowDialog();
                this.Close();
            }
            escritor.Close();
            archivo.Close();

        }

        private void lblIniciarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInicioDeSesion inicioSesion = new frmInicioDeSesion();
            inicioSesion.ShowDialog();
            this.Close();
        }
    }
}
