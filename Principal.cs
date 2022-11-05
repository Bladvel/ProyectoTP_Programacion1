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
        //Declaro las form extras que utilizo
        frmInicioDeSesion inicioDeSesion; //Form de inicio de sesion
        frmRegistro registroUsuario; //Form de registro de usuario
        public bool _activo = false; //bandera que habilita o deshabilita los componentes
        
        public void activo() //metodo para controlar la bandera
        {
            _activo = true;
        }
        
        public frmPrincipal()
        {
            InitializeComponent();
        }

        public void Toggle(string[] vector) //Funcion que habilita o deshabilita los componentes
        {
            bool bandera = _activo;
            grpDatosEmpleado.Enabled = bandera;
            grpCategoria.Enabled = bandera;
            grpEmpleado.Enabled = bandera;
            
            lstEmpleados.Enabled = bandera;
            lstGeneral.Enabled = bandera;
            btnEliminarCategoria.Enabled = bandera;
            btnEliminarEmpleado.Enabled = bandera;
            if (bandera)
            {
                lblSaludo.Show();
                lblSaludo.Text = "Hola " + vector[0];
                lblAntesDeIniciar.Hide();
            }
            else
            {
                lblSaludo.Hide();
            }
            
        }

        List<Categoria> ListaCategoria = new List<Categoria> ();

        Categoria crearObjetoCategoria(string[] vector)
        {
            Categoria _categoria = new Categoria ();
            if (Int32.TryParse(vector[0], out int val))
            {
                _categoria.codigo = val;
            }
            _categoria.descripcion = vector[1];

            _categoria.sueldoBasico = float.Parse(vector[2]);
            _categoria.valorHoraExtra = float.Parse(vector[3]);
            return _categoria;
            
        }

        void leerCategoria()
        {
            if(File.Exists(Directory.GetCurrentDirectory() + "/categoria.txt"))
            {
                FileStream archivo = new FileStream(Directory.GetCurrentDirectory() + "/categoria.txt", FileMode.Open);
                StreamReader lector = new StreamReader(archivo);
                Categoria _categoria = new Categoria();
                string registro;
                string[] vector;
                
                ListaCategoria.Clear();

                while (lector.Peek() != -1)
                {

                    registro = lector.ReadLine();
                    vector = registro.Split(';');
                    
                    ListaCategoria.Add(crearObjetoCategoria(vector));
                }

                archivo.Close();
                lector.Close();
            }
           
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
            string[] vector = new string[2];
            Toggle(vector);
            ListarCategoria();
            ListarEmpleado();
            
        }

        private void btnCargarCategoria_Click(object sender, EventArgs e)
        {
            FileStream archivo = new FileStream(Directory.GetCurrentDirectory() + "/categoria.txt", FileMode.Append);
            StreamWriter escritor = new StreamWriter(archivo);
            string registro;
            string[] vector;
            

            if(txtCodigoCategoria.Text != "" && txtDescripcion.Text !="" && txtSueldoBasico.Text != "" && txtValorHoraExtra.Text !="")
            {
                registro = txtCodigoCategoria.Text + ";" + txtDescripcion.Text + ";" + txtSueldoBasico.Text + ";" + txtValorHoraExtra.Text + ";";
                vector = registro.Split(';');
                if (Int32.TryParse(vector[0], out int number))
                {
                    if(number > 6 || number <1)
                    {
                        MessageBox.Show("No se puede agregar una categoria mayor a 6 o menor a 1");
                    }
                    else
                    {
                        escritor.WriteLine(registro);
                    }

                }

                
                
                
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

                leerCategoria();
                
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

        
        private void btnDatosIndividuales_Click(object sender, EventArgs e)
        {
            if (File.Exists(Directory.GetCurrentDirectory() + "/empleados.txt"))
            {
                FileStream archivo = new FileStream(Directory.GetCurrentDirectory() + "/empleados.txt", FileMode.Open);
                StreamReader lector = new StreamReader(archivo);

                string registro;
                string[] vector;
                
                float sumSalario = 0;
                int legajoAnterior;
                
                
                int categoria;
                float sueldo;
                float valorHora;
                float[] salarioPorMes = new float[12];
                int[] horasExtrasPorMes = new int[12]; 
                int mes;
                int horasExtras;
                int ultimoEmpleado = 0;
                float promedioEmpleado;
                List<float> listaMaximosSueldos = new List<float>();
                
                int iterador;
                float maxSueldo = 0;
                //int maxMes = 0;
                int maxEmpleado = 0;
                float maxSueldoDiciembre = 0;
                int maxEmpleadoDiciembre = 0;
                
                int minPrimerTrimestre = 99999;
                List<string> listaHorasPrimerTrimestre = new List<string>();


                registro = lector.ReadLine();
                vector = registro.Split(';');

                lstSueldoAnual.Items.Clear();
                lstSueldosMayorPromedio.Items.Clear();
                lstPrimerTrimestre.Items.Clear();

                while (lector.Peek() != -1)
                {
                    
                    sumSalario = 0;
                    iterador = 0;
                    
                    
                    categoria = int.Parse(vector[1]);
                    sueldo = ListaCategoria[categoria - 1].sueldoBasico;
                    valorHora = ListaCategoria[categoria - 1].valorHoraExtra;
                    

                    for(int i = 0; i < 12; i++)
                    {
                        salarioPorMes[i] = 0;
                        horasExtrasPorMes[i] = 0;
                        
                    }

                    legajoAnterior = int.Parse(vector[0]);
                    int empleadoHorasPrimerTrimestre = 0; 

                    while(lector.Peek() !=-1 && legajoAnterior == int.Parse(vector[0]))
                    {
                        mes = int.Parse( vector[3]);
                        
                        horasExtras = int.Parse(vector[2]);
                        horasExtrasPorMes[mes - 1] = horasExtras;
                        if(mes <= 3)
                        {
                            empleadoHorasPrimerTrimestre += horasExtras;
                            
                        }
                        salarioPorMes[mes - 1] += valorHora * horasExtras;
                        ultimoEmpleado = int.Parse(vector[0]);
                            //Avanzo en el archivo
                        registro = lector.ReadLine();
                        vector = registro.Split(';');

                        /*Hago esto para el caso de la ultima linea del archivo
                         * ya que sino, se la salta porque leo al final de cada ciclo 
                         * y el Peek da -1 pero falta una iteracion
                         */
                        if(lector.Peek() == -1 && legajoAnterior == int.Parse(vector[0]))
                        {
                            mes = int.Parse(vector[3]);

                            horasExtras = int.Parse(vector[2]);
                            
                            salarioPorMes[mes - 1] += valorHora * horasExtras;
                            ultimoEmpleado = int.Parse(vector[0]);
                        }
                        
                    }

                    if(empleadoHorasPrimerTrimestre < minPrimerTrimestre)
                    {
                        minPrimerTrimestre = empleadoHorasPrimerTrimestre;
                        listaHorasPrimerTrimestre.Clear();
                        listaHorasPrimerTrimestre.Add("El empleado con menos horas fue " + ultimoEmpleado + " con " + minPrimerTrimestre);
                    }else if(empleadoHorasPrimerTrimestre == minPrimerTrimestre)
                    {
                        listaHorasPrimerTrimestre.Add("El empleado con menos horas fue " + ultimoEmpleado + " con " + minPrimerTrimestre);
                    }

                   

                    
                    
                    
                    for(int k = 0; k<12; k++)
                    {
                        if(k==5 || k == 11)
                        {
                            salarioPorMes[k] += sueldo + (sueldo/12)*6;
                        }
                        else
                        {
                            salarioPorMes[k] += sueldo;
                        }
                        
                        sumSalario += salarioPorMes[k];
                    }

                    promedioEmpleado = sumSalario/12;

                    
                    for(int k = 0; k<12; k++)
                    {
                        if(salarioPorMes[k] > promedioEmpleado )
                        {
                            if (salarioPorMes[k] > maxSueldo)
                            {
                                maxSueldo = salarioPorMes[k];
                                //maxMes = k + 1;
                                maxEmpleado = ultimoEmpleado;
                            }
                            listaMaximosSueldos.Add(salarioPorMes[k]);
                            lstSueldosMayorPromedio.Items.Add("Para " + ultimoEmpleado + " es " + listaMaximosSueldos[iterador]);
                            iterador++;
                        }

                        
                        
                    }

                    listaMaximosSueldos.Clear();
                    

                    lstSueldoAnual.Items.Add( "Para " +  ultimoEmpleado + " es " + sumSalario);

                    if (salarioPorMes[11] > maxSueldoDiciembre)
                    {
                        maxSueldoDiciembre = salarioPorMes[11];
                        maxEmpleadoDiciembre = ultimoEmpleado;
                    }

                    
 
                }

                
                for(int i = 0; i< listaHorasPrimerTrimestre.Count; i++)
                {
                    lstPrimerTrimestre.Items.Add(listaHorasPrimerTrimestre[i]);
                }
                
                //Aqui estan los calculos de las operaciones generales
                txtMaximoSueldo.Text = "El maximo sueldo fue de " + maxSueldo + " a " + maxEmpleado;
                txtCobroDiciembre.Text = "El empleado quien cobro mas en diciembre fue " + maxEmpleadoDiciembre + " con " + maxSueldoDiciembre;
                archivo.Close();
                lector.Close();
            }


        }

        
    }



        //void ActualizarLista()
        //{
        //    lstLista.Items.Clear();
        //    int i;
        //    for (i = 0; i < ListaCategoria.Count; i++) //que sea menor o igual y el count -1
        //    {
        //        lstLista.Items.Add(ListaCategoria[i].codigo + " " + ListaCategoria[i].descripcion +" " + ListaCategoria[i].sueldoBasico + " " + ListaCategoria[i].valorHoraExtra);
        //    }
        //}
        //private void btnAgregarlista_Click(object sender, EventArgs e)
        //{
        //    ActualizarLista();
        //}
}

//1 es 1050000
//2 es 1320000
//3 es 1938000
//4 es 2471000