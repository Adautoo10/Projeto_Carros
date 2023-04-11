using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Carros.Model
{
    public class Carro
    {
        public static int ID { get; set; }

        public string Modelo { get; set; }
        public string cor { get; set; }
        public string Numero_chassi { get; set; }
        public string kilometragem { get; set; }
        public string obs { get; set; }

        public void Incluir()
        {
            try
            {

                Banco.Conexao.Open();
                Banco.Comando = new MySqlCommand
                    ("INSERT INTO carro (modelo, cor, numero_chassi, kilometragem) " +
                    "VALUES (@modelo, @cor, @numero_chassi, @kilometragem,@obs)", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@Modelo", Modelo);
                Banco.Comando.Parameters.AddWithValue("@cor", cor);
                Banco.Comando.Parameters.AddWithValue("@Numero_chassi", Numero_chassi);
                Banco.Comando.Parameters.AddWithValue("@kilometragem", kilometragem);
                Banco.Comando.Parameters.AddWithValue("@obs", obs);
                Banco.Comando.ExecuteNonQuery();
                Banco.Conexao.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }







    }
}



