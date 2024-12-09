using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics.Eventing.Reader;

namespace DDI_Tarea_6
{
    /// <summary>
    /// Clase donde se rcogen datos de usuario nuevo, asi como una pregunta y respuesta personal para la recuperacion
    /// de la contraseña en caso de olvidarse
    /// </summary>
    public partial class Registro : Form
    {
        //variables de clase accesibles por todos los metodos de la misma
        private bool _valido = false;//booleano que comprueba que la contraseña tenga longitud suficiente y concuerde con la confirmacion de contraseña
        private bool _tortilla;//booleano que determina si mereces acceder a los servicios

        private string _pregunta;
        private string _confirmedPass;

        public Registro()
        {
            InitializeComponent();
        }

        //metodo que comprueba que la contraseña cumpe con las condiciones
        private bool ComprobarPassword()
        {
            _valido = false;//de entrada no las cumple, tiene que demostrar que si


            if (txtContrasena.Text.Length < 8)//caso de longitud no suficiente
            {
                MessageBox.Show("la contraseña debe tener al menos 8 caracteres");
            }
            else if (txtContrasena.Text.Equals(txtConfirmCOntrasena.Text))//la comparamos con el textbox que contiene la confirmacionm
            {
                _confirmedPass = txtContrasena.Text;//guardamos la contraseña en una variable de clase para sacarla del metodo
                _valido = true;//asi si que vale, en cualquier otro caso, el metdoo sigue devilviendo falso
            }
            else//caso de no coincidencia
            {
                MessageBox.Show("La contraseña no coincide. Asegurese de introducir valores iguales");
            }
            return _valido;
        }

        //evento que llama al metodo de confirmacion de registro
        private void btnConfirmRegistro_Click(object sender, EventArgs e)
        {
            ConfirmarRegistro();
        }

        /// <summary>
        /// evento principal del formulario. Confirmamos que todos los parametros son correctos y en caso correcto
        /// guardamos los valoes de nuick de usuario y ocntraseña en las propiedades del proyecto
        /// </summary>
        private void ConfirmarRegistro()
        {

            ComprobarPassword();//llamamos al metdo de validacion de contraseña

            //si la contraseña es valida y la tortilla como debe ser, guardamos las variables para recogerlas en el futuro
            //mediante persistencia, instanciamos y rellenamos un objeto MacGuffin, mostramos mensaje afirmativo de registro
            //y cerramos este formulario, abriendo a su vez uno del tipo Despedida
            if (_valido == true && _tortilla == true)
            {
                Properties.Settings.Default.Nickname = txtNickname.Text;
                Properties.Settings.Default.Password = _confirmedPass;
                Properties.Settings.Default.Save();

                MacGuffin usuario = new MacGuffin
                   (
                   txtNombre.Text,
                   txtApellido1.Text,
                   txtApellido2.Text,
                   domPais.Text,
                   _tortilla,
                   dtmFechaNacimiento.Text
                   );

                MessageBox.Show("ha sido registrado con exito. Disfrute de nuestros servicios");
                this.Close();
                Despedida despedida = new Despedida();
                despedida.Show();
            }
            else if (_valido && _tortilla == false)//si la contraseña es correcta, pero la tortilla no
            {
                MessageBox.Show("Debes elegir el lado cebollil de la buena gente");
            }
            else//si algun dato de los obligatorios no es correcto o no esta presente
            {
                MessageBox.Show("Los datos de usuario y/o contraseña no son validos");
            }
        }

        //evento de seleccion de pregunta personal para recuperar contraseña, contenidas en un DominioUpDown
        private void domPreguntrasPersonalles_SelectedItemChanged(object sender, EventArgs e)
        {
            _pregunta = domPreguntrasPersonalles.SelectedItem.ToString();//igualamos el string de clase pregunta a la eleccion del usuario
        }

        //evento que guarda con persistencia la pregunta y respuesta que sirven para recuperar la contraseña en caso de olvido
        private void btnGuardarPersonal_Click(object sender, EventArgs e)
        {
            //si tanto la pregunta ocmo la respuesta ofrecida no estan vacias, guardamos los datos en las variables correspondientes
            if (_pregunta.Length >= 1 && txtRespPersonal.Text.Length > 0)
            {
                Properties.Settings.Default.Pregunta = _pregunta;
                Properties.Settings.Default.Respuesta = txtRespPersonal.Text;
            }
            else
            {
                MessageBox.Show("Debes elegir y contestar (con sinceridad!!!) una de las preguntas");
            }
        }

        //si se elige la tortilla correcta, se activa el booleano corrspondiente y podremos completar el registro
        private void radTortillaCon_CheckedChanged(object sender, EventArgs e)
        {
            btnConfirmRegistro.Visible = true;//en caso que haya sido ocultado el boton, aqui lo habilitamos de nuevo
            _tortilla = true;
        }

        //si no somos personas, pasa esto
        private void radTortillaSin_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("No se puede registrar a gente como tu.\n\nTe oculto el botón de registro hasta que entres en razón");
            btnConfirmRegistro.Visible = false;//se oculta el boton de registro
            _tortilla = false;//se pone elboolenao tortilla a negativo
        }
    }
}
