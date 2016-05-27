using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeautySystem.View;
using BeautySystem.Model.DataModel;
using BeautySystem.Model.Repository;
using System.Windows.Forms;

namespace BeautySystem.Controller
{
   public class CategoriaController
    {
        CategoriaRepository objDados = new CategoriaRepository();


        public void AbrirTelaPrincipal()
        {
            frmTelaPrincipal tp = new frmTelaPrincipal();
           
            tp.ShowDialog();
            tp.Dispose();
        }

        public void AbrirTelaCategoria()
        {
            
            frmCadastroCategoria cc = new frmCadastroCategoria();
            cc.ShowDialog();
            cc.Dispose();
        }



        public  void SalvarCategoria(CategoriaModel cm)
        {
            try
            {
               
                objDados.Gravar(cm);
               
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro" + erro.Message);
            }

        }

    }
}

