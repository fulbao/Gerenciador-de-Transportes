using Gerenciador_de_Transportes.Telas.Utilitarias;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Gerenciador_de_Transportes.ConexaoBanco.BancoSelects
{
    internal class BancoFilial
    {
        public static MySqlConnection Conexao;

        public static MySqlCommand Comando;

        public static void criarTabelaFilial()
        {
            Conexao = new MySqlConnection("server=localhost;uid=root;pwd=root");

            Conexao.Open();

            Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS gerenciadortransportes.filial" +
                                            "(id integer auto_increment primary key," +
                                            "nome char(40)," +
                                            "usuario char(40)," +
                                            "deletado boolean);", Conexao);

            Comando.ExecuteNonQuery();

            Conexao.Close();

            if (verificaFilial() == -1)
            {
                valoresPadrao();
            }
        }

        public static int verificaFilial()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd=root");
                MySqlCommand usuarioQuery = new MySqlCommand();
                MySqlDataReader readerUsuario;

                usuarioQuery.CommandText = "SELECT * FROM gerenciadortransportes.filial;";
                usuarioQuery.CommandType = CommandType.Text;
                usuarioQuery.Connection = conn;

                conn.Open();

                readerUsuario = usuarioQuery.ExecuteReader();


                if (!readerUsuario.HasRows) { return -1; }

                conn.Close();

                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static void valoresPadrao()
        {
            Conexao = new MySqlConnection("server=localhost;uid=root;pwd=root");

            Conexao.Open();

            Comando = new MySqlCommand("INSERT INTO gerenciadortransportes.filial(nome, usuario, deletado)" +
                                           "VALUES('TS', 'admin', false), ('STS', 'admin', false), ('TN MTZ', 'admin', false), ('TN PR', 'admin', false), ('TN SC', 'admin', false), ('TN SP', 'admin', false), ('TN GO', 'admin', false), ('TN MG', 'admin', false); ", Conexao);

            Comando.ExecuteNonQuery();

            Conexao.Close();
        }

        public static List<String> leFilial()
        {
            List<String> filial = new List<String>();

            try
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd=root");
                conn.Open();

                string query = "SELECT* FROM gerenciadortransportes.filial";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "table_name");
                DataTable dt = ds.Tables["table_name"];

                foreach (DataRow row in dt.Rows)
                {
                    bool deletado = (bool)row[3];

                    if (!deletado)
                    {
                        filial.Add((String)row[1]);
                    }
                }

                conn.Close();

                return filial;
            }
            catch (Exception)
            {
                ModalErro modal = new ModalErro("Erro!", "Erro ao buscar os embarcadores.");
                modal.ShowDialog();
                return filial;
            }
        }
    }
}
