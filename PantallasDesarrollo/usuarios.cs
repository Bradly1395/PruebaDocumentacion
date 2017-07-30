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

/*
 * Eduardo Gonzalez 
 * Bradly Aguilera 
 * David Euceda 
 * 
 * Interfaz central de Uusuario con la vista de usuarios ya existentes y las opciones para crear nuevos
 * y editar los ya existentes 
 * 
 * 27/7/2017 
 * */
 

namespace PantallasDesarrollo
{
    public partial class usuarios : Form
    {
        public usuarios()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            this.Hide();


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            NuevoUsuario frm3 = new NuevoUsuario();
            frm3.Show();
        }

        private void usuarios_Load(object sender, EventArgs e)
        {
            users us = new users();
            us.cargarUsers(dataGridView1);
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            users us = new users();
            us.cargarUsers(dataGridView1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show("Selecione una linea");
            }
            else
            {
                EditarUsuario ec = new EditarUsuario();
                ec.user.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                ec.nom.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                ec.comboBox1.SelectedItem = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                ec.comboBox2.SelectedItem = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                ec.txteid.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                ec.txtEstado.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                ec.txtPuesto.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();



                this.Hide();
                ec.Show();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void acercaDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Ayuda ayuda = new Ayuda();
            ayuda.Show();

        }
    }
}
