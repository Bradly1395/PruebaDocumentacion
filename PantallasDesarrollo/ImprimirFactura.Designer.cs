namespace PantallasDesarrollo
{
    partial class ImprimirFactura
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.numfac = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.TextBox();
            this.rtn = new System.Windows.Forms.TextBox();
            this.nom = new System.Windows.Forms.TextBox();
            this.desc = new System.Windows.Forms.TextBox();
            this.monto = new System.Windows.Forms.TextBox();
            this.isv = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero Factura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "RTN / ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Subtotal";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Imprimir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(139, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numfac
            // 
            this.numfac.Location = new System.Drawing.Point(114, 28);
            this.numfac.Name = "numfac";
            this.numfac.ReadOnly = true;
            this.numfac.Size = new System.Drawing.Size(155, 20);
            this.numfac.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(288, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Fecha";
            // 
            // fecha
            // 
            this.fecha.Location = new System.Drawing.Point(324, 28);
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Size = new System.Drawing.Size(155, 20);
            this.fecha.TabIndex = 14;
            // 
            // rtn
            // 
            this.rtn.Location = new System.Drawing.Point(114, 60);
            this.rtn.Name = "rtn";
            this.rtn.ReadOnly = true;
            this.rtn.Size = new System.Drawing.Size(155, 20);
            this.rtn.TabIndex = 15;
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(324, 61);
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            this.nom.Size = new System.Drawing.Size(155, 20);
            this.nom.TabIndex = 16;
            // 
            // desc
            // 
            this.desc.Location = new System.Drawing.Point(200, 87);
            this.desc.Multiline = true;
            this.desc.Name = "desc";
            this.desc.ReadOnly = true;
            this.desc.Size = new System.Drawing.Size(279, 80);
            this.desc.TabIndex = 17;
            // 
            // monto
            // 
            this.monto.Location = new System.Drawing.Point(365, 183);
            this.monto.Name = "monto";
            this.monto.ReadOnly = true;
            this.monto.Size = new System.Drawing.Size(114, 20);
            this.monto.TabIndex = 18;
            // 
            // isv
            // 
            this.isv.Location = new System.Drawing.Point(365, 213);
            this.isv.Name = "isv";
            this.isv.ReadOnly = true;
            this.isv.Size = new System.Drawing.Size(114, 20);
            this.isv.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(288, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Impuesto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(284, 248);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Total";
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(365, 241);
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Size = new System.Drawing.Size(114, 20);
            this.total.TabIndex = 22;
            // 
            // ImprimirFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(491, 292);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.isv);
            this.Controls.Add(this.monto);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.rtn);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numfac);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ImprimirFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImprimirFactura";
            this.Load += new System.EventHandler(this.ImprimirFactura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox numfac;
        public System.Windows.Forms.TextBox fecha;
        public System.Windows.Forms.TextBox rtn;
        public System.Windows.Forms.TextBox nom;
        public System.Windows.Forms.TextBox desc;
        public System.Windows.Forms.TextBox monto;
        public System.Windows.Forms.TextBox isv;
        public System.Windows.Forms.TextBox total;
    }
}