using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientesGimnasio.Modelos;

public class Cliente
{
	public Cliente()
	{
	}

	public Cliente(int id, string nombre, string apellido, string telefono, DateTime fechaRegistro)
	{
		Id = id;
		Nombre = nombre;
		Apellido = apellido;
		Telefono = telefono;
		FechaRegistro = fechaRegistro;
	}

	public int Id { get; set; }
	public string Nombre { get; set; }
	public string Apellido { get; set; }
	public string Telefono { get; set; }
	public DateTime FechaRegistro { get; set; }

	public override bool Equals(object? obj)
	{
		if (obj is Cliente)
		{
			var nuevo = obj as Cliente;
			if (nuevo.Nombre == this.Nombre && nuevo.Apellido == this.Apellido && nuevo.Telefono == this.Telefono && nuevo.FechaRegistro == this.FechaRegistro)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		return false;
	}

}
