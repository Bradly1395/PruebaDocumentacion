using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PantallasDesarrollo;






namespace PantallasDesarrollo
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clientes frm3 = new clientes();
            frm3.Show();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dispositivos frm2 = new dispositivos();
            
            
            frm2.Show();
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            facturas1 frm1 = new facturas1();

            frm1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            Login form = new Login();
            this.Hide();
            form.Show();
            
           
             
            }

        private void button3_Click(object sender, EventArgs e)
        {/*
            string Prompt = "Ingrese Clave";
            string Titulo = "Acceso Restringuido";
            string texto = Microsoft.VisualBasic.Interaction.InputBox(Prompt, Titulo, "*", 150, 150);*/
            usuarios frm = new usuarios();
            frm.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ParametrosAdmon frm = new ParametrosAdmon();
            frm.Show(); 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Desea Salir del Programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                Environment.Exit(0);

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Validated(object sender, EventArgs e)
        {
            
           
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            string adm;

            adm = test.Text;


            if (adm == "Admin")
            {
                button3.Visible = true;
                button5.Visible = true;
            }
        }

        private void EntrarB_Click(object sender, EventArgs e)
        {

        }
    }
}
