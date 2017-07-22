using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Data.SqlClient;
using Clases;

namespace PantallasDesarrollo
{
    public partial class ImprimirFactura : Form
    {

        private Button botonImprimir = new Button();
        private PrintDocument printDocument1 = new PrintDocument();

        public ImprimirFactura()
        {
            InitializeComponent();
        }

        Bitmap imagen;

        private void printDocument1_PrintPage(System.Object sender,
              System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(imagen, 0, 0);
        }

        private void CapturarPantalla()
        {
            Graphics g = this.CreateGraphics();
            Size s = this.Size;
            imagen = new Bitmap(s.Width, s.Height, g);
            Graphics g2 = Graphics.FromImage(imagen);
            g2.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*if (string.IsNullOrWhiteSpace(textBox2.Text) == true || string.IsNullOrWhiteSpace(textBox3.Text) == true || string.IsNullOrWhiteSpace(textBox4.Text) == true || string.IsNullOrWhiteSpace(comboBox1.Text) == true || string.IsNullOrWhiteSpace(comboBox2.Text) == true)
            {
                MessageBox.Show("No se permiten campos vacios");
            }*/
            //else
            {
                string Query = "select *from CLIENTE where [RTN/ID]= " + desc.Text + "";

                /*contactos cl = new contactos();
                if (cl.Buscar(Query) == false)
                {
                    MessageBox.Show("Rtn no existe");
                }*/
                //else
                {
                  

                    using (SqlConnection cone = Conexion.generarConexion())
                    {
                        try
                        {
                         /*   cone.Open();
                            string cadenasql = "insert  into FACTURA values (" + 000 + ", " + 1 + ", " + 15 + ", '2017-12-07' , " + 1 + ", " + 10 + ");";
                            using (SqlCommand cmd = new SqlCommand(cadenasql, cone))
                            {

                                cmd.Parameters.AddWithValue("@fecha", Fecha.Value.Date);

                                cmd.ExecuteNonQuery();
                                cone.Close();
                            }*/
                        
                            //
                            CapturarPantalla();
                            printDocument1.Print();

                            this.Hide();
                            facturas1 frm = new facturas1();
                            frm.Show();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }

                    }
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones numero = new validaciones();
            numero.SoloNumeros(e);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones numero = new validaciones();
            numero.SoloNumeros(e);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones numero = new validaciones();
            numero.SoloNumeros(e);
        }

        private void ImprimirFactura_Load(object sender, EventArgs e)
        {
            //this.Fecha.Enabled = false;

            connect cli = new connect();
            Conexion conec = new Conexion();

            //textBox1.Text = Mantenimiento.codigoFactura().ToString();

            Mantenimiento llenar = new Mantenimiento();
            //llenar.llenarUsuario(comboBox1);
            //llenar.llenarEstado(comboBox2);

            double tot = 0;
            double imp = 0;
            double subt = 0;
            
            imp = double.Parse(isv.Text);
            subt = double.Parse(monto.Text);

            tot = subt + ((imp / 100) * subt);

            total.Text = tot.ToString();


        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Fecha_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
