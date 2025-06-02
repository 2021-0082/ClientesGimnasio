using ClientesGimnasio.Modelos;
using ClientesGimnasio.Servicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientesGimnasio.Forms;

public partial class frmClientes : Form
{

	BindingList<Cliente> allClientes = new BindingList<Cliente>();
	BindingList<Cliente> filtrados = new BindingList<Cliente>();

	public frmClientes()
	{
		InitializeComponent();
		this.cargarClientes();
	}
	private void cargarClientes()
	{
		allClientes = ClientesServicios.clientes;
		filtrados = allClientes;
		dgvClientes.DataSource = filtrados;
	}
	// Evento de filtrado 
	private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (txtFilter.Text.Length > 0)
		{
			filtrados = new BindingList<Cliente>(allClientes.Where(c => c.Nombre.Contains(txtFilter.Text) || c.Apellido.Contains(txtFilter.Text)).ToList());
		}
		else
		{
			filtrados = allClientes;
		}
	}


	#region MENU	

	private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
	{
		this.Hide();
		new frmPrincipal().Show();
	}

	private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
	{
		this.Hide();
		new frmClientes().Show();
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

	private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
	{

	}
	#endregion

	private void txtFilter_TextChanged(object sender, EventArgs e)
	{
		if (txtFilter.Text.Length > 0)
		{
			filtrados = new BindingList<Cliente>(allClientes.Where(c => c.Nombre.Contains(txtFilter.Text) || c.Apellido.Contains(txtFilter.Text)).ToList());
		}
		else
		{
			filtrados = allClientes;
		}
		dgvClientes.DataSource = filtrados;
	}

	private void btnEliminar_Click(object sender, EventArgs e)
	{
		if (dgvClientes.SelectedRows.Count > 0)
		{
			var cliente = (Cliente)dgvClientes.SelectedRows[0].DataBoundItem;
			ClientesServicios.Eliminar(cliente);
		}
		else
		{
			MessageBox.Show("Selecciona el cliente que deseas eliminar", "Selecciona el cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	private void btnActualizar_Click(object sender, EventArgs e)
	{
		if (dgvClientes.SelectedRows.Count > 0)
		{
			var cliente = (Cliente)dgvClientes.SelectedRows[0].DataBoundItem;
			this.Hide();
			new frmRegActualizar(cliente).Show();
		}
		else
		{
			MessageBox.Show("Selecciona el cliente que deseas Actualizar", "Selecciona el cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		if (dgvClientes.SelectedRows.Count > 0)
		{
			var cliente = (Cliente)dgvClientes.SelectedRows[0].DataBoundItem;
			this.Hide();
			new frmDetallesCliente(cliente).Show();
		}
	}
}
