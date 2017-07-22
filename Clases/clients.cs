using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Data.Sql;
using Clases;  


namespace Clases
{
    public class clients:connect
    {
        public static void insetarclien(string query)
        {
            using (SqlConnection cnn = Conexion.generarConexion())
            {
                cnn.Open();
                SqlCommand comandosql = new SqlCommand(query, cnn);
                comandosql.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Cliente ingresado!");
            }
        }

        public static int idtypecheck(string query)
        {
            int resultado;
            using (SqlConnection cone = Conexion.generarConexion())
            {
                cone.Open();
                SqlCommand comando = new SqlCommand(query, cone);

                resultado = Convert.ToInt32(comando.ExecuteScalar().ToString());
                cone.Close();

            }

            return resultado;
        }


        public static int codigoCont()
        {
            int resultado;
            using (SqlConnection cone = Conexion.generarConexion())
            {
                cone.Open();
                SqlCommand comando = new SqlCommand("select top 1 [Idcontacto] +1 from [dbo].[Contactos] order by [Idcontacto] desc", cone);

                resultado = Convert.ToInt32(comando.ExecuteScalar().ToString());
                cone.Close();

            }

            return resultado;

        }


        public void buscarclientes(DataGridView dgv, string query)
        {
            using (SqlConnection cone = Conexion.generarConexion())
            {
                cone.Open();

                DataSet dt = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(query, cone);

                da.Fill(dt, "IT4");
                dgv.DataSource = dt;
                dgv.DataMember = "IT4";
                cone.Close();

            }
        }


        public void cargarCliente(DataGridView dgv)
        {
            //DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter(); 

            try
            {
                da = new SqlDataAdapter("Select a.IDCliente, a.[RTN/ID], a.[NOMBRE COMPLETO], a.DIRECCION, c.Descripcion as Estado, b.Descripcion as TipoID from CLIENTE as a inner join IDTypes as b on a.IDtype = b.IDType inner join [Estados/Entidad] as c on a.Estado = c.IDCol", cnn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el Datagridview: " + ex.ToString());
            }
        }

        public string edit(int id, int rtn, string name, string direc, int est, int idtype)
        {
            string salida = "Se actualizaron los datos";
            try
            {
                cnn.Open();
                comandosql = new SqlCommand("Update CLIENTE set [RTN/ID]= " + rtn + ", [NOMBRE COMPLETO]= '" + name + "', DIRECCION= '" + direc + "', Estado = " + est + ", IDtype ="+idtype+" where IDCliente = " + id + " ", cnn);
                comandosql.ExecuteNonQuery();
                cnn.Close();
            }
            catch (Exception ex)
            {
                salida = "No se actualizo: " + ex.ToString();
            }
            return salida;
        }

      


      
    }
}
