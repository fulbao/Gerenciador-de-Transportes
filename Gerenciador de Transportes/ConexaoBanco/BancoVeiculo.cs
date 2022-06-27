using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Gerenciador_de_Transportes
{
    internal class BancoVeiculo
    {
        public static MySqlConnection Conexao;

        public static MySqlCommand Comando;

        public static void criarTabelaVeiculo()
        {
            Conexao = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");

            Conexao.Open();
     
            Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS gerenciadortransportes.veiculos" +
                                            "(id integer auto_increment primary key," +
                                            "placaCavalo char(40)," +
                                            "placaCarreta char(40)," +
                                            "placaCarretaDois char(40)," +
                                            "proprietario char(40)," +
                                            "motorista char(40)," +
                                            "motorista2 char(40)," +
                                            "motorista3 char(40)," +
                                            "motorista4 char(40)," +
                                            "motorista5 char(40)," +
                                            "motorista6 char(40)," +
                                            "motorista7 char(40)," +
                                            "motorista8 char(40)," +
                                            "motorista9 char(40)," +
                                            "motorista10 char(40)," +
                                            "motorista11 char(40)," +
                                            "motorista12 char(40)," +
                                            "usuario char(40)," +
                                            "deletado boolean)", Conexao);

            Comando.ExecuteNonQuery();

            Conexao.Close();
        }

        public static Boolean alterarItemVeiculos(string pPlacaCavalo, string pPlacaCarreta, string pPlacaCarretaSegunda, string pProprietario, string mMotorista, string placaCavalo, string placaCarreta, string placaCarretaSegunda, string proprietario, string motorista, string usuario)
        {
            try
            {
                Conexao = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");

                Conexao.Open();

                Comando = new MySqlCommand("UPDATE gerenciadortransportes.veiculos SET placaCavalo = '" + pPlacaCavalo + "' , placaCarreta = '" + pPlacaCarreta + "' , placaCarretaDois = '" + pPlacaCarretaSegunda + "' , proprietario = '" + pProprietario + "' , motorista = '" + mMotorista + "' , usuario = '" + usuario + "'  WHERE placaCavalo = '" + placaCavalo + "'" +
                                           " AND placaCarreta = '" + placaCarreta + "' AND placaCarretaDois = '" + placaCarretaSegunda + "' AND proprietario = '" + proprietario + "' AND motorista = '" + motorista + "';", Conexao);

                Comando.ExecuteNonQuery();

                Conexao.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static Boolean deletarItemVeiculos(string placaCavalo, string placaCarreta, string placaCarretaSegunda, string proprietario, string motorista)
        {
            try
            {
                Conexao = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");

                Conexao.Open();

                Comando = new MySqlCommand("UPDATE gerenciadortransportes.veiculos SET deletado = true WHERE placaCavalo = '" + placaCavalo + "'" +
                                           " AND placaCarreta = '" + placaCarreta + "' AND placaCarretaDois = '" + placaCarretaSegunda + "' AND proprietario = '" + proprietario + "' AND motorista = '" + motorista + "';", Conexao);

                Comando.ExecuteNonQuery();

                Conexao.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static Boolean adicionarVeiculos(string placaCavalo, string placaCarreta, string placaCarretaDois, string proprietario, string motorista, string usuario)
        {
            try
            {
                Conexao = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");

                Conexao.Open();

                Comando = new MySqlCommand("INSERT INTO gerenciadortransportes.veiculos(placaCavalo, placaCarreta, placaCarretaDois, proprietario, motorista, usuario, deletado)" +
                                           "VALUES('" + placaCavalo + "', '" + placaCarreta + "', '" + placaCarretaDois + "', '" + proprietario + "', '" + motorista + "', '" + usuario + "', false); ", Conexao);
                Comando.ExecuteNonQuery();

                Conexao.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static Boolean vincularMotorista(string placa, string motorista1, string motorista2, string motorista3, string motorista4, string motorista5, string motorista6, string motorista7, string motorista8, string motorista9, string motorista10, string motorista11, string motorista12, string usuario)
        {
            try
            {
                Conexao = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");

                Conexao.Open();

                Comando = new MySqlCommand("UPDATE gerenciadortransportes.veiculos SET motorista = '" + motorista1 + "' , motorista2 = '" + motorista2 + "' , motorista3 = '" + motorista3 + "' , motorista4 = '" + motorista4 + "' , motorista5 = '" + motorista5 + "' , motorista6 = '" + motorista6 + "' , motorista7 = '" + motorista7 + "' , motorista8 = '" + motorista8 + "' , motorista9 = '" + motorista9 + "' , motorista10 = '" + motorista10 + "' , motorista11 = '" + motorista11 + "' , motorista12 = '" + motorista12 + "' , usuario = '" + usuario + "'  WHERE placaCavalo = '" + placa + "';", Conexao);

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
