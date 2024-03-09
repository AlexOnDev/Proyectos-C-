using System;
using System.Collections.Generic;
using System.Linq;
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
	/// Lógica de interacción para VehiculosWindows.xaml
	/// </summary>
	public partial class VehiculosWindows : Window
	{
		public VehiculosWindows()
		{
			InitializeComponent();

			if(Cliente.listaClientes.Count > 0)
			{
				cmbDNI.Items.Clear();
				foreach (Cliente cliente in Cliente.listaClientes)
				{
					cmbDNI.Items.Add(cliente.DNI);
				}
			}
		
		}

		private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{

		}
		private void LoadVehiculosTable()
		{
			dataGridVehiculos.Items.Clear();

			foreach (Vehiculo vehiculo in Vehiculo.ListaVehiculos)
			{
				dataGridVehiculos.Items.Add(vehiculo);
			}
		}

		private void BtnAgregarVehiculo_Click(object sender, RoutedEventArgs e)
		{
			if (string.IsNullOrEmpty(txtModelo.Text) ||
			string.IsNullOrEmpty(txtMarca.Text) ||
			string.IsNullOrEmpty(txtMatricula.Text))
			{
				// Si algún campo está vacío, mostrar un mensaje de error
				MessageBox.Show("Debe rellenar todos los campos", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
			}
			else
			{
				if (string.IsNullOrEmpty(cmbDNI.Text))
				{
					MessageBox.Show("Crea un cliente primero con el cual enlazar el dni al vehiculo");
				}
				else
				{
					if (!Vehiculo.CompruebaSiExistePorMatricula(txtMatricula.Text))
					{
						Vehiculo.CreaVehiculo(txtModelo.Text, txtMarca.Text, txtMatricula.Text, cmbDNI.Text);
						LoadVehiculosTable();
					}
					else
					{
						MessageBox.Show("Matricula repetida");
					}
				}
			
			}

		}

		private void cmbDNI_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{

		}
	}
}
