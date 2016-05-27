using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using BeautySystem.Model.DataModel;

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

        public void Gravar(CategoriaModel cm)
        {
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand objComando = new SqlCommand(strInsert, objConexao))
                {
                    
                    objComando.Parameters.AddWithValue("@nome_cat", cm.NomeCat);

                    objConexao.Open();

                    objComando.ExecuteNonQuery();

                    objConexao.Close();
                }
            } 
        }

        public void Atualizar(int cod_cat, string nome_cat)
        {
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand objComando = new SqlCommand(strUpdate, objConexao))
                {
                    objComando.Parameters.AddWithValue("@cod_cat", cod_cat);
                    objComando.Parameters.AddWithValue("@nome_cat", nome_cat);

                    objConexao.Open();

                    objComando.ExecuteNonQuery();

                    objConexao.Close();
                }
            }
        }

        public void Excluir(int cod_cat)
        {
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand objComando = new SqlCommand(strDelete, objConexao))
                {
                    objComando.Parameters.AddWithValue("@cod_cat", cod_cat);

                    objConexao.Open();

                    objComando.ExecuteNonQuery();

                    objConexao.Close();
                }
            }
        }

    }

}

