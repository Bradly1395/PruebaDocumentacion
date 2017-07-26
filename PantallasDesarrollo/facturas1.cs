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
    public partial class facturas1 : Form
    {
        public facturas1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            this.Hide();
        }

        private void facturas_Load(object sender, EventArgs e)
        {
            contactos co = new contactos();
            co.cargarFacturas(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAyuda2_Click(object sender, EventArgs e)
        {
            Ayuda ayuda = new Ayuda();
            ayuda.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ImprimirFactura frm = new ImprimirFactura();
            frm.Show();
        }
    }
}
