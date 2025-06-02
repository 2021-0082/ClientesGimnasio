namespace ClientesGimnasio.Forms
{
	partial class frmRegActualizar
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
			menuStrip1 = new MenuStrip();
			inicioToolStripMenuItem = new ToolStripMenuItem();
			clientesToolStripMenuItem = new ToolStripMenuItem();
			registrarToolStripMenuItem = new ToolStripMenuItem();
			salirToolStripMenuItem = new ToolStripMenuItem();
			lblAccion = new Label();
			label1 = new Label();
			txtNombre = new TextBox();
			txtApellido = new TextBox();
			label2 = new Label();
			txtTelefono = new TextBox();
			label3 = new Label();
			label4 = new Label();
			dtpFecha = new DateTimePicker();
			btnAccion = new Button();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			menuStrip1.ImageScalingSize = new Size(20, 20);
			menuStrip1.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, clientesToolStripMenuItem, registrarToolStripMenuItem, salirToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Padding = new Padding(14, 4, 0, 4);
			menuStrip1.Size = new Size(1200, 38);
			menuStrip1.TabIndex = 4;
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
			// lblAccion
			// 
			lblAccion.AutoSize = true;
			lblAccion.Location = new Point(526, 48);
			lblAccion.Margin = new Padding(4, 0, 4, 0);
			lblAccion.Name = "lblAccion";
			lblAccion.Size = new Size(148, 26);
			lblAccion.TabIndex = 5;
			lblAccion.Text = "Agregar Cliente";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(57, 100);
			label1.Name = "label1";
			label1.Size = new Size(83, 26);
			label1.TabIndex = 6;
			label1.Text = "Nombre";
			// 
			// txtNombre
			// 
			txtNombre.Location = new Point(57, 129);
			txtNombre.Name = "txtNombre";
			txtNombre.PlaceholderText = "Nombre";
			txtNombre.Size = new Size(134, 34);
			txtNombre.TabIndex = 7;
			// 
			// txtApellido
			// 
			txtApellido.Location = new Point(283, 129);
			txtApellido.Name = "txtApellido";
			txtApellido.PlaceholderText = "Apellido";
			txtApellido.Size = new Size(134, 34);
			txtApellido.TabIndex = 9;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(283, 100);
			label2.Name = "label2";
			label2.Size = new Size(85, 26);
			label2.TabIndex = 8;
			label2.Text = "Apellido";
			// 
			// txtTelefono
			// 
			txtTelefono.Location = new Point(502, 129);
			txtTelefono.Name = "txtTelefono";
			txtTelefono.PlaceholderText = "Telefono";
			txtTelefono.Size = new Size(134, 34);
			txtTelefono.TabIndex = 11;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(502, 100);
			label3.Name = "label3";
			label3.Size = new Size(86, 26);
			label3.TabIndex = 10;
			label3.Text = "Telefono";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(722, 100);
			label4.Name = "label4";
			label4.Size = new Size(138, 26);
			label4.TabIndex = 12;
			label4.Text = "Fecha Registro";
			// 
			// dtpFecha
			// 
			dtpFecha.Location = new Point(722, 129);
			dtpFecha.Name = "dtpFecha";
			dtpFecha.Size = new Size(250, 34);
			dtpFecha.TabIndex = 13;
			// 
			// btnAccion
			// 
			btnAccion.Location = new Point(359, 244);
			btnAccion.Name = "btnAccion";
			btnAccion.Size = new Size(229, 78);
			btnAccion.TabIndex = 14;
			btnAccion.Text = "Agregar";
			btnAccion.UseVisualStyleBackColor = true;
			btnAccion.Click += btnAgregar_Click;
			// 
			// frmRegActualizar
			// 
			AutoScaleDimensions = new SizeF(12F, 26F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1200, 585);
			Controls.Add(btnAccion);
			Controls.Add(dtpFecha);
			Controls.Add(label4);
			Controls.Add(txtTelefono);
			Controls.Add(label3);
			Controls.Add(txtApellido);
			Controls.Add(label2);
			Controls.Add(txtNombre);
			Controls.Add(label1);
			Controls.Add(lblAccion);
			Controls.Add(menuStrip1);
			Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Margin = new Padding(4);
			Name = "frmRegActualizar";
			Load += frmRegActualizar_Load;
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem inicioToolStripMenuItem;
		private ToolStripMenuItem clientesToolStripMenuItem;
		private ToolStripMenuItem registrarToolStripMenuItem;
		private ToolStripMenuItem salirToolStripMenuItem;
		private Label lblAccion;
		private Label label1;
		private TextBox txtNombre;
		private TextBox txtApellido;
		private Label label2;
		private TextBox txtTelefono;
		private Label label3;
		private Label label4;
		private DateTimePicker dtpFecha;
		private Button btnAccion;
	}
}