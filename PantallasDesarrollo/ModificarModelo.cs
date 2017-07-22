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
    public partial class ModificarModelo : Form
    {
        public ModificarModelo()
        {
            InitializeComponent();
            act.Checked = true;
            Mantenimiento llenar = new Mantenimiento();
            llenar.llenarMarca(comboBox1); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ParametrosAdmon form = new ParametrosAdmon();
            form.tabControl1.SelectedIndex = 1;
            form.Show();
            this.Hide();
        }

        private void ModificarModelo_Load(object sender, EventArgs e)
        {

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
                string idtype = "select IDmarca from Marca where Descripcion = '" + comboBox1.Text + "'";
                int idbd = 0;
                idbd = clients.idtypecheck(idtype);



                string query = "update Modelo set Descripcion= '" + txtEdit.Text + "', Estado = " + estado + ", IDmarca = " + idbd + " where IDmodelo = " + int.Parse(cod.Text) + "";
                Mantenimiento.actualizar(query);


                ParametrosAdmon form = new ParametrosAdmon();
                form.tabControl1.SelectedIndex = 1;
                form.Show();
                this.Hide();
                //this.Hide();
            }
            else
            {
                MessageBox.Show("No se permiten espacios vacios!!");
            }
        }
    }
}
