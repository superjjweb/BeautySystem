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
        public frmCadastroCategoria()
        {
            InitializeComponent();
        }

            private void Gravar(string nome_cat)
        {
            try
            {
                CategoriaRepository objDados = new CategoriaRepository();
                objDados.Gravar(nome_cat);
            }
            catch(Exception erro)
            {
                MessageBox.Show("Ocorreu um erro" + erro.Message);
            }
            
        }
        

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Gravar(txtNomeCat.Text);
        }
    }
}
