using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;

namespace SistemaVentas
{
    public partial class Form1 : Form
    {

        ConexionN cn= new ConexionN();
        public Form1()
        {
            InitializeComponent();
        }

        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToLongTimeString();
            lblfecha.Text = DateTime.Now.ToLongDateString();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            if (cn.conSQL(txtUsuario.Text) == 1)
            {
                MessageBox.Show("Usuario Encontrado");
            }
            else {
                MessageBox.Show("Usuario no Encontrado");
            }
        }
    }
}
