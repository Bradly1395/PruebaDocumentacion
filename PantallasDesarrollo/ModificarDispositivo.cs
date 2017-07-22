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
    public partial class ModificarDispositivo : Form
    {
        public ModificarDispositivo()
        {
            InitializeComponent();

            /*Mantenimiento man = new Mantenimiento();

            man.llenarPst(comboBox2);*/

            SqlDataReader Lect;
            using (SqlConnection Cone = Conexion.generarConexion())
            {
                Cone.Open();
                SqlCommand comando = new SqlCommand("select [Descripcion] from [dbo].[Estados/Entidad]  where [IDEntidad] = 2 ", Cone);

                Lect = comando.ExecuteReader();

                while (Lect.Read())
                {
                    comboBox1.Items.Add(Lect["Descripcion"].ToString());
                }
                Cone.Close();

            }

            /************************/
            SqlDataReader Lect1;
            using (SqlConnection Cone = Conexion.generarConexion())
            {
                Cone.Open();
                SqlCommand comando = new SqlCommand("select NOM_EMPLEADO from USUARIO", Cone);

                Lect1 = comando.ExecuteReader();

                while (Lect1.Read())
                {
                    comboBox2.Items.Add(Lect1["NOM_EMPLEADO"].ToString());
                }
                Cone.Close();

            }


            /************************/

        }

        private void button8_Click(object sender, EventArgs e)
        {
            /*string idtype = "SELECT IDCol FROM [Estados/Entidad] WHERE IDEntidad = 2 and Descripcion = '" + comboBox1.Text + "'";
            int idbd = 0;
            idbd = clients.idtypecheck(idtype);

            string idtype1 = "select ID_EMPLEADO from USUARIO where NOM_EMPLEADO = '" + comboBox2.Text + "'";
            int idbd1 = 0;
            idbd1 = clients.idtypecheck(idtype1);*/

            //prueba.Text = idbd.ToString();
            //prueba2.Text = idbd1.ToString();

            if (string.IsNullOrWhiteSpace(comboBox1.Text) == true || string.IsNullOrWhiteSpace(diag.Text) == true || string.IsNullOrWhiteSpace(comboBox2.Text) == true )
            {
                MessageBox.Show("No se permiten campos vacios");
            }
            else
            {
                string idtype = "SELECT IDCol FROM [Estados/Entidad] WHERE IDEntidad = 2 and Descripcion = '" + comboBox1.Text + "'";
                int idbd = 0;
                idbd = clients.idtypecheck(idtype);

                string idtype1 = "select ID_EMPLEADO from USUARIO where NOM_EMPLEADO = '" + comboBox2.Text + "'";
                int idbd1 = 0;
                idbd1 = clients.idtypecheck(idtype1);

                string idclien = "select IDCliente from CLIENTE where [NOMBRE COMPLETO] = '" + nomcliente.Text + "'";
                int idbd2 = 0;
                idbd2 = clients.idtypecheck(idclien);

                string rtn = "select [RTN/ID] from CLIENTE where [NOMBRE COMPLETO] = '" + nomcliente.Text + "'";
                int rtn1 = 0;
                rtn1 = clients.idtypecheck(rtn);


                string isv;
                string query1 = "select ISV from ISV";
                isv = Mantenimiento.lookerSt(query1);

                if (comboBox1.Text == "Reparado")
                {
                    string query = "update DISPOSITIVO set DIAGNOSTICO= '" + diag.Text + "', Estado = " + idbd + ", Tecnico = " + idbd1 + ", fecharRetiro = '" + fecha.Text + "', Monto = " + monto.Text + ", [Cod Fac] = " + codfac.Text + " where IdDispositivos = " + int.Parse(iddis.Text) + "";
                    Mantenimiento.actualizar(query);

                    string cadenasql = "insert  into FACTURA values (" + codfac.Text + ", " + idbd2 + ", " + isv + ", '" + fecha.Text + "' , " + idbd1 + ", " + 10 + ");";
                    Mantenimiento.actualizar(cadenasql);

                    ImprimirFactura frm3 = new ImprimirFactura();

                    frm3.numfac.Text = codfac.Text;
                    frm3.fecha.Text = fecha.Text;
                    frm3.rtn.Text = rtn1.ToString();
                    frm3.desc.Text = diag.Text;
                    frm3.monto.Text = monto.Text;
                    frm3.isv.Text = isv.ToString();
                    frm3.nom.Text = nomcliente.Text;

                    frm3.Show();

                }

                else
                {
                    string query = "update DISPOSITIVO set DIAGNOSTICO= '" + diag.Text + "', Estado = " + idbd + ", Tecnico = " + idbd1 + ", fecharRetiro = '" + fecha.Text + "' where IdDispositivos = " + int.Parse(iddis.Text) + "";
                    Mantenimiento.actualizar(query);
                }
                
                
                dispositivos frm4 = new dispositivos();

                
                
                




                frm4.Show();
                this.Close();
            }




            
            
        }

        private void ModificarDispositivo_Load(object sender, EventArgs e)
        {
            monto.Text = "0";
            codfac.Text = "0";
            

            
            fecha.Text = DateTime.Now.ToString("yyyy-MM-dd");

            Mantenimiento man = new Mantenimiento();

            int cod;

            cod = int.Parse(iddis.Text);

            man.cargarAccesorioMod(dgvMostrarItem, cod);

            dgvMostrarItem.Columns["Descripcion"].ReadOnly = true;

            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dispositivos frm3 = new dispositivos();
            frm3.Show();
            this.Close();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Reparado")
            {
                monto.Enabled = true;
                codfac.Enabled = true;
            }

            else
            {
                monto.Enabled = false;
                codfac.Enabled = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ImprimirFactura frm = new ImprimirFactura();
            frm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string rtn = "select [RTN/ID] from CLIENTE where [NOMBRE COMPLETO] = '" + nomcliente.Text + "'";
            int rtn1 = 0;
            rtn1 = clients.idtypecheck(rtn);


            string isv;
            string query1 = "select ISV from ISV";
            isv = Mantenimiento.lookerSt(query1);

            
            
            ImprimirFactura frm3 = new ImprimirFactura();

            frm3.numfac.Text = codfac.Text;
            frm3.fecha.Text = fecha.Text;
            frm3.rtn.Text = rtn1.ToString();
            frm3.desc.Text = diag.Text;
            frm3.monto.Text = monto.Text;
            frm3.isv.Text = isv.ToString();
            frm3.nom.Text = nomcliente.Text;

            frm3.Show();
        }

        private void codfac_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones numero = new validaciones();
            numero.SoloNumeros(e);
        }

        private void monto_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones numero = new validaciones();
            numero.SoloNumeros(e);
        }
    }
}
