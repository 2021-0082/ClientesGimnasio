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

public partial class frmPrincipal : Form
{
	public frmPrincipal()
	{
		InitializeComponent();
	}


	private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
	{
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

	private void registrarToolStripMenuItem_Click_1(object sender, EventArgs e)
	{
		this.Hide();
		new frmRegActualizar().Show();
	}
}
