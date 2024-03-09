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
	/// Lógica de interacción para Menu.xaml
	/// </summary>
	public partial class Menu : Window
	{
		public Menu()
		{
			InitializeComponent();
		}

		private void ClientesButton_Click(object sender, RoutedEventArgs e)
		{
			// Abrir la ventana de clientes
			ClientesWindows clientesWindow = new ClientesWindows();
			clientesWindow.ShowDialog();
		}

		private void VehiculosButton_Click(object sender, RoutedEventArgs e)
		{
			// Abrir la ventana de vehículos
			VehiculosWindows vehiculosWindow = new VehiculosWindows();
			vehiculosWindow.ShowDialog();
		}

		private void ReparacionesButton_Click(object sender, RoutedEventArgs e)
		{
			// Abrir la ventana de reparaciones
			ReparacionesWindow reparacionesWindow = new ReparacionesWindow();
			reparacionesWindow.ShowDialog();
		}

	}
}
