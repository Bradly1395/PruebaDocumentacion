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
using System.Data.SqlClient;

namespace PantallasDesarrollo
{
    public partial class NuevoDispositivo : Form
    {
        public NuevoDispositivo()
        {
            InitializeComponent();
        }

        private void NuevoDispositivo_Load(object sender, EventArgs e)
        {
            Mantenimiento llenar = new Mantenimiento();
            llenar.llenarMarca(comboBox1);
            llenar.llenarTipoDis(comboBox3);

            Mantenimiento man = new Mantenimiento();

            man.cargarAccesorio(dgvMostrarItem);

            dgvMostrarItem.Columns["Descripcion"].ReadOnly = true;


            fecha.Text = DateTime.Now.ToString("yyyy-MM-dd");

            string idtype = "select top 1 IdDispositivos + 1 from DISPOSITIVO order by IdDispositivos desc";
            int idbd = 0;
            idbd = clients.idtypecheck(idtype);

            iddis.Text = idbd.ToString();


        }

        private void button8_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(registro.Text) == true || string.IsNullOrWhiteSpace(desc.Text) == true || string.IsNullOrWhiteSpace(diag.Text) == true || string.IsNullOrEmpty(comboBox1.Text) || string.IsNullOrEmpty(comboBox2.Text) || string.IsNullOrEmpty(comboBox3.Text))
            {
                MessageBox.Show("No se permiten campos vacios");
            }

            else
            {

                string Query = "select * from DISPOSITIVO where NumRegistro = " + registro.Text + "";

                contactos cl = new contactos();

                if (cl.Buscar(Query) == true)
                {
                    MessageBox.Show("Registro ya existe");
                }
                else
                {
                    string idtype = "select IDModelo from Modelo where Descripcion = '" + comboBox2.Text + "'";
                    int idbd = 0;
                    idbd = clients.idtypecheck(idtype);

                    string idtype1 = "select IDTipoDispositivo from TipoDispositivo where Descripcion = '" + comboBox3.Text + "'";
                    int idbd1 = 0;
                    idbd1 = clients.idtypecheck(idtype1);

                    modeloTest.Text = idbd.ToString();
                    TipoTest.Text = idbd1.ToString();

                    string cadenasql = "INSERT INTO DISPOSITIVO(IDMODELO, DESCRIPCION, DIAGNOSTICO, IDCliente, fechaIngreso, Estado, NumRegistro, TipoDispositivo) VALUES (" + idbd + ", '" + desc.Text + "', '" + diag.Text + "', " + idcliente.Text + ", '" + fecha.Text + "', " + 10 + ", " + registro.Text + ", " + idbd1 + ");";
                    Mantenimiento.insertar(cadenasql);


                    /**************/
                    foreach (DataGridViewRow row in dgvMostrarItem.Rows)
                    {
                        string constring = @"Data Source=(localdb)\MyInstance;Initial Catalog=IT4;Integrated Security=True";
                        using (SqlConnection con = new SqlConnection(constring))
                        {
                            if (Convert.ToBoolean(row.Cells[0].Value) == true)
                            {
                                using (SqlCommand cmd = new SqlCommand("INSERT INTO [Dispositivo/Accesorio] VALUES(@DispoID, @Acc)", con))
                                {
                                    cmd.Parameters.AddWithValue("@DispoID", iddis.Text);
                                    cmd.Parameters.AddWithValue("@Acc", row.Cells[2].Value);

                                    con.Open();
                                    cmd.ExecuteNonQuery();
                                    con.Close();
                                }


                            }



                        }
                    }
                    /**************/
                    this.Hide();
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvMostrarItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            Mantenimiento llenar = new Mantenimiento();

            string idtype = "select IDmarca from Marca where Descripcion = '" + comboBox1.Text + "'";
            int idbd = 0;
            idbd = clients.idtypecheck(idtype);

            llenar.llenarModelo(comboBox2, idbd);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvMostrarItem.Rows)
            {
                string constring = @"Data Source=(localdb)\MyInstance;Initial Catalog=IT4;Integrated Security=True";
                using (SqlConnection con = new SqlConnection(constring))
                {
                    if (Convert.ToBoolean(row.Cells[0].Value) == true)
                    {
                        using (SqlCommand cmd = new SqlCommand("INSERT INTO [Dispositivo/Accesorio] VALUES(@DispoID, @Acc)", con))
                    {
                        cmd.Parameters.AddWithValue("@DispoID", iddis.Text);
                        cmd.Parameters.AddWithValue("@Acc", row.Cells[2].Value);
                        
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    
                    
                    }

                    
                    
                }
            }
            MessageBox.Show("Records inserted.");
        }

        private void registro_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones numero = new validaciones();
            numero.SoloNumeros(e);

            validaciones vali = new validaciones();
            vali.ParaLoginSinEspacios(e);

        }
    }
}
