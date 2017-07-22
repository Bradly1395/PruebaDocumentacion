namespace PantallasDesarrollo
{
    partial class CambiarContraseña
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
            this.button1 = new System.Windows.Forms.Button();
            this.EntrarB = new System.Windows.Forms.Button();
            this.conftxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clavetxt = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(172, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 28);
            this.button1.TabIndex = 16;
            this.button1.Text = "SALIR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EntrarB
            // 
            this.EntrarB.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.EntrarB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EntrarB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EntrarB.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.EntrarB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EntrarB.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntrarB.ForeColor = System.Drawing.Color.White;
            this.EntrarB.Location = new System.Drawing.Point(172, 152);
            this.EntrarB.Name = "EntrarB";
            this.EntrarB.Size = new System.Drawing.Size(140, 28);
            this.EntrarB.TabIndex = 15;
            this.EntrarB.Text = "INGRESAR";
            this.EntrarB.UseVisualStyleBackColor = false;
            this.EntrarB.Click += new System.EventHandler(this.EntrarB_Click);
            // 
            // conftxt
            // 
            this.conftxt.BackColor = System.Drawing.SystemColors.InfoText;
            this.conftxt.ForeColor = System.Drawing.Color.Lime;
            this.conftxt.Location = new System.Drawing.Point(172, 91);
            this.conftxt.MaxLength = 50;
            this.conftxt.Name = "conftxt";
            this.conftxt.PasswordChar = '*';
            this.conftxt.Size = new System.Drawing.Size(140, 20);
            this.conftxt.TabIndex = 14;
            this.conftxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.conftxt_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlText;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(115, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Confirmar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(115, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Clave";
            // 
            // clavetxt
            // 
            this.clavetxt.BackColor = System.Drawing.SystemColors.MenuText;
            this.clavetxt.ForeColor = System.Drawing.SystemColors.Info;
            this.clavetxt.Location = new System.Drawing.Point(172, 55);
            this.clavetxt.MaxLength = 50;
            this.clavetxt.Name = "clavetxt";
            this.clavetxt.PasswordChar = '*';
            this.clavetxt.Size = new System.Drawing.Size(140, 20);
            this.clavetxt.TabIndex = 11;
            this.clavetxt.TextChanged += new System.EventHandler(this.usuariotxt_TextChanged);
            this.clavetxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.clavetxt_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.Enabled = false;
            this.textBox1.ForeColor = System.Drawing.Color.Lime;
            this.textBox1.Location = new System.Drawing.Point(172, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(140, 20);
            this.textBox1.TabIndex = 17;
            this.textBox1.Visible = false;
            // 
            // CambiarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(514, 262);
            this.ControlBox = false;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EntrarB);
            this.Controls.Add(this.conftxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clavetxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CambiarContraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CambiarContraseña";
            this.Load += new System.EventHandler(this.CambiarContraseña_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button EntrarB;
        private System.Windows.Forms.TextBox conftxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox clavetxt;
        private System.Windows.Forms.TextBox textBox1;
    }
}