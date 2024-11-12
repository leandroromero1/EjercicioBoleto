namespace EjercicioBoleto
{
    partial class FormPasajeros
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvPasajeros = new DataGridView();
            rdbtnPasajeros = new RadioButton();
            rdbtnEstudiantes = new RadioButton();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPasajeros).BeginInit();
            SuspendLayout();
            // 
            // dgvPasajeros
            // 
            dgvPasajeros.AllowUserToAddRows = false;
            dgvPasajeros.AllowUserToDeleteRows = false;
            dgvPasajeros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPasajeros.Location = new Point(12, 12);
            dgvPasajeros.Name = "dgvPasajeros";
            dgvPasajeros.ReadOnly = true;
            dgvPasajeros.Size = new Size(910, 397);
            dgvPasajeros.TabIndex = 0;
            // 
            // rdbtnPasajeros
            // 
            rdbtnPasajeros.AutoSize = true;
            rdbtnPasajeros.Location = new Point(928, 24);
            rdbtnPasajeros.Name = "rdbtnPasajeros";
            rdbtnPasajeros.Size = new Size(125, 19);
            rdbtnPasajeros.TabIndex = 1;
            rdbtnPasajeros.TabStop = true;
            rdbtnPasajeros.Text = "Pasajeros regulares";
            rdbtnPasajeros.UseVisualStyleBackColor = true;
            rdbtnPasajeros.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rdbtnEstudiantes
            // 
            rdbtnEstudiantes.AutoSize = true;
            rdbtnEstudiantes.Location = new Point(928, 49);
            rdbtnEstudiantes.Name = "rdbtnEstudiantes";
            rdbtnEstudiantes.Size = new Size(137, 19);
            rdbtnEstudiantes.TabIndex = 2;
            rdbtnEstudiantes.TabStop = true;
            rdbtnEstudiantes.Text = "Pasajeros Estudiantes";
            rdbtnEstudiantes.UseVisualStyleBackColor = true;
            rdbtnEstudiantes.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 415);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(318, 415);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(713, 415);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FormPasajeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 450);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(rdbtnEstudiantes);
            Controls.Add(rdbtnPasajeros);
            Controls.Add(dgvPasajeros);
            Name = "FormPasajeros";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPasajeros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPasajeros;
        private RadioButton rdbtnPasajeros;
        private RadioButton rdbtnEstudiantes;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
    }
}
