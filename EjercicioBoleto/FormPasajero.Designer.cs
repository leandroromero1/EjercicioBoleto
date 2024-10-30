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
            textBox5 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            chkBoxEstudiante = new CheckBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
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
            // textBox5
            // 
            textBox5.Location = new Point(12, 319);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 24;
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
            // textBox4
            // 
            textBox4.Location = new Point(12, 251);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 22;
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
            // textBox3
            // 
            textBox3.Location = new Point(12, 151);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 19;
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
            // textBox2
            // 
            textBox2.Location = new Point(12, 96);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 17;
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
            // textBox1
            // 
            textBox1.Location = new Point(12, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 15;
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
            Controls.Add(textBox5);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(chkBoxEstudiante);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(btnAgregar);
            Name = "FormPasajero";
            Text = "FormPasajero";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private Label label5;
        private TextBox textBox5;
        private Label label4;
        private TextBox textBox4;
        private CheckBox chkBoxEstudiante;
        private Label label3;
        private TextBox textBox3;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private Button btnModificar;
    }
}