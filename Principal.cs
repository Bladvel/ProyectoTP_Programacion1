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
        public void desactivo()//metodo para desactivarla
        {
            _activo = false;
        }
        
        public frmPrincipal()
        {
            InitializeComponent();
        }

        public void Toggle(string[] vector = null) //Funcion que habilita o deshabilita los componentes
        {//El parametro vector es opcional porque solo lo necesito en un llamado en particular
            bool bandera = _activo;
            /*
            grpDatosEmpleado.Enabled = bandera;
            grpCategoria.Enabled = bandera;
            grpEmpleado.Enabled = bandera;
            
            
            btnEliminarCategoria.Enabled = bandera;
            btnEliminarEmpleado.Enabled = bandera;
            btnCerrarSesion.Hide();
            */

            
            grpDatosEmpleado.Visible = bandera;
            grpCategoria.Visible = bandera;
            grpEmpleado.Visible = bandera;


            btnEliminarCategoria.Visible = bandera;
            btnEliminarEmpleado.Visible = bandera;
            btnCerrarSesion.Hide();
            if (bandera)
            {
                

                lstEmpleados.Show();
                lstGeneral.Show();

                lblSaludo.Show();
                lblSaludo.Text = "Hola " + vector[0];
                lblAntesDeIniciar.Hide();
                //Habilito el cierre de sesion
                btnCerrarSesion.Show();
                btnIniciarSesion.Hide();
                btnRegistrarse.Hide();
            }
            else
            {
                lblAntesDeIniciar.Show();
                lstGeneral.Hide();
                lstEmpleados.Hide();
                lblSaludo.Hide();
            }
            
        }
        //Lista donde guardo las categorias
        List<Categoria> ListaCategoria = new List<Categoria> ();

        //Funcion para guardar el objeto categoria que uso para la lista
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

        void leerCategoria()//Este metodo sirve para agregar las categorias cargadas en el archivo a la listaCategoria
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
            //Inicializo el form de inicio de sesion y paso el form principal como parametro
            inicioDeSesion = new frmInicioDeSesion(this);
            inicioDeSesion.ShowDialog();
            
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            //inicializo el form de registro de usuario
            registroUsuario = new frmRegistro();
            registroUsuario.ShowDialog();     
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            
            Toggle();
            ListarCategoria();
            ListarEmpleado();
            
        }

        //Funcion para cargar la categoria introducida al archivo
        private void btnCargarCategoria_Click(object sender, EventArgs e)
        {
            FileStream archivo = new FileStream(Directory.GetCurrentDirectory() + "/categoria.txt", FileMode.Append);
            StreamWriter escritor = new StreamWriter(archivo);
            string registro;
            string[] vector;
            
            //Verifico que no se introduzcan campos vacios
            if(txtCodigoCategoria.Text != "" && txtDescripcion.Text !="" && txtSueldoBasico.Text != "" && txtValorHoraExtra.Text !="")
            {
                registro = txtCodigoCategoria.Text + ";" + txtDescripcion.Text + ";" + txtSueldoBasico.Text + ";" + txtValorHoraExtra.Text + ";";
                vector = registro.Split(';');
                if (Int32.TryParse(vector[0], out int number))
                {
                    if(number > 6 || number <1)//Verifico que el codigo de categoria este dentro del rango adecuado
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

        //Funcion que muestra las categorias en el listbox correspondiente
        public void ListarCategoria()
        {
            if(File.Exists(Directory.GetCurrentDirectory() + "/categoria.txt"))
            {
                lstGeneral.Items.Clear();
                FileStream archivo = new FileStream(Directory.GetCurrentDirectory() + "/categoria.txt", FileMode.Open);
                StreamReader lector = new StreamReader(archivo);
                string registro;
                string[] vector;
                

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

        //Funcion para mostrar en los textbox correspondientes la categoria seleccionada
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
            if (File.Exists(Directory.GetCurrentDirectory() + "/categoria.txt"))
            {
                FileStream archivo = new FileStream(Directory.GetCurrentDirectory() + "/categoria.txt", FileMode.Open);
                FileStream archivoAux = new FileStream(Directory.GetCurrentDirectory() + "/categoriaAux.txt", FileMode.Create);
                StreamReader lector = new StreamReader(archivo);
                StreamWriter escritor = new StreamWriter(archivoAux);

                string registro;
                string[] vector;

                while (lector.Peek() != -1)
                {
                    registro = lector.ReadLine();
                    vector = registro.Split(';');

                    //Comparo el registro leido del archivo con el dato mostrado en el textbox
                    if (txtCodigoCategoria.Text == vector[0])
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

                //Recargo el listbox y la lista de categorias
                ListarCategoria();

            }


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

                if (txtLegajo.Text == vector[0] && txtMes.Text == vector[3])
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

                if (txtLegajo.Text == vector[0] && txtCategoria.Text == vector[1] && txtCantidadHorasExtras.Text == vector[2] && txtMes.Text == vector[3])
                {
                    continue;
                }
                else
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

        //Funcion que muestra TODOS los datos de interes de los empleados
        //btnDatosIndividuales_Click
        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            if (File.Exists(Directory.GetCurrentDirectory() + "/empleados.txt"))
            {
                FileStream archivo = new FileStream(Directory.GetCurrentDirectory() + "/empleados.txt", FileMode.Open);
                StreamReader lector = new StreamReader(archivo);

                //Strings de uso general para leer los registros del archivo
                string registro;
                string[] vector;
                
                //Variables para el calculo de los datos de interes usando corte de control
                float sumSalario = 0;
                int legajoAnterior = 0;
                int categoria; //Categoria de un empleado
                float sueldo;//Sueldo de un empleado
                float valorHora;//Valor de hora extra de un empleado
                float[] salarioPorMes = new float[12];//Array de salarios de cada mes de un empleado
                int[] horasExtrasPorMes = new int[12]; //Array de horas extras de cada mes de un empleado
                int mes;
                int horasExtras;
                int ultimoEmpleado = 0;//Variable para saber el legajo del ultimo empleado estudiado
                float promedioEmpleado;
                //Lista de sueldos superiores al promedio del empleado
                List<float> listaMaximosSueldos = new List<float>();
                //iterador para contabilizar los sueldos guardados en la lista de sueldos superiores al promedio
                int iterador;

                //Variable para guardar el maximo sueldo
                float maxSueldo = 0;
                //int maxMes = 0;
                int maxEmpleado = 0;
                float maxSueldoDiciembre = 0;
                int maxEmpleadoDiciembre = 0;
                
                //Variables para el calculo de los empleados que trabajaron menos el primer trimestre del año
                int minPrimerTrimestre = 99999;
                List<string> listaHorasPrimerTrimestre = new List<string>();

                //Leo un registro del archivo por primera vez
                registro = lector.ReadLine();
                vector = registro.Split(';');

                //limpio los listbox para que no se repitan los datos
                lstSueldoAnual.Items.Clear();
                lstSueldosMayorPromedio.Items.Clear();
                lstPrimerTrimestre.Items.Clear();

                while (!lector.EndOfStream || (lector.EndOfStream && legajoAnterior != int.Parse(vector[0])))
                {
                    
                    sumSalario = 0;
                    iterador = 0;
                    
                    //Leo la categoria para determinar el sueldo del empleado
                    categoria = int.Parse(vector[1]);

                    //Calculo el sueldo leyendo el valor correspondiente a la categoria a la que pertenece
                    sueldo = ListaCategoria[categoria - 1].sueldoBasico;
                    //Hago lo mismo para el valor de las horas extras del empleado
                    valorHora = ListaCategoria[categoria - 1].valorHoraExtra;
                    
                    //Inicializo los vectores con 0 en todas sus posiciones
                    for(int i = 0; i < 12; i++)
                    {
                        //Vectores que guardan los datos por mes de un empleado
                        salarioPorMes[i] = 0;
                        horasExtrasPorMes[i] = 0;
                        
                    }

                    //Guardo el legajo del empleado y lo uso para realizar el corte de control
                    legajoAnterior = int.Parse(vector[0]);
                    //Variable que guarda las horas extras del primer trimestre del año
                    int empleadoHorasPrimerTrimestre = 0; 
                    

                    while((!lector.EndOfStream && legajoAnterior == int.Parse(vector[0])) || (lector.EndOfStream && legajoAnterior == int.Parse(vector[0])))
                    {
                        mes = int.Parse( vector[3]);
                        //guardo las horas extra por mes del empleado
                        horasExtras = int.Parse(vector[2]);
                        horasExtrasPorMes[mes - 1] = horasExtras;
                        if(mes <= 3)
                        {
                            //Guardo las horas extras trabajadas en el primer trimestre del año
                            empleadoHorasPrimerTrimestre += horasExtras;
                            
                        }
                        //Voy cargando en el array lo que gano por las horas extras trabajadas
                        salarioPorMes[mes - 1] += valorHora * horasExtras;
                        //Guardo el legajo del ultimo empleado para tenerlo como referencia a futuro
                        ultimoEmpleado = int.Parse(vector[0]);
                        
                        //Avanzo en el archivo
                        registro = lector.ReadLine();
                        
                        if(registro == null)
                        {
                            break;
                        }
                        
                        vector = registro.Split(';');

                        /*Hago este if para el caso de la ultima linea del archivo
                         * ya que sino, se la salta porque leo al final de cada ciclo 
                         * y el Peek da -1 cuando falta una ultima iteracion
                         */
                        if(lector.EndOfStream && legajoAnterior == int.Parse(vector[0]))
                        {

                            mes = int.Parse(vector[3]);
                            
                            horasExtras = int.Parse(vector[2]);
                            horasExtrasPorMes[mes - 1] = horasExtras;
                            if (mes <= 3)
                            {
                                
                                empleadoHorasPrimerTrimestre += horasExtras;

                            }
                            
                            salarioPorMes[mes - 1] += valorHora * horasExtras;
                            
                            ultimoEmpleado = int.Parse(vector[0]);
                            
                        }
                        
                        
                    }

                   
                     

                    //Calculo el empleado con menos horas el primer trimestre
                    if (empleadoHorasPrimerTrimestre < minPrimerTrimestre)
                    {
                        //Si las horas trabajadas son menor que el minimo, el nuevo minimo seran las horas de ese empleado
                        minPrimerTrimestre = empleadoHorasPrimerTrimestre;
                        //Limpio la lista que contiene a los empleados la menor cantidad de horas extras el primer trimestre
                        listaHorasPrimerTrimestre.Clear();
                        listaHorasPrimerTrimestre.Add("El empleado con menos horas fue " + ultimoEmpleado + " con " + minPrimerTrimestre + " horas.");
                    }else if(empleadoHorasPrimerTrimestre == minPrimerTrimestre)
                    {
                        //En el caso de que el empleado la misma cantidad de horas que el minimo, se agrega a lista sin limpiarla primero
                        listaHorasPrimerTrimestre.Add("El empleado con menos horas fue " + ultimoEmpleado + " con " + minPrimerTrimestre + " horas.");
                    }

                   

                    
                    
                    //Iteracion para rellenar el vector de salario por mes de el empleado estudiado
                    for(int k = 0; k<12; k++)
                    {
                        if(k==5 || k == 11)
                        {
                            //Se guarda tanto el sueldo como el aguinaldo de junio y diciembre
                            salarioPorMes[k] += sueldo + (sueldo/12)*6;
                        }
                        else
                        {
                            salarioPorMes[k] += sueldo;
                        }
                        //Se va acumulando el salario del empleado
                        sumSalario += salarioPorMes[k];
                    }
                    //Se calcula el promedio de sueldo del empleado
                    promedioEmpleado = sumSalario/12;

                    //Iteracion para obtener los salarios superiores a su promedio de sueldos
                    for(int k = 0; k<12; k++)
                    {
                        if(salarioPorMes[k] > promedioEmpleado )
                        {
                            //Se compara el salario mensual con el maximo sueldo para referencia a futuro
                            if (salarioPorMes[k] > maxSueldo)
                            {
                                maxSueldo = salarioPorMes[k];
                                //maxMes = k + 1;
                                maxEmpleado = ultimoEmpleado;
                            }
                            //Se guardan los salarios superiores al promedio en la lista de sueldos maximos
                            listaMaximosSueldos.Add(salarioPorMes[k]);
                            //Muestro los resultados en el listbox correspondiente
                            lstSueldosMayorPromedio.Items.Add("Para el empleado " + ultimoEmpleado + " el sueldo fue de $" + listaMaximosSueldos[iterador]);
                            iterador++;
                        }

                        
                        
                    }

                    //Limpio la lista para que inicialice vacia para el siguiente empleado a estudiar
                    listaMaximosSueldos.Clear();
                    
                    //Se agregar al listbox el salario anual de cada empleado
                    lstSueldoAnual.Items.Add( "Para el empleado " +  ultimoEmpleado + " el sueldo anual es de $" + sumSalario );

                    //Comparo el salario de diciembre del empleado estudiado con el sueldo maximo registrado para diciembre (inicializado en 0)
                    if (salarioPorMes[11] > maxSueldoDiciembre)
                    {
                        maxSueldoDiciembre = salarioPorMes[11];
                        maxEmpleadoDiciembre = ultimoEmpleado;
                    }

                    
 
                }

                //Se agrega al listbox correspondiente los empleados con la menor cantidad de horas trabajadas el primer trimestre del año
                for(int i = 0; i< listaHorasPrimerTrimestre.Count; i++)
                {
                    lstPrimerTrimestre.Items.Add(listaHorasPrimerTrimestre[i]);
                }
                
                
                txtMaximoSueldo.Text = "El maximo sueldo fue de $" + maxSueldo + " al empleado " + maxEmpleado + ".";
                txtCobroDiciembre.Text = "El empleado quien cobro mas en diciembre fue " + maxEmpleadoDiciembre + " con $" + maxSueldoDiciembre + ".";
                archivo.Close();
                lector.Close();
            }


        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            btnIniciarSesion.Show();
            btnRegistrarse.Show();
            this.desactivo();
            Toggle();
        }

        



}

