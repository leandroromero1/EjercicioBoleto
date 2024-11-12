namespace EjercicioBoleto
{
    partial class FormPasajero
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
            btnAgregar = new Button();
            label5 = new Label();
            txtUniversidad = new TextBox();
            label4 = new Label();
            txtLegajo = new TextBox();
            chkBoxEstudiante = new CheckBox();
            label3 = new Label();
            txtEdad = new TextBox();
            label2 = new Label();
            txtApellido = new TextBox();
            label1 = new Label();
            txtNombre = new TextBox();
            btnModificar = new Button();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(37, 382);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Aceptar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 301);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 25;
            label5.Text = "Universidad";
            // 
            // txtUniversidad
            // 
            txtUniversidad.Location = new Point(12, 319);
            txtUniversidad.Name = "txtUniversidad";
            txtUniversidad.Size = new Size(100, 23);
            txtUniversidad.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 233);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 23;
            label4.Text = "Legajo";
            // 
            // txtLegajo
            // 
            txtLegajo.Location = new Point(12, 251);
            txtLegajo.Name = "txtLegajo";
            txtLegajo.Size = new Size(100, 23);
            txtLegajo.TabIndex = 22;
            // 
            // chkBoxEstudiante
            // 
            chkBoxEstudiante.AutoSize = true;
            chkBoxEstudiante.Location = new Point(12, 197);
            chkBoxEstudiante.Name = "chkBoxEstudiante";
            chkBoxEstudiante.Size = new Size(81, 19);
            chkBoxEstudiante.TabIndex = 21;
            chkBoxEstudiante.Text = "Estudiante";
            chkBoxEstudiante.UseVisualStyleBackColor = true;
            chkBoxEstudiante.CheckedChanged += chkBoxEstudiante_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 133);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 20;
            label3.Text = "Edad";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(12, 151);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 78);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 18;
            label2.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(12, 96);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 16;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 37);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 15;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(211, 382);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 26;
            btnModificar.Text = "Cancelar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // FormPasajero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 450);
            Controls.Add(btnModificar);
            Controls.Add(label5);
            Controls.Add(txtUniversidad);
            Controls.Add(label4);
            Controls.Add(txtLegajo);
            Controls.Add(chkBoxEstudiante);
            Controls.Add(label3);
            Controls.Add(txtEdad);
            Controls.Add(label2);
            Controls.Add(txtApellido);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Controls.Add(btnAgregar);
            Name = "FormPasajero";
            Text = "FormPasajero";
            Load += FormPasajero_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private Label label5;
        private TextBox txtUniversidad;
        private Label label4;
        private TextBox txtLegajo;
        private CheckBox chkBoxEstudiante;
        private Label label3;
        private TextBox txtEdad;
        private Label label2;
        private TextBox txtApellido;
        private Label label1;
        private TextBox txtNombre;
        private Button btnModificar;
    }
}