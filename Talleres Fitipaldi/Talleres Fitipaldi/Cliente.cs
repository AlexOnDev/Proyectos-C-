using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talleres_Fitipaldi
{
	using System.Collections.ObjectModel;
	using System.Windows;

	public class Cliente
	{
		public string Nombre { get; set; }
		public string Apellidos { get; set; }
		public int Edad { get; set; }
		public string Telefono { get; set; }
		public string DNI { get; set; }

		public Cliente(string nombre, string apellidos, int edad, string telefono, string dni)
		{
			Nombre = nombre;
			Apellidos = apellidos;
			Edad = edad;
			Telefono = telefono;
			DNI = dni;
		}

		public override string ToString()
		{
			return Nombre + " " + Apellidos;
		}

		public static ObservableCollection<Cliente> listaClientes = new ObservableCollection<Cliente>();

		public static bool ComprobarSiExistePorDni(string dni)
		{
			foreach (Cliente cliente in listaClientes)
			{
				if (cliente.DNI == dni)
				{
					return true;
				}
			}

			return false;
		}

		public static Cliente EncuentraCliente(string dni)
		{
			foreach (Cliente cliente in listaClientes)
			{
				if (cliente.DNI == dni)
				{
					return cliente;
				}
			}

			return null;
		}
		public static void AgregarCliente(Cliente cliente)
		{
			if (!ComprobarSiExistePorDni(cliente.DNI))
			{
				listaClientes.Add(cliente);
			}
			else
			{
				MessageBox.Show("Ya existe un cliente con ese DNI");
			}
		}

		public static void ActualizarCliente(string dni, Cliente clienteActualizado)
		{
			foreach (Cliente cliente in listaClientes)
			{
				if (cliente.DNI == dni)
				{
					cliente.Nombre = clienteActualizado.Nombre;
					cliente.Apellidos = clienteActualizado.Apellidos;
					cliente.Edad = clienteActualizado.Edad;
					cliente.Telefono = clienteActualizado.Telefono;
					break;
				}
			}
		}

		public static void EliminarCliente(string dni)
		{
			foreach (Cliente cliente in listaClientes)
			{
				if (cliente.DNI == dni)
				{
					listaClientes.Remove(cliente);
					break;
				}
			}
		}

	}

}
