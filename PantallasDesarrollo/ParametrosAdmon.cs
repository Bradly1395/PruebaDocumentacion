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
    public partial class ParametrosAdmon : Form
    {
        public ParametrosAdmon()
        {
            InitializeComponent();
        }

        private void ParametrosAdmon_Load(object sender, EventArgs e)
        {
            contactos co = new contactos();
            co.cargarIDTypes(dataGridView6);
            co.cargarMarcas(dataGridView1);
            co.cargarModelo(dataGridView2);
            co.cargarAcc(dataGridView3);
            co.cargarTdispo(dataGridView5);
            string query = "select ISV from ISV";
            isv.Text = Mantenimiento.lookerSt(query);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AgregarMarca newMarca = new AgregarMarca();
            newMarca.Show();
            this.Hide();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string query = "update ISV set ISV = " + isv.Text + " where Id = " +1+ "";
            Mantenimiento.actualizar(query);
        }

        private void usuariotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones numero = new validaciones();

            //validaciones vali = new validaciones();
            //vali.ParaLoginSinEspacios(e);

            //numero.SoloNumeros(e);
            //e.Handled = char.IsWhiteSpace(e.KeyChar);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ModificarTipoID form = new ModificarTipoID();
            form.comboBox1.Text = dataGridView6.CurrentRow.Cells[0].Value.ToString();
            form.textBox1.Text = dataGridView6.CurrentRow.Cells[1].Value.ToString();

            if (dataGridView6.CurrentRow.Cells[2].Value.ToString() == "Activo")
            {
                form.act.Checked = true;
            }
            else
                form.inac.Checked = true;


            form.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            contactos co = new contactos();
            co.cargarIDTypes(dataGridView6);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NuevoTipoID form = new NuevoTipoID();


            form.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show("Selecione una linea");
            }
            else
            {
                EditarMarca edit = new EditarMarca();
                edit.cod.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                edit.txtEdit.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                
                if(dataGridView1.CurrentRow.Cells[2].Value.ToString() == "Activo")
                {
                    edit.act.Checked = true;
                }
                else
                    edit.inac.Checked = true;


                edit.Show();
                this.Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NuevoAccesorio newAcc = new NuevoAccesorio();
            newAcc.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ModificarAccesorio modAcc = new ModificarAccesorio();

            modAcc.cod.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            modAcc.txtEdit.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            if (dataGridView3.CurrentRow.Cells[2].Value.ToString() == "Activo")
            {
                modAcc.act.Checked = true;
            }
            else
                modAcc.inac.Checked = true;
            
            modAcc.Show();
            this.Hide();
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            NuevoTipoDispositivo newTiD = new NuevoTipoDispositivo();
            newTiD.Show();
            this.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            ModificarTipoDispositivo modTipDis = new ModificarTipoDispositivo();

            modTipDis.cod.Text = dataGridView5.CurrentRow.Cells[0].Value.ToString();
            modTipDis.txtEdit.Text = dataGridView5.CurrentRow.Cells[1].Value.ToString();

            if (dataGridView5.CurrentRow.Cells[2].Value.ToString() == "Activo")
            {
                modTipDis.act.Checked = true;
            }
            else
                modTipDis.inac.Checked = true;


            modTipDis.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NuevoModelo newMol = new NuevoModelo();
            
            newMol.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ModificarModelo modMol = new ModificarModelo();
            modMol.cod.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            modMol.comboBox1.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            modMol.txtEdit.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();

            if (dataGridView2.CurrentRow.Cells[3].Value.ToString() == "Activo")
            {
                modMol.act.Checked = true;
            }
            else
                modMol.inac.Checked = true;


            modMol.Show();
            this.Hide();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
