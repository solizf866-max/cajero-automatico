using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace CajeroATM
{
    public partial class frmCajero : Form
    {
        private string nombreCliente;
        private string numeroTarjeta;
        private decimal saldoActual;
        private List<string> historial = new List<string>();


        public frmCajero(string nombre, string tarjeta, decimal saldo)
        {
            InitializeComponent();
            nombreCliente = nombre;
            numeroTarjeta = tarjeta;
            saldoActual = saldo;
        }

        private void frmCajero_Load(object sender, EventArgs e)
        {

            lblBienvenida.Text = $"Bienvenido/a, {nombreCliente}";

            string ultimos4 = numeroTarjeta.Length >= 4
                ? numeroTarjeta.Substring(numeroTarjeta.Length - 4)
                : numeroTarjeta;
            lblTarjetaNum.Text = $"Tarjeta: **** **** **** {ultimos4}";

            ActualizarSaldo();

            timer1.Start();
            ActualizarFecha();
        }
        private void ActualizarSaldo()
        {
            lblSaldo.Text = saldoActual.ToString("C2", new System.Globalization.CultureInfo("es-GT"));


            if (saldoActual > 1000)
                lblSaldo.ForeColor = Color.LimeGreen;
            else if (saldoActual > 0)
                lblSaldo.ForeColor = Color.Orange;
            else
                lblSaldo.ForeColor = Color.Red;
        }


        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string mensaje = $"Estimado/a {nombreCliente}\n\n" +
                             $"Su saldo disponible es:\n\n" +
                             $"{saldoActual.ToString("C2", new System.Globalization.CultureInfo("es-GT"))}\n\n" +
                             $"Fecha: {DateTime.Now.ToString("dd/MM/yyyy HH:mm")}";
            MessageBox.Show(mensaje, "Consulta de Saldo",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            string entrada = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el monto a depositar:","Deposito","0.00");

            if (string.IsNullOrWhiteSpace(entrada)) return;

            if (decimal.TryParse(entrada, out decimal monto) && monto > 0)
            {
                saldoActual += monto;
                ActualizarSaldo();

                string registro = $"[{DateTime.Now:HH:mm}] DEPOSITO: +{monto:C2}";
                historial.Add(registro);
                lstHistorial.Items.Insert(0, registro);

                MessageBox.Show($"Deposito exitoso.\nNuevo saldo: {saldoActual.ToString("C2", new System.Globalization.CultureInfo("es-GT"))}",
                    "Deposito Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Monto invalido. Ingrese un numero mayor a 0.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            string entrada = Microsoft.VisualBasic.Interaction.InputBox(
                $"Saldo disponible: {saldoActual.ToString("C2", new System.Globalization.CultureInfo("es-GT"))}\n\nIngrese el monto a retirar:",
                "Retiro", "0.00");

            if (string.IsNullOrWhiteSpace(entrada)) return;

            if (decimal.TryParse(entrada, out decimal monto) && monto > 0)
            {
                if (monto > saldoActual)
                {
                    MessageBox.Show("Saldo insuficiente para realizar esta operacion.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    saldoActual -= monto;
                    ActualizarSaldo();

                    string registro = $"[{DateTime.Now:HH:mm}] RETIRO:   -{monto:C2}";
                    historial.Add(registro);
                    lstHistorial.Items.Insert(0, registro);

                    MessageBox.Show($"Retiro exitoso.\nSaldo restante: {saldoActual.ToString("C2", new System.Globalization.CultureInfo("es-GT"))}",
                        "Retiro Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
              }
            }
            else
            {
                MessageBox.Show("Monto invalido. Ingrese un numero mayor a 0.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        }
        private void btnHistorial_Click(object sender, EventArgs e)
        {
            if (historial.Count == 0)
            {
                MessageBox.Show("No hay transacciones en esta sesion.",
                    "Historial", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lstHistorial.Visible = !lstHistorial.Visible;
                btnHistorial.Text = lstHistorial.Visible ? "OCULTAR HISTORIAL" : "VER HISTORIAL";
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "Desea cerrar la sesion?",
                "Cerrar Sesion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                timer1.Stop();
                Application.OpenForms["frmLogin"]?.Show();
                foreach (Form f in Application.OpenForms)
                {
                    if (f is frmLogin login)
                    {
                        login.txtTarjeta.Clear();
                        login.txtPin.Clear();
                        login.lblIntento.Text = "";
                    }
                }
                this.Close();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            ActualizarFecha();
        }

        private void ActualizarFecha()
        {
            lblFecha.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy    HH:mm:ss",
                new System.Globalization.CultureInfo("es-GT"));
        }

        }
    }
