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
    public partial class EditarMarca : Form
    {
        public EditarMarca()
        {
            InitializeComponent();
            act.Checked = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ParametrosAdmon form = new ParametrosAdmon();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int estado = 16;
            if (act.Checked == false)
            {
                estado = 17;
            }

            if (string.IsNullOrWhiteSpace(txtEdit.Text) == false)
            {
                string query = "update Marca set Descripcion= '" + txtEdit.Text + "', Estado = " + estado + " where IDmarca = " + int.Parse(cod.Text) + "";
                Mantenimiento.actualizar(query);


                ParametrosAdmon form = new ParametrosAdmon();
                form.Show();
                this.Hide();
                //this.Hide();
            }
            else
            {
                MessageBox.Show("No se permiten espacios vacios!!");
            }
        }

        private void EditarMarca_Load(object sender, EventArgs e)
        {

        }
    }
}
