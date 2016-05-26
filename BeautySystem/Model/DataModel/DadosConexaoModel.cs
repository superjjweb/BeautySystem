using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace BeautySystem.Model.DataModel
{
    public class DadosConexaoModel
    {
        public string strConexao = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        //Variaveis Constantes para instrução SQL

        public const string strDelete = "";
        public const string strInsert = "";
        public const string strSelect = "";
        public const string strUpdate = "";
    }

}
