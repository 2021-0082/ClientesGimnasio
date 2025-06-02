using ClientesGimnasio.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientesGimnasio.Servicio;

public static class ClientesServicios
{
	public static BindingList<Cliente> clientes = new BindingList<Cliente>();

	public static void Agregar(Cliente cliente){
		clientes.Add(cliente);
	}
	public static void Actualiza(int id, Cliente nuevo){
	 
		var viejo = clientes.First(c => c.Id == id);
		viejo.Nombre = nuevo.Nombre;
		viejo.Apellido = nuevo.Apellido;
		viejo.Telefono = nuevo.Telefono;
		viejo.FechaRegistro = nuevo.FechaRegistro;
	}
	public static void Eliminar(Cliente cliente){
		clientes.Remove(cliente);
		MessageBox.Show("Cliente Eliminado");
	}


}
