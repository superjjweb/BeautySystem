using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeautySystem.View;

namespace BeautySystem.Controller
{
   public class CategoriaController
    {
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

    }
}
