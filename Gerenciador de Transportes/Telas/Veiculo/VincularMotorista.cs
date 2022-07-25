using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Gerenciador_de_Transportes
{
    public partial class Motoristas : Form
    {
        string placa;

        string usuarioLogado;

        string[] itens = new string[12];

        public Motoristas(string placa, string usuario)
        {
            InitializeComponent();
            usuarioLogado = usuario;
            this.placa = placa;
            Boolean semUso = leMotoristas();
            tb_moto1.Text = itens[0];
            tb_moto2.Text = itens[1];
            tb_moto3.Text = itens[2];
            tb_moto4.Text = itens[3];
            tb_moto5.Text = itens[4];
            tb_moto6.Text = itens[5];
            tb_moto7.Text = itens[6];
            tb_moto8.Text = itens[7];
            tb_moto9.Text = itens[8];
            tb_moto10.Text = itens[9];
            tb_moto11.Text = itens[10];
            tb_moto12.Text = itens[11];

            if (tb_moto1.Text != "")
            {
                tb_moto1.Enabled = false;
            }
            if (tb_moto2.Text != "")
            {
                tb_moto2.Enabled = false;
            }
            if (tb_moto3.Text != "")
            {
                tb_moto3.Enabled = false;
            }
            if (tb_moto4.Text != "")
            {
                tb_moto4.Enabled = false;
            }
            if (tb_moto5.Text != "")
            {
                tb_moto5.Enabled = false;
            }
            if (tb_moto6.Text != "")
            {
                tb_moto6.Enabled = false;
            }
            if (tb_moto7.Text != "")
            {
                tb_moto7.Enabled = false;
            }
            if (tb_moto8.Text != "")
            {
                tb_moto8.Enabled = false;
            }
            if (tb_moto9.Text != "")
            {
                tb_moto9.Enabled = false;
            }
            if (tb_moto10.Text != "")
            {
                tb_moto10.Enabled = false;
            }
            if (tb_moto11.Text != "")
            {
                tb_moto11.Enabled = false;
            }
            if (tb_moto12.Text != "")
            {
                tb_moto12.Enabled = false;
            }

        }

        public bool leMotoristas()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd=root");
                MySqlCommand usuarioQuery = new MySqlCommand();
                MySqlDataReader readerUsuario;

                usuarioQuery.CommandText = "SELECT * FROM gerenciadortransportes.veiculos WHERE placaCavalo = '" + placa + "'";
                usuarioQuery.CommandType = CommandType.Text;
                usuarioQuery.Connection = conn;

                conn.Open();

                readerUsuario = usuarioQuery.ExecuteReader();
                if (!readerUsuario.HasRows) { return true; }
                readerUsuario.Read();

                itens[0] = readerUsuario.GetString(5);

                itens[1] = readerUsuario.GetString(6);

                itens[2] = readerUsuario.GetString(7);

                itens[3] = readerUsuario.GetString(8);

                itens[4] = readerUsuario.GetString(9);

                itens[5] = readerUsuario.GetString(10);

                itens[6] = readerUsuario.GetString(11);

                itens[7] = readerUsuario.GetString(12);

                itens[8] = readerUsuario.GetString(13);

                itens[9] = readerUsuario.GetString(14);

                itens[10] = readerUsuario.GetString(15);

                itens[11] = readerUsuario.GetString(16);

                conn.Close();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void cb_moto1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_moto1.Checked)
            {
                tb_moto1.Enabled = true;
            }
            else { tb_moto1.Enabled = false; }
        }

        private void cb_moto2_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_moto2.Checked)
            {
                tb_moto2.Enabled = true;
            }
            else { tb_moto2.Enabled = false; }
        }

        private void cb_moto3_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_moto3.Checked)
            {
                tb_moto3.Enabled = true;
            }
            else { tb_moto3.Enabled = false; }
        }

        private void cb_moto4_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_moto4.Checked)
            {
                tb_moto4.Enabled = true;
            }
            else { tb_moto4.Enabled = false; }
        }

        private void cb_moto5_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_moto5.Checked)
            {
                tb_moto5.Enabled = true;
            }
            else { tb_moto5.Enabled = false; }
        }

        private void cb_moto6_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_moto6.Checked)
            {
                tb_moto6.Enabled = true;
            }
            else { tb_moto6.Enabled = false; }
        }

        private void cb_moto7_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_moto7.Checked)
            {
                tb_moto7.Enabled = true;
            }
            else { tb_moto7.Enabled = false; }
        }

        private void cb_moto8_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_moto8.Checked)
            {
                tb_moto8.Enabled = true;
            }
            else { tb_moto8.Enabled = false; }
        }

        private void cb_moto9_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_moto9.Checked)
            {
                tb_moto9.Enabled = true;
            }
            else { tb_moto9.Enabled = false; }
        }

        private void cb_moto10_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_moto10.Checked)
            {
                tb_moto10.Enabled = true;
            }
            else { tb_moto10.Enabled = false; }
        }

        private void cb_moto11_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_moto11.Checked)
            {
                tb_moto11.Enabled = true;
            }
            else { tb_moto11.Enabled = false; }
        }

        private void cb_moto12_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_moto12.Checked)
            {
                tb_moto12.Enabled = true;
            }
            else { tb_moto12.Enabled = false; }
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            BancoVeiculo.vincularMotorista(placa, tb_moto1.Text, tb_moto2.Text, tb_moto3.Text, tb_moto4.Text, tb_moto5.Text, tb_moto6.Text, tb_moto7.Text, tb_moto8.Text, tb_moto9.Text, tb_moto10.Text, tb_moto11.Text, tb_moto12.Text, usuarioLogado);
            Boolean semUso = leMotoristas();
            tb_moto1.Text = itens[0];
            tb_moto2.Text = itens[1];
            tb_moto3.Text = itens[2];
            tb_moto4.Text = itens[3];
            tb_moto5.Text = itens[4];
            tb_moto6.Text = itens[5];
            tb_moto7.Text = itens[6];
            tb_moto8.Text = itens[7];
            tb_moto9.Text = itens[8];
            tb_moto10.Text = itens[9];
            tb_moto11.Text = itens[10];
            tb_moto12.Text = itens[11];

            tb_moto1.Enabled = true;
            tb_moto2.Enabled = true;
            tb_moto3.Enabled = true;
            tb_moto4.Enabled = true;
            tb_moto5.Enabled = true;
            tb_moto6.Enabled = true;
            tb_moto7.Enabled = true;
            tb_moto8.Enabled = true;
            tb_moto9.Enabled = true;
            tb_moto10.Enabled = true;
            tb_moto11.Enabled = true;
            tb_moto12.Enabled = true;

            if (tb_moto1.Text != "")
            {
                tb_moto1.Enabled = false;
            }
            if (tb_moto2.Text != "")
            {
                tb_moto2.Enabled = false;
            }
            if (tb_moto3.Text != "")
            {
                tb_moto3.Enabled = false;
            }
            if (tb_moto4.Text != "")
            {
                tb_moto4.Enabled = false;
            }
            if (tb_moto5.Text != "")
            {
                tb_moto5.Enabled = false;
            }
            if (tb_moto6.Text != "")
            {
                tb_moto6.Enabled = false;
            }
            if (tb_moto7.Text != "")
            {
                tb_moto7.Enabled = false;
            }
            if (tb_moto8.Text != "")
            {
                tb_moto8.Enabled = false;
            }
            if (tb_moto9.Text != "")
            {
                tb_moto9.Enabled = false;
            }
            if (tb_moto10.Text != "")
            {
                tb_moto10.Enabled = false;
            }
            if (tb_moto11.Text != "")
            {
                tb_moto11.Enabled = false;
            }
            if (tb_moto12.Text != "")
            {
                tb_moto12.Enabled = false;
            }
            desativaCheckBox();
        }

        public void desativaCheckBox()
        {
            cb_moto1.Checked = false;
            cb_moto2.Checked = false;
            cb_moto3.Checked = false;
            cb_moto4.Checked = false;
            cb_moto5.Checked = false;
            cb_moto6.Checked = false;
            cb_moto7.Checked = false;
            cb_moto8.Checked = false;
            cb_moto9.Checked = false;
            cb_moto10.Checked = false;
            cb_moto11.Checked = false;
            cb_moto12.Checked = false;
        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            if (cb_moto1.Checked)
            {
                tb_moto1.Text = "";
            }
            if (cb_moto2.Checked)
            {
                tb_moto2.Text = "";
            }
            if (cb_moto3.Checked)
            {
                tb_moto3.Text = "";
            }
            if (cb_moto4.Checked)
            {
                tb_moto4.Text = "";
            }
            if (cb_moto5.Checked)
            {
                tb_moto5.Text = "";
            }
            if (cb_moto6.Checked)
            {
                tb_moto6.Text = "";
            }
            if (cb_moto7.Checked)
            {
                tb_moto7.Text = "";
            }
            if (cb_moto8.Checked)
            {
                tb_moto8.Text = "";
            }
            if (cb_moto9.Checked)
            {
                tb_moto9.Text = "";
            }
            if (cb_moto10.Checked)
            {
                tb_moto10.Text = "";
            }
            if (cb_moto11.Checked)
            {
                tb_moto11.Text = "";
            }
            if (cb_moto12.Checked)
            {
                tb_moto12.Text = "";
            }
            BancoVeiculo.vincularMotorista(placa, tb_moto1.Text, tb_moto2.Text, tb_moto3.Text, tb_moto4.Text, tb_moto5.Text, tb_moto6.Text, tb_moto7.Text, tb_moto8.Text, tb_moto9.Text, tb_moto10.Text, tb_moto11.Text, tb_moto12.Text, usuarioLogado);
            Boolean semUso = leMotoristas();
            tb_moto1.Text = itens[0];
            tb_moto2.Text = itens[1];
            tb_moto3.Text = itens[2];
            tb_moto4.Text = itens[3];
            tb_moto5.Text = itens[4];
            tb_moto6.Text = itens[5];
            tb_moto7.Text = itens[6];
            tb_moto8.Text = itens[7];
            tb_moto9.Text = itens[8];
            tb_moto10.Text = itens[9];
            tb_moto11.Text = itens[10];
            tb_moto12.Text = itens[11];

            tb_moto1.Enabled = true;
            tb_moto2.Enabled = true;
            tb_moto3.Enabled = true;
            tb_moto4.Enabled = true;
            tb_moto5.Enabled = true;
            tb_moto6.Enabled = true;
            tb_moto7.Enabled = true;
            tb_moto8.Enabled = true;
            tb_moto9.Enabled = true;
            tb_moto10.Enabled = true;
            tb_moto11.Enabled = true;
            tb_moto12.Enabled = true;

            if (tb_moto1.Text != "")
            {
                tb_moto1.Enabled = false;
            }
            if (tb_moto2.Text != "")
            {
                tb_moto2.Enabled = false;
            }
            if (tb_moto3.Text != "")
            {
                tb_moto3.Enabled = false;
            }
            if (tb_moto4.Text != "")
            {
                tb_moto4.Enabled = false;
            }
            if (tb_moto5.Text != "")
            {
                tb_moto5.Enabled = false;
            }
            if (tb_moto6.Text != "")
            {
                tb_moto6.Enabled = false;
            }
            if (tb_moto7.Text != "")
            {
                tb_moto7.Enabled = false;
            }
            if (tb_moto8.Text != "")
            {
                tb_moto8.Enabled = false;
            }
            if (tb_moto9.Text != "")
            {
                tb_moto9.Enabled = false;
            }
            if (tb_moto10.Text != "")
            {
                tb_moto10.Enabled = false;
            }
            if (tb_moto11.Text != "")
            {
                tb_moto11.Enabled = false;
            }
            if (tb_moto12.Text != "")
            {
                tb_moto12.Enabled = false;
            }
            desativaCheckBox();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Maximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }
    }
}
