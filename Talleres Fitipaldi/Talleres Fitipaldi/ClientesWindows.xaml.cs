using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Talleres_Fitipaldi
{
	/// <summary>
	/// Lógica de interacción para ClientesWindows.xaml
	/// </summary>
	public partial class ClientesWindows : Window
	{
		public ClientesWindows()
		{
			InitializeComponent();
			LoadClientesComboBox();
		}
		private void LoadClientesComboBox()
		{
			cmbClientes.Items.Clear();

			foreach (Cliente cliente in Cliente.listaClientes)
			{
				cmbClientes.Items.Add(cliente.DNI);
			}
		}
		private bool CamposLlenos()
		{
			if (string.IsNullOrEmpty(txtNombre.Text))
				return false;
			if (string.IsNullOrEmpty(txtApellidos.Text))
				return false;
			if (string.IsNullOrEmpty(txtEdad.Text))
				return false;
			if (string.IsNullOrEmpty(txtTelefono.Text))
				return false;
			if (string.IsNullOrEmpty(txtDNI.Text))
				return false;
			return true;
		}
		private void LimpiarText()
		{
			txtNombre.Text = "";
			txtApellidos.Text = "";
			txtEdad.Text = "";
			txtTelefono.Text = "";
			txtDNI.Text = "";
		}



		private void btnAnadirCliente_Click(object sender, RoutedEventArgs e)
		{
			if (CamposLlenos())
			{

				Cliente c = new Cliente(txtNombre.Text, txtApellidos.Text, int.Parse(txtEdad.Text), txtTelefono.Text, txtDNI.Text);
				Cliente.AgregarCliente(c);
				LoadClientesComboBox();
				LimpiarText();
			}
			else
			{
				MessageBox.Show("Rellene todos los campos");
			}
			
		}

		private void btnModificarCliente_Click(object sender, RoutedEventArgs e)
		{
			if (CamposLlenos() && Cliente.ComprobarSiExistePorDni(txtDNI.Text))
			{
				Cliente c = new Cliente(txtNombre.Text, txtApellidos.Text, int.Parse(txtEdad.Text), txtTelefono.Text, txtDNI.Text);
				Cliente.ActualizarCliente(txtDNI.Text,c);
				LoadClientesComboBox();
				LimpiarText();
			}
			else
			{
				MessageBox.Show("No se puede actualizar porque faltan campos por rellenar o el DNI es incorrecto");
			}
		}

		private void btnBorrarCliente_Click(object sender, RoutedEventArgs e)
		{
			if (!string.IsNullOrEmpty(txtDNI.Text) && Cliente.ComprobarSiExistePorDni(txtDNI.Text))
			{
				Cliente.EliminarCliente(txtDNI.Text);
				LoadClientesComboBox();
				LimpiarText();
			}
			else
			{
				MessageBox.Show("No se puede eliminar porque el DNI es incorrecto");

			}
		}

		private void cmbClientes_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (cmbClientes.SelectedItem != null)
			{
				
				Cliente clienteSeleccionado = Cliente.EncuentraCliente((String)cmbClientes.SelectedItem);
				txtDNI.Text = clienteSeleccionado.DNI;
				txtNombre.Text = clienteSeleccionado.Nombre;
				txtApellidos.Text = clienteSeleccionado.Apellidos;
				txtEdad.Text = clienteSeleccionado.Edad.ToString();
				txtTelefono.Text = clienteSeleccionado.Telefono;
			}
		}


		private void txtDNI_TextChanged(object sender, TextChangedEventArgs e)
		{

		}
	}
}
