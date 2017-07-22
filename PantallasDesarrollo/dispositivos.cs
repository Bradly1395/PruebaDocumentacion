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
    public partial class dispositivos : Form
    {
        public dispositivos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             
            this.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModificarDispositivo frm3 = new ModificarDispositivo();

            if (dataGridView1.RowCount == 1)
            {
                MessageBox.Show("Selecione un Contacto");
            }
            else
            {
                
                frm3.iddis.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                frm3.registro.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                frm3.marca.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                frm3.modelo.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                frm3.nomcliente.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                //frm3.nomcliente.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                frm3.diag.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                

                this.Hide();
                frm3.Show();
            }




            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dispositivos_Load(object sender, EventArgs e)
        {
            contactos co = new contactos();
            co.cargarDispo(dataGridView1);
            
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            string codigo = "%" + textBox2.Text + "%";
            string query = "select a.IdDispositivos, a.NumRegistro, c.Descripcion as Marca, b.Descripcion as Modelo, d.[NOMBRE COMPLETO], f.Descripcion as Estado, a.DIAGNOSTICO, a.fechaIngreso from DISPOSITIVO as a inner join Modelo as b on a.IDMODELO = b.IDmodelo inner join Marca as c on b.IDmarca = c.IDmarca inner join CLIENTE as d on a.IDCliente = d.IDCliente inner join [Estados/Entidad] as f on f.IDCol = a.Estado Where a.NumRegistro LIKE '" + codigo + "' OR a.DESCRIPCION LIKE '" + codigo + "' OR c.Descripcion LIKE '" + codigo + "';";
            Mantenimiento.buscarDevice(dataGridView1, query); 
        }
    }
}
