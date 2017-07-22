using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Printing;
using System.Drawing;
using System.Data;
using System.ComponentModel;
using System.Windows.Forms;

namespace Clases
{
    public partial class Imprimir : Form
    {
            private Button botonImprimir = new Button();
            private PrintDocument printDocument1 = new PrintDocument();


            public Imprimir()
            {
                botonImprimir.Text = "Imprimir Formulario";
                botonImprimir.Click += new EventHandler(printButton_Click);
                printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
                this.Controls.Add(botonImprimir);
            }

            void printButton_Click(object sender, EventArgs e)
            {
                CapturarPantalla();
                printDocument1.Print();
            }

            Bitmap imagen;

            private void CapturarPantalla()
            {
                Graphics g = this.CreateGraphics();
                Size s = this.Size;
                imagen = new Bitmap(s.Width, s.Height, g);
                Graphics g2 = Graphics.FromImage(imagen);
                g2.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
            }

            private void printDocument1_PrintPage(System.Object sender,
                   System.Drawing.Printing.PrintPageEventArgs e)
            {
                e.Graphics.DrawImage(imagen, 0, 0);
            }

            private void InitializeComponent()
            {
            this.SuspendLayout();
            // 
            // Imprimir
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Name = "Imprimir";
            this.Load += new System.EventHandler(this.Imprimir_Load);
            this.ResumeLayout(false);

            }

            private void Imprimir_Load(object sender, EventArgs e)
            {

            }

        
    }
}
