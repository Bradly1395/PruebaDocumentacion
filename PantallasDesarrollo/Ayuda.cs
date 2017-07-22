using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PantallasDesarrollo
{
    public partial class Ayuda : Form
    {
        public Ayuda()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Ayuda_Load(object sender, EventArgs e)
        {

        }

        private void op1a_Click(object sender, EventArgs e)
        {
            cajaHelp.Text = "Solo una cuenta de administrador\npuede acceder a asignar\nprivilegios y a activar o desactivar\ncuentas. En caso de que un usuario sea creado\nla primera vez debera de cambiar su contraseña.";
        }

        private void op1b_Click(object sender, EventArgs e)
        {
            cajaHelp.Text = "Al darle al boton imprimir solo se\nesperara su confirmacion para imprimir la factura seleccionada."; 
        }

        private void op2_Click(object sender, EventArgs e)
        {
            cajaHelp.Text = "Antes de imprimir asegurese\nde que los datos son congruentes\ncon los del cliente.\nAsegurese de asignarle los privilegios\nadecuados al usuario de acuerdo a su\npuesto.\nAl momento de desactivar un usuario asegurese\nde que los datos coinciden con los del empleado.";
            


        }

        private void op3_Click(object sender, EventArgs e)
        {
             cajaHelp.Text = "Si el programa se traba cierrelo\ny vuelva a abrirlo\nsi el problema persiste es posible que \neste mal instalado o que sea incompatible\ncon su sistema operativo.\nCuando hay un error al momento de\nimprimir es posible que la\nimpresora no esta conecctada al equipo\ndonde opera el sistema.";
        }
    }
}
