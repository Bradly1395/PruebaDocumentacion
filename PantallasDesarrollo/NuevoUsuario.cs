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

/*
 * Eduardo Gonzalez 
 * Bradly Aguilera 
 * David Euceda 
 * 
 * Interfaz para añadir usuarios
 * 
 * 27/7/2017 
 * */ 


namespace PantallasDesarrollo
{
    public partial class NuevoUsuario : Form
    {
        public NuevoUsuario()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            
            
            if (string.IsNullOrWhiteSpace(nom.Text) == true || string.IsNullOrWhiteSpace(tel.Text) == true || string.IsNullOrWhiteSpace(comboBox1.Text) == true || string.IsNullOrWhiteSpace(user.Text) == true || string.IsNullOrWhiteSpace(clave.Text) == true)
            {
                MessageBox.Show("No se permiten campos vacios");
            }
            
            else
            {
            //copia el texto de las cajas de texto y lo compara en la base de datos para asegurarase de que
            //no existe
            string Query = "select *from USUARIO where USUARIO= '" + user.Text + "'";

            contactos cl = new contactos();
            if (cl.Buscar(Query) == true)
            {
                MessageBox.Show("USUARIO ya existe");
            }

            else
            {
                //encripta contraseña
                users us = new users();
                string login_pass = clave.Text;
                MD5 md5 = MD5.Create();
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(login_pass);
                byte[] hash = md5.ComputeHash(inputBytes);
                login_pass = BitConverter.ToString(hash).Replace("-", ""); 
                
                //toma la decision lo asigna a administrador o usuario regular para derechos
                if (comboBox1.Text == "Administrador")
                {
                    string cadenasql = "insert  into USUARIO values ('" + nom.Text + "', '" + tel.Text + "', '" + user.Text + "', '" + login_pass + "'," + 8 + ", " + 0 + "," + 6 + ");";
                    users.insertarUser(cadenasql);
                }
                else
                {
                    string cadenasql = "insert  into USUARIO values ('" + nom.Text + "', '" + tel.Text + "', '" + user.Text + "', '" + login_pass + "'," + 8 + ", " + 0 + "," + 7 + ");";
                    users.insertarUser(cadenasql);
                }
                
            
                nom.Clear();
                tel.Clear();
                user.Clear();
                comboBox1.Text = " ";
                this.Hide();
                usuarios user1 = new usuarios();
                user1.Show();



            }
          }
        }

            
            
           
        

        private void button3_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            usuarios user1 = new usuarios();
            user1.Show();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones numero = new validaciones();
            numero.SoloNumeros(e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones numero = new validaciones();
            numero.SoloNumeros(e);

            validaciones vali = new validaciones();
            vali.ParaLoginSinEspacios(e);

          
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones letra = new validaciones();
            letra.SoloLetras(e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones vali = new validaciones();
            vali.ParaLoginSinEspacios(e);

            e.Handled = char.IsWhiteSpace(e.KeyChar);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones vali = new validaciones();
            vali.ParaLoginSinEspacios(e);

        
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones vali = new validaciones();
            vali.ParaLoginSinEspacios(e);
        }

        private void NuevoUsuario_Load(object sender, EventArgs e)
        {
            Mantenimiento llenar = new Mantenimiento();
            llenar.llenarPst(comboBox1); 
        }
    }
}
