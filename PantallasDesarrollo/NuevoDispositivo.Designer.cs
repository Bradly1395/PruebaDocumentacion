namespace PantallasDesarrollo
{
    partial class NuevoDispositivo
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
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.idcliente = new System.Windows.Forms.TextBox();
            this.desc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.diag = new System.Windows.Forms.TextBox();
            this.fecha = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.nomcliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.dgvMostrarItem = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.registro = new System.Windows.Forms.TextBox();
            this.iddis = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.modeloTest = new System.Windows.Forms.TextBox();
            this.TipoTest = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarItem)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.OrangeRed;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(572, 272);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 42);
            this.button3.TabIndex = 43;
            this.button3.Text = "Volver";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(9, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "TIPO DISPOSITIVO";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.YellowGreen;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.Location = new System.Drawing.Point(439, 272);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 42);
            this.button8.TabIndex = 37;
            this.button8.Text = "GUARDAR";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(183, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "DIAGNOSTICO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(183, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "DESCRIPCION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "ID CLIENTE";
            // 
            // idcliente
            // 
            this.idcliente.BackColor = System.Drawing.SystemColors.MenuText;
            this.idcliente.Enabled = false;
            this.idcliente.ForeColor = System.Drawing.SystemColors.Info;
            this.idcliente.Location = new System.Drawing.Point(12, 25);
            this.idcliente.Name = "idcliente";
            this.idcliente.Size = new System.Drawing.Size(79, 20);
            this.idcliente.TabIndex = 55;
            // 
            // desc
            // 
            this.desc.BackColor = System.Drawing.SystemColors.MenuText;
            this.desc.ForeColor = System.Drawing.SystemColors.Info;
            this.desc.Location = new System.Drawing.Point(186, 72);
            this.desc.Multiline = true;
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(234, 70);
            this.desc.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(331, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 59;
            this.label7.Text = "ID DISPOSITIVO";
            // 
            // diag
            // 
            this.diag.BackColor = System.Drawing.SystemColors.MenuText;
            this.diag.ForeColor = System.Drawing.SystemColors.Info;
            this.diag.Location = new System.Drawing.Point(186, 186);
            this.diag.Multiline = true;
            this.diag.Name = "diag";
            this.diag.Size = new System.Drawing.Size(234, 55);
            this.diag.TabIndex = 64;
            // 
            // fecha
            // 
            this.fecha.BackColor = System.Drawing.SystemColors.MenuText;
            this.fecha.Enabled = false;
            this.fecha.ForeColor = System.Drawing.SystemColors.Info;
            this.fecha.Location = new System.Drawing.Point(524, 22);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(123, 20);
            this.fecha.TabIndex = 70;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Black;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(12, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 71;
            this.label12.Text = "MARCA";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Black;
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(9, 205);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 13);
            this.label14.TabIndex = 75;
            this.label14.Text = "N° REGISTRO";
            // 
            // nomcliente
            // 
            this.nomcliente.BackColor = System.Drawing.SystemColors.MenuText;
            this.nomcliente.Enabled = false;
            this.nomcliente.ForeColor = System.Drawing.SystemColors.Info;
            this.nomcliente.Location = new System.Drawing.Point(97, 25);
            this.nomcliente.Name = "nomcliente";
            this.nomcliente.Size = new System.Drawing.Size(212, 20);
            this.nomcliente.TabIndex = 77;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(94, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 78;
            this.label1.Text = "CLIENTE";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 21);
            this.comboBox1.TabIndex = 79;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.SystemColors.MenuText;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.ForeColor = System.Drawing.SystemColors.Info;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 121);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(140, 21);
            this.comboBox2.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 80;
            this.label2.Text = "MODELO";
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.SystemColors.MenuText;
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox3.ForeColor = System.Drawing.SystemColors.Info;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(12, 172);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(140, 21);
            this.comboBox3.TabIndex = 82;
            // 
            // dgvMostrarItem
            // 
            this.dgvMostrarItem.AllowUserToAddRows = false;
            this.dgvMostrarItem.AllowUserToDeleteRows = false;
            this.dgvMostrarItem.AllowUserToResizeColumns = false;
            this.dgvMostrarItem.AllowUserToResizeRows = false;
            this.dgvMostrarItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarItem.ColumnHeadersVisible = false;
            this.dgvMostrarItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvMostrarItem.Location = new System.Drawing.Point(439, 72);
            this.dgvMostrarItem.Name = "dgvMostrarItem";
            this.dgvMostrarItem.Size = new System.Drawing.Size(208, 169);
            this.dgvMostrarItem.TabIndex = 84;
            this.dgvMostrarItem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMostrarItem_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(436, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 83;
            this.label9.Text = "ACCESORIOS";
            // 
            // registro
            // 
            this.registro.BackColor = System.Drawing.SystemColors.MenuText;
            this.registro.ForeColor = System.Drawing.SystemColors.Info;
            this.registro.Location = new System.Drawing.Point(12, 221);
            this.registro.MaxLength = 100;
            this.registro.Name = "registro";
            this.registro.ShortcutsEnabled = false;
            this.registro.Size = new System.Drawing.Size(79, 20);
            this.registro.TabIndex = 85;
            this.registro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.registro_KeyPress);
            // 
            // iddis
            // 
            this.iddis.BackColor = System.Drawing.SystemColors.MenuText;
            this.iddis.Enabled = false;
            this.iddis.ForeColor = System.Drawing.SystemColors.Info;
            this.iddis.Location = new System.Drawing.Point(334, 25);
            this.iddis.Name = "iddis";
            this.iddis.Size = new System.Drawing.Size(79, 20);
            this.iddis.TabIndex = 86;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(521, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 87;
            this.label8.Text = "FECHA";
            // 
            // modeloTest
            // 
            this.modeloTest.BackColor = System.Drawing.SystemColors.MenuText;
            this.modeloTest.Enabled = false;
            this.modeloTest.ForeColor = System.Drawing.SystemColors.Info;
            this.modeloTest.Location = new System.Drawing.Point(33, 272);
            this.modeloTest.Name = "modeloTest";
            this.modeloTest.Size = new System.Drawing.Size(79, 20);
            this.modeloTest.TabIndex = 88;
            this.modeloTest.Visible = false;
            // 
            // TipoTest
            // 
            this.TipoTest.BackColor = System.Drawing.SystemColors.MenuText;
            this.TipoTest.Enabled = false;
            this.TipoTest.ForeColor = System.Drawing.SystemColors.Info;
            this.TipoTest.Location = new System.Drawing.Point(151, 272);
            this.TipoTest.Name = "TipoTest";
            this.TipoTest.Size = new System.Drawing.Size(79, 20);
            this.TipoTest.TabIndex = 91;
            this.TipoTest.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(309, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 42);
            this.button1.TabIndex = 92;
            this.button1.Text = "GUARDAR ACCESORIO";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NuevoDispositivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(659, 322);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TipoTest);
            this.Controls.Add(this.modeloTest);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.iddis);
            this.Controls.Add(this.registro);
            this.Controls.Add(this.dgvMostrarItem);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nomcliente);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.diag);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.idcliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NuevoDispositivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevoDispositivo";
            this.Load += new System.EventHandler(this.NuevoDispositivo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox desc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox diag;
        private System.Windows.Forms.TextBox fecha;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox idcliente;
        public System.Windows.Forms.TextBox nomcliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox3;
        public System.Windows.Forms.DataGridView dgvMostrarItem;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox registro;
        public System.Windows.Forms.TextBox iddis;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox modeloTest;
        public System.Windows.Forms.TextBox TipoTest;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.Button button1;
    }
}