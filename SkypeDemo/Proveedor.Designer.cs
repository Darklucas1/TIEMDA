namespace SkypeDemo
{
    partial class Proveedor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txthora = new System.Windows.Forms.DateTimePicker();
            this.txtfecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.txttel = new System.Windows.Forms.TextBox();
            this.txtcita = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnnuevo);
            this.groupBox1.Controls.Add(this.txtcod);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txthora);
            this.groupBox1.Controls.Add(this.txtfecha);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btneliminar);
            this.groupBox1.Controls.Add(this.btnmodificar);
            this.groupBox1.Controls.Add(this.btnregistrar);
            this.groupBox1.Controls.Add(this.txttel);
            this.groupBox1.Controls.Add(this.txtcita);
            this.groupBox1.Controls.Add(this.txtnom);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(762, 214);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnnuevo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnnuevo.ForeColor = System.Drawing.Color.White;
            this.btnnuevo.Location = new System.Drawing.Point(76, 163);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(138, 43);
            this.btnnuevo.TabIndex = 18;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = false;
            // 
            // txtcod
            // 
            this.txtcod.Enabled = false;
            this.txtcod.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcod.Location = new System.Drawing.Point(465, 29);
            this.txtcod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(154, 37);
            this.txtcod.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(415, 35);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "NIT:";
            // 
            // txthora
            // 
            this.txthora.CustomFormat = "hh:mm:ss tt";
            this.txthora.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txthora.Location = new System.Drawing.Point(465, 118);
            this.txthora.Name = "txthora";
            this.txthora.ShowUpDown = true;
            this.txthora.Size = new System.Drawing.Size(154, 37);
            this.txthora.TabIndex = 15;
            // 
            // txtfecha
            // 
            this.txtfecha.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfecha.Location = new System.Drawing.Point(465, 73);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(154, 37);
            this.txtfecha.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(396, 121);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Hora:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(390, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fecha:";
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.Red;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btneliminar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btneliminar.ForeColor = System.Drawing.Color.White;
            this.btneliminar.Location = new System.Drawing.Point(505, 163);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(138, 43);
            this.btneliminar.TabIndex = 8;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = false;
            // 
            // btnmodificar
            // 
            this.btnmodificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnmodificar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnmodificar.ForeColor = System.Drawing.Color.White;
            this.btnmodificar.Location = new System.Drawing.Point(362, 163);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(138, 43);
            this.btnmodificar.TabIndex = 7;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = false;
            // 
            // btnregistrar
            // 
            this.btnregistrar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnregistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnregistrar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnregistrar.ForeColor = System.Drawing.Color.White;
            this.btnregistrar.Location = new System.Drawing.Point(218, 163);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(138, 43);
            this.btnregistrar.TabIndex = 6;
            this.btnregistrar.Text = "Registrar";
            this.btnregistrar.UseVisualStyleBackColor = false;
            // 
            // txttel
            // 
            this.txttel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttel.Location = new System.Drawing.Point(189, 118);
            this.txttel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(178, 37);
            this.txttel.TabIndex = 5;
            // 
            // txtcita
            // 
            this.txtcita.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtcita.Location = new System.Drawing.Point(189, 75);
            this.txtcita.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcita.Name = "txtcita";
            this.txtcita.Size = new System.Drawing.Size(178, 37);
            this.txtcita.TabIndex = 4;
            // 
            // txtnom
            // 
            this.txtnom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnom.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtnom.Location = new System.Drawing.Point(189, 32);
            this.txtnom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(178, 37);
            this.txtnom.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(64, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Teléfono:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(62, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dirección:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre y Apellidos:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 236);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(762, 274);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 50;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(4, 18);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(754, 251);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "NIT";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Dirección";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Teléfono";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Fecha";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Hora";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "Proveedor";
            this.Size = new System.Drawing.Size(762, 510);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker txthora;
        private System.Windows.Forms.DateTimePicker txtfecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.TextBox txtcita;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
