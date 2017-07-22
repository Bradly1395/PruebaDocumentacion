namespace PantallasDesarrollo
{
    partial class editarcli
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
            this.txtedirec = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtenom = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtertnid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txteid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtestatus = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtetype = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.OrangeRed;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(239, 214);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 42);
            this.button3.TabIndex = 31;
            this.button3.Text = "Volver";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(89, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "DIRECCION";
            // 
            // txtedirec
            // 
            this.txtedirec.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtedirec.ForeColor = System.Drawing.SystemColors.Info;
            this.txtedirec.Location = new System.Drawing.Point(163, 107);
            this.txtedirec.MaxLength = 200;
            this.txtedirec.Name = "txtedirec";
            this.txtedirec.Size = new System.Drawing.Size(140, 20);
            this.txtedirec.TabIndex = 29;
            this.txtedirec.TextChanged += new System.EventHandler(this.txtdirec_TextChanged);
            this.txtedirec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtedirec_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(89, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "NOMBRE";
            // 
            // txtenom
            // 
            this.txtenom.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtenom.ForeColor = System.Drawing.SystemColors.Info;
            this.txtenom.Location = new System.Drawing.Point(163, 75);
            this.txtenom.MaxLength = 50;
            this.txtenom.Name = "txtenom";
            this.txtenom.ShortcutsEnabled = false;
            this.txtenom.Size = new System.Drawing.Size(140, 20);
            this.txtenom.TabIndex = 27;
            this.txtenom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtenom_KeyPress);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.YellowGreen;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsave.Location = new System.Drawing.Point(103, 214);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 42);
            this.btnsave.TabIndex = 26;
            this.btnsave.Text = "ACEPTAR";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            this.btnsave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnsave_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(89, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "RTN/ID";
            // 
            // txtertnid
            // 
            this.txtertnid.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtertnid.Enabled = false;
            this.txtertnid.ForeColor = System.Drawing.SystemColors.Info;
            this.txtertnid.Location = new System.Drawing.Point(163, 44);
            this.txtertnid.MaxLength = 50;
            this.txtertnid.Name = "txtertnid";
            this.txtertnid.ShortcutsEnabled = false;
            this.txtertnid.Size = new System.Drawing.Size(140, 20);
            this.txtertnid.TabIndex = 24;
            this.txtertnid.TextChanged += new System.EventHandler(this.txtertnid_TextChanged);
            this.txtertnid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtertnid_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(89, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "#IDCliente";
            // 
            // txteid
            // 
            this.txteid.BackColor = System.Drawing.SystemColors.MenuText;
            this.txteid.Enabled = false;
            this.txteid.ForeColor = System.Drawing.SystemColors.Info;
            this.txteid.Location = new System.Drawing.Point(163, 14);
            this.txteid.MaxLength = 50;
            this.txteid.Name = "txteid";
            this.txteid.ReadOnly = true;
            this.txteid.Size = new System.Drawing.Size(140, 20);
            this.txteid.TabIndex = 33;
            this.txteid.TextChanged += new System.EventHandler(this.txteid_TextChanged);
            this.txteid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txteid_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(92, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "ESTADO";
            // 
            // txtestatus
            // 
            this.txtestatus.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtestatus.ForeColor = System.Drawing.SystemColors.Info;
            this.txtestatus.Location = new System.Drawing.Point(73, 173);
            this.txtestatus.Name = "txtestatus";
            this.txtestatus.ReadOnly = true;
            this.txtestatus.Size = new System.Drawing.Size(82, 20);
            this.txtestatus.TabIndex = 40;
            this.txtestatus.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(264, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 65);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(6, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "IDTYPE";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(8, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 21);
            this.comboBox1.TabIndex = 44;
            // 
            // txtetype
            // 
            this.txtetype.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtetype.ForeColor = System.Drawing.SystemColors.Info;
            this.txtetype.Location = new System.Drawing.Point(31, 263);
            this.txtetype.Name = "txtetype";
            this.txtetype.ReadOnly = true;
            this.txtetype.Size = new System.Drawing.Size(82, 20);
            this.txtetype.TabIndex = 41;
            this.txtetype.Visible = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton1.Location = new System.Drawing.Point(179, 141);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(55, 17);
            this.radioButton1.TabIndex = 42;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Activo";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton2.Location = new System.Drawing.Point(179, 173);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(63, 17);
            this.radioButton2.TabIndex = 43;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Inactivo";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // editarcli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(430, 295);
            this.ControlBox = false;
            this.Controls.Add(this.txtetype);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtestatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txteid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtedirec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtenom);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtertnid);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "editarcli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Clientes";
            this.Load += new System.EventHandler(this.editarcli_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtedirec;
        public System.Windows.Forms.TextBox txtenom;
        public System.Windows.Forms.TextBox txtertnid;
        public System.Windows.Forms.TextBox txteid;
        public System.Windows.Forms.TextBox txtestatus;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtetype;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}