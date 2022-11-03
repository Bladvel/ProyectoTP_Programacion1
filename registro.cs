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
        frmPrincipal principal;

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

                escritor.WriteLine(registro);
                principal = new frmPrincipal();
                principal.Show();
                this.Hide();
            }
            escritor.Close();
            archivo.Close();
            
            

            

            

        }

    }
}
