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

namespace PantallasDesarrollo
{
    public partial class editarcli : Form 
    {
        clients cli = new clients();
        

        public editarcli()
        {
            InitializeComponent();
            radioButton1.Checked = true;
        }

        private void txtdirec_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txteid.Text) == true || string.IsNullOrWhiteSpace(txtertnid.Text) == true || string.IsNullOrWhiteSpace(txtenom.Text) == true || string.IsNullOrWhiteSpace(txtedirec.Text) == true)
            {
                MessageBox.Show("No se permiten campos vacios");
            }
            else
            {
                string idtype = "select IDType from IDTypes where Descripcion = '" + comboBox1.Text + "'";
                int idbd = 0;
                idbd = clients.idtypecheck(idtype);


                if (radioButton1.Checked == true)
                {
                    MessageBox.Show(cli.edit((Convert.ToInt32(txteid.Text)), (Convert.ToInt32(txtertnid.Text)), txtenom.Text, txtedirec.Text, 16,idbd));
                }

                if (radioButton2.Checked == true)
                {
                    MessageBox.Show(cli.edit((Convert.ToInt32(txteid.Text)), (Convert.ToInt32(txtertnid.Text)), txtenom.Text, txtedirec.Text, 17,idbd));
                }

                this.Hide();
                clientes clifrm = new clientes();
                clifrm.Show();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //this.Hide();
            this.Hide();
            clientes clifrm = new clientes();
            clifrm.Show();
        }

        private void txteid_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsWhiteSpace(e.KeyChar);
        }

        private void editarcli_Load(object sender, EventArgs e)
        {
            connect cli = new connect();
            Conexion conec = new Conexion();

            Mantenimiento llenar = new Mantenimiento();
            llenar.llenarCliente(comboBox1);
            comboBox1.SelectedItem = txtetype.Text;
        }

        private void txtestatus_KeyPress(object sender, KeyPressEventArgs e)
        { 
            /*int n=(int.Parse(txtestatus.Text)); 

            if (n  !=  1)
            { 
                MessageBox.Show("Los unicos estado validos son '1', '2', '3'");
            }

            if (n != 1)
            {
                MessageBox.Show("Los unicos estado validos son '1', '2', '3'");
            }

            if (n != 1)
            {
                MessageBox.Show("Los unicos estado validos son '1', '2', '3'");
            }*/

          

        }

        private void txtedirec_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtenom_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones letra = new validaciones();
            letra.SoloLetras(e);
        }

        private void txtertnid_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txteid_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnsave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txteid.Text == null)
            {
                btnsave.Enabled = false;
                MessageBox.Show("No se pueden actualizar campos vacios");
            }

            if (txtertnid.Text == null)
            {
                btnsave.Enabled = false;
                MessageBox.Show("No se pueden actualizar campos vacios");
            }

            if (txtenom.Text == null)
            {
                btnsave.Enabled = false;
                MessageBox.Show("No se pueden actualizar campos vacios");
            }

            if (txtedirec.Text == null)
            {
                btnsave.Enabled = false;
                MessageBox.Show("No se pueden actualizar campos vacios");
            }

            


        }

        private void txtertnid_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsWhiteSpace(e.KeyChar);
        }
    }
}
