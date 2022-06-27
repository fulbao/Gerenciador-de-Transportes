using Gerenciador_de_Transportes.Telas.Utilitarias;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Gerenciador_de_Transportes
{
    internal class BancoEmbarcador
    {
        public static MySqlConnection Conexao;

        public static MySqlCommand Comando;

        public static void criarTabelaEmbarcador()
        {
            Conexao = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");

            Conexao.Open();

            Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS gerenciadortransportes.embarcadores" +
                                            "(id integer auto_increment primary key," +
                                            "nome char(40)," +
                                            "usuario char(40)," +
                                            "deletado boolean," +
                                            "destinatario char(40))", Conexao);

            Comando.ExecuteNonQuery();

            Conexao.Close();
        }

        public static List<EmbarcadoresCs> leEmbarcadores()
        {
            List<EmbarcadoresCs> embarcadores = new List<EmbarcadoresCs>();

            try
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");
                conn.Open();

                string query = "SELECT* FROM gerenciadortransportes.embarcadores order by nome";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "table_name");
                DataTable dt = ds.Tables["table_name"];

                foreach (DataRow row in dt.Rows)
                {
                    bool deletado = (bool)row[3];

                    if (!deletado)
                    {
                        embarcadores.Add(new EmbarcadoresCs((string)row[1], (string)row[4]));
                    }
                }

                conn.Close();

                return embarcadores;
            }
            catch (Exception)
            {
                ModalErro modal = new ModalErro("Erro!", "Erro ao buscar os embarcadores.");
                modal.ShowDialog();
                return embarcadores;
            }
        }

        public static Boolean alterarItemEmbarcadores(string embarcador, string eembarcador, string destinatario, string ddestinatario)
        {
            try
            {
                Conexao = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");

                Conexao.Open();

                Comando = new MySqlCommand("UPDATE gerenciadortransportes.embarcadores SET nome = '" + embarcador + "', destinatario = '" + destinatario + "'  WHERE nome = '" + eembarcador + "' AND destinatario = '" + ddestinatario + "';", Conexao);

                Comando.ExecuteNonQuery();

                Conexao.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static Boolean deletarItemEmbarcadores(string eembarcador, string destinatario)
        {
            try
            {
                Conexao = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");

                Conexao.Open();

                Comando = new MySqlCommand("UPDATE gerenciadortransportes.embarcadores SET deletado = true WHERE nome = '" + eembarcador + "' AND destinatario = '" + destinatario + "';", Conexao);

                Comando.ExecuteNonQuery();

                Conexao.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static Boolean adicionarEmbarcador(string nome, string usuario, string destinatario)
        {
            try
            {
                Conexao = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");

                Conexao.Open();

                Comando = new MySqlCommand("INSERT INTO gerenciadortransportes.embarcadores(nome, usuario, deletado, destinatario)" +
                                           "VALUES('" + nome + "', '" + usuario + "', false, '" + destinatario + "'); ", Conexao);

                Comando.ExecuteNonQuery();

                Conexao.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
