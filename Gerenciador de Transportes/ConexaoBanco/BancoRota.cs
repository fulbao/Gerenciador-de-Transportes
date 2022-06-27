using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Gerenciador_de_Transportes
{
    internal class BancoRota
    {
        public static MySqlConnection Conexao;

        public static MySqlCommand Comando;

        public static void criarTabelaRota()
        {
            try
            {
                Conexao = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");

                Conexao.Open();

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS gerenciadortransportes.rotas" +
                                                "(id integer auto_increment primary key," +
                                                "rota char(40)," +
                                                "cidadeOrigem char(40)," +
                                                "estadoOrigem char(40)," +
                                                "cidadeDestino char(40)," +
                                                "estadoDestino char(40)," +
                                                "usuario char(40)," +
                                                "deletado boolean," +
                                                "destinatario char(40))", Conexao);

                Comando.ExecuteNonQuery();

                Conexao.Close();
            } catch (Exception ex) 
            { MessageBox.Show(ex.Message);
                MessageBox.Show("ex.Message");
            }
        }

        public static Boolean alterarItemRota(string rRota, string cCidadeOrigem, string eEstadoOrigem, string cCidadeDestino, string eEstadoDestino, string rota, string cidadeOrigem, string estadoOrigem, string cidadeDestino, string estadoDestino, string usuario)
        {
            try
            {
                Conexao = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");

                Conexao.Open();

                Comando = new MySqlCommand("UPDATE gerenciadortransportes.rotas SET rota = '" + rRota + "' , cidadeOrigem = '" + cCidadeOrigem + "' , estadoOrigem = '" + eEstadoOrigem + "' , cidadeDestino = '" + cCidadeDestino + "' , estadoDestino = '" + eEstadoDestino + "' , usuario = '" + usuario + "'  WHERE rota = '" + rota + "'" +
                                           " AND cidadeOrigem = '" + cidadeOrigem + "' AND estadoOrigem = '" + estadoOrigem + "' AND cidadeDestino = '" + cidadeDestino + "' AND estadoDestino = '" + estadoDestino + "';", Conexao);

                Comando.ExecuteNonQuery();

                Conexao.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static Boolean deletarItemRota(string rota, string cidadeOrigem, string estadoOrigem, string cidadeDestino, string estadoDestino)
        {
            try
            {
                Conexao = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");

                Conexao.Open();

                Comando = new MySqlCommand("UPDATE gerenciadortransportes.rotas SET deletado = true WHERE rota = '" + rota + "'" +
                                           " AND cidadeOrigem = '" + cidadeOrigem + "' AND estadoOrigem = '" + estadoOrigem + "' AND cidadeDestino = '" + cidadeDestino + "' AND estadoDestino = '" + estadoDestino + "';", Conexao);

                Comando.ExecuteNonQuery();

                Conexao.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static Boolean adicionarRota(string rota, string cidadeOrigem, string estadoOrigen, string cidadeDestino, string estadoDestino, string usuario)
        {
            try
            {
                Conexao = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");

                Conexao.Open();

                Comando = new MySqlCommand("INSERT INTO gerenciadortransportes.rotas(rota, cidadeOrigem, estadoOrigem, cidadeDestino, estadoDestino, usuario, deletado)" +
                                           "VALUES('" + rota + "', '" + cidadeOrigem + "', '" + estadoOrigen + "', '" + cidadeDestino + "', '" + estadoDestino + "', '" + usuario + "', false); ", Conexao);

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
