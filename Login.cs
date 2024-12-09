using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDI_Tarea_6
{
    public partial class Login : Form
    {
        /// <summary>
        /// Formulario donde el usuario se loguea en la web, solicita registrarse en la web o recupera la contraseña en caso de olvido
        /// </summary>

        string respuesta = "";
        bool LoginCorrecto;
        public Login()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile(Application.StartupPath + "\\imagenes\\fondo.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogin.BackgroundImage = Image.FromFile(Application.StartupPath + "\\imagenes\\logo2.png");
            btnLogin.BackgroundImageLayout = ImageLayout.Stretch;

        }

        //evento click del boton de SOlicitar Registro. Cierra este formulario y abre uno del tipo Registro
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Registro registro = new Registro();
            registro.Show();
        }

        //evento de confirmacion de logueo
        private void btnLogin_Click(object sender, EventArgs e)
        {
            VerificacionDatos();//llamada al metodo que verifica los datos

            if (LoginCorrecto == true)//si todo es correcto, ciera este formulario y llama al de los servicios
            {
                this.Close();
                Despedida despedida = new Despedida();
                despedida.Show();
            }
            else
            {
                MessageBox.Show("Datos no correctos");
            }
        }

        //evento de click en el linklabel donde recuperamos la ocntraseña olvidada
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //mostramos el groupBox donde se recupera la contraseña y ocultacion de los de login y peticion de registro
            grpRecupContrasena.Visible = true;
            grpLogin.Visible = false;
            grpRegistrar.Visible = false;

            if (Properties.Settings.Default.Pregunta == null)//no se encuentra ninguna pregunta guardada en los settings de la aplicacion
            {
                label1.Text = "No ha definido ninguna pregunta para recuperar contraseña";
            }
            else//si hay  pregunta guardada, se muestra en un label y se ponen visibles el textbox donde responder y el boton de confirmar respuesta
            {
                label1.Text = Properties.Settings.Default.Pregunta.ToString();
                txtCheckRespuestaPersonal.Visible = true;
                btnCheckrespuestaPersonal.Visible = true;
            }
        }

        //evento de boton que llama al metodo de omprobacion de respuesta
        private void btnCheckrespuestaPersonal_Click(object sender, EventArgs e)
        {
            CheckRespuesta();
        }

        //evento que cierra el groupbox de recuperar contraeña
        private void btncerrar_Click(object sender, EventArgs e)
        {
            grpRecupContrasena.Enabled = false;
        }

        //metodo que comprueba que la respuesta dada por el usuario en el textbox es correcta
        private void CheckRespuesta()
        {
            if (txtCheckRespuestaPersonal.Text == string.Empty)//caso de no introduccion de respuesta
            {
                MessageBox.Show("No ha respondido nada");
            }
            else if (txtCheckRespuestaPersonal.Text.Equals(Properties.Settings.Default.Respuesta))//si coincide con la respuesta 
            {
                MessageBox.Show($"Su contraseña es {Properties.Settings.Default.Password}");//se muestra la contraseña guardada por persistencia
               
                //se cierra el grupo recuperar contraseña y se reabren el de login y registro
                grpRecupContrasena.Visible = false;
                grpLogin.Visible = true;
                grpRegistrar.Visible = true;
            }
            else//si no coincide la respuesta, se cierra el formulario y se abre el de regiustro para que se registre otra vez
            {
                MessageBox.Show("Pues va a ser que no has acertado. mejor te registras de nuevo");
                Registro form = new Registro();
                form.Show();
                this.Close();
            }

        }

        //metodo que verifica lños datos insertados por el usuario, los compara con los guardados en persistencia y devuelve un 
        //booleano que indica si esta todo correcto o no
        private bool VerificacionDatos()
        {
            LoginCorrecto = false;//en pricipio es falso, debe demostrar que es verdadero

            if (txtUsuario.Text.Length >= 1 || txtPassword.Text.Length >= 1)//los datos no estan vacios
            {
                if (txtUsuario.Text.Equals(Properties.Settings.Default.Nickname))//el usuario introducido coincide con el guardado
                {
                    if (txtPassword.Text.Equals(Properties.Settings.Default.Password))//la ocntraseña tambien coincide
                    {
                        LoginCorrecto = true;//asi si..para adentro
                    }
                    else//caso contraseña no correcta
                    {
                        MessageBox.Show("contraseña incorrecta");
                        LoginCorrecto = false;
                    }
                }
                else//usuario no coincidente
                {
                    MessageBox.Show("Usuario incorrecto");
                    LoginCorrecto = false;
                }
            }
            else//los textbos estaban vacios cuando se llamo al metodo desde el evento
            {
                MessageBox.Show("No ha introducido datos");
                LoginCorrecto = false;
            }
            return LoginCorrecto;
        }

    }
}
