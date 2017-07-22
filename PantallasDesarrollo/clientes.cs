using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using Clases;

namespace PantallasDesarrollo
{
    public partial class clientes : Form 
    {
        clients cli = new clients(); 

        public clientes()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NuevoCliente frm3 = new NuevoCliente();
            this.Hide();
            frm3.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NuevoContacto frm3 = new NuevoContacto();
            frm3.Show();
        }

        private void clientes_Load(object sender, EventArgs e)
        {
            cli.cargarCliente(DgvClientes);
            contactos co = new contactos();
            co.cargarContacto(dataGridView2);
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (DgvClientes.RowCount == 1)
            {
                MessageBox.Show("Sleccione un cliente");

                editarcli ec = new editarcli();



            }
            else
            {
                NuevoDispositivo ec = new NuevoDispositivo();
                ec.idcliente.Text = DgvClientes.CurrentRow.Cells[0].Value.ToString();
                ec.nomcliente.Text = DgvClientes.CurrentRow.Cells[2].Value.ToString();



                this.Hide();
                ec.Show();

            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            if (DgvClientes.RowCount == 1)
            {
                MessageBox.Show("Sleccione un cliente");

                 editarcli ec = new editarcli();

              

            }
            else
            {
                editarcli ec = new editarcli();
                ec.txteid.Text = DgvClientes.CurrentRow.Cells[0].Value.ToString();
                ec.txtertnid.Text = DgvClientes.CurrentRow.Cells[1].Value.ToString();
                ec.txtenom.Text = DgvClientes.CurrentRow.Cells[2].Value.ToString();
                ec.txtedirec.Text = DgvClientes.CurrentRow.Cells[3].Value.ToString();
                ec.txtestatus.Text = DgvClientes.CurrentRow.Cells[4].Value.ToString();
                ec.txtetype.Text = DgvClientes.CurrentRow.Cells[5].Value.ToString();



                this.Hide();
                ec.Show();

            }
           
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection cnn = Conexion.generarConexion())
            {

                cnn.Open();


                SqlCommand cmd = cnn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from CLIENTE where [NOMBRE COMPLETO] like ('" + txtsearch.Text + "%') ";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                DgvClientes.DataSource = dt;



                cnn.Close();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvClientes.RowCount == 0)
            {
                MessageBox.Show("Selecione una linea");
            }
            else
            {
                Modificar_contacto mo = new Modificar_contacto();
                mo.textBox11.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                mo.textBox22.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                mo.textBox33.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
                mo.maskedTextBox11.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
                mo.textBox66.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();



                mo.Show();

            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (DgvClientes.RowCount == 1)
            {
                MessageBox.Show("Selecione un Contacto");
            }
            else
            {
                Modificar_contacto mo = new Modificar_contacto();
                mo.textBox11.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                mo.textBox22.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                mo.textBox33.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                mo.maskedTextBox11.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
                mo.textBox66.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();


                this.Hide();
                mo.Show();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            contactos co = new contactos();
            co.cargarContacto(dataGridView2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NuevoContacto frm3 = new NuevoContacto();
            this.Hide();
            frm3.Show();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            using (SqlConnection cnn = Conexion.generarConexion())
            {

                cnn.Open();


                SqlCommand cmd = cnn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select Contactos.Rtn, Contactos.Nombre, Contactos.Apellido, Contactos.Telefono , Contactos.Idcliente, CLIENTE.[NOMBRE COMPLETO] from [dbo].[Contactos] inner join [dbo].[CLIENTE] on Contactos.Idcliente=CLIENTE.IDCliente where Rtn like ('" + textBox1.Text + "%') ";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                dataGridView2.DataSource = dt;



                cnn.Close();
            }
        }

        private void txtsearch_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
