namespace ClientesGimnasio.Forms
{
	partial class frmClientes
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			dgvClientes = new DataGridView();
			panel1 = new Panel();
			txtFilter = new TextBox();
			menuStrip1 = new MenuStrip();
			inicioToolStripMenuItem = new ToolStripMenuItem();
			clientesToolStripMenuItem = new ToolStripMenuItem();
			registrarToolStripMenuItem = new ToolStripMenuItem();
			salirToolStripMenuItem = new ToolStripMenuItem();
			btnEliminar = new Button();
			btnActualizar = new Button();
			((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
			panel1.SuspendLayout();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// dgvClientes
			// 
			dgvClientes.AllowUserToAddRows = false;
			dgvClientes.AllowUserToDeleteRows = false;
			dgvClientes.AllowUserToOrderColumns = true;
			dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvClientes.Dock = DockStyle.Fill;
			dgvClientes.Location = new Point(0, 0);
			dgvClientes.Name = "dgvClientes";
			dgvClientes.RowHeadersWidth = 51;
			dgvClientes.Size = new Size(680, 255);
			dgvClientes.TabIndex = 0;
			dgvClientes.CellDoubleClick += dgvClientes_CellDoubleClick;
			// 
			// panel1
			// 
			panel1.Controls.Add(dgvClientes);
			panel1.Location = new Point(59, 103);
			panel1.Name = "panel1";
			panel1.Size = new Size(680, 255);
			panel1.TabIndex = 1;
			// 
			// txtFilter
			// 
			txtFilter.Location = new Point(59, 46);
			txtFilter.Name = "txtFilter";
			txtFilter.PlaceholderText = "Filtrar por Nombre";
			txtFilter.Size = new Size(243, 27);
			txtFilter.TabIndex = 2;
			txtFilter.TextChanged += txtFilter_TextChanged;
			txtFilter.KeyPress += txtFilter_KeyPress;
			// 
			// menuStrip1
			// 
			menuStrip1.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			menuStrip1.ImageScalingSize = new Size(20, 20);
			menuStrip1.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, clientesToolStripMenuItem, registrarToolStripMenuItem, salirToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Padding = new Padding(9, 3, 0, 3);
			menuStrip1.Size = new Size(800, 36);
			menuStrip1.TabIndex = 3;
			menuStrip1.Text = "menuStrip1";
			menuStrip1.ItemClicked += menuStrip1_ItemClicked;
			// 
			// inicioToolStripMenuItem
			// 
			inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
			inicioToolStripMenuItem.Size = new Size(77, 30);
			inicioToolStripMenuItem.Text = "Inicio";
			inicioToolStripMenuItem.Click += inicioToolStripMenuItem_Click;
			// 
			// clientesToolStripMenuItem
			// 
			clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
			clientesToolStripMenuItem.Size = new Size(95, 30);
			clientesToolStripMenuItem.Text = "Clientes";
			clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
			// 
			// registrarToolStripMenuItem
			// 
			registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
			registrarToolStripMenuItem.Size = new Size(104, 30);
			registrarToolStripMenuItem.Text = "Registrar";
			registrarToolStripMenuItem.Click += registrarToolStripMenuItem_Click;
			// 
			// salirToolStripMenuItem
			// 
			salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			salirToolStripMenuItem.Size = new Size(66, 30);
			salirToolStripMenuItem.Text = "Salir";
			salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
			// 
			// btnEliminar
			// 
			btnEliminar.BackColor = Color.IndianRed;
			btnEliminar.Location = new Point(582, 34);
			btnEliminar.Name = "btnEliminar";
			btnEliminar.Size = new Size(119, 51);
			btnEliminar.TabIndex = 4;
			btnEliminar.Text = "Eliminar";
			btnEliminar.UseVisualStyleBackColor = false;
			btnEliminar.Click += btnEliminar_Click;
			// 
			// btnActualizar
			// 
			btnActualizar.BackColor = Color.ForestGreen;
			btnActualizar.Location = new Point(457, 34);
			btnActualizar.Name = "btnActualizar";
			btnActualizar.Size = new Size(119, 51);
			btnActualizar.TabIndex = 5;
			btnActualizar.Text = "Actualizar";
			btnActualizar.UseVisualStyleBackColor = false;
			btnActualizar.Click += btnActualizar_Click;
			// 
			// frmClientes
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btnActualizar);
			Controls.Add(btnEliminar);
			Controls.Add(menuStrip1);
			Controls.Add(txtFilter);
			Controls.Add(panel1);
			Name = "frmClientes";
			Text = "frmClientes";
			((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
			panel1.ResumeLayout(false);
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dgvClientes;
		private Panel panel1;
		private TextBox txtFilter;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem inicioToolStripMenuItem;
		private ToolStripMenuItem clientesToolStripMenuItem;
		private ToolStripMenuItem registrarToolStripMenuItem;
		private ToolStripMenuItem salirToolStripMenuItem;
		private Button btnEliminar;
		private Button btnActualizar;
	}
}