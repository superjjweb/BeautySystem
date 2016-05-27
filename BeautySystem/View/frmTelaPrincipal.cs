using BeautySystem.Controller;
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
    public partial class frmTelaPrincipal : Form
    {
        public frmTelaPrincipal()
        {
            InitializeComponent();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            CategoriaController categoria = new CategoriaController();
            categoria.AbrirTelaCategoria();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            CategoriaController perfil = new CategoriaController();
            perfil.AbrirTelaPerfil();
        }
    }
}
