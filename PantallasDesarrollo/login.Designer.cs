namespace PantallasDesarrollo
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.usuariotxt = new System.Windows.Forms.TextBox();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.EntrarB = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.prueba = new System.Windows.Forms.TextBox();
            this.estado = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.intents = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // usuariotxt
            // 
            this.usuariotxt.BackColor = System.Drawing.SystemColors.MenuText;
            this.usuariotxt.ForeColor = System.Drawing.SystemColors.Info;
            this.usuariotxt.Location = new System.Drawing.Point(269, 60);
            this.usuariotxt.MaxLength = 50;
            this.usuariotxt.Name = "usuariotxt";
            this.usuariotxt.ShortcutsEnabled = false;
            this.usuariotxt.Size = new System.Drawing.Size(140, 20);
            this.usuariotxt.TabIndex = 1;
            this.usuariotxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usuariotxt_KeyPress);
            // 
            // passwordtxt
            // 
            this.passwordtxt.BackColor = System.Drawing.SystemColors.InfoText;
            this.passwordtxt.ForeColor = System.Drawing.Color.Lime;
            this.passwordtxt.Location = new System.Drawing.Point(269, 108);
            this.passwordtxt.MaxLength = 50;
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.PasswordChar = '*';
            this.passwordtxt.ShortcutsEnabled = false;
            this.passwordtxt.Size = new System.Drawing.Size(140, 20);
            this.passwordtxt.TabIndex = 4;
            this.passwordtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordtxt_KeyPress);
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
            this.EntrarB.Location = new System.Drawing.Point(269, 163);
            this.EntrarB.Name = "EntrarB";
            this.EntrarB.Size = new System.Drawing.Size(140, 28);
            this.EntrarB.TabIndex = 5;
            this.EntrarB.Text = "INGRESAR";
            this.EntrarB.UseVisualStyleBackColor = false;
            this.EntrarB.Click += new System.EventHandler(this.EntrarButton);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(462, 288);
            this.shapeContainer1.TabIndex = 9;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 178;
            this.lineShape1.X2 = 178;
            this.lineShape1.Y1 = 45;
            this.lineShape1.Y2 = 229;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlText;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(220, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Clave";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(220, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario";
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
            this.button1.Location = new System.Drawing.Point(269, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "SALIR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(275, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "*Sistema bloqueado";
            this.label3.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // prueba
            // 
            this.prueba.BackColor = System.Drawing.SystemColors.InfoText;
            this.prueba.ForeColor = System.Drawing.Color.Lime;
            this.prueba.Location = new System.Drawing.Point(23, 246);
            this.prueba.Name = "prueba";
            this.prueba.Size = new System.Drawing.Size(140, 20);
            this.prueba.TabIndex = 12;
            this.prueba.Visible = false;
            // 
            // estado
            // 
            this.estado.BackColor = System.Drawing.SystemColors.InfoText;
            this.estado.ForeColor = System.Drawing.Color.Lime;
            this.estado.Location = new System.Drawing.Point(23, 208);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(140, 20);
            this.estado.TabIndex = 13;
            this.estado.Visible = false;
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.SystemColors.InfoText;
            this.id.ForeColor = System.Drawing.Color.Lime;
            this.id.Location = new System.Drawing.Point(23, 45);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(140, 20);
            this.id.TabIndex = 14;
            this.id.Visible = false;
            // 
            // intents
            // 
            this.intents.BackColor = System.Drawing.SystemColors.InfoText;
            this.intents.ForeColor = System.Drawing.Color.Lime;
            this.intents.Location = new System.Drawing.Point(269, 256);
            this.intents.Name = "intents";
            this.intents.Size = new System.Drawing.Size(140, 20);
            this.intents.TabIndex = 15;
            this.intents.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(462, 288);
            this.ControlBox = false;
            this.Controls.Add(this.intents);
            this.Controls.Add(this.id);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.prueba);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EntrarB);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usuariotxt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesion";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox usuariotxt;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.Button EntrarB;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox prueba;
        private System.Windows.Forms.TextBox estado;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox intents;
    }
}

