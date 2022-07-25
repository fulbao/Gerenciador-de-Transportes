using Gerenciador_de_Transportes.Telas.Utilitarias;
using MySql.Data.MySqlClient;
using System;
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
                Conexao = new MySqlConnection("server=192.9.229.61;uid=root;pwd=root");

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
                Conexao = new MySqlConnection("server=192.9.229.61;uid=root;pwd=root");

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
                    Conexao = new MySqlConnection("server=192.9.229.61;uid=root;pwd=root");

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
                MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd=root");
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

                Conexao = new MySqlConnection("server=localhost;uid=root;pwd=root");

                Conexao.Open();

                Comando = new MySqlCommand("UPDATE gerenciadortransportes.pedido SET freteFiscal = '" + pintes[1] + "', icms = '" + pintes[2] + "', pedagio = '" + pintes[3] + "'  WHERE id = '" + (i + 1).ToString() + "';", Conexao);

                Comando.ExecuteNonQuery();

                Conexao.Close();*/


            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModalYN modal = new ModalYN("Teste", "Ai que delicia");
            modal.ShowDialog();

            Boolean retorno = modal.retorno;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModalAlerta modal = new ModalAlerta("Tituloooo", "evertuuuuuuu");
            modal.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ModalErro modal = new ModalErro("evertu", "burro");
            modal.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ModalSucesso modaluto = new ModalSucesso("lincon", "for each");
            modaluto.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UsuarioSelecionado modalUser = new UsuarioSelecionado("moriggi gay");
            modalUser.ShowDialog();
        }
    }
}
