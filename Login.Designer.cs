namespace DDI_Tarea_6
{
    partial class Login
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
            grpLogin = new GroupBox();
            btnLogin = new Button();
            linkLabel1 = new LinkLabel();
            lblRecuperarPassword = new Label();
            txtPassword = new TextBox();
            txtUsuario = new TextBox();
            lblPassword = new Label();
            lblUsuario = new Label();
            grpRecupContrasena = new GroupBox();
            btnCheckrespuestaPersonal = new Button();
            txtCheckRespuestaPersonal = new TextBox();
            label1 = new Label();
            grpRegistrar = new GroupBox();
            button1 = new Button();
            lblRegistroUsuario = new Label();
            grpLogin.SuspendLayout();
            grpRecupContrasena.SuspendLayout();
            grpRegistrar.SuspendLayout();
            SuspendLayout();
            // 
            // grpLogin
            // 
            grpLogin.BackColor = Color.Transparent;
            grpLogin.Controls.Add(btnLogin);
            grpLogin.Controls.Add(linkLabel1);
            grpLogin.Controls.Add(lblRecuperarPassword);
            grpLogin.Controls.Add(txtPassword);
            grpLogin.Controls.Add(txtUsuario);
            grpLogin.Controls.Add(lblPassword);
            grpLogin.Controls.Add(lblUsuario);
            grpLogin.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpLogin.ForeColor = SystemColors.ButtonHighlight;
            grpLogin.Location = new Point(72, 29);
            grpLogin.Name = "grpLogin";
            grpLogin.Size = new Size(885, 226);
            grpLogin.TabIndex = 0;
            grpLogin.TabStop = false;
            grpLogin.Text = "Acceso de Usuario";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(622, 34);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(129, 123);
            btnLogin.TabIndex = 2;
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Cooper Black", 9.75F);
            linkLabel1.ForeColor = SystemColors.ButtonHighlight;
            linkLabel1.Location = new Point(237, 184);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(37, 15);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "aqui";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // lblRecuperarPassword
            // 
            lblRecuperarPassword.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecuperarPassword.ForeColor = SystemColors.ButtonHighlight;
            lblRecuperarPassword.Location = new Point(188, 166);
            lblRecuperarPassword.Name = "lblRecuperarPassword";
            lblRecuperarPassword.Size = new Size(383, 47);
            lblRecuperarPassword.TabIndex = 4;
            lblRecuperarPassword.Text = "Si tiene problemas recordando su contraseña, pulse";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.Snow;
            txtPassword.Font = new Font("Cooper Black", 11.25F);
            txtPassword.ForeColor = Color.Sienna;
            txtPassword.Location = new Point(164, 108);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(414, 25);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.Snow;
            txtUsuario.Font = new Font("Cooper Black", 11.25F);
            txtUsuario.ForeColor = Color.Sienna;
            txtUsuario.Location = new Point(164, 57);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(414, 25);
            txtUsuario.TabIndex = 0;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Cooper Black", 11.25F);
            lblPassword.ForeColor = SystemColors.ButtonHighlight;
            lblPassword.Location = new Point(56, 115);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(96, 17);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Cooper Black", 11.25F);
            lblUsuario.ForeColor = SystemColors.ButtonHighlight;
            lblUsuario.Location = new Point(76, 59);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(68, 17);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            // 
            // grpRecupContrasena
            // 
            grpRecupContrasena.BackColor = Color.Transparent;
            grpRecupContrasena.Controls.Add(btnCheckrespuestaPersonal);
            grpRecupContrasena.Controls.Add(txtCheckRespuestaPersonal);
            grpRecupContrasena.Controls.Add(label1);
            grpRecupContrasena.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpRecupContrasena.ForeColor = Color.White;
            grpRecupContrasena.Location = new Point(210, 88);
            grpRecupContrasena.Margin = new Padding(3, 2, 3, 2);
            grpRecupContrasena.Name = "grpRecupContrasena";
            grpRecupContrasena.Padding = new Padding(3, 2, 3, 2);
            grpRecupContrasena.Size = new Size(638, 288);
            grpRecupContrasena.TabIndex = 2;
            grpRecupContrasena.TabStop = false;
            grpRecupContrasena.Text = "Recuperacion de Contraseña";
            grpRecupContrasena.Visible = false;
            // 
            // btnCheckrespuestaPersonal
            // 
            btnCheckrespuestaPersonal.BackColor = Color.Sienna;
            btnCheckrespuestaPersonal.ForeColor = Color.White;
            btnCheckrespuestaPersonal.Location = new Point(256, 233);
            btnCheckrespuestaPersonal.Margin = new Padding(3, 2, 3, 2);
            btnCheckrespuestaPersonal.Name = "btnCheckrespuestaPersonal";
            btnCheckrespuestaPersonal.Size = new Size(105, 33);
            btnCheckrespuestaPersonal.TabIndex = 1;
            btnCheckrespuestaPersonal.Text = "Comprobar";
            btnCheckrespuestaPersonal.UseVisualStyleBackColor = false;
            btnCheckrespuestaPersonal.Visible = false;
            btnCheckrespuestaPersonal.Click += btnCheckrespuestaPersonal_Click;
            // 
            // txtCheckRespuestaPersonal
            // 
            txtCheckRespuestaPersonal.BackColor = Color.Linen;
            txtCheckRespuestaPersonal.ForeColor = Color.SaddleBrown;
            txtCheckRespuestaPersonal.Location = new Point(85, 152);
            txtCheckRespuestaPersonal.Margin = new Padding(3, 2, 3, 2);
            txtCheckRespuestaPersonal.Name = "txtCheckRespuestaPersonal";
            txtCheckRespuestaPersonal.Size = new Size(426, 25);
            txtCheckRespuestaPersonal.TabIndex = 0;
            txtCheckRespuestaPersonal.Visible = false;
            // 
            // label1
            // 
            label1.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(113, 56);
            label1.Name = "label1";
            label1.Size = new Size(404, 55);
            label1.TabIndex = 0;
            // 
            // grpRegistrar
            // 
            grpRegistrar.BackColor = Color.Transparent;
            grpRegistrar.Controls.Add(button1);
            grpRegistrar.Controls.Add(lblRegistroUsuario);
            grpRegistrar.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpRegistrar.ForeColor = Color.White;
            grpRegistrar.Location = new Point(215, 261);
            grpRegistrar.Name = "grpRegistrar";
            grpRegistrar.Size = new Size(512, 163);
            grpRegistrar.TabIndex = 1;
            grpRegistrar.TabStop = false;
            grpRegistrar.Text = "Registro de Nuevo Usuario";
            // 
            // button1
            // 
            button1.BackColor = Color.Sienna;
            button1.Font = new Font("Cooper Black", 9F);
            button1.ForeColor = Color.MistyRose;
            button1.Location = new Point(159, 107);
            button1.Name = "button1";
            button1.Size = new Size(167, 37);
            button1.TabIndex = 0;
            button1.Text = "Registrar Nuevo Usuario";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblRegistroUsuario
            // 
            lblRegistroUsuario.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRegistroUsuario.ForeColor = Color.Transparent;
            lblRegistroUsuario.Location = new Point(30, 39);
            lblRegistroUsuario.Name = "lblRegistroUsuario";
            lblRegistroUsuario.Size = new Size(383, 37);
            lblRegistroUsuario.TabIndex = 0;
            lblRegistroUsuario.Text = "Si usted aun no es usuario de nuestra plataforma, por favor registrese pulsando el boton mostrado a continuacion";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 500);
            Controls.Add(grpRecupContrasena);
            Controls.Add(grpRegistrar);
            Controls.Add(grpLogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            grpLogin.ResumeLayout(false);
            grpLogin.PerformLayout();
            grpRecupContrasena.ResumeLayout(false);
            grpRecupContrasena.PerformLayout();
            grpRegistrar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpLogin;
        private Label lblPassword;
        private Label lblUsuario;
        private Label lblRecuperarPassword;
        private TextBox txtPassword;
        private TextBox txtUsuario;
        private LinkLabel linkLabel1;
        private GroupBox groupBox1;
        private Button btnLogin;
        internal GroupBox grpRegistrar;
        private Label lblRegistroUsuario;
        private Button button1;
        private GroupBox grpRecupContrasena;
        private Button btnCheckrespuestaPersonal;
        private TextBox txtCheckRespuestaPersonal;
        private Label label1;
    }
}