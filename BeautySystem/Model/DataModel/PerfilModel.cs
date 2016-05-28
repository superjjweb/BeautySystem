using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySystem.Model.DataModel
{
    class PerfilModel
    {
        public PerfilModel()
        {
            CodPerfil = 0;
            NomePerfil = "";
        }

        public PerfilModel(int codperfil, String nomeperfil)
        {
            CodPerfil = codperfil;
            NomePerfil = nomeperfil;
        }

        private int cod_perfil;
        public int CodPerfil
        {
            get { return cod_perfil; }
            set { cod_perfil = value; }
        }

        public String nome_perfil;
        public String NomePerfil
        {
            get { return nome_perfil; }
            set { nome_perfil = value; }
        }
    }
}
