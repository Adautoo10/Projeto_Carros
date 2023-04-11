using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projeto_Carros
{
    public class Banco
    {

        public static MySqlConnection Conexao;

        public static MySqlCommand Comando;

        public static MySqlDataAdapter Adaptador;

        public static DataTable datTabela;


        public static void AbrirConexao()
        {
            try
            {

                Conexao = new MySqlConnection("server=localhost;port=3307;uid=root;pwd=etecjau");

                Conexao.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void FecharConexao()
        {
            try
            {

                Conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void CriarBanco()
        {
            try
            {

                AbrirConexao();


                Comando = new MySqlCommand("CREATE DATABASE IF NOT EXISTS Cadastro; USE Cadastro", Conexao);


                Comando.ExecuteNonQuery();


                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS Carro " +
                                            "(id integer auto_increment primary key, " +
                                            "modelo varchar(100), " +
                                            "numero_chassi char(17)," +
                                            "kilometragem varchar(1000000000)," +
                                            "cor varchar(100))", Conexao);
                Comando.ExecuteNonQuery();



                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS Cadastro " +
                               "(id integer auto_increment primary key, " +
                               "marca varchar(100), " +
                               "combustivel varchar(1000), " +
                               "fabricante varchar(100), " +
                               "tipo varchar (100)", Conexao);
                Comando.ExecuteNonQuery();



                FecharConexao();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }



}
