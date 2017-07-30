using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Clases;

using System.Windows.Forms;
using System.Data;
using System.Data.Sql;



namespace Clases
{
   public class contactos:connect
    {
       public static bool resul = false;

       public static void insertar(string query)
       {
           using (SqlConnection cnn = Conexion.generarConexion())
           {
               cnn.Open();
               SqlCommand comando = new SqlCommand(query, cnn);
               comando.ExecuteNonQuery();
               cnn.Close();
               MessageBox.Show("Ingresado!");
           }
       }

       public static void insetarCon(string query)
       {
           using (SqlConnection cnn = Conexion.generarConexion())
           {
               cnn.Open();
               SqlCommand comando = new SqlCommand(query, cnn);
               comando.ExecuteNonQuery();
               cnn.Close();
               MessageBox.Show("Contacto ingresado!");
           }
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


       public static void buscarcontactos(DataGridView dgv, string query)
       {
           using (SqlConnection cone = Conexion.generarConexion())
           {
               cone.Open();

               DataSet dt = new DataSet();
               SqlDataAdapter da = new SqlDataAdapter(query, cone);

               da.Fill(dt, "IT3");
               dgv.DataSource = dt;
               dgv.DataMember = "IT3";
               cone.Close();

           }
       }


       public bool Buscar(string sql)
       {

           using (SqlConnection cone = Conexion.generarConexion())
           {
               bool resultado = false;
               cone.Open();
               SqlCommand comando = new SqlCommand(sql, cone);

               SqlDataReader reg = (null);
               reg = comando.ExecuteReader();
               if (reg.Read())
               {
                   resultado = true;

               }
               cone.Close();
               resul = resultado;
               return resultado;
           }


       }


       public static void actualizar(string query)
       {
           using (SqlConnection cone = Conexion.generarConexion())
           {
               cone.Open();
               SqlCommand comando = new SqlCommand(query, cone);

               comando.ExecuteNonQuery();
               cone.Close();
               MessageBox.Show("Modificacion realizada!");
           }
       }


       public string edit(int rtn, string name, string ape, string tel, int t, int cli)
       {
           string salida = "Se actualizaron los datos";
           try
           {
               cnn.Open();
               //comandosql = new SqlCommand("Update Contactos set Rtn= " + rtn + ", Nombre= '" + name + "', Apellido= '" + ape + "', Telefono = '" + tel + "', Estado = " + t + "  , Idcliente = " + cli + " where Rtn = " + rtn + " ", cnn);
               comandosql = new SqlCommand("Update Contactos set Rtn= " + rtn + ", Nombre= '" + name + "', Apellido= '" + ape + "', Telefono = '" + tel + "', Estado = " + 16 + "  , Idcliente = " + cli + " where Rtn = " + rtn + " ", cnn);
               comandosql.ExecuteNonQuery();
               cnn.Close();
           }
           catch (Exception ex)
           {
               salida = "No se actualizo: " + ex.ToString();
           }
           return salida;
       }



       public void cargarContacto(DataGridView dgv)
       {
           //DataTable dt = new DataTable();
           //SqlDataAdapter da = new SqlDataAdapter(); 

           try
           {
               da = new SqlDataAdapter("Select Contactos.Rtn, Contactos.Nombre, Contactos.Apellido, Contactos.Telefono , Contactos.Idcliente, CLIENTE.[NOMBRE COMPLETO] from [dbo].[Contactos] inner join [dbo].[CLIENTE] on Contactos.Idcliente=CLIENTE.IDCliente", cnn);
               dt = new DataTable();
               da.Fill(dt);
               dgv.DataSource = dt;
           }
           catch (Exception ex)
           {
               MessageBox.Show("No se pudo llenar el Datagridview: " + ex.ToString());
           }
       }


       /*-----------!Grids externos-------------*/
       public void cargarIDTypes(DataGridView dgv)
       {
           //DataTable dt = new DataTable();
           //SqlDataAdapter da = new SqlDataAdapter(); 

           try
           {
               da = new SqlDataAdapter("select a.IDType, a.Descripcion, b.Descripcion as Estado from IDTypes as a inner join [Estados/Entidad] as b on a.Estado = b.IDCol", cnn);
               dt = new DataTable();
               da.Fill(dt);
               dgv.DataSource = dt;
           }
           catch (Exception ex)
           {
               MessageBox.Show("No se pudo llenar el Datagridview: " + ex.ToString());
           }
       }

       public void cargarMarcas(DataGridView dgv)
       {
           //DataTable dt = new DataTable();
           //SqlDataAdapter da = new SqlDataAdapter(); 

           try
           {
               da = new SqlDataAdapter("select a.IDmarca, a.Descripcion, b.Descripcion as Estado from Marca as a inner join [Estados/Entidad] as b on a.Estado = b.IDCol", cnn);
               dt = new DataTable();
               da.Fill(dt);
               dgv.DataSource = dt;
           }
           catch (Exception ex)
           {
               MessageBox.Show("No se pudo llenar el Datagridview: " + ex.ToString());
           }
       }

       public void cargarModelo(DataGridView dgv)
       {
           //DataTable dt = new DataTable();
           //SqlDataAdapter da = new SqlDataAdapter(); 

           try
           {
               da = new SqlDataAdapter("select a.IDmodelo, b.Descripcion as Marca, a.Descripcion as Modelo, c.Descripcion from Modelo as a inner join Marca as b on a.IDmarca = b.IDmarca inner join [Estados/Entidad] as c on a.Estado = c.IDCol", cnn);
               dt = new DataTable();
               da.Fill(dt);
               dgv.DataSource = dt;
           }
           catch (Exception ex)
           {
               MessageBox.Show("No se pudo llenar el Datagridview: " + ex.ToString());
           }
       }

       public void cargarAcc(DataGridView dgv)
       {
           //DataTable dt = new DataTable();
           //SqlDataAdapter da = new SqlDataAdapter(); 

           try
           {
               da = new SqlDataAdapter("select a.IDAccesorio, a.Descripcion, b.Descripcion as Estado from Accesorios as a inner join [Estados/Entidad] as b on a.Estado = b.IDCol", cnn);
               dt = new DataTable();
               da.Fill(dt);
               dgv.DataSource = dt;
           }
           catch (Exception ex)
           {
               MessageBox.Show("No se pudo llenar el Datagridview: " + ex.ToString());
           }
       }

       public void cargarTdispo(DataGridView dgv)
       {
           //DataTable dt = new DataTable();
           //SqlDataAdapter da = new SqlDataAdapter(); 

           try
           {
               da = new SqlDataAdapter("select a.IDTipoDispositivo, a.Descripcion, b.Descripcion as Estado from TipoDispositivo as a inner join [Estados/Entidad] as b on a.Estado = b.IDCol", cnn);
               dt = new DataTable();
               da.Fill(dt);
               dgv.DataSource = dt;
           }
           catch (Exception ex)
           {
               MessageBox.Show("No se pudo llenar el Datagridview: " + ex.ToString());
           }
       }

       public void cargarDispo(DataGridView dgv)
       {
           //DataTable dt = new DataTable();
           //SqlDataAdapter da = new SqlDataAdapter(); 

           try
           {
               da = new SqlDataAdapter("select a.IdDispositivos, a.NumRegistro, c.Descripcion as Marca, b.Descripcion as Modelo, d.[NOMBRE COMPLETO], f.Descripcion as Estado, a.DIAGNOSTICO, a.fechaIngreso from DISPOSITIVO as a inner join Modelo as b on a.IDMODELO = b.IDmodelo inner join Marca as c on b.IDmarca = c.IDmarca inner join CLIENTE as d on a.IDCliente = d.IDCliente inner join [Estados/Entidad] as f on f.IDCol = a.Estado ", cnn);
               dt = new DataTable();
               da.Fill(dt);
               dgv.DataSource = dt;
           }
           catch (Exception ex)
           {
               MessageBox.Show("No se pudo llenar el Datagridview: " + ex.ToString());
           }
       }

        /*-----------Grids externos!-------------*/
       public void cargarFacturas(DataGridView dgv)
       {
           //DataTable dt = new DataTable();
           //SqlDataAdapter da = new SqlDataAdapter(); 

           try
           {
               da = new SqlDataAdapter("select * from FACTURA", cnn);
               dt = new DataTable();
               da.Fill(dt);
               dgv.DataSource = dt;
           }
           catch (Exception ex)
           {
               MessageBox.Show("No se pudo llenar el Datagridview: " + ex.ToString());
           }
       }
    }
}
