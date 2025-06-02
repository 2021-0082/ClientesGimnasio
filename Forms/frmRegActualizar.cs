using ClientesGimnasio.Modelos;
using ClientesGimnasio.Servicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClientesGimnasio.Forms;

public partial class frmRegActualizar : Form
{
	private Cliente? cliente = null;
	private BindingList<Cliente> allClientes;

	

	public frmRegActualizar(Cliente? cliente = null)
	{
		InitializeComponent();
		this.cliente = cliente;
		this.allClientes = ClientesServicios.clientes;
	}
	private void frmRegActualizar_Load(object sender, EventArgs e)
	{

		lblAccion.Text = cliente != null ? "Actualizar" : "Agregar";
		btnAccion.Text = cliente != null ? "Actualizar" : "Agregar";
		if (cliente != null)
		{
			txtNombre.Text = cliente.Nombre;
			txtApellido.Text = cliente.Apellido;
			txtTelefono.Text = cliente.Telefono;
			dtpFecha.Value = cliente.FechaRegistro;
		}
	}


	#region menu

	private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
	{
		this.Hide();
		new frmPrincipal().Show();
	}

	private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
	{
		this.irClientes();
	}

	private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
	{

		this.Hide();
		new frmRegActualizar().Show();
	}

	private void salirToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Application.Exit();
	}

	private void irClientes()
	{
		this.Hide();
		new frmClientes().Show();
	}
	#endregion


	private void btnAgregar_Click(object sender, EventArgs e)
	{
		if (txtNombre.Text.Length > 0 && txtApellido.Text.Length > 0 && txtTelefono.Text.Length > 0)
		{
			if (cliente == null)
			{
				var agregar = new Cliente()
				{
					Id = allClientes.Count + 1,
					Nombre = txtNombre.Text,
					Apellido = txtApellido.Text,
					Telefono = txtTelefono.Text,
					FechaRegistro = dtpFecha.Value
				};
				ClientesServicios.Agregar(agregar);
				//allClientes.Add(agregar);
				MessageBox.Show("Cliente Agregado");
				this.irClientes();

			}
			else
			{
				var nuevo = new Cliente()
				{
					Id = cliente.Id,
					Nombre = txtNombre.Text,
					Apellido = txtApellido.Text,
					Telefono = txtTelefono.Text,
					FechaRegistro = dtpFecha.Value
				};
				if (cliente.Equals(nuevo))
				{
					MessageBox.Show("No has cambiado nada");
				}
				else
				{
					ClientesServicios.Actualiza(cliente.Id, nuevo);
					//cliente = nuevo;
					MessageBox.Show("Cliente Actualizado");
					this.irClientes();
				}
			}
		}
		else
		{
			MessageBox.Show("Debes completar todos los campos", "Faltan Valores", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}
	}
}
