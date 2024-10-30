using Controladora;

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
            dataGridView1.DataSource = controladora.RecuperarPasajeros();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = controladora.RecuperarPasajeros();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = controladora.RecuperarPasajerosEstudiantes();
        }
    }
}
