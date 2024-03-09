using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Talleres_Fitipaldi
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public static string usuario="";
		public MainWindow()
		{
			InitializeComponent();
		}

		private void LogInButton_Click(object sender, RoutedEventArgs e)
		{
			// Validar los datos ingresados por el usuario
			string username = UsernameTextBox.Text;
			string password = PasswordTextBox.Password;

			if ((username == "pepe" && password == "pepe") || (username == "maria" && password == "maria"))
			{
				// Si los datos son correctos, abrir la ventana principal de la aplicación
				Menu mainWindow = new Menu();
				mainWindow.Show();
				usuario = username;
				// Cerrar la ventana de login
				this.Close();
			}
			else
			{
				// Si los datos son incorrectos, mostrar un mensaje de error
				MessageBox.Show("Incorrect username or password.");
			}
		}
	}
}
