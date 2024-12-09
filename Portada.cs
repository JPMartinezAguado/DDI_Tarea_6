namespace DDI_Tarea_6
{
    public partial class Portada : Form
    {
        private int _segundosRestantes = 3;

        //primer formulario del programa que muestra una pictureBox y un boton superpuesto. Ambos ante el evento click llaman al mismo metodo, "button1_Click"
        //que consiste en,a traves de un timer, una cuenta atras de 3 segundos, que se mostrará con un label en el momento de activarse
        //ésta, y a continuacion, se ocultará y lanzará una llamada a una instancia del siguiente formulario, Login
        public Portada()
        {
            InitializeComponent();

            //definimos caracteristicas del pictureBox y boton por codigo, indicando rutas relativas
            pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\imagenes\\f2.png");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BackColor = Color.Transparent;
            button1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\imagenes\\logo3.png");
            button1.BackgroundImageLayout = ImageLayout.Stretch; 
            button1.BackColor = Color.Transparent;

            //seteamos los intervalos de los 2 timers que incluye el formulario.
            timer1.Interval = 3000;//timer de cambio de pantalla

            //timer de refresco del label de cuneta atras, que rellama al metodo timer2_Tick cada fin de intervalo
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick;
            lblTimer2.Text = $"Se va a acceder a la ventana de Login en {_segundosRestantes} segundos";

        }

        //evento que arranca los dos timers y muestra el label de cuenta atras
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            lblTimer2.Visible = true;
        }

        //evento de finalizacion de la cuenta atras. Oculta este formulario, llama al siguiente formulario y detiene el timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Hide();
            Login form = new Login();
            form.Show();
            timer1.Stop();
        }

        //al fin del intervalo de 1 segundo, mientras el contador sea mayor de 0, el timer mostrará el mensaje con los segundos correspondientes 
        //y restara uno al contador de segunods. Cuando llegue a 0, detendrá el timer
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (_segundosRestantes > 0)
            {
                lblTimer2.Text = $"Se va a acceder a la ventana de Login en {_segundosRestantes} segundos";
                _segundosRestantes--;
            }
            else
            {
                timer2.Stop();
            }
        }

    }
}
