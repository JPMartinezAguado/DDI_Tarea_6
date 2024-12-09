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
    public partial class Despedida : Form
    {
        /// <summary>
        /// Formulario final donde se muestran los servicios disponibles, se puede generar otro, y se sale de la aplicacion
        /// </summary>

        string servicio;
        int indiceImagen = 0; //incide para un imagelist de seleccion de iconos
        Image imageBotonGenerado;


        public Despedida()
        {
            InitializeComponent();

            //inicializamos un picturebox que mostrara las diversas imagenes de un imagelist que contiene el formulario
            pictureBox1.Image = imageList3.Images[indiceImagen];

            //definimos por codigo el fondo del formulario y las imagenes que contienen los botones
            this.BackgroundImage = Image.FromFile(Application.StartupPath + "\\imagenes\\fondodesp.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            btnAlbanil.BackgroundImage = Image.FromFile(Application.StartupPath + "\\imagenes\\brick.png");
            btnAlbanil.BackgroundImageLayout = ImageLayout.Stretch;
            btnElectricista.BackgroundImage = Image.FromFile(Application.StartupPath + "\\imagenes\\electric.png");
            btnElectricista.BackgroundImageLayout = ImageLayout.Stretch;
            btnMecanico.BackgroundImage = Image.FromFile(Application.StartupPath + "\\imagenes\\mech.png");
            btnMecanico.BackgroundImageLayout = ImageLayout.Stretch;
        }

        //evento de salida de la aplicacion
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //evento de clickado de los botones y labels "dummy" del formulario. Todas llaman a este metodo
        private void btnElectricista_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Servicio en construccion. \n\nDisculpe las molestias");

        }

        //evento de peticion de creacion de nuevo boton. POne visible el groupbox desde el que se puede configurar el mismo
        private void btnServPersonalizado_Click(object sender, EventArgs e)
        {
            grpNuevoServicio.Visible = true;
        }

        //evento de boton que cambia la imagen del imagenList qu mostrara el pictureBox
        private void btnSiguienteImagen_Click(object sender, EventArgs e)
        {
            //si el indice del ImageList llega a la cantidad de imagenees que contiene, se reinicia a 0 y se muestra
            //por el picturebox la primera, la que esta en posicion 0
            if (indiceImagen == imageList3.Images.Count)
            {
                indiceImagen = 0;
                pictureBox1.Image = imageList3.Images[indiceImagen];
            }
            else//en caso contrario, se muestra la imagen con el indice guardado en la variable de clase, y se aumenta en 1 esta variable
            {
                pictureBox1.Image = imageList3.Images[indiceImagen];
                indiceImagen++;
            }
        }

        //evento que guarda en una variable de clase la imagen del imagen list que esté en estos momentos indicada por el indice almacenado
        private void btnSelImage_Click(object sender, EventArgs e)
        {
            imageBotonGenerado = imageList3.Images[indiceImagen];
        }

        //Evento que intenta generar el boton y label con las especificacioens del usuario
        private void btnAgregServicio_Click(object sender, EventArgs e)
        {
            if (imageBotonGenerado == null || string.IsNullOrEmpty(txtNUevoServicio.Text))//caso que alguna de las variables que guardan la imagen o el string esten vacias
            {
                MessageBox.Show("faltan datos para crear el servicio. Indique un nombre y seleccione un icono");
            }
            else//si tenemos toda la informacion generamos por codigo boton y label
            {
                //creamos el boton tomando co0mo referencia uno de los creados, moviendo su posicion 100 pixeles hacia abajo
                Button nuevoBoton = new Button();
                nuevoBoton.Size = btnAlbanil.Size;
                nuevoBoton.Location = new Point(btnAlbanil.Left, btnAlbanil.Top + 100);
                nuevoBoton.Margin = btnAlbanil.Margin;
                nuevoBoton.Name = "btn" + txtNUevoServicio.Text;//lo nombramos como indica el usuario, con prefijo "btn" que para eso manejamos las omenclatuiras estandarizadas ;)
                nuevoBoton.BackgroundImage = imageBotonGenerado;//aplicamos la imagen seleccionada del imagelist
                nuevoBoton.BackgroundImageLayout = ImageLayout.Stretch;//nos aseguramos que llene el area del boton
                nuevoBoton.UseVisualStyleBackColor = true;
                nuevoBoton.Visible = true;
                nuevoBoton.Click += btnElectricista_Click;//le aplicamos el mismo evento click que el resto de controles "dummy"
                this.Controls.Add(nuevoBoton);//añadimos al controlador del formulario

                //lo mismo para la label
                Label nuevaLabel = new Label();
                nuevaLabel.Text = txtNUevoServicio.Text;
                nuevaLabel.Location = new Point(lblAlbanil.Left, lblAlbanil.Top + 100);
                nuevaLabel.Font = lblAlbanil.Font;
                nuevaLabel.BackColor = Color.Transparent;
                nuevaLabel.ForeColor = lblAlbanil.ForeColor;
                nuevaLabel.Click += btnElectricista_Click;
                this.Controls.Add(nuevaLabel);

                //modificamos el groupbox para que la proxima vez que lo intenten no pudean añadir mas botonoes.hay que dejar algo para la version 2.0 ;)
                btnAgregServicio.Enabled = false;
                btnAgregServicio.Text = "Ya agregó un servicio";
                grpNuevoServicio.Visible = false;
                lblDisclaimer.Visible = true;
            }
        }

    }
}
