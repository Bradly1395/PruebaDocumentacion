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
    public partial class Login : Form
    {
        int cont = 0;

        public Login()
        {
            InitializeComponent();
        }

        public string login_usuario;

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void EntrarButton(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usuariotxt.Text) == true || string.IsNullOrWhiteSpace(passwordtxt.Text) == true)
            {
                MessageBox.Show("No se permiten campos vacios");
            }
            else
            {
                users u = new users();
                string login_pass = passwordtxt.Text;
                MD5 md5 = MD5.Create();
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(login_pass);
                byte[] hash = md5.ComputeHash(inputBytes);
                login_pass = BitConverter.ToString(hash).Replace("-", "");
                login_usuario = passwordtxt.Text;
                u.Usuario = this.usuariotxt.Text;
                u.Contraseña = login_pass;


                /*
                if (usuariotxt.Text == "usuario" && passwordtxt.Text == "clave")
                {
                   MenuPrincipal formulario = new MenuPrincipal();
                    this.Hide();
                    MessageBox.Show("!!Correcto!! ", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    formulario.Show();
                }
                */
                /*
                else  /* if (usuariotxt.Text == "" || passwordtxt.Text == "")*/
                /*
{
/*MessageBox.Show("!!Incorrecto!! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);*/
                /*   MessageBox.Show("Error", "No registrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               }*/

                //users u = new users();
                //u.Usuario = this.usuariotxt.Text;
                //u.Contraseña = this.passwordtxt.Text;

                if (u.Buscar() == true)
                {
                    //MessageBox.Show(u.mensaje, "");
                    //
                    string adm;
                    string est;
                    string idus;

                    string query = "update USUARIO set INTENTOS = " + 0 + " where USUARIO = '"+usuariotxt.Text+"'";
                    Mantenimiento.actNomsg(query);

                    adm = prueba.Text;
                    est = estado.Text;
                    idus = id.Text;

                    /*if (adm == "User")
                    {
                        MessageBox.Show(u.mensaje, "");   
                    }*/


                    //Chequear si es admin
                    prueba.Text = Mantenimiento.consulta(usuariotxt.Text).ToString();
                    MenuPrincipal forma2 = new MenuPrincipal();
                    CambiarContraseña forma3 = new CambiarContraseña();
                    var txt6 = forma2.Controls["test"];
                    var txt7 = forma3.Controls["textBox1"];
                    //txt6.Text = Mantenimiento.consulta(u.Usuario, u.Contraseña).ToString();
                    txt6.Text = prueba.Text.ToString();

                    //Cheque estado
                    estado.Text = Mantenimiento.Estado(usuariotxt.Text).ToString();

                    //Copia Id
                    id.Text = Mantenimiento.userid(usuariotxt.Text).ToString();
                    txt7.Text = id.Text.ToString();


                    adm = prueba.Text;
                    est = estado.Text;
                    idus = id.Text;

                    //if (adm == "User" || adm == "Admin"
                    if (true)
                    {
                        //MessageBox.Show(u.mensaje, "");

                        switch (est)
                        {
                            case "Activo":
                                forma2.Show();
                                this.Hide();
                                break;
                            case "Inactivo":
                                MessageBox.Show(u.mensaje, "Usuario Inactivo");
                                break;
                            case "Bloqueado":
                                MessageBox.Show(u.mensaje, "Usuario Bloqueado");
                                break;
                            case "NuevoUser":
                                forma3.Show();
                                this.Hide();
                                break;
                            case "CambiarClave":
                                forma3.Show();
                                this.Hide();
                                break;

                            default:
                                break;
                        }

                    }
                   /* else
                    {
                        forma2.Show();
                        this.Hide();
                    }*/

                    //forma2.Show();
                    //this.Hide();
                }
                else
                {
                    if (u.BuscarUser() == true)
                    {
                        string query = "select INTENTOS FROM USUARIO where USUARIO = '" + usuariotxt.Text + "'";
                        cont = Mantenimiento.looker(query);
                        cont++;
                        intents.Text = cont.ToString();
                        
                        if (cont >= 3)
                        {
                            MessageBox.Show(u.mensaje, "Usuario Bloqueado");
                            string query1 = "update USUARIO set INTENTOS = " + 3 + ", ESTADO = " + 7 + " where USUARIO = '" + usuariotxt.Text + "'";
                            Mantenimiento.actNomsg(query1);
                        }
                        else
                        {
                          //cont++;
                          id.Text = Mantenimiento.userid(usuariotxt.Text).ToString();
                          int idus = Convert.ToInt32(id.Text);
                          //MessageBox.Show(u.mensaje, "");
                          //MessageBox.Show(u.mensaje, "Usuario Bloqueado");
                          MessageBox.Show(u.editIntentos(cont, idus));
                        }

                        
                    
                    }
                    
                    //MessageBox.Show(u.mensaje, "ERROR");
                    //cont++;
                    usuariotxt.Clear();
                    passwordtxt.Clear();
                }

                /*if (cont > 3)
                {

                    EntrarB.Enabled = false;
                    usuariotxt.Enabled = false;
                    passwordtxt.Enabled = false;
                    label3.Visible = true;
                }*/
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Close();
            Environment.Exit(0);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones numero = new validaciones();
            numero.SoloNumeros(e);
        }

        private void usuariotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones vali = new validaciones();
            vali.ParaLoginSinEspacios(e);

            e.Handled = char.IsWhiteSpace(e.KeyChar);
        }

        private void passwordtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones vali = new validaciones();
            vali.ParaLoginSinEspacios(e);

            e.Handled = char.IsWhiteSpace(e.KeyChar);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
