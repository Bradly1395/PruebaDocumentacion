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

using System.Data.SqlClient;


namespace PantallasDesarrollo
{
    public partial class EditarUsuario : Form
    {
        public EditarUsuario()
        {
            InitializeComponent();
        }

        private void EditarUsuario_Load(object sender, EventArgs e)
        {
            Mantenimiento llenar = new Mantenimiento();
            
            llenar.llenarPst(comboBox1);

            users us = new users();

            SqlDataReader Lect;
            using (SqlConnection Cone = Conexion.generarConexion())
            {
                Cone.Open();
                SqlCommand comando = new SqlCommand("select [Descripcion] from [dbo].[Estados/Entidad]  where [IDEntidad] = 1 ", Cone);

                Lect = comando.ExecuteReader();

                while (Lect.Read())
                {
                    comboBox2.Items.Add(Lect["Descripcion"].ToString());
                }
                Cone.Close();

            }

            comboBox1.SelectedItem = txtPuesto.Text;
            comboBox2.SelectedItem = txtEstado.Text;


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

            users us = new users();
            Conexion cone = new Conexion();
            
            if (string.IsNullOrWhiteSpace(nom.Text) == true || string.IsNullOrWhiteSpace(comboBox1.Text) == true || string.IsNullOrWhiteSpace(user.Text) == true || string.IsNullOrWhiteSpace(clave.Text) == true || string.IsNullOrWhiteSpace(comboBox2.Text) == true)
            {
                MessageBox.Show("No se permiten campos vacios");
            }
            else
            {

                //users us = new users();
                //users us = new users();
                string login_pass = clave.Text;
                MD5 md5 = MD5.Create();
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(login_pass);
                byte[] hash = md5.ComputeHash(inputBytes);
                login_pass = BitConverter.ToString(hash).Replace("-", "");


                /*if (comboBox1.Text == "Administrador")
                    MessageBox.Show(us.edit((Convert.ToInt32(txteid.Text)), nom.Text, user.Text, login_pass, 9, 6));
                else
                    MessageBox.Show(us.edit((Convert.ToInt32(txteid.Text)), nom.Text, user.Text, login_pass, 9, 7));*/

                /*----------------------------------------------------*/
                if (comboBox2.Text == "Activo")
                {
                    if (comboBox1.Text == "Administrador")
                        MessageBox.Show(us.edit((Convert.ToInt32(txteid.Text)), nom.Text, user.Text, login_pass, 5, 6));
                    else
                        MessageBox.Show(us.edit((Convert.ToInt32(txteid.Text)), nom.Text, user.Text, login_pass, 5, 7));
                }


                if (comboBox2.Text == "Inactivo")
                {
                    if (comboBox1.Text == "Administrador")
                        MessageBox.Show(us.edit((Convert.ToInt32(txteid.Text)), nom.Text, user.Text, login_pass, 6, 6));
                    else
                        MessageBox.Show(us.edit((Convert.ToInt32(txteid.Text)), nom.Text, user.Text, login_pass, 6, 7));
                }

                if (comboBox2.Text == "Bloqueado")
                {
                    if (comboBox1.Text == "Administrador")
                        MessageBox.Show(us.edit((Convert.ToInt32(txteid.Text)), nom.Text, user.Text, login_pass, 7, 6));
                    else
                        MessageBox.Show(us.edit((Convert.ToInt32(txteid.Text)), nom.Text, user.Text, login_pass, 7, 7));
                }

                if (comboBox2.Text == "NuevoUser")
                {
                    if (comboBox1.Text == "Administrador")
                        MessageBox.Show(us.edit((Convert.ToInt32(txteid.Text)), nom.Text, user.Text, login_pass, 8, 6));
                    else
                        MessageBox.Show(us.edit((Convert.ToInt32(txteid.Text)), nom.Text, user.Text, login_pass, 8, 7));
                }

                if (comboBox2.Text == "CambiarClave")
                {
                    if (comboBox1.Text == "Administrador")
                        MessageBox.Show(us.edit((Convert.ToInt32(txteid.Text)), nom.Text, user.Text, login_pass, 9, 6));
                    else
                        MessageBox.Show(us.edit((Convert.ToInt32(txteid.Text)), nom.Text, user.Text, login_pass, 9, 7));
                }



                /*----------------------------------------------------*/


                this.Hide();
                usuarios user1 = new usuarios();
                user1.Show();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this.Hide();
            this.Hide();
            usuarios user1 = new usuarios();
            user1.Show();
        }

        private void user_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsWhiteSpace(e.KeyChar);
        }

        private void clave_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsWhiteSpace(e.KeyChar);
        }
    }
}
