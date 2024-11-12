using Controladora;
using Modelo;

namespace EjercicioBoleto
{
    public partial class FormPasajeros : Form
    {
        private ControladoraCRUDPasajeros controladora;
        public FormPasajeros()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            controladora = new ControladoraCRUDPasajeros();
            dgvPasajeros.DataSource = controladora.RecuperarPasajeros();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dgvPasajeros.DataSource = null;
            dgvPasajeros.DataSource = controladora.RecuperarPasajeros();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dgvPasajeros.DataSource = null;
            dgvPasajeros.DataSource = controladora.RecuperarPasajerosEstudiantes();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Form formAgregar = new FormPasajero();
            formAgregar.ShowDialog();
            ActualizarVista();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {/*
            if (dgvPasajeros.Rows.Count > 0)
            {
                var pasajero = (Pasajero)dgvPasajeros.CurrentRow.DataBoundItem;
                bool eliminado = controladora.Eliminar(pasajero);
                if (eliminado)
                {
                    MessageBox.Show("Medicamento eliminado correctamente");
                }
                else
                {
                    MessageBox.Show("Error: no se pudo eliminar el medicamento");
                }
                ActualizarVista();
            }
            else
            {
                MessageBox.Show("No hay ningun medicamento para eliminar");
            }
        */}

        private void ActualizarVista()
        {
            if (rdbtnPasajeros.Checked)
            {
                dgvPasajeros.DataSource = null;
                dgvPasajeros.DataSource = controladora.RecuperarPasajeros();
            }
            if (rdbtnEstudiantes.Checked)
            {
                dgvPasajeros.DataSource = null;
                dgvPasajeros.DataSource = controladora.RecuperarPasajerosEstudiantes();
            }
        }
    }
    
}
