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
    public partial class NuevoTipoID : Form
    {
        public NuevoTipoID()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult = System.Windows.Forms.DialogResult.OK;
            ParametrosAdmon form = new ParametrosAdmon();

            form.tabControl1.SelectedIndex = 3;
            form.Show();
            this.Hide();
            //this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBox2.Text) == true)
            {
                MessageBox.Show("No se permiten espacios en blanco");
                textBox2.Clear();
            }

            else
            {
                try
                {
                    string Query = "select *from IDTypes where Descripcion= '" + textBox2.Text + "'";

                    contactos cl = new contactos();
                    if (cl.Buscar(Query) == true)
                    {
                        MessageBox.Show("IDType ya existe");
                    }
                    else
                    {
                        string cadenasql = "insert  into IDTypes  values ('" + textBox2.Text + "', "+16+")";
                        contactos.insertar(cadenasql);

                        textBox2.Clear();
                        textBox1.Text = Mantenimiento.codigoIDTypes().ToString();
                        ParametrosAdmon form = new ParametrosAdmon();

                        form.tabControl1.SelectedIndex = 3;
                        form.Show();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void NuevoTipoID_Load(object sender, EventArgs e)
        {
            textBox1.Text = Mantenimiento.codigoIDTypes().ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
