using BeautySystem.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeautySystem.Controller;

namespace BeautySystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            TelaPrincipalController telaprincipal = new TelaPrincipalController();
           telaprincipal.AbrirTelaPrincipal();
            Close();
        }
    }
}
