namespace ClientesGimnasio.Forms
{
	partial class frmDetallesCliente
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
			dtpFecha = new DateTimePicker();
			label4 = new Label();
			txtTelefono = new TextBox();
			label3 = new Label();
			txtApellido = new TextBox();
			label2 = new Label();
			txtNombre = new TextBox();
			label1 = new Label();
			btnVolver = new Button();
			menuStrip1 = new MenuStrip();
			inicioToolStripMenuItem = new ToolStripMenuItem();
			clientesToolStripMenuItem = new ToolStripMenuItem();
			registrarToolStripMenuItem = new ToolStripMenuItem();
			salirToolStripMenuItem = new ToolStripMenuItem();
			label5 = new Label();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// dtpFecha
			// 
			dtpFecha.Location = new Point(437, 214);
			dtpFecha.Name = "dtpFecha";
			dtpFecha.Size = new Size(250, 27);
			dtpFecha.TabIndex = 21;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(437, 185);
			label4.Name = "label4";
			label4.Size = new Size(106, 20);
			label4.TabIndex = 20;
			label4.Text = "Fecha Registro";
			// 
			// txtTelefono
			// 
			txtTelefono.Location = new Point(217, 214);
			txtTelefono.Name = "txtTelefono";
			txtTelefono.PlaceholderText = "Telefono";
			txtTelefono.Size = new Size(134, 27);
			txtTelefono.TabIndex = 19;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(217, 185);
			label3.Name = "label3";
			label3.Size = new Size(67, 20);
			label3.TabIndex = 18;
			label3.Text = "Telefono";
			// 
			// txtApellido
			// 
			txtApellido.Location = new Point(446, 136);
			txtApellido.Name = "txtApellido";
			txtApellido.PlaceholderText = "Apellido";
			txtApellido.Size = new Size(134, 27);
			txtApellido.TabIndex = 17;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(446, 107);
			label2.Name = "label2";
			label2.Size = new Size(66, 20);
			label2.TabIndex = 16;
			label2.Text = "Apellido";
			// 
			// txtNombre
			// 
			txtNombre.Location = new Point(220, 136);
			txtNombre.Name = "txtNombre";
			txtNombre.PlaceholderText = "Nombre";
			txtNombre.Size = new Size(134, 27);
			txtNombre.TabIndex = 15;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(220, 107);
			label1.Name = "label1";
			label1.Size = new Size(64, 20);
			label1.TabIndex = 14;
			label1.Text = "Nombre";
			// 
			// btnVolver
			// 
			btnVolver.Location = new Point(283, 325);
			btnVolver.Name = "btnVolver";
			btnVolver.Size = new Size(229, 50);
			btnVolver.TabIndex = 22;
			btnVolver.Text = "Volver";
			btnVolver.UseVisualStyleBackColor = true;
			btnVolver.Click += btnVolver_Click;
			// 
			// menuStrip1
			// 
			menuStrip1.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			menuStrip1.ImageScalingSize = new Size(20, 20);
			menuStrip1.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, clientesToolStripMenuItem, registrarToolStripMenuItem, salirToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Padding = new Padding(14, 4, 0, 4);
			menuStrip1.Size = new Size(800, 38);
			menuStrip1.TabIndex = 23;
			menuStrip1.Text = "menuStrip1";
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
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Sylfaen", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label5.Location = new Point(287, 49);
			label5.Name = "label5";
			label5.Size = new Size(247, 44);
			label5.TabIndex = 24;
			label5.Text = "Detalles Cliente";
			// 
			// frmDetallesCliente
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(label5);
			Controls.Add(menuStrip1);
			Controls.Add(btnVolver);
			Controls.Add(dtpFecha);
			Controls.Add(label4);
			Controls.Add(txtTelefono);
			Controls.Add(label3);
			Controls.Add(txtApellido);
			Controls.Add(label2);
			Controls.Add(txtNombre);
			Controls.Add(label1);
			Name = "frmDetallesCliente";
			Text = "Detalles Cliente";
			Load += frmDetallesCliente_Load;
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DateTimePicker dtpFecha;
		private Label label4;
		private TextBox txtTelefono;
		private Label label3;
		private TextBox txtApellido;
		private Label label2;
		private TextBox txtNombre;
		private Label label1;
		private Button btnVolver;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem inicioToolStripMenuItem;
		private ToolStripMenuItem clientesToolStripMenuItem;
		private ToolStripMenuItem registrarToolStripMenuItem;
		private ToolStripMenuItem salirToolStripMenuItem;
		private Label label5;
	}
}