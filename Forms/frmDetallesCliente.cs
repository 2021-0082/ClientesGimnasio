using ClientesGimnasio.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientesGimnasio.Forms;

public partial class frmDetallesCliente : Form
{
	private Cliente cliente;

	public frmDetallesCliente(Cliente cliente)
	{
		InitializeComponent();
		this.cliente = cliente;
	}

	private void frmDetallesCliente_Load(object sender, EventArgs e)
	{
		txtNombre.Text = cliente.Nombre;
		txtApellido.Text = cliente.Apellido;
		txtTelefono.Text = cliente.Telefono;
		dtpFecha.Value = cliente.FechaRegistro;
	}

	private void btnVolver_Click(object sender, EventArgs e)
	{
		this.irClientes();
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


}
