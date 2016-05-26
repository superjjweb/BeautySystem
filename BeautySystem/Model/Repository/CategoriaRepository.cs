using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace BeautySystem.Model.Repository
{
    public class CategoriaRepository
    {
        public string strConexao = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        //Variaveis Constantes para instrução SQL

        public const string strDelete = "DELETE from categoria WHERE cod_cat = @cod_cat";
        public const string strInsert = "INSERT INTO categoria VALUES (@nome_cat)";
        public const string strSelect = "SELECT * FROM categoria";
        public const string strUpdate = "UPDATE categoria SET nome_cat = @nome_cat";
    }

}

