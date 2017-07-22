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
    public partial class NuevoModelo : Form
    {
        public NuevoModelo()
        {
            InitializeComponent();
        }

        private void NuevoModelo_Load(object sender, EventArgs e)
        {
            Mantenimiento llenar = new Mantenimiento();
            llenar.llenarMarca(comboBox1);
            comboBox1.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ParametrosAdmon form = new ParametrosAdmon();
            form.tabControl1.SelectedIndex = 1;
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtnomAg.Text) == false)
            {
                string idtype = "select IDmarca from Marca where Descripcion = '" + comboBox1.Text + "'";
                int idbd = 0;
                idbd = clients.idtypecheck(idtype);
                
                string cadenasql = "insert  into Modelo values ("+idbd+",'" + txtnomAg.Text + "'," + 16 + ");";
                Mantenimiento.insertar(cadenasql);
                txtnomAg.Clear();
                ParametrosAdmon form = new ParametrosAdmon();
                form.tabControl1.SelectedIndex = 1;
                form.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("No se permiten espacios en blanco");


            }
        }
    }
}
