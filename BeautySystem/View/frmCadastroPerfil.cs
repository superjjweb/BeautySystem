using BeautySystem.Controller;
using BeautySystem.Model.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautySystem.View
{
    public partial class frmCadastroPerfil : Form

        //PerfilController cc = new PerfilController();
        //PerfilModel cm = new PerfilModel();
    {
        public frmCadastroPerfil()
        {
            InitializeComponent();
        }

        private void frmCadastroPerfil_Load(object sender, EventArgs e)
        {

        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            //dgvDadosPerfil.DataSource = ctrl.Localizar(txtPesquisaCat.Text);
        }
    }
}
