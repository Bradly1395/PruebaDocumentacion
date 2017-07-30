using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

using System.Data;
using System.Data.Sql;

namespace Clases
{
    public class users : connect
    {
        private string usuario;
        private string contraseña;

        public users()
        {
            usuario = string.Empty;
            contraseña = string.Empty;
            this.sql = string.Empty;


        }

        public string Usuario
        {
            get { return this.usuario; }
            set { this.usuario = value; }

        }
        public string Contraseña
        {
            get { return this.contraseña; }
            set { this.contraseña = value; }

        }

        public bool Buscar()
        {
            bool Resultado = false;
            this.sql = string.Format(@"select a.ID_EMPLEADO  from USUARIO as a where a.USUARIO='{0}' AND a.CLAVE='{1}' ", this.usuario, this.contraseña);

            this.comandosql = new SqlCommand(this.sql, this.cnn);
            this.cnn.Open();
            SqlDataReader reg = null;
            reg = this.comandosql.ExecuteReader();
            if (reg.Read())
            {
                Resultado = true;
                this.mensaje = "INGRESO INCORRECTO";

            }
            else
            {
                this.mensaje = "Usuario o Contraseña incorrecto";
            }
            this.cnn.Close();
            return Resultado;

        }

        public bool BuscarUser()
        {
            bool Resultado = false;
            this.sql = string.Format(@"select a.ID_EMPLEADO  from USUARIO as a where a.USUARIO='{0}'", this.usuario);

            this.comandosql = new SqlCommand(this.sql, this.cnn);
            this.cnn.Open();
            SqlDataReader reg = null;
            reg = this.comandosql.ExecuteReader();
            if (reg.Read())
            {
                Resultado = true;
                //this.mensaje = "INGRESO CORRECTO";

            }
            //else
            //{
                //this.mensaje = "Usuario o Contraseña incorrecto";
            //}
            this.cnn.Close();
            return Resultado;

        }

        public void cargarUsers(DataGridView dgv)
        {
            //DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter(); 

            try
            {
                da = new SqlDataAdapter("select a.USUARIO,a.NOM_EMPLEADO,b.DESC_PUESTO,c.Descripcion,a.ID_EMPLEADO from USUARIO as a inner join PUESTO as b on a.ID_Puesto = b.ID_PUESTO inner join [Estados/Entidad] as c on a.ESTADO = c.IDCol", cnn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el Datagridview: " + ex.ToString());
            }
        }

        public static void insertarUser(string query)
        {
            using (SqlConnection cnn = Conexion.generarConexion())
            {
                cnn.Open();
                SqlCommand comandosql = new SqlCommand(query, cnn);
                comandosql.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Usuario ingresado!");
            }
        }

        public string edit(int id, string nom, string user, string clave, int est, int puesto)
        {
            string salida = "Se actualizaron los datos";
            try
            {
                cnn.Open();
                comandosql = new SqlCommand("Update USUARIO set NOM_EMPLEADO = '" + nom + "', USUARIO = '" + user + "', CLAVE= '" + clave + "', ID_Puesto = " + puesto + ", Estado = " + est + " where ID_EMPLEADO = " + id + " ", cnn);
                comandosql.ExecuteNonQuery();
                cnn.Close();
            }
            catch (Exception ex)
            {
                salida = "No se actualizo: " + ex.ToString();
            }
            return salida;
        }

        public string editIntentos(int intentos,int id)
        {
            string salida = "Contraseña Incorrecta";
            try
            {
                cnn.Open();
                comandosql = new SqlCommand("Update USUARIO set [INTENTOS] = " + intentos + " where ID_EMPLEADO = " + id + " ", cnn);
                comandosql.ExecuteNonQuery();
                if(intentos == 3)
                {
                  comandosql = new SqlCommand("Update USUARIO set ESTADO = " + 7 + " where ID_EMPLEADO = " + id + " ", cnn);
                  comandosql.ExecuteNonQuery();
                }
                //comandosql.ExecuteNonQuery();
                cnn.Close();
            }
            catch (Exception ex)
            {
                salida = "No se actualizo: " + ex.ToString();
            }
            return salida;
        }



        public string Cambiarcontra(string clave, int id)
        {
            string salida = "Se actualizaron los datos";
            try
            {
                cnn.Open();
                comandosql = new SqlCommand("Update USUARIO set  CLAVE= '" + clave + "', Estado = " +5+" where ID_EMPLEADO = " + id + " ", cnn);
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
