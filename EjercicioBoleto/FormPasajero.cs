using Controladora;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace EjercicioBoleto
{
    public partial class FormPasajero : Form
    {
        private ControladoraCRUDPasajeros controladoraPasajeros;
        private Pasajero pasajero;
        private Colectivo colectivo;
        private bool modifica = false;
        public FormPasajero()
        {
            InitializeComponent();
            pasajero = new Pasajero();
            controladoraPasajeros = new ControladoraCRUDPasajeros();
        }

        public FormPasajero(Pasajero pasajero)
        {
            InitializeComponent();
            controladoraPasajeros = new ControladoraCRUDPasajeros();
            this.pasajero = pasajero;
            modifica = true;
        }

        private void chkBoxEstudiante_CheckedChanged(object sender, EventArgs e)
        {
            //txtLegajo.Enabled = !chkBoxEstudiante.Checked;

            if (chkBoxEstudiante.Checked)
            {
                txtLegajo.Enabled = true;
                txtUniversidad.Enabled = true;

            }
            else
            {
                txtLegajo.Enabled = false;
                txtUniversidad.Enabled = false;
            }
        }

        private void FormPasajero_Load(object sender, EventArgs e)
        {
            txtLegajo.Enabled = false;
            txtUniversidad.Enabled = false;
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("El nombre no puede ser nulo");
                return false;
            }
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("El apellido no puede ser nulo");
                return false;
            }
            if (string.IsNullOrEmpty(txtEdad.Text))
            {
                MessageBox.Show("La edad no puede ser nula");
                return false;
            }
            /*if (string.IsNullOrEmpty(txtStockMinimo.Text))
            {
                MessageBox.Show("El stock minimo no puede ser nulo");
                return false;
            }

            if (!Decimal.TryParse(txtPrecioVenta.Text, out var val))
            {
                MessageBox.Show("El precio de venta debe ser un numero entero o decimal");
                return false;
            }
            if (!int.TryParse(txtStock.Text, out var val2))
            {
                MessageBox.Show("El stock debe ser un numero entero");
                return false;
            }
            if (!int.TryParse(txtStockMinimo.Text, out var val3))
            {
                MessageBox.Show("El stock minimo debe ser un numero entero");
                return false; */

            return true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                
                pasajero.Nombre = txtNombre.Text;
                pasajero.Apellido = txtApellido.Text;
                pasajero.Edad = Convert.ToInt32(txtEdad.Text);
                var monodrogas = controladoraPasajeros.RecuperarPasajeros();
                var pasajeros = colectivo.Pasajeros;
                if (pasajeros.Count() > 0)
                {
                    if (modifica)
                    {
                        var modifica = controladoraPasajeros.Modificar(pasajero);
                        if (modifica)
                        {
                            MessageBox.Show("Pasajero modificado con exito");
                        }
                        else
                        {
                            MessageBox.Show("Error: no se pudo modificar el pasajero");
                        }
                        Close();
                    }
                    else
                    {
                        var agregado = controladoraPasajeros.Agregar(pasajero);
                        if (agregado)
                        {
                            MessageBox.Show("Pasajero agregado con exito");
                        }
                        else
                        {
                            MessageBox.Show("Error: no se pudo agregar el Pasajero");
                        }
                        Close();
                    }
                }
              
            }
        }
    }
}
