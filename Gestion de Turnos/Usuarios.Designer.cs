namespace Gestion_de_Turnos
{
	partial class Usuarios
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
			this.dgvUsuarios = new System.Windows.Forms.DataGridView();
			this.btnAdd = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbCont = new System.Windows.Forms.RadioButton();
			this.rbTran = new System.Windows.Forms.RadioButton();
			this.txtContra = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnActualizar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvUsuarios
			// 
			this.dgvUsuarios.AllowUserToAddRows = false;
			this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvUsuarios.Location = new System.Drawing.Point(408, 39);
			this.dgvUsuarios.Name = "dgvUsuarios";
			this.dgvUsuarios.RowTemplate.Height = 24;
			this.dgvUsuarios.Size = new System.Drawing.Size(510, 268);
			this.dgvUsuarios.TabIndex = 36;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(38, 341);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(116, 44);
			this.btnAdd.TabIndex = 35;
			this.btnAdd.Text = "Añadir Usuario";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbCont);
			this.groupBox1.Controls.Add(this.rbTran);
			this.groupBox1.Location = new System.Drawing.Point(75, 177);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(300, 130);
			this.groupBox1.TabIndex = 34;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Tipo de Usuario";
			// 
			// rbCont
			// 
			this.rbCont.AutoSize = true;
			this.rbCont.Location = new System.Drawing.Point(130, 78);
			this.rbCont.Name = "rbCont";
			this.rbCont.Size = new System.Drawing.Size(144, 21);
			this.rbCont.TabIndex = 1;
			this.rbCont.TabStop = true;
			this.rbCont.Text = "Control de Acceso";
			this.rbCont.UseVisualStyleBackColor = true;
			// 
			// rbTran
			// 
			this.rbTran.AutoSize = true;
			this.rbTran.Location = new System.Drawing.Point(130, 36);
			this.rbTran.Name = "rbTran";
			this.rbTran.Size = new System.Drawing.Size(118, 21);
			this.rbTran.TabIndex = 0;
			this.rbTran.TabStop = true;
			this.rbTran.Text = "Transaccional";
			this.rbTran.UseVisualStyleBackColor = true;
			// 
			// txtContra
			// 
			this.txtContra.Location = new System.Drawing.Point(190, 132);
			this.txtContra.Name = "txtContra";
			this.txtContra.PasswordChar = '*';
			this.txtContra.Size = new System.Drawing.Size(185, 22);
			this.txtContra.TabIndex = 33;
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(190, 85);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(185, 22);
			this.txtNombre.TabIndex = 32;
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(190, 39);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(185, 22);
			this.txtUsuario.TabIndex = 31;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(103, 135);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 17);
			this.label3.TabIndex = 30;
			this.label3.Text = "Contraseña";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(126, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 17);
			this.label2.TabIndex = 29;
			this.label2.Text = "Nombre";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(53, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(131, 17);
			this.label1.TabIndex = 28;
			this.label1.Text = "Nombre de Usuario";
			// 
			// btnActualizar
			// 
			this.btnActualizar.Location = new System.Drawing.Point(282, 341);
			this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(116, 44);
			this.btnActualizar.TabIndex = 38;
			this.btnActualizar.Text = "Actualizar Cliente";
			this.btnActualizar.UseVisualStyleBackColor = true;
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(160, 341);
			this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(116, 44);
			this.btnEliminar.TabIndex = 37;
			this.btnEliminar.Text = "Eliminar Usuario";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// Usuarios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(970, 416);
			this.Controls.Add(this.btnActualizar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.dgvUsuarios);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.txtContra);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.txtUsuario);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Usuarios";
			this.Text = "Usuarios";
			this.Load += new System.EventHandler(this.Usuarios_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvUsuarios;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rbCont;
		private System.Windows.Forms.RadioButton rbTran;
		private System.Windows.Forms.TextBox txtContra;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnActualizar;
		private System.Windows.Forms.Button btnEliminar;
	}
}