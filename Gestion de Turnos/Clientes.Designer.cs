namespace Gestion_de_Turnos
{
	partial class Clientes
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
			this.dgvClientes = new System.Windows.Forms.DataGridView();
			this.btnAdd = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbMiem = new System.Windows.Forms.RadioButton();
			this.rbPrio = new System.Windows.Forms.RadioButton();
			this.txtApellido = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtDui = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnActualizar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvClientes
			// 
			this.dgvClientes.AllowUserToAddRows = false;
			this.dgvClientes.AllowUserToDeleteRows = false;
			this.dgvClientes.AllowUserToOrderColumns = true;
			this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvClientes.Location = new System.Drawing.Point(422, 29);
			this.dgvClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvClientes.Name = "dgvClientes";
			this.dgvClientes.ReadOnly = true;
			this.dgvClientes.RowTemplate.Height = 24;
			this.dgvClientes.Size = new System.Drawing.Size(509, 268);
			this.dgvClientes.TabIndex = 27;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(26, 328);
			this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(116, 44);
			this.btnAdd.TabIndex = 26;
			this.btnAdd.Text = "Añadir Cliente";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbMiem);
			this.groupBox1.Controls.Add(this.rbPrio);
			this.groupBox1.Location = new System.Drawing.Point(89, 166);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Size = new System.Drawing.Size(300, 130);
			this.groupBox1.TabIndex = 25;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Tipo de Cliente";
			// 
			// rbMiem
			// 
			this.rbMiem.AutoSize = true;
			this.rbMiem.Location = new System.Drawing.Point(131, 78);
			this.rbMiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rbMiem.Name = "rbMiem";
			this.rbMiem.Size = new System.Drawing.Size(83, 21);
			this.rbMiem.TabIndex = 1;
			this.rbMiem.TabStop = true;
			this.rbMiem.Text = "Miembro";
			this.rbMiem.UseVisualStyleBackColor = true;
			// 
			// rbPrio
			// 
			this.rbPrio.AutoSize = true;
			this.rbPrio.Location = new System.Drawing.Point(131, 36);
			this.rbPrio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rbPrio.Name = "rbPrio";
			this.rbPrio.Size = new System.Drawing.Size(90, 21);
			this.rbPrio.TabIndex = 0;
			this.rbPrio.TabStop = true;
			this.rbPrio.Text = "Prioritario";
			this.rbPrio.UseVisualStyleBackColor = true;
			// 
			// txtApellido
			// 
			this.txtApellido.Location = new System.Drawing.Point(203, 121);
			this.txtApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtApellido.Name = "txtApellido";
			this.txtApellido.Size = new System.Drawing.Size(185, 22);
			this.txtApellido.TabIndex = 24;
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(203, 74);
			this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(185, 22);
			this.txtNombre.TabIndex = 23;
			// 
			// txtDui
			// 
			this.txtDui.Location = new System.Drawing.Point(203, 29);
			this.txtDui.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtDui.Name = "txtDui";
			this.txtDui.Size = new System.Drawing.Size(185, 22);
			this.txtDui.TabIndex = 22;
			this.txtDui.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDui_KeyPress);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(139, 125);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 17);
			this.label3.TabIndex = 21;
			this.label3.Text = "Apellido";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(139, 77);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 17);
			this.label2.TabIndex = 20;
			this.label2.Text = "Nombre";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(43, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(154, 17);
			this.label1.TabIndex = 19;
			this.label1.Text = "Número de Documento";
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(161, 328);
			this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(116, 44);
			this.btnEliminar.TabIndex = 28;
			this.btnEliminar.Text = "Eliminar Cliente";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnActualizar
			// 
			this.btnActualizar.Location = new System.Drawing.Point(293, 328);
			this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(116, 44);
			this.btnActualizar.TabIndex = 29;
			this.btnActualizar.Text = "Actualizar Cliente";
			this.btnActualizar.UseVisualStyleBackColor = true;
			// 
			// Clientes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(974, 395);
			this.Controls.Add(this.btnActualizar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.dgvClientes);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.txtApellido);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.txtDui);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Clientes";
			this.Text = "Clientes";
			this.Load += new System.EventHandler(this.Clientes_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvClientes;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rbMiem;
		private System.Windows.Forms.RadioButton rbPrio;
		private System.Windows.Forms.TextBox txtApellido;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtDui;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnActualizar;
	}
}