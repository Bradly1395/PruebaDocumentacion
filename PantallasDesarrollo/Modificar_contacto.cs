using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Clases;
//using System.Windows.Forms;
//using System.Data;
using System.Data.Sql;
namespace PantallasDesarrollo
{
    public partial class Modificar_contacto : Form
    {
     
        public Modificar_contacto()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)

        {
            if (string.IsNullOrWhiteSpace(textBox11.Text) == true || string.IsNullOrWhiteSpace(textBox22.Text) == true || string.IsNullOrWhiteSpace(textBox33.Text) == true || string.IsNullOrWhiteSpace(maskedTextBox11.Text) == true || string.IsNullOrWhiteSpace(textBox66.Text) == true)
            {
                MessageBox.Show("No se permiten campos vacios");
            }

            else
            {
                contactos co = new contactos();
                MessageBox.Show(co.edit((Convert.ToInt32(textBox11.Text)), textBox22.Text, textBox33.Text, maskedTextBox11.Text, 1, (Convert.ToInt32(textBox66.Text))));
                this.Hide();
                clientes clifrm = new clientes();
                clifrm.Show();
            }
        }

        private void Modificar_contacto_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this.Hide();
            this.Hide();
            clientes clifrm = new clientes();
            clifrm.Show();
        }

        private void textBox5_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            string codigo = "%" + textBox5.Text + "%";
            string query = "Select CLIENTE.IDCliente, CLIENTE.[NOMBRE COMPLETO] from [dbo].[CLIENTE]  Where CLIENTE.IDCliente LIKE '" + codigo + "' OR CLIENTE.[NOMBRE COMPLETO] LIKE '" + codigo + "';";
            contactos.buscarcontactos(dataGridView1, query); 
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox66_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            e.Handled = char.IsWhiteSpace(e.KeyChar);
        }
    

}
}
