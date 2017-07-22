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
    public partial class ModificarTipoDispositivo : Form
    {
        public ModificarTipoDispositivo()
        {
            InitializeComponent();
            act.Checked = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ParametrosAdmon form = new ParametrosAdmon();
            form.tabControl1.SelectedIndex = 5;
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
                
                
                
                string query = "update TipoDispositivo set Descripcion= '" + txtEdit.Text + "', Estado = " + estado + " where IDTipoDispositivo = " + int.Parse(cod.Text) + "";
                Mantenimiento.actualizar(query);


                ParametrosAdmon form = new ParametrosAdmon();
                form.tabControl1.SelectedIndex = 5;
                form.Show();
                this.Hide();
                //this.Hide();
            }
            else
            {
                MessageBox.Show("No se permiten espacios vacios!!");
            }
        }

        private void txtEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones letra = new validaciones();
            letra.SoloLetras(e);
        }
    }
}
