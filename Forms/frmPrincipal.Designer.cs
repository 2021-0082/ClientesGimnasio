namespace ClientesGimnasio.Forms
{
	partial class frmPrincipal
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
			label1 = new Label();
			menuStrip1 = new MenuStrip();
			inicioToolStripMenuItem = new ToolStripMenuItem();
			clientesToolStripMenuItem = new ToolStripMenuItem();
			salirToolStripMenuItem = new ToolStripMenuItem();
			registrarToolStripMenuItem = new ToolStripMenuItem();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.None;
			label1.AutoSize = true;
			label1.Font = new Font("Sylfaen", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.Location = new Point(8, 195);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(779, 66);
			label1.TabIndex = 1;
			label1.Text = "Bienvenido al manejador de clientes";
			label1.TextAlign = ContentAlignment.MiddleCenter;
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
			// salirToolStripMenuItem
			// 
			salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			salirToolStripMenuItem.Size = new Size(66, 30);
			salirToolStripMenuItem.Text = "Salir";
			salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
			// 
			// registrarToolStripMenuItem
			// 
			registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
			registrarToolStripMenuItem.Size = new Size(104, 30);
			registrarToolStripMenuItem.Text = "Registrar";
			registrarToolStripMenuItem.Click += registrarToolStripMenuItem_Click_1;
			// 
			// frmPrincipal
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(menuStrip1);
			Controls.Add(label1);
			Name = "frmPrincipal";
			Text = "frmPrincipal";
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem inicioToolStripMenuItem;
		private ToolStripMenuItem clientesToolStripMenuItem;
		private ToolStripMenuItem salirToolStripMenuItem;
		private ToolStripMenuItem registrarToolStripMenuItem;
	}
}