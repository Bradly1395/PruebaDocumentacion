﻿namespace PantallasDesarrollo
{
    partial class EditarMarca
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
            this.label6 = new System.Windows.Forms.Label();
            this.inac = new System.Windows.Forms.RadioButton();
            this.act = new System.Windows.Forms.RadioButton();
            this.cod = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtEdit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(31, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 55;
            this.label6.Text = "ESTADO";
            // 
            // inac
            // 
            this.inac.AutoSize = true;
            this.inac.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.inac.Location = new System.Drawing.Point(170, 157);
            this.inac.Name = "inac";
            this.inac.Size = new System.Drawing.Size(63, 17);
            this.inac.TabIndex = 54;
            this.inac.TabStop = true;
            this.inac.Text = "Inactivo";
            this.inac.UseVisualStyleBackColor = true;
            // 
            // act
            // 
            this.act.AutoSize = true;
            this.act.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.act.Location = new System.Drawing.Point(100, 157);
            this.act.Name = "act";
            this.act.Size = new System.Drawing.Size(55, 17);
            this.act.TabIndex = 53;
            this.act.TabStop = true;
            this.act.Text = "Activo";
            this.act.UseVisualStyleBackColor = true;
            // 
            // cod
            // 
            this.cod.BackColor = System.Drawing.SystemColors.InfoText;
            this.cod.Enabled = false;
            this.cod.ForeColor = System.Drawing.SystemColors.Info;
            this.cod.Location = new System.Drawing.Point(100, 44);
            this.cod.MaxLength = 50;
            this.cod.Name = "cod";
            this.cod.Size = new System.Drawing.Size(133, 20);
            this.cod.TabIndex = 52;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.OrangeRed;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(158, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 45);
            this.button2.TabIndex = 51;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(34, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 45);
            this.button1.TabIndex = 50;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEdit
            // 
            this.txtEdit.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtEdit.ForeColor = System.Drawing.SystemColors.Info;
            this.txtEdit.Location = new System.Drawing.Point(100, 81);
            this.txtEdit.MaxLength = 50;
            this.txtEdit.Name = "txtEdit";
            this.txtEdit.Size = new System.Drawing.Size(133, 20);
            this.txtEdit.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(31, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(45, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Codigo";
            // 
            // EditarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.inac);
            this.Controls.Add(this.act);
            this.Controls.Add(this.cod);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "EditarMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarMarca";
            this.Load += new System.EventHandler(this.EditarMarca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox cod;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtEdit;
        public System.Windows.Forms.RadioButton inac;
        public System.Windows.Forms.RadioButton act;
    }
}