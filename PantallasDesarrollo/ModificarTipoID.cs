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
    public partial class ModificarTipoID : Form
    {
        public ModificarTipoID()
        {
            InitializeComponent();
            act.Checked = true;
        }

        private void ModificarTipoID_Load(object sender, EventArgs e)
        {
            connect cli = new connect();
            Conexion conec = new Conexion();

            //Mantenimiento llenar = new Mantenimiento();
            //llenar.llenarCliente(comboBox1); 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int estado = 16;
            if (act.Checked == false)
            {
                estado = 17;
            }

            if (string.IsNullOrWhiteSpace(textBox1.Text) == false)
            {
                string query = "update IDTypes set Descripcion= '" + textBox1.Text + "', ESTADO = "+estado+" where IDType = " + int.Parse(comboBox1.Text) + "";
                Mantenimiento.actualizar(query);
                
                
                ParametrosAdmon form = new ParametrosAdmon();
                form.tabControl1.SelectedIndex = 3;
                form.Show();
                this.Hide();
                //this.Hide();
            }
            else
            {
                MessageBox.Show("No se permiten espacios vacios!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ParametrosAdmon form = new ParametrosAdmon();

            form.tabControl1.SelectedIndex = 3;
            form.Show();
            this.Hide();
            //this.Hide();
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones letra = new validaciones();
            letra.SoloLetras(e);
        }
    }
}
