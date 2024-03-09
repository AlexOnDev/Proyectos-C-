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
	/// Lógica de interacción para ReparacionesWindow.xaml
	/// </summary>
	public partial class ReparacionesWindow : Window
	{
		public ReparacionesWindow()
		{
			InitializeComponent();
			txtMecanico.Text = MainWindow.usuario;
			if (Vehiculo.ListaVehiculos.Count > 0)
			{
				cmbVehiculos.Items.Clear();

				foreach (Vehiculo v in Vehiculo.ListaVehiculos)
				{
					cmbVehiculos.Items.Add(v.Matricula);
				}
			}
		}

		private void txtMecanico_TextChanged(object sender, TextChangedEventArgs e)
		{

		}

		private void cmbVehiculos_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{

		}
	}
}
