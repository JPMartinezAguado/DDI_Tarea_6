namespace DDI_Tarea_6
{
    partial class Despedida
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Despedida));
            btnSalir = new Button();
            imageList3 = new ImageList(components);
            btnElectricista = new Button();
            btnMecanico = new Button();
            btnAlbanil = new Button();
            btnServPersonalizado = new Button();
            lblElectric = new Label();
            lblMecanico = new Label();
            lblAlbanil = new Label();
            grpNuevoServicio = new GroupBox();
            lblDisclaimer = new Label();
            pictureBox1 = new PictureBox();
            btnSelImage = new Button();
            txtNUevoServicio = new TextBox();
            btnSiguienteImagen = new Button();
            btnAgregServicio = new Button();
            lblDescrNewServicio = new Label();
            lblNomNewServicio = new Label();
            grpNuevoServicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Transparent;
            btnSalir.BackgroundImage = Properties.Resources.salida2;
            btnSalir.BackgroundImageLayout = ImageLayout.Stretch;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.ImageAlign = ContentAlignment.TopCenter;
            btnSalir.Location = new Point(443, 388);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(117, 137);
            btnSalir.TabIndex = 4;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // imageList3
            // 
            imageList3.ColorDepth = ColorDepth.Depth8Bit;
            imageList3.ImageStream = (ImageListStreamer)resources.GetObject("imageList3.ImageStream");
            imageList3.TransparentColor = Color.Black;
            imageList3.Images.SetKeyName(0, "r1.jpg");
            imageList3.Images.SetKeyName(1, "r2.jpg");
            imageList3.Images.SetKeyName(2, "r3.jpg");
            imageList3.Images.SetKeyName(3, "r4.jpg");
            imageList3.Images.SetKeyName(4, "r5.jpg");
            imageList3.Images.SetKeyName(5, "r6.jpg");
            // 
            // btnElectricista
            // 
            btnElectricista.BackgroundImageLayout = ImageLayout.Stretch;
            btnElectricista.Location = new Point(35, 49);
            btnElectricista.Name = "btnElectricista";
            btnElectricista.Size = new Size(100, 90);
            btnElectricista.TabIndex = 0;
            btnElectricista.UseVisualStyleBackColor = true;
            btnElectricista.Click += btnElectricista_Click;
            // 
            // btnMecanico
            // 
            btnMecanico.Location = new Point(35, 133);
            btnMecanico.Name = "btnMecanico";
            btnMecanico.Size = new Size(100, 90);
            btnMecanico.TabIndex = 1;
            btnMecanico.UseVisualStyleBackColor = true;
            btnMecanico.Click += btnElectricista_Click;
            // 
            // btnAlbanil
            // 
            btnAlbanil.Location = new Point(35, 221);
            btnAlbanil.Name = "btnAlbanil";
            btnAlbanil.Size = new Size(100, 90);
            btnAlbanil.TabIndex = 2;
            btnAlbanil.UseVisualStyleBackColor = true;
            btnAlbanil.Click += btnElectricista_Click;
            // 
            // btnServPersonalizado
            // 
            btnServPersonalizado.BackColor = SystemColors.ButtonFace;
            btnServPersonalizado.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnServPersonalizado.Location = new Point(24, 413);
            btnServPersonalizado.Name = "btnServPersonalizado";
            btnServPersonalizado.Size = new Size(219, 84);
            btnServPersonalizado.TabIndex = 3;
            btnServPersonalizado.Text = "Agregar servicio personalizado";
            btnServPersonalizado.UseVisualStyleBackColor = false;
            btnServPersonalizado.Click += btnServPersonalizado_Click;
            // 
            // lblElectric
            // 
            lblElectric.AutoSize = true;
            lblElectric.BackColor = Color.Transparent;
            lblElectric.Font = new Font("Cooper Black", 20.25F);
            lblElectric.ForeColor = Color.Navy;
            lblElectric.Location = new Point(142, 76);
            lblElectric.Name = "lblElectric";
            lblElectric.Size = new Size(183, 31);
            lblElectric.TabIndex = 4;
            lblElectric.Text = "Electricidad";
            lblElectric.Click += btnElectricista_Click;
            // 
            // lblMecanico
            // 
            lblMecanico.AutoSize = true;
            lblMecanico.BackColor = Color.Transparent;
            lblMecanico.Font = new Font("Cooper Black", 20.25F);
            lblMecanico.ForeColor = Color.Navy;
            lblMecanico.Location = new Point(142, 160);
            lblMecanico.Name = "lblMecanico";
            lblMecanico.Size = new Size(138, 31);
            lblMecanico.TabIndex = 5;
            lblMecanico.Text = "Mecanica";
            lblMecanico.Click += btnElectricista_Click;
            // 
            // lblAlbanil
            // 
            lblAlbanil.AutoSize = true;
            lblAlbanil.BackColor = Color.Transparent;
            lblAlbanil.Font = new Font("Cooper Black", 20.25F);
            lblAlbanil.ForeColor = Color.Navy;
            lblAlbanil.Location = new Point(142, 252);
            lblAlbanil.Name = "lblAlbanil";
            lblAlbanil.Size = new Size(169, 31);
            lblAlbanil.TabIndex = 6;
            lblAlbanil.Text = "Albañileria";
            lblAlbanil.Click += btnElectricista_Click;
            // 
            // grpNuevoServicio
            // 
            grpNuevoServicio.BackColor = Color.Transparent;
            grpNuevoServicio.Controls.Add(lblDisclaimer);
            grpNuevoServicio.Controls.Add(pictureBox1);
            grpNuevoServicio.Controls.Add(btnSelImage);
            grpNuevoServicio.Controls.Add(txtNUevoServicio);
            grpNuevoServicio.Controls.Add(btnSiguienteImagen);
            grpNuevoServicio.Controls.Add(btnAgregServicio);
            grpNuevoServicio.Controls.Add(lblDescrNewServicio);
            grpNuevoServicio.Controls.Add(lblNomNewServicio);
            grpNuevoServicio.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpNuevoServicio.Location = new Point(183, 49);
            grpNuevoServicio.Name = "grpNuevoServicio";
            grpNuevoServicio.Size = new Size(652, 358);
            grpNuevoServicio.TabIndex = 7;
            grpNuevoServicio.TabStop = false;
            grpNuevoServicio.Text = "Agregar Nuevo Servicio";
            grpNuevoServicio.Visible = false;
            // 
            // lblDisclaimer
            // 
            lblDisclaimer.BackColor = SystemColors.ControlDarkDark;
            lblDisclaimer.BorderStyle = BorderStyle.Fixed3D;
            lblDisclaimer.Font = new Font("Cooper Black", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDisclaimer.ForeColor = Color.PeachPuff;
            lblDisclaimer.Location = new Point(126, 96);
            lblDisclaimer.Name = "lblDisclaimer";
            lblDisclaimer.Size = new Size(384, 127);
            lblDisclaimer.TabIndex = 5;
            lblDisclaimer.Text = "La agregacion de multiples servicios estará disponible en la version 2.0 del programa";
            lblDisclaimer.TextAlign = ContentAlignment.MiddleCenter;
            lblDisclaimer.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.InitialImage = Properties.Resources.r2;
            pictureBox1.Location = new Point(352, 37);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnSelImage
            // 
            btnSelImage.Location = new Point(447, 263);
            btnSelImage.Margin = new Padding(3, 2, 3, 2);
            btnSelImage.Name = "btnSelImage";
            btnSelImage.Size = new Size(131, 54);
            btnSelImage.TabIndex = 2;
            btnSelImage.Text = "Seleccionar imagen";
            btnSelImage.UseVisualStyleBackColor = true;
            btnSelImage.Click += btnSelImage_Click;
            // 
            // txtNUevoServicio
            // 
            txtNUevoServicio.Font = new Font("Cooper Black", 9.75F);
            txtNUevoServicio.Location = new Point(49, 46);
            txtNUevoServicio.Name = "txtNUevoServicio";
            txtNUevoServicio.Size = new Size(154, 22);
            txtNUevoServicio.TabIndex = 0;
            // 
            // btnSiguienteImagen
            // 
            btnSiguienteImagen.Location = new Point(285, 263);
            btnSiguienteImagen.Margin = new Padding(3, 2, 3, 2);
            btnSiguienteImagen.Name = "btnSiguienteImagen";
            btnSiguienteImagen.Size = new Size(131, 54);
            btnSiguienteImagen.TabIndex = 1;
            btnSiguienteImagen.Text = "Siguiente";
            btnSiguienteImagen.UseVisualStyleBackColor = true;
            btnSiguienteImagen.Click += btnSiguienteImagen_Click;
            // 
            // btnAgregServicio
            // 
            btnAgregServicio.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregServicio.Location = new Point(97, 218);
            btnAgregServicio.Name = "btnAgregServicio";
            btnAgregServicio.Size = new Size(149, 83);
            btnAgregServicio.TabIndex = 3;
            btnAgregServicio.Text = "Agregar Servicio";
            btnAgregServicio.UseVisualStyleBackColor = true;
            btnAgregServicio.Click += btnAgregServicio_Click;
            // 
            // lblDescrNewServicio
            // 
            lblDescrNewServicio.AutoSize = true;
            lblDescrNewServicio.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescrNewServicio.Location = new Point(49, 96);
            lblDescrNewServicio.Name = "lblDescrNewServicio";
            lblDescrNewServicio.Size = new Size(119, 19);
            lblDescrNewServicio.TabIndex = 1;
            lblDescrNewServicio.Text = "Elija su icono";
            // 
            // lblNomNewServicio
            // 
            lblNomNewServicio.AutoSize = true;
            lblNomNewServicio.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNomNewServicio.Location = new Point(49, 25);
            lblNomNewServicio.Name = "lblNomNewServicio";
            lblNomNewServicio.Size = new Size(173, 19);
            lblNomNewServicio.TabIndex = 0;
            lblNomNewServicio.Text = "Nombre del Servicio";
            // 
            // Despedida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 541);
            Controls.Add(btnServPersonalizado);
            Controls.Add(grpNuevoServicio);
            Controls.Add(lblAlbanil);
            Controls.Add(lblMecanico);
            Controls.Add(lblElectric);
            Controls.Add(btnSalir);
            Controls.Add(btnAlbanil);
            Controls.Add(btnElectricista);
            Controls.Add(btnMecanico);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Despedida";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Despedida";
            grpNuevoServicio.ResumeLayout(false);
            grpNuevoServicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private GroupBox grpConstruccion;
        private Button btnCerrar;
        private GroupBox grpNuevoServicio;
        private TextBox txtNUevoServicio;
        private Label lblDescrNewServicio;
        private Label lblNomNewServicio;
        private Button btnAgregServicio;
        private ImageList imageList3;
        private PictureBox pictureBox1;
        private Button btnSiguienteImagen;
        private Button btnSelImage;
        private Button btnElectricista;
        private Button btnMecanico;
        private Button btnAlbanil;
        private Button btnServPersonalizado;
        private Label lblElectric;
        private Label lblMecanico;
        private Label lblAlbanil;
        private Label lblDisclaimer;
    }
}