using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;
using System.Security.Cryptography;

namespace PantallasDesarrollo
{
    public partial class CambiarContraseña : Form
    {
        public CambiarContraseña()
        {
            InitializeComponent();
        }

        private void CambiarContraseña_Load(object sender, EventArgs e)
        {

        }

        private void EntrarB_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(clavetxt.Text) == true || string.IsNullOrWhiteSpace(conftxt.Text) == true)
            {
                MessageBox.Show("No se permiten campos vacios");
            }
            else
            {
                users us = new users();
                //users us = new users();
                string login_pass = clavetxt.Text;
                MD5 md5 = MD5.Create();
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(login_pass);
                byte[] hash = md5.ComputeHash(inputBytes);
                login_pass = BitConverter.ToString(hash).Replace("-", "");

                int clave;

                clave = Int32.Parse(textBox1.Text);

                if (clavetxt.Text == conftxt.Text)
                {
                    MessageBox.Show(us.Cambiarcontra(login_pass, clave));
                    MenuPrincipal forma2 = new MenuPrincipal();
                    forma2.Show();
                    this.Hide();

                }


            }
        }

        private void usuariotxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void clavetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsWhiteSpace(e.KeyChar);
        }

        private void conftxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsWhiteSpace(e.KeyChar);
        }
    }
}
