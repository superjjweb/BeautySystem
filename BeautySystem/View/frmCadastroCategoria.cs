
using BeautySystem.Controller;
using BeautySystem.Model.DataModel;
using BeautySystem.Model.Repository;
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
    
    public partial class frmCadastroCategoria : Form
    {
        CategoriaController cc = new CategoriaController();
        CategoriaModel cm = new CategoriaModel();

        public frmCadastroCategoria()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            cm.NomeCat = txtNomeCat.Text;
            cc.SalvarCategoria(cm);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
