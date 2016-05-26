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
            frmTelaPrincipal frmCadastroPerfil = new frmTelaPrincipal();
            frmCadastroPerfil.ShowDialog();
            frmCadastroPerfil.Dispose();
        }

    }
}
