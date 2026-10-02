using System;
using System.Drawing;
using System.Windows.Forms;

namespace CajeroATM
{
    public partial class frmLogin : Form
    {

        private string[] tarjetas = { "2024001", "2024002", "2024003" };
        private string[] pins = { "1234", "5678", "9012" };
        private decimal[] saldos = { 5000.00m, 12500.75m, 850.50m };
        private string[] nombres = { "Ana Garcia", "Luis Perez", "Maria Lopez" };

        private int intentosFallidos = 0;
        private const int MAX_INTENTOS = 3;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string tarjetaIngresada = txtTarjeta.Text.Trim();
            string pinIngresado = txtPin.Text.Trim();

            if (string.IsNullOrEmpty(tarjetaIngresada) || string.IsNullOrEmpty(pinIngresado))
            {
                MessageBox.Show("Por favor ingresa tu numero de tarjeta y PIN.",
                    "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Buscar la tarjeta en el arreglo
            int indice = -1;
            for (int i = 0; i < tarjetas.Length; i++)
            {
                if (tarjetas[i] == tarjetaIngresada)
                {
                    indice = i;
                    break;
                }
            }

            if (indice != -1 && pins[indice] == pinIngresado)
            {

                intentosFallidos = 0;
                frmCajero cajero = new frmCajero(nombres[indice], tarjetas[indice], saldos[indice]);
                cajero.Show();
                this.Hide();
            }
            else
            {

                intentosFallidos++;
                int restantes = MAX_INTENTOS - intentosFallidos;

                if (intentosFallidos >= MAX_INTENTOS)
                {
                    MessageBox.Show("Tarjeta BLOQUEADA por 3 intentos fallidos.\nContacte a su banco.",
                        "Tarjeta Bloqueada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnIngresar.Enabled = false;
                    lblIntento.Text = "TARJETA BLOQUEADA";
                    lblIntento.ForeColor = Color.Red;
                }
                else
                {
                    lblIntento.Text = $"Datos incorrectos. Intentos restantes: {restantes}";
                    lblIntento.ForeColor = Color.OrangeRed;
                }
                txtPin.Clear();
                txtPin.Focus();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtTarjeta.Clear();
            txtPin.Clear();
            lblIntento.Text = "";
            txtTarjeta.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void picBanco_Click(object sender, EventArgs e)
        {

        }
    }
}

