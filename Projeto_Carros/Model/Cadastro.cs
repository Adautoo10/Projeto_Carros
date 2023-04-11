using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Carros.Model
{
    public class Cadastro
    {
        public int ID { get; set; }
        public string Combustivel { get; set; }
        public string Marca { get; set; }
        public string Fabricante { get; set; }
        public string Tipo { get; set; }


        public void Incluir()
        {
            try
            {
                Banco.AbrirConexao();
                Banco.Comando = new MySqlCommand("INSERT INTO cadastro ( @marca,@combustivel,@fabricante,@tipo) VALUES (@marca,@combustivel,@fabricante,@tipo)", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@Marca", Marca);
                Banco.Comando.Parameters.AddWithValue("@Fabricante", Fabricante);
                Banco.Comando.Parameters.AddWithValue("@Tipo", Tipo);
                Banco.Comando.Parameters.AddWithValue("@Combustivel", Combustivel);

                Banco.Comando.ExecuteNonQuery();

                Banco.FecharConexao();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}



