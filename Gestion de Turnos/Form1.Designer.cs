
namespace Gestion_de_Turnos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			this.btnpantalla = new System.Windows.Forms.Button();
			this.btnlista = new System.Windows.Forms.Button();
			this.btncrear = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnClientes = new System.Windows.Forms.Button();
			this.btnUsuarios = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnpantalla
			// 
			this.btnpantalla.BackColor = System.Drawing.Color.Wheat;
			this.btnpantalla.FlatAppearance.BorderSize = 0;
			this.btnpantalla.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod;
			this.btnpantalla.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
			this.btnpantalla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnpantalla.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnpantalla.Location = new System.Drawing.Point(441, 152);
			this.btnpantalla.Name = "btnpantalla";
			this.btnpantalla.Size = new System.Drawing.Size(158, 120);
			this.btnpantalla.TabIndex = 3;
			this.btnpantalla.Text = "Mostrar turnos";
			this.btnpantalla.UseVisualStyleBackColor = false;
			this.btnpantalla.Click += new System.EventHandler(this.btnpantalla_Click);
			// 
			// btnlista
			// 
			this.btnlista.BackColor = System.Drawing.Color.SkyBlue;
			this.btnlista.FlatAppearance.BorderSize = 0;
			this.btnlista.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
			this.btnlista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnlista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnlista.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnlista.Location = new System.Drawing.Point(235, 152);
			this.btnlista.Name = "btnlista";
			this.btnlista.Size = new System.Drawing.Size(158, 120);
			this.btnlista.TabIndex = 4;
			this.btnlista.Text = "Gestionar Tickets";
			this.btnlista.UseVisualStyleBackColor = false;
			this.btnlista.Click += new System.EventHandler(this.btnlista_Click);
			// 
			// btncrear
			// 
			this.btncrear.BackColor = System.Drawing.Color.Gold;
			this.btncrear.FlatAppearance.BorderSize = 0;
			this.btncrear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btncrear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btncrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btncrear.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btncrear.Location = new System.Drawing.Point(30, 152);
			this.btncrear.Name = "btncrear";
			this.btncrear.Size = new System.Drawing.Size(158, 120);
			this.btncrear.TabIndex = 4;
			this.btncrear.Text = "Crear Tickets";
			this.btncrear.UseVisualStyleBackColor = false;
			this.btncrear.Click += new System.EventHandler(this.btncrear_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Gestion_de_Turnos.Properties.Resources.intro_image;
			this.pictureBox1.Location = new System.Drawing.Point(139, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(348, 113);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// btnClientes
			// 
			this.btnClientes.BackColor = System.Drawing.Color.SkyBlue;
			this.btnClientes.FlatAppearance.BorderSize = 0;
			this.btnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
			this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClientes.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClientes.Location = new System.Drawing.Point(129, 296);
			this.btnClientes.Name = "btnClientes";
			this.btnClientes.Size = new System.Drawing.Size(158, 120);
			this.btnClientes.TabIndex = 5;
			this.btnClientes.Text = "Agregar Clientes";
			this.btnClientes.UseVisualStyleBackColor = false;
			this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
			// 
			// btnUsuarios
			// 
			this.btnUsuarios.BackColor = System.Drawing.Color.SkyBlue;
			this.btnUsuarios.FlatAppearance.BorderSize = 0;
			this.btnUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
			this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUsuarios.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUsuarios.Location = new System.Drawing.Point(349, 296);
			this.btnUsuarios.Name = "btnUsuarios";
			this.btnUsuarios.Size = new System.Drawing.Size(158, 120);
			this.btnUsuarios.TabIndex = 6;
			this.btnUsuarios.Text = "Gestionar Usuarios";
			this.btnUsuarios.UseVisualStyleBackColor = false;
			this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(629, 461);
			this.Controls.Add(this.btnUsuarios);
			this.Controls.Add(this.btnClientes);
			this.Controls.Add(this.btncrear);
			this.Controls.Add(this.btnlista);
			this.Controls.Add(this.btnpantalla);
			this.Controls.Add(this.pictureBox1);
			this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sistema de Gestión de Turnos";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnpantalla;
        private System.Windows.Forms.Button btnlista;
        private System.Windows.Forms.Button btncrear;
		private System.Windows.Forms.Button btnClientes;
		private System.Windows.Forms.Button btnUsuarios;
	}
}

