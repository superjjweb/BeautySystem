using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySystem.Model.DataModel
{
    public class CategoriaModel
    {

        public CategoriaModel()
        {
            CodCat = 0;
            NomeCat = "";
        }

        public CategoriaModel(int codcat, String nomecat)
        {
            CodCat = codcat;
            NomeCat = nomecat;
        }

        private int cod_cat;
        public int CodCat
        {
            get{return cod_cat;}
            set{cod_cat = value;}
        }

        public String nome_cat;
        public String NomeCat
        {
            get { return nome_cat; }
            set { nome_cat = value; }
        }
    }
    }

