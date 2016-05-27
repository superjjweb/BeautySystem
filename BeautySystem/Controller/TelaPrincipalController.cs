using BeautySystem.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySystem.Controller
{
    class TelaPrincipalController
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

        public void AbrirTelaPerfil()
        {

            frmCadastroPerfil cp = new frmCadastroPerfil();
            cp.ShowDialog();
            cp.Dispose();
        }
    }
}
