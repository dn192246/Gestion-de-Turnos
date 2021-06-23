
namespace Gestion_de_Turnos
{
    partial class tickets
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.rbmiembro = new System.Windows.Forms.RadioButton();
			this.rbprioritario = new System.Windows.Forms.RadioButton();
			this.rbnomiembro = new System.Windows.Forms.RadioButton();
			this.btngenerar = new System.Windows.Forms.Button();
			this.dgvTurnos = new System.Windows.Forms.DataGridView();
			this.btnReiniciar = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.rbDUI = new System.Windows.Forms.RadioButton();
			this.mtxtDUI = new System.Windows.Forms.MaskedTextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(30, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(231, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Agregue un turno nuevo";
			// 
			// rbmiembro
			// 
			this.rbmiembro.AutoSize = true;
			this.rbmiembro.Location = new System.Drawing.Point(29, 151);
			this.rbmiembro.Name = "rbmiembro";
			this.rbmiembro.Size = new System.Drawing.Size(241, 25);
			this.rbmiembro.TabIndex = 3;
			this.rbmiembro.TabStop = true;
			this.rbmiembro.Text = "2 - Cliente Miembro - CM";
			this.rbmiembro.UseVisualStyleBackColor = true;
			// 
			// rbprioritario
			// 
			this.rbprioritario.AutoSize = true;
			this.rbprioritario.Location = new System.Drawing.Point(29, 80);
			this.rbprioritario.Name = "rbprioritario";
			this.rbprioritario.Size = new System.Drawing.Size(235, 25);
			this.rbprioritario.TabIndex = 4;
			this.rbprioritario.TabStop = true;
			this.rbprioritario.Text = "1 - Cliente Prioritario - CP";
			this.rbprioritario.UseVisualStyleBackColor = true;
			// 
			// rbnomiembro
			// 
			this.rbnomiembro.AutoSize = true;
			this.rbnomiembro.Location = new System.Drawing.Point(29, 222);
			this.rbnomiembro.Name = "rbnomiembro";
			this.rbnomiembro.Size = new System.Drawing.Size(261, 25);
			this.rbnomiembro.TabIndex = 5;
			this.rbnomiembro.TabStop = true;
			this.rbnomiembro.Text = "3 - Cliente no miembro - CN";
			this.rbnomiembro.UseVisualStyleBackColor = true;
			// 
			// btngenerar
			// 
			this.btngenerar.BackColor = System.Drawing.Color.Black;
			this.btngenerar.FlatAppearance.BorderSize = 0;
			this.btngenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btngenerar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btngenerar.ForeColor = System.Drawing.Color.White;
			this.btngenerar.Location = new System.Drawing.Point(262, 121);
			this.btngenerar.Name = "btngenerar";
			this.btngenerar.Size = new System.Drawing.Size(85, 60);
			this.btngenerar.TabIndex = 6;
			this.btngenerar.Text = "Generar Ticket";
			this.btngenerar.UseVisualStyleBackColor = false;
			this.btngenerar.Click += new System.EventHandler(this.btngenerar_Click);
			// 
			// dgvTurnos
			// 
			this.dgvTurnos.AllowUserToAddRows = false;
			this.dgvTurnos.AllowUserToDeleteRows = false;
			this.dgvTurnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvTurnos.DefaultCellStyle = dataGridViewCellStyle1;
			this.dgvTurnos.EnableHeadersVisualStyles = false;
			this.dgvTurnos.Location = new System.Drawing.Point(369, 13);
			this.dgvTurnos.MultiSelect = false;
			this.dgvTurnos.Name = "dgvTurnos";
			this.dgvTurnos.ReadOnly = true;
			this.dgvTurnos.RowHeadersVisible = false;
			this.dgvTurnos.RowTemplate.Height = 30;
			this.dgvTurnos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dgvTurnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dgvTurnos.Size = new System.Drawing.Size(304, 231);
			this.dgvTurnos.TabIndex = 7;
			// 
			// btnReiniciar
			// 
			this.btnReiniciar.BackColor = System.Drawing.Color.Maroon;
			this.btnReiniciar.FlatAppearance.BorderSize = 0;
			this.btnReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReiniciar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReiniciar.ForeColor = System.Drawing.Color.White;
			this.btnReiniciar.Location = new System.Drawing.Point(444, 250);
			this.btnReiniciar.Name = "btnReiniciar";
			this.btnReiniciar.Size = new System.Drawing.Size(180, 26);
			this.btnReiniciar.TabIndex = 8;
			this.btnReiniciar.Text = "Reiniciar conteo de Tickets";
			this.btnReiniciar.UseVisualStyleBackColor = false;
			this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(285, 39);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 20);
			this.label2.TabIndex = 9;
			this.label2.Text = "Siguiente →";
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 3500;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// rbDUI
			// 
			this.rbDUI.AutoSize = true;
			this.rbDUI.Location = new System.Drawing.Point(29, 284);
			this.rbDUI.Name = "rbDUI";
			this.rbDUI.Size = new System.Drawing.Size(86, 25);
			this.rbDUI.TabIndex = 10;
			this.rbDUI.TabStop = true;
			this.rbDUI.Text = "4 - DUI";
			this.rbDUI.UseVisualStyleBackColor = true;
			// 
			// mtxtDUI
			// 
			this.mtxtDUI.Location = new System.Drawing.Point(121, 284);
			this.mtxtDUI.Mask = "00000000-0";
			this.mtxtDUI.Name = "mtxtDUI";
			this.mtxtDUI.Size = new System.Drawing.Size(100, 27);
			this.mtxtDUI.TabIndex = 11;
			// 
			// tickets
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(685, 344);
			this.Controls.Add(this.mtxtDUI);
			this.Controls.Add(this.rbDUI);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnReiniciar);
			this.Controls.Add(this.dgvTurnos);
			this.Controls.Add(this.btngenerar);
			this.Controls.Add(this.rbnomiembro);
			this.Controls.Add(this.rbprioritario);
			this.Controls.Add(this.rbmiembro);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "tickets";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Creación de Tickets";
			((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbmiembro;
        private System.Windows.Forms.RadioButton rbprioritario;
        private System.Windows.Forms.RadioButton rbnomiembro;
        private System.Windows.Forms.Button btngenerar;
        private System.Windows.Forms.DataGridView dgvTurnos;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.RadioButton rbDUI;
		private System.Windows.Forms.MaskedTextBox mtxtDUI;
	}
}