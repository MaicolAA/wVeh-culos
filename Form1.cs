using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Fecha: 30/03/2022
/// Descripcion: Selección de vehiculo a ingresar al sistema
/// Autores: Natalia Usuga Manco, Sara Daniela Parra Betancur, Maicol Arroyave Mor de Medellin Mor
/// 
/// </summary>

namespace wVehículos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void IniciarFormulario()
        {

            txtPotencia.Enabled = true;
            txtPlaca.Enabled = true;
            txtModelo.Enabled = true;
            txtMarca.Enabled = true;
            txtColor.Enabled = true;





            #region[Limpiar formulario]
            try
            {
                txtPlaca.Text = "";
                txtModelo.Text = "";
                txtPotencia.Text = "";
                txtColor.Text = "";
                txtMarca.Text = "";
                cboSeleccionarVehículo.Text = "";
                #endregion

            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Message, " Error");
            }

        }

        private void cboSeleccionarVehículo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = cboSeleccionarVehículo.Text;

            switch (item)
            {
                case "Taxi":
                    txtPotencia.Enabled = false;

                    break;

                case "Buseta":

                    break;

                case "Particular":

                    txtMarca.Enabled = false;

                    break;
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            IniciarFormulario();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

            string Item = cboSeleccionarVehículo.Text;

            try
            {

                switch (Item)
                {
                    case "Taxi":
                        var taxi = new clsTaxi();

                        taxi.Placa = txtPlaca.Text;
                        taxi.Marca = txtMarca.Text;
                        taxi.Modelo = txtModelo.Text;
                        taxi.Color = txtColor.Text;

                        MessageBox.Show($"Informacion del vehiculo \r\n  \r\n \r\n \r\n Tipo: Taxi \r\n \r\n Placa: {taxi.Placa} \r\n \r\n Marca: {taxi.Marca} \r\n \r\n  Modelo: {taxi.Modelo}  \r\n \r\n Color: {taxi.Color} ");

                        break;

                    case "Buseta":
                        var buseta = new clsBuseta();

                        buseta.Placa = txtPlaca.Text;
                        buseta.Marca = txtMarca.Text;
                        buseta.Modelo = txtModelo.Text;
                        buseta.Color = txtColor.Text;
                        buseta.Potencia = txtPotencia.Text;

                        MessageBox.Show($"Informacion del vehiculo \r\n  \r\n \r\n \r\n Tipo: Buseta \r\n \r\n Placa: {buseta.Placa} \r\n \r\n Marca: {buseta.Marca} \r\n \r\n  Modelo: {buseta.Modelo}  \r\n \r\n Color: {buseta.Color} \r\n \r\n\r\n \r\n Potencia: {buseta.Potencia} HP ");

                        break;

                    case "Particular":
                        var particular = new clsParticular();

                        particular.Placa = txtPlaca.Text;
                        particular.Modelo = txtModelo.Text;
                        particular.Color = txtColor.Text;
                        particular.Potencia = txtPotencia.Text;

                        MessageBox.Show($"Informacion del vehiculo \r\n  \r\n \r\n \r\n Tipo: Particular \r\n \r\n Placa: {particular.Placa}  \r\n \r\n  Modelo: {particular.Modelo}  \r\n \r\n Color: {particular.Color}  \r\n \r\n  Potencia: {particular.Potencia} HP ");




                        break;


                }





            }

            catch (Exception Err)
            {
                //Mensaje de salida si hay algun error 
                MessageBox.Show(Err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            cboSeleccionarVehículo.Items.Add("Taxi");
            cboSeleccionarVehículo.Items.Add("Buseta");
            cboSeleccionarVehículo.Items.Add("Particular");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Realmente desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            e.Cancel = (resultado == DialogResult.No);
        }

    }
      
}
