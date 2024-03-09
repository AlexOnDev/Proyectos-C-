using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talleres_Fitipaldi
{
	public class Vehiculo
	{
		public string Modelo { get; set; }
		public string Marca { get; set; }
		public string Matricula { get; set; }
		public string Dni { get; set; }

		public static ObservableCollection<Vehiculo> ListaVehiculos { get; set; } = new ObservableCollection<Vehiculo>();

		public static bool CompruebaSiExistePorMatricula(string matricula)
		{
			return ListaVehiculos.Any(v => v.Matricula == matricula);
		}

		public static void CreaVehiculo(string modelo, string marca, string matricula, string dni)
		{
			ListaVehiculos.Add(new Vehiculo { Modelo = modelo, Marca = marca, Matricula = matricula, Dni = dni });
		}

		public static void ActualizaVehiculo(string matricula, string nuevoModelo, string nuevaMarca, string nuevoDni)
		{
			var vehiculo = ListaVehiculos.FirstOrDefault(v => v.Matricula == matricula);

			if (vehiculo != null)
			{
				vehiculo.Modelo = nuevoModelo;
				vehiculo.Marca = nuevaMarca;
				vehiculo.Dni = nuevoDni;
			}
		}

		public static void BorraVehiculo(string matricula)
		{
			var vehiculo = ListaVehiculos.FirstOrDefault(v => v.Matricula == matricula);

			if (vehiculo != null)
			{
				ListaVehiculos.Remove(vehiculo);
			}
		}
	}

}
