namespace PantallasDesarrollo
{
    partial class Ayuda
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
            this.cajaHelp = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.op1 = new System.Windows.Forms.ToolStripMenuItem();
            this.op2 = new System.Windows.Forms.ToolStripMenuItem();
            this.op1a = new System.Windows.Forms.ToolStripMenuItem();
            this.op1b = new System.Windows.Forms.ToolStripMenuItem();
            this.op3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cajaHelp
            // 
            this.cajaHelp.Location = new System.Drawing.Point(143, 26);
            this.cajaHelp.Name = "cajaHelp";
            this.cajaHelp.ReadOnly = true;
            this.cajaHelp.Size = new System.Drawing.Size(207, 247);
            this.cajaHelp.TabIndex = 0;
            this.cajaHelp.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(378, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesMenu
            // 
            this.opcionesMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.op1,
            this.op2,
            this.op3});
            this.opcionesMenu.Name = "opcionesMenu";
            this.opcionesMenu.Size = new System.Drawing.Size(69, 20);
            this.opcionesMenu.Text = "Opciones";
            // 
            // op1
            // 
            this.op1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.op1a,
            this.op1b});
            this.op1.Name = "op1";
            this.op1.Size = new System.Drawing.Size(205, 22);
            this.op1.Text = "Acerca";
            // 
            // op2
            // 
            this.op2.Name = "op2";
            this.op2.Size = new System.Drawing.Size(205, 22);
            this.op2.Text = "Tips y Recomendaciones";
            this.op2.Click += new System.EventHandler(this.op2_Click);
            // 
            // op1a
            // 
            this.op1a.Name = "op1a";
            this.op1a.Size = new System.Drawing.Size(152, 22);
            this.op1a.Text = "Usuarios";
            this.op1a.Click += new System.EventHandler(this.op1a_Click);
            // 
            // op1b
            // 
            this.op1b.Name = "op1b";
            this.op1b.Size = new System.Drawing.Size(152, 22);
            this.op1b.Text = "Facturas";
            this.op1b.Click += new System.EventHandler(this.op1b_Click);
            // 
            // op3
            // 
            this.op3.Name = "op3";
            this.op3.Size = new System.Drawing.Size(205, 22);
            this.op3.Text = "Solucionar Problemas";
            this.op3.Click += new System.EventHandler(this.op3_Click);
            // 
            // Ayuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 299);
            this.Controls.Add(this.cajaHelp);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Ayuda";
            this.Text = "Ayuda";
            this.Load += new System.EventHandler(this.Ayuda_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox cajaHelp;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesMenu;
        private System.Windows.Forms.ToolStripMenuItem op1;
        private System.Windows.Forms.ToolStripMenuItem op1a;
        private System.Windows.Forms.ToolStripMenuItem op1b;
        private System.Windows.Forms.ToolStripMenuItem op2;
        private System.Windows.Forms.ToolStripMenuItem op3;
    }
}