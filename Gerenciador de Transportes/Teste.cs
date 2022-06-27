using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciador_de_Transportes
{
    public partial class Teste : Form
    {
        public static MySqlConnection Conexao;

        public static MySqlCommand Comando;
        public Teste()
        {
            InitializeComponent();
            tb_dataDois.Format = DateTimePickerFormat.Custom;
            tb_dataDois.CustomFormat = " ";
        }
        private void btn_acao_Click(object sender, EventArgs e)
        {
            string oi = tb_teste.Text.ToLower();
            if (oi.Contains("brf"))
            {
                MessageBox.Show("YUP");
            }


        }

        private void tb_dataDois_ValueChanged(object sender, EventArgs e)
        {
            tb_dataDois.Format = DateTimePickerFormat.Short;
        }

        private void btn_drop_Click(object sender, EventArgs e)
        {
            /*drop banco veiculos
             * try
            {
                Conexao = new MySqlConnection("server=localhost;uid=root;pwd=root");

                Conexao.Open();

                Comando = new MySqlCommand("use gerenciadortransportes;DROP TABLE veiculos;", Conexao);

                Comando.ExecuteNonQuery();

                Conexao.Close();
            }
            catch (Exception ex)
            {
            }
            try
            {
                Conexao = new MySqlConnection("server=localhost;uid=root;pwd=root");

                Conexao.Open();

                Comando = new MySqlCommand("use gerenciadortransportes;ALTER TABLE embarcadores ADD destinatario char(40)", Conexao);

                Comando.ExecuteNonQuery();

                Conexao.Close();
            }
            catch (Exception ex)
            {
            }
            try
            {
                for (int i = 0; i < 100; i++)
                {
                    Conexao = new MySqlConnection("server=localhost;uid=root;pwd=root");

                    Conexao.Open();

                    Comando = new MySqlCommand("UPDATE gerenciadortransportes.embarcadores SET destinatario = ' '  WHERE id = " + (i + 1).ToString(), Conexao);

                    Comando.ExecuteNonQuery();

                    Conexao.Close();
                }
            }
            catch (Exception ex)
            {
            }
            for (int i = 0; i > -1; i++)
            {
                string[] itens = new string[4];
                string[] pintes = new string[4];
                MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");
                MySqlCommand usuarioQuery = new MySqlCommand();
                MySqlDataReader readerUsuario;

                usuarioQuery.CommandText = "SELECT * FROM gerenciadortransportes.pedido WHERE id = " + (i + 1).ToString();
                usuarioQuery.CommandType = CommandType.Text;
                usuarioQuery.Connection = conn;

                conn.Open();

                readerUsuario = usuarioQuery.ExecuteReader();
                if (!readerUsuario.HasRows) { break; }
                readerUsuario.Read();


                itens[1] = readerUsuario.GetString(3);

                itens[2] = readerUsuario.GetString(4);

                itens[3] = readerUsuario.GetString(5);


                conn.Close();

                pintes[1] = itens[1].Trim('.');
                pintes[2] = itens[2].Trim('.');
                pintes[3] = itens[3].Trim('.');

                Conexao = new MySqlConnection("server=localhost;uid=root;pwd=s4FGn95");

                Conexao.Open();

                Comando = new MySqlCommand("UPDATE gerenciadortransportes.pedido SET freteFiscal = '" + pintes[1] + "', icms = '" + pintes[2] + "', pedagio = '" + pintes[3] + "'  WHERE id = '" + (i + 1).ToString() + "';", Conexao);

                Comando.ExecuteNonQuery();

                Conexao.Close();*/


        //}
    }

        private void Teste_Load(object sender, EventArgs e)
        {

        }
    }
}
