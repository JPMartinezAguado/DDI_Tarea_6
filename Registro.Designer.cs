namespace DDI_Tarea_6
{
    partial class Registro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabRegistro = new TabControl();
            tabBasicos = new TabPage();
            btnConfirmRegistro = new Button();
            grpDatosPersonales = new GroupBox();
            domPais = new DomainUpDown();
            dtmFechaNacimiento = new DateTimePicker();
            radTortillaSin = new RadioButton();
            radTortillaCon = new RadioButton();
            txtApellido1 = new TextBox();
            txtApellido2 = new TextBox();
            txtNombre = new TextBox();
            lblEdad = new Label();
            lblNacionalidad = new Label();
            lblTortilla = new Label();
            lblApellido2 = new Label();
            lblApellido1 = new Label();
            lblNombre = new Label();
            groupBox1 = new GroupBox();
            lblPassSize = new Label();
            txtConfirmCOntrasena = new TextBox();
            txtContrasena = new TextBox();
            txtNickname = new TextBox();
            lblCheckPassword = new Label();
            lblPassword = new Label();
            lblNickname = new Label();
            tabRecupPassword = new TabPage();
            btnGuardarPersonal = new Button();
            txtRespPersonal = new TextBox();
            lblPregPersRespuesta = new Label();
            domPreguntrasPersonalles = new DomainUpDown();
            lblPregunta = new Label();
            lblComoRecupPass = new Label();
            tabRegistro.SuspendLayout();
            tabBasicos.SuspendLayout();
            grpDatosPersonales.SuspendLayout();
            groupBox1.SuspendLayout();
            tabRecupPassword.SuspendLayout();
            SuspendLayout();
            // 
            // tabRegistro
            // 
            tabRegistro.Controls.Add(tabBasicos);
            tabRegistro.Controls.Add(tabRecupPassword);
            tabRegistro.Dock = DockStyle.Fill;
            tabRegistro.Font = new Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabRegistro.Location = new Point(0, 0);
            tabRegistro.Name = "tabRegistro";
            tabRegistro.SelectedIndex = 0;
            tabRegistro.Size = new Size(707, 493);
            tabRegistro.TabIndex = 0;
            // 
            // tabBasicos
            // 
            tabBasicos.BackColor = Color.DarkSalmon;
            tabBasicos.BorderStyle = BorderStyle.FixedSingle;
            tabBasicos.Controls.Add(btnConfirmRegistro);
            tabBasicos.Controls.Add(grpDatosPersonales);
            tabBasicos.Controls.Add(groupBox1);
            tabBasicos.Font = new Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabBasicos.Location = new Point(4, 23);
            tabBasicos.Name = "tabBasicos";
            tabBasicos.Padding = new Padding(3);
            tabBasicos.Size = new Size(699, 466);
            tabBasicos.TabIndex = 0;
            tabBasicos.Text = "Datos Basicos";
            // 
            // btnConfirmRegistro
            // 
            btnConfirmRegistro.BackColor = Color.Brown;
            btnConfirmRegistro.Location = new Point(267, 385);
            btnConfirmRegistro.Name = "btnConfirmRegistro";
            btnConfirmRegistro.Size = new Size(129, 41);
            btnConfirmRegistro.TabIndex = 10;
            btnConfirmRegistro.Text = "Registrar";
            btnConfirmRegistro.UseVisualStyleBackColor = false;
            btnConfirmRegistro.Click += btnConfirmRegistro_Click;
            // 
            // grpDatosPersonales
            // 
            grpDatosPersonales.Controls.Add(domPais);
            grpDatosPersonales.Controls.Add(dtmFechaNacimiento);
            grpDatosPersonales.Controls.Add(radTortillaSin);
            grpDatosPersonales.Controls.Add(radTortillaCon);
            grpDatosPersonales.Controls.Add(txtApellido1);
            grpDatosPersonales.Controls.Add(txtApellido2);
            grpDatosPersonales.Controls.Add(txtNombre);
            grpDatosPersonales.Controls.Add(lblEdad);
            grpDatosPersonales.Controls.Add(lblNacionalidad);
            grpDatosPersonales.Controls.Add(lblTortilla);
            grpDatosPersonales.Controls.Add(lblApellido2);
            grpDatosPersonales.Controls.Add(lblApellido1);
            grpDatosPersonales.Controls.Add(lblNombre);
            grpDatosPersonales.Font = new Font("Cooper Black", 9.75F);
            grpDatosPersonales.Location = new Point(24, 165);
            grpDatosPersonales.Name = "grpDatosPersonales";
            grpDatosPersonales.Size = new Size(631, 215);
            grpDatosPersonales.TabIndex = 1;
            grpDatosPersonales.TabStop = false;
            grpDatosPersonales.Text = "Datos Personales";
            // 
            // domPais
            // 
            domPais.BackColor = Color.MistyRose;
            domPais.Items.Add("Españolo");
            domPais.Items.Add("Galeguiense");
            domPais.Items.Add("Portugaliano");
            domPais.Items.Add("Francialero");
            domPais.Items.Add("Estadounidoso");
            domPais.Items.Add("Inglesorro");
            domPais.Items.Add("Paquistadermo");
            domPais.Items.Add("Chimpún");
            domPais.Location = new Point(187, 179);
            domPais.Name = "domPais";
            domPais.Size = new Size(120, 22);
            domPais.TabIndex = 9;
            domPais.Text = "Pais";
            // 
            // dtmFechaNacimiento
            // 
            dtmFechaNacimiento.Location = new Point(187, 148);
            dtmFechaNacimiento.Name = "dtmFechaNacimiento";
            dtmFechaNacimiento.Size = new Size(228, 22);
            dtmFechaNacimiento.TabIndex = 8;
            // 
            // radTortillaSin
            // 
            radTortillaSin.AutoSize = true;
            radTortillaSin.Location = new Point(325, 121);
            radTortillaSin.Name = "radTortillaSin";
            radTortillaSin.Size = new Size(166, 19);
            radTortillaSin.TabIndex = 7;
            radTortillaSin.TabStop = true;
            radTortillaSin.Text = "Sin Sentido Ninguno";
            radTortillaSin.UseVisualStyleBackColor = true;
            radTortillaSin.Click += radTortillaSin_CheckedChanged;
            // 
            // radTortillaCon
            // 
            radTortillaCon.AutoSize = true;
            radTortillaCon.Location = new Point(187, 121);
            radTortillaCon.Name = "radTortillaCon";
            radTortillaCon.Size = new Size(103, 19);
            radTortillaCon.TabIndex = 6;
            radTortillaCon.TabStop = true;
            radTortillaCon.Text = "Con cebolla";
            radTortillaCon.UseVisualStyleBackColor = true;
            radTortillaCon.Click += radTortillaCon_CheckedChanged;
            // 
            // txtApellido1
            // 
            txtApellido1.BackColor = Color.MistyRose;
            txtApellido1.Location = new Point(187, 56);
            txtApellido1.Name = "txtApellido1";
            txtApellido1.Size = new Size(245, 22);
            txtApellido1.TabIndex = 4;
            // 
            // txtApellido2
            // 
            txtApellido2.BackColor = Color.MistyRose;
            txtApellido2.Location = new Point(187, 89);
            txtApellido2.Name = "txtApellido2";
            txtApellido2.Size = new Size(245, 22);
            txtApellido2.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.MistyRose;
            txtNombre.Location = new Point(187, 24);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(245, 22);
            txtNombre.TabIndex = 3;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(18, 154);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(147, 15);
            lblEdad.TabIndex = 5;
            lblEdad.Text = "Fecha de Nacimiento";
            lblEdad.TextAlign = ContentAlignment.TopRight;
            // 
            // lblNacionalidad
            // 
            lblNacionalidad.AutoSize = true;
            lblNacionalidad.Location = new Point(68, 186);
            lblNacionalidad.Name = "lblNacionalidad";
            lblNacionalidad.Size = new Size(97, 15);
            lblNacionalidad.TabIndex = 4;
            lblNacionalidad.Text = "Nacionalidad";
            lblNacionalidad.TextAlign = ContentAlignment.TopRight;
            // 
            // lblTortilla
            // 
            lblTortilla.AutoSize = true;
            lblTortilla.Location = new Point(53, 123);
            lblTortilla.Name = "lblTortilla";
            lblTortilla.Size = new Size(112, 15);
            lblTortilla.TabIndex = 3;
            lblTortilla.Text = "Tipo de tortilla";
            lblTortilla.TextAlign = ContentAlignment.TopRight;
            // 
            // lblApellido2
            // 
            lblApellido2.AutoSize = true;
            lblApellido2.Location = new Point(39, 91);
            lblApellido2.Name = "lblApellido2";
            lblApellido2.Size = new Size(124, 15);
            lblApellido2.TabIndex = 2;
            lblApellido2.Text = "Segundo apellido";
            lblApellido2.TextAlign = ContentAlignment.TopRight;
            // 
            // lblApellido1
            // 
            lblApellido1.AutoSize = true;
            lblApellido1.Location = new Point(43, 59);
            lblApellido1.Name = "lblApellido1";
            lblApellido1.Size = new Size(120, 15);
            lblApellido1.TabIndex = 1;
            lblApellido1.Text = "Primer Apellido";
            lblApellido1.TextAlign = ContentAlignment.TopRight;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(102, 27);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(61, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            lblNombre.TextAlign = ContentAlignment.TopRight;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblPassSize);
            groupBox1.Controls.Add(txtConfirmCOntrasena);
            groupBox1.Controls.Add(txtContrasena);
            groupBox1.Controls.Add(txtNickname);
            groupBox1.Controls.Add(lblCheckPassword);
            groupBox1.Controls.Add(lblPassword);
            groupBox1.Controls.Add(lblNickname);
            groupBox1.Font = new Font("Cooper Black", 9.75F);
            groupBox1.Location = new Point(23, 17);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(632, 133);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de Acceso de Usuario";
            // 
            // lblPassSize
            // 
            lblPassSize.AutoSize = true;
            lblPassSize.ForeColor = Color.Brown;
            lblPassSize.Location = new Point(129, 109);
            lblPassSize.Name = "lblPassSize";
            lblPassSize.Size = new Size(338, 15);
            lblPassSize.TabIndex = 6;
            lblPassSize.Text = "La contraseña debe contener al menos 8 caracteres";
            // 
            // txtConfirmCOntrasena
            // 
            txtConfirmCOntrasena.BackColor = Color.MistyRose;
            txtConfirmCOntrasena.Location = new Point(207, 76);
            txtConfirmCOntrasena.Name = "txtConfirmCOntrasena";
            txtConfirmCOntrasena.Size = new Size(303, 22);
            txtConfirmCOntrasena.TabIndex = 2;
            // 
            // txtContrasena
            // 
            txtContrasena.BackColor = Color.MistyRose;
            txtContrasena.Location = new Point(207, 46);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(303, 22);
            txtContrasena.TabIndex = 1;
            // 
            // txtNickname
            // 
            txtNickname.BackColor = Color.MistyRose;
            txtNickname.Location = new Point(207, 19);
            txtNickname.Name = "txtNickname";
            txtNickname.Size = new Size(303, 22);
            txtNickname.TabIndex = 0;
            // 
            // lblCheckPassword
            // 
            lblCheckPassword.AutoSize = true;
            lblCheckPassword.Location = new Point(51, 77);
            lblCheckPassword.Name = "lblCheckPassword";
            lblCheckPassword.Size = new Size(130, 15);
            lblCheckPassword.TabIndex = 2;
            lblCheckPassword.Text = "Repita Contraseña";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(47, 49);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(135, 15);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Contraseña deseada";
            // 
            // lblNickname
            // 
            lblNickname.AutoSize = true;
            lblNickname.Location = new Point(113, 21);
            lblNickname.Name = "lblNickname";
            lblNickname.Size = new Size(76, 15);
            lblNickname.TabIndex = 0;
            lblNickname.Text = "NIckname";
            // 
            // tabRecupPassword
            // 
            tabRecupPassword.BackColor = Color.Sienna;
            tabRecupPassword.Controls.Add(btnGuardarPersonal);
            tabRecupPassword.Controls.Add(txtRespPersonal);
            tabRecupPassword.Controls.Add(lblPregPersRespuesta);
            tabRecupPassword.Controls.Add(domPreguntrasPersonalles);
            tabRecupPassword.Controls.Add(lblPregunta);
            tabRecupPassword.Controls.Add(lblComoRecupPass);
            tabRecupPassword.Location = new Point(4, 23);
            tabRecupPassword.Name = "tabRecupPassword";
            tabRecupPassword.Padding = new Padding(3);
            tabRecupPassword.Size = new Size(699, 466);
            tabRecupPassword.TabIndex = 1;
            tabRecupPassword.Text = "Recuperacion de contraseña";
            // 
            // btnGuardarPersonal
            // 
            btnGuardarPersonal.BackColor = Color.LightSalmon;
            btnGuardarPersonal.Font = new Font("Cooper Black", 9F);
            btnGuardarPersonal.Location = new Point(241, 328);
            btnGuardarPersonal.Name = "btnGuardarPersonal";
            btnGuardarPersonal.Size = new Size(173, 57);
            btnGuardarPersonal.TabIndex = 2;
            btnGuardarPersonal.Text = "Guardar Respuesta";
            btnGuardarPersonal.UseVisualStyleBackColor = false;
            btnGuardarPersonal.Click += btnGuardarPersonal_Click;
            // 
            // txtRespPersonal
            // 
            txtRespPersonal.BackColor = Color.PeachPuff;
            txtRespPersonal.Font = new Font("Cooper Black", 9F);
            txtRespPersonal.Location = new Point(77, 271);
            txtRespPersonal.Name = "txtRespPersonal";
            txtRespPersonal.Size = new Size(539, 21);
            txtRespPersonal.TabIndex = 1;
            // 
            // lblPregPersRespuesta
            // 
            lblPregPersRespuesta.AutoSize = true;
            lblPregPersRespuesta.Font = new Font("Cooper Black", 9F);
            lblPregPersRespuesta.Location = new Point(35, 233);
            lblPregPersRespuesta.Name = "lblPregPersRespuesta";
            lblPregPersRespuesta.Size = new Size(103, 14);
            lblPregPersRespuesta.TabIndex = 3;
            lblPregPersRespuesta.Text = "Mi respuesta es:";
            // 
            // domPreguntrasPersonalles
            // 
            domPreguntrasPersonalles.BackColor = Color.PeachPuff;
            domPreguntrasPersonalles.Font = new Font("Cooper Black", 9F);
            domPreguntrasPersonalles.Items.Add("¿Cual es mi numero de cuenta?");
            domPreguntrasPersonalles.Items.Add("¿Cual es mi clave WIFI?");
            domPreguntrasPersonalles.Items.Add("¿Cual es el numero, caducidad y CCV de mi tarjeta?(la buena, la de las compras gordas)");
            domPreguntrasPersonalles.Items.Add("¿Cual es mi contraseña de acceso a mi ordenador personal?");
            domPreguntrasPersonalles.Items.Add("¿Cuales son las preguntas del examen de Desarrollo de Interfaces de este año?");
            domPreguntrasPersonalles.Location = new Point(67, 190);
            domPreguntrasPersonalles.Name = "domPreguntrasPersonalles";
            domPreguntrasPersonalles.Size = new Size(472, 21);
            domPreguntrasPersonalles.TabIndex = 0;
            domPreguntrasPersonalles.Text = "Preguntas Personales";
            domPreguntrasPersonalles.SelectedItemChanged += domPreguntrasPersonalles_SelectedItemChanged;
            // 
            // lblPregunta
            // 
            lblPregunta.AutoSize = true;
            lblPregunta.Font = new Font("Cooper Black", 9F);
            lblPregunta.Location = new Point(35, 143);
            lblPregunta.Name = "lblPregunta";
            lblPregunta.Size = new Size(123, 14);
            lblPregunta.TabIndex = 1;
            lblPregunta.Text = "Elija una pregunta:";
            // 
            // lblComoRecupPass
            // 
            lblComoRecupPass.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblComoRecupPass.Location = new Point(35, 37);
            lblComoRecupPass.Name = "lblComoRecupPass";
            lblComoRecupPass.Size = new Size(635, 75);
            lblComoRecupPass.TabIndex = 0;
            lblComoRecupPass.Text = "En caso de que se olvide la contraseña, puede guardar una pregunta personal para ayudarle a recuperarla. Estos datos solo se guardarán y utilizarán con el proposito de recuperar sus datos de acceso";
            lblComoRecupPass.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSalmon;
            ClientSize = new Size(707, 493);
            Controls.Add(tabRegistro);
            Font = new Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Snow;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Registro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de Nuevo Usuario";
            tabRegistro.ResumeLayout(false);
            tabBasicos.ResumeLayout(false);
            grpDatosPersonales.ResumeLayout(false);
            grpDatosPersonales.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabRecupPassword.ResumeLayout(false);
            tabRecupPassword.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabRegistro;
        private TabPage tabBasicos;
        private TabPage tabRecupPassword;
        private GroupBox groupBox1;
        private Label lblCheckPassword;
        private Label lblPassword;
        private Label lblNickname;
        private TextBox txtConfirmCOntrasena;
        private TextBox txtContrasena;
        private TextBox txtNickname;
        private GroupBox grpDatosPersonales;
        private Label lblNacionalidad;
        private Label lblTortilla;
        private Label lblApellido2;
        private Label lblApellido1;
        private Label lblNombre;
        private Label lblPassSize;
        private Label lblEdad;
        private DateTimePicker dtmFechaNacimiento;
        private RadioButton radTortillaSin;
        private RadioButton radTortillaCon;
        private TextBox txtApellido1;
        private TextBox txtApellido2;
        private TextBox txtNombre;
        private DomainUpDown domPais;
        private Button btnConfirmRegistro;
        private Label lblComoRecupPass;
        private Label lblPregunta;
        private DomainUpDown domPreguntrasPersonalles;
        private Button btnGuardarPersonal;
        private TextBox txtRespPersonal;
        private Label lblPregPersRespuesta;
    }
}