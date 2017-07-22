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
using System.Data.SqlClient;

namespace PantallasDesarrollo
{
    public partial class NuevoContacto : Form


    {
        
      
        public NuevoContacto()
        {
            InitializeComponent();
        }

        private void NuevoContacto_Load(object sender, EventArgs e)
        {
          

        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            //this.Hide();
            this.Hide();
            clientes clifrm = new clientes();
            clifrm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            



                if (string.IsNullOrWhiteSpace(textBox1.Text) == true || string.IsNullOrWhiteSpace(textBox2.Text) == true || string.IsNullOrWhiteSpace(textBox3.Text) == true || string.IsNullOrWhiteSpace(maskedTextBox1.Text) == true || string.IsNullOrWhiteSpace(textBox6.Text) == true)
                {
                    MessageBox.Show("No se permiten campos vacios");
                }

                    else
                    {

                    string Query = "select *from Contactos where Rtn= " + textBox1.Text + "";

            contactos cl = new contactos();
            if (cl.Buscar(Query) == true)
            {
                MessageBox.Show("Rtn ya existe");
            }
            else
            {
                    string cadenasql = "insert  into Contactos  values ('" + textBox2.Text + "', '" + textBox3.Text + "','" + maskedTextBox1.Text + "', " + 16 + ", " + int.Parse(textBox6.Text) + ", " + int.Parse(textBox1.Text) + ", "+1+")";
                    contactos.insetarCon(cadenasql);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox1.Clear();
                    maskedTextBox1.Clear();
                    this.Hide();
                    clientes clifrm = new clientes();
                    clifrm.Show();
                    }


                }
            }

        
        

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones numero = new validaciones();
            numero.SoloNumeros(e);

            validaciones vali = new validaciones();
            vali.ParaLoginSinEspacios(e);

            //e.Handled = char.IsWhiteSpace(e.KeyChar);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones letra = new validaciones();
            letra.SoloLetras(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones letra = new validaciones();
            letra.SoloLetras(e);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones numero = new validaciones();
            numero.SoloNumeros(e);

            //e.Handled = char.IsWhiteSpace(e.KeyChar);
        }

        private void textBox5_KeyUp(object sender, KeyEventArgs e)
        {
            string codigo = "%" + textBox5.Text + "%";
            string query = "Select CLIENTE.IDCliente, CLIENTE.[NOMBRE COMPLETO] from [dbo].[CLIENTE]  Where CLIENTE.IDCliente LIKE '" + codigo + "' OR CLIENTE.[NOMBRE COMPLETO] LIKE '" + codigo + "';";
            contactos.buscarcontactos(dataGridView1, query); 
        }
    }
}
