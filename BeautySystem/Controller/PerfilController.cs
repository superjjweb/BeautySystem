using BeautySystem.Model.DataModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySystem.Controller
{
    class PerfilController
    {
        public string strConexao = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        //Variaveis Constantes para instruзгo SQL

        public const string strDelete = "DELETE from perfil WHERE cod_perfil = @cod_perfil";
        public const string strInsert = "INSERT INTO perfil VALUES (@nome_perfil)";
        public const string strSelect = "SELECT * FROM perfil";
        public const string strUpdate = "UPDATE perfil SET nome_perfil = @nome_perfil";

        public void Gravar(PerfilModel cm)
        {
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand objComando = new SqlCommand(strInsert, objConexao))
                {

                    objComando.Parameters.AddWithValue("@nome_perfil", cm.NomePerfil);

                    objConexao.Open();

                    objComando.ExecuteNonQuery();

                    objConexao.Close();
                }
            }
        }

        public void Atualizar(int cod_perfil, string nome_perfil)
        {
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand objComando = new SqlCommand(strUpdate, objConexao))
                {
                    objComando.Parameters.AddWithValue("@cod_perfil", cod_perfil);
                    objComando.Parameters.AddWithValue("@nome_perfil", nome_perfil);

                    objConexao.Open();

                    objComando.ExecuteNonQuery();

                    objConexao.Close();
                }
            }
        }

        public void Excluir(int cod_perfil)
        {
            using (SqlConnection objConexao = new SqlConnection(strConexao))
            {
                using (SqlCommand objComando = new SqlCommand(strDelete, objConexao))
                {
                    objComando.Parameters.AddWithValue("@cod_perfil", cod_perfil);

                    objConexao.Open();

                    objComando.ExecuteNonQuery();

                    objConexao.Close();
                }
            }
        }
    }
}
