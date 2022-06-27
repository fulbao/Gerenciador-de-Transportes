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
    internal class BancoEmbalagem
    {
        public static MySqlConnection Conexao;

        public static MySqlCommand Comando;

        public static void criarTabelaEmbalagem()
        {
            Conexao = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");

            Conexao.Open();

            Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS gerenciadortransportes.embalagem" +
                                            "(id integer auto_increment primary key," +
                                            "nome char(40)," +
                                            "usuario char(40)," +
                                            "deletado boolean);", Conexao);

            Comando.ExecuteNonQuery();

            Conexao.Close();

            if (verificaEmbalagem() == -1)
            {
                valoresPadrao();
            }
        }

        public static int verificaEmbalagem()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");
                MySqlCommand usuarioQuery = new MySqlCommand();
                MySqlDataReader readerUsuario;

                usuarioQuery.CommandText = "SELECT * FROM gerenciadortransportes.embalagem;";
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

            Comando = new MySqlCommand("INSERT INTO gerenciadortransportes.embalagem(nome, usuario, deletado)" +
                                           "VALUES('Pallet', 'admin', false), ('Saco', 'admin', false), ('Big Bag', 'admin', false); ", Conexao);

            Comando.ExecuteNonQuery();

            Conexao.Close();
        }

        public static List<String> leEmbalagem()
        {
            List<String> embalagem = new List<String>();

            try
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");
                conn.Open();

                string query = "SELECT* FROM gerenciadortransportes.embalagem";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "table_name");
                DataTable dt = ds.Tables["table_name"];

                foreach (DataRow row in dt.Rows)
                {
                    bool deletado = (bool)row[3];

                    if (!deletado)
                    {
                        embalagem.Add((String)row[1]);
                    }
                }

                conn.Close();

                return embalagem;
            }
            catch (Exception)
            {
                ModalErro modal = new ModalErro("Erro!", "Erro ao buscar os embalagem.");
                modal.ShowDialog();
                return embalagem;
            }
        }
    }
}
