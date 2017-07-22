using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;

namespace PantallasDesarrollo
{
    public partial class NuevoCliente : Form
    {

        connect cli = new connect();
        Conexion conec = new Conexion();

        public NuevoCliente()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
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
          
            if (string.IsNullOrWhiteSpace(txtrtnid.Text) == true || string.IsNullOrWhiteSpace(txtnom.Text) == true || string.IsNullOrWhiteSpace(txtdirec.Text) == true || string.IsNullOrWhiteSpace(comboBox1.Text) == true)
            {
                MessageBox.Show("No se permiten campos vacios");
            }

            else
            {

                string Query = "select *from CLIENTE where [RTN/ID]= " + txtrtnid.Text + "";

                contactos cl = new contactos();
                if (cl.Buscar(Query) == true)
                {
                    MessageBox.Show("Rtn ya existe");
                }
                else
                {
                    string idtype = "select IDType from IDTypes where Descripcion = '"+comboBox1.Text+"'";
                    int idbd = 0;
                    idbd = clients.idtypecheck(idtype);

                    string cadenasql = "insert  into CLIENTE values (" + txtrtnid.Text + ", '" + txtnom.Text + "', '" + txtdirec.Text + "', " + 16 + ", " + idbd + ");";
                    clients.insetarclien(cadenasql);
                    txtdirec.Clear();
                    txtnom.Clear();
                    txtrtnid.Clear();
                    comboBox1.Text = " ";
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

            //e.Handled = char.IsWhiteSpace(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones letra = new validaciones();
            letra.SoloLetras(e);

           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NuevoCliente_Load(object sender, EventArgs e)
        {
 
            connect cli = new connect();
            Conexion conec = new Conexion(); 

            Mantenimiento llenar = new Mantenimiento();
            llenar.llenarCliente(comboBox1);  

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
