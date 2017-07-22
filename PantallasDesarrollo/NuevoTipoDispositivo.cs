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
    public partial class NuevoTipoDispositivo : Form
    {
        public NuevoTipoDispositivo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtnomAg.Text) == false)
            {
                string cadenasql = "insert  into TipoDispositivo values ('" + txtnomAg.Text + "'," + 16 + ");";
                Mantenimiento.insertar(cadenasql);
                txtnomAg.Clear();
                ParametrosAdmon form = new ParametrosAdmon();
                form.tabControl1.SelectedIndex = 5;
                form.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("No se permiten espacios en blanco");


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ParametrosAdmon form = new ParametrosAdmon();
            form.tabControl1.SelectedIndex = 5;
            form.Show();
            this.Hide();
        }

        private void NuevoTipoDispositivo_Load(object sender, EventArgs e)
        {
             
        }

        private void txtnomAg_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones letra = new validaciones();
            letra.SoloLetras(e);
        }
    }
}
