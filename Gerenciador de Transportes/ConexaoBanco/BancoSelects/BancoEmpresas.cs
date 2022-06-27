using Gerenciador_de_Transportes.Telas.Utilitarias;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciador_de_Transportes.ConexaoBanco
{
    internal class BancoEmpresas
    {
        public static MySqlConnection Conexao;

        public static MySqlCommand Comando;

        public static void criarTabelaEmpresas()
        {
            Conexao = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");

            Conexao.Open();

            Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS gerenciadortransportes.empresas" +
                                            "(id integer auto_increment primary key," +
                                            "nome char(40)," +
                                            "usuario char(40)," +
                                            "deletado boolean);", Conexao);

            Comando.ExecuteNonQuery();

            Conexao.Close();

            if (verificaEmpresas() == -1)
            {
                valoresPadrao();
            }
        }

        public static int verificaEmpresas()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");
                MySqlCommand usuarioQuery = new MySqlCommand();
                MySqlDataReader readerUsuario;

                usuarioQuery.CommandText = "SELECT * FROM gerenciadortransportes.empresas;";
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
            Conexao = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");

            Conexao.Open();

            Comando = new MySqlCommand("INSERT INTO gerenciadortransportes.empresas(nome, usuario, deletado)" +
                                           "VALUES('Trans Navi', 'admin', false), ('Trans Scalcon', 'admin', false), ('STS', 'admin', false); ", Conexao);

            Comando.ExecuteNonQuery();

            Conexao.Close();
        }

        public static List<String> leEmpresas()
        {
            List<String> empresas = new List<String>();

            try
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");
                conn.Open();

                string query = "SELECT* FROM gerenciadortransportes.empresas";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "table_name");
                DataTable dt = ds.Tables["table_name"];

                foreach (DataRow row in dt.Rows)
                {
                    bool deletado = (bool)row[3];

                    if (!deletado)
                    {
                        empresas.Add((String) row[1]);
                    }
                }

                conn.Close();

                return empresas;
            }
            catch (Exception)
            {
                ModalErro modal = new ModalErro("Erro!", "Erro ao buscar os empresas.");
                modal.ShowDialog();
                return empresas;
            }
        }
    }
}
