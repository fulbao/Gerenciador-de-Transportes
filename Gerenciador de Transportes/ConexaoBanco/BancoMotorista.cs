using Gerenciador_de_Transportes.Telas.Utilitarias;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Gerenciador_de_Transportes
{
    internal class BancoMotorista
    {
        public static MySqlConnection Conexao;

        public static MySqlCommand Comando;

        public static void criarTabelaMotorista()
        {
            Conexao = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");

            Conexao.Open();

            Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS gerenciadortransportes.motoristas" +
                                            "(id integer auto_increment primary key," +
                                            "nome char(40)," +
                                            "telefone char(40)," +
                                            "nomeEmergencia char(40)," +
                                            "telefoneEmergencia char(40)," +
                                            "usuario char(40)," +
                                            "deletado boolean)", Conexao);

            Comando.ExecuteNonQuery();

            Conexao.Close();
        }

        public static Boolean cadastrarMotorista(string usuario, MotoristaCs moto)
        {
            try
            {
                Conexao = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");

                Conexao.Open();

                Comando = new MySqlCommand("INSERT INTO gerenciadortransportes.motoristas(nome, telefone, nomeEmergencia, telefoneEmergencia, usuario, deletado)" +
                                           "VALUES('" + moto.Nome + "', '" + moto.NumeroTelefone + "', '" + moto.ContatoEmergencia + "', '" + moto.NumeroContatoEmergencia + "', '" + usuario + "', false); ", Conexao);

                Comando.ExecuteNonQuery();

                Conexao.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static int retornaId(string motorista, string telefone, string contatoEmergencia, string telefoneEmergencia) {
            try
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");
                conn.Open();

                string query = "SELECT * FROM gerenciadortransportes.motoristas where nome = '"+ motorista + "' AND telefone = '" + telefone + "' AND nomeEmergencia = '" + contatoEmergencia + "' AND telefoneEmergencia = '" + telefoneEmergencia + "';";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "table_name");
                DataTable dt = ds.Tables["table_name"];

                foreach (DataRow row in dt.Rows)
                {
                    bool deletado = (bool)row[6];

                    if (!deletado)
                    {
                        return (int)row[0];
                    }
                }
                return -1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public static List<MotoristaCs> leMotorista()
        {
            List<MotoristaCs> motoristas = new List<MotoristaCs>();

            try
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");
                conn.Open();

                string query = "SELECT* FROM gerenciadortransportes.motoristas order by nome";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "table_name");
                DataTable dt = ds.Tables["table_name"];

                foreach (DataRow row in dt.Rows)
                {
                    bool deletado = (bool)row[6];

                    if (!deletado)
                    {
                        motoristas.Add(new MotoristaCs((string)row[1], (string)row[2], (string)row[3], (string)row[4]));
                    }
                }

                conn.Close();

                return motoristas;
            }
            catch (Exception)
            {
                ModalErro modal = new ModalErro("Erro!", "Erro ao buscar os embarcadores.");
                modal.ShowDialog();
                return motoristas;
            }
        }

        public static Boolean editarMotorista (int id, string motorista, string telefone, string contatoEmergencia, string telefoneEmergencia)
        {
            try
            {
                Conexao = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");

                Conexao.Open();

                Comando = new MySqlCommand("UPDATE gerenciadortransportes.motoristas SET nome = '" + motorista + "', telefone = '" + telefone + "', nomeEmergencia = '" + contatoEmergencia + "', telefoneEmergencia = '" + telefoneEmergencia + "' WHERE id = '" + id.ToString() + "';", Conexao);

                Comando.ExecuteNonQuery();

                Conexao.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static Boolean deletarMotorista (int id)
        {
            try
            {
                Conexao = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");

                Conexao.Open();

                Comando = new MySqlCommand("UPDATE gerenciadortransportes.motoristas SET deletado = true WHERE id = '" + id.ToString() + "';", Conexao);

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
