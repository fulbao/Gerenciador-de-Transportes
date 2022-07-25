using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Gerenciador_de_Transportes
{
    public partial class Dashboard_3 : Form
    {
        public string contexto;

        public string empresaSelecionada;

        public int j = 0;

        public int w = 0;

        string[] rotasEstados = new string[1000000];

        string[] destinatarios = new string[10000];

        public Dashboard_3()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            InitializeComponent();
            Boolean retorno = buscaDestinario();
            sl_destinatario.Items.Add("Todas");

            for (int i = 0; i < w; i++)
            {
                sl_destinatario.Items.Add(destinatarios[i]);
            }

            sl_destinatario.SelectedIndex = 0;
        }

        private void Dashboard_3_Load(object sender, EventArgs e)
        {
            contexto = "embarqueTodos";
            empresaSelecionada = "Todas";
            sl_contexto.SelectedIndex = 0;
            gerarGraficoEstados();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;
                return handleParam;
            }
        }

        public bool buscaDadosEmbaquesPorEstado()
        {
            j = 0;
            try
            {
                for (int i = 0; i > -1; i++)
                {
                    string deletado;
                    MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd=root");
                    MySqlCommand usuarioQuery = new MySqlCommand();
                    MySqlDataReader readerUsuario;

                    usuarioQuery.CommandText = "SELECT * FROM gerenciadortransportes." + contexto + " WHERE id = " + (i + 1).ToString();
                    usuarioQuery.CommandType = CommandType.Text;
                    usuarioQuery.Connection = conn;

                    conn.Open();

                    readerUsuario = usuarioQuery.ExecuteReader();
                    readerUsuario.Read();


                    if (!readerUsuario.HasRows)
                    {
                        return true;
                    }

                    deletado = readerUsuario.GetString(41);

                    if (deletado == "False")
                    {
                        string possivel = readerUsuario.GetString(33).ToLower();
                        empresaSelecionada = empresaSelecionada.ToLower();

                        if ((empresaSelecionada.Contains(possivel)) || (empresaSelecionada == "todas"))
                        {
                            string embarque = readerUsuario.GetString(5).ToUpper();
                            string destino = readerUsuario.GetString(7).ToUpper();

                            switch (embarque)
                            {
                                case "ACRE": embarque = "AC"; break;
                                case "ALAGOAS": embarque = "AL"; break;
                                case "AMAPÁ": embarque = "AP"; break;
                                case "AMAZONAS": embarque = "AM"; break;
                                case "BAHIA": embarque = "BA"; break;
                                case "CEARÁ": embarque = "CE"; break;
                                case "DISTRITO FEDERAL": embarque = "DF"; break;
                                case "ESPÍRITO SANTO": embarque = "ES"; break;
                                case "GOIÁS": embarque = "GO"; break;
                                case "MARANHÃO": embarque = "MA"; break;
                                case "MATO GROSSO": embarque = "MT"; break;
                                case "MATO GROSSO DO SUL": embarque = "MS"; break;
                                case "MINAS GERAIS": embarque = "MG"; break;
                                case "PARÁ": embarque = "PA"; break;
                                case "PARAÍBA": embarque = "PB"; break;
                                case "PARANÁ": embarque = "PR"; break;
                                case "PERNANBUCO": embarque = "PE"; break;
                                case "PIAUÍ": embarque = "PI"; break;
                                case "RIO DE JANEIRO": embarque = "RJ"; break;
                                case "RIO GRANDE DO NORTE": embarque = "RN"; break;
                                case "RIO GRANDE DO SUL": embarque = "RS"; break;
                                case "RONDÔNIA": embarque = "RO"; break;
                                case "RORAIMA": embarque = "RR"; break;
                                case "SANTA CATARINA": embarque = "SC"; break;
                                case "SÃO PAULO": embarque = "SP"; break;
                                case "SERGIPE": embarque = "SE"; break;
                                case "TOCANTINS": embarque = "TO"; break;
                            }

                            switch (destino)
                            {
                                case "ACRE": destino = "AC"; break;
                                case "ALAGOAS": destino = "AL"; break;
                                case "AMAPÁ": destino = "AP"; break;
                                case "AMAZONAS": destino = "AM"; break;
                                case "BAHIA": destino = "BA"; break;
                                case "CEARÁ": destino = "CE"; break;
                                case "DISTRITO FEDERAL": destino = "DF"; break;
                                case "ESPÍRITO SANTO": destino = "ES"; break;
                                case "GOIÁS": destino = "GO"; break;
                                case "MARANHÃO": destino = "MA"; break;
                                case "MATO GROSSO": destino = "MT"; break;
                                case "MATO GROSSO DO SUL": destino = "MS"; break;
                                case "MINAS GERAIS": destino = "MG"; break;
                                case "PARÁ": destino = "PA"; break;
                                case "PARAÍBA": destino = "PB"; break;
                                case "PARANÁ": destino = "PR"; break;
                                case "PERNANBUCO": destino = "PE"; break;
                                case "PIAUÍ": destino = "PI"; break;
                                case "RIO DE JANEIRO": destino = "RJ"; break;
                                case "RIO GRANDE DO NORTE": destino = "RN"; break;
                                case "RIO GRANDE DO SUL": destino = "RS"; break;
                                case "RONDÔNIA": destino = "RO"; break;
                                case "RORAIMA": destino = "RR"; break;
                                case "SANTA CATARINA": destino = "SC"; break;
                                case "SÃO PAULO": destino = "SP"; break;
                                case "SERGIPE": destino = "SE"; break;
                                case "TOCANTINS": destino = "TO"; break;
                            }

                            rotasEstados[j] = embarque + " X " + destino;

                            j++;
                        }
                    }

                    conn.Close();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool buscaDestinario()
        {
            j = 0;
            try
            {
                for (int i = 0; i > -1; i++)
                {
                    string deletado;
                    MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd=root");
                    MySqlCommand usuarioQuery = new MySqlCommand();
                    MySqlDataReader readerUsuario;

                    usuarioQuery.CommandText = "SELECT * FROM gerenciadortransportes.embarcadores WHERE id = " + (i + 1).ToString();
                    usuarioQuery.CommandType = CommandType.Text;
                    usuarioQuery.Connection = conn;

                    conn.Open();

                    readerUsuario = usuarioQuery.ExecuteReader();
                    readerUsuario.Read();


                    if (!readerUsuario.HasRows)
                    {
                        return true;
                    }

                    deletado = readerUsuario.GetString(3);

                    if (deletado == "False")
                    {
                        string destina = readerUsuario.GetString(4);
                        if (destina != "")
                        {
                            if ((destina.First() == ' ') && (destina.Length > 1))
                            {
                                destinatarios[w] = destina.Remove(0, 1);
                                w++;
                            }
                            else
                            {
                                destinatarios[w] = destina;
                                w++;
                            }
                        }
                    }

                    conn.Close();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void gerarGraficoEstados()
        {
            string[] classificaRotasEstados = new string[300];
            int[] numeroRotasEstados = new int[300];
            int z = 0;
            bool retorno = buscaDadosEmbaquesPorEstado();
            z++;
            Boolean repetido;
            int k;
            classificaRotasEstados[0] = rotasEstados[0];
            numeroRotasEstados[0] = 0;
            for (int i = 1; i <= j; i++)
            {
                repetido = false;
                for (k = 0; k < z; k++)
                {
                    if (classificaRotasEstados[k] == rotasEstados[i])
                    {
                        repetido = true;
                        numeroRotasEstados[k]++;
                        k = z;
                    }
                }
                if (!repetido)
                {
                    classificaRotasEstados[z] = rotasEstados[i];
                    numeroRotasEstados[z]++;
                    z++;
                }
            }

            embarquesPorEstado.Series.Add("Estados de Origem");
            embarquesPorEstado.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            embarquesPorEstado.Series[0].Points.DataBindXY(classificaRotasEstados, numeroRotasEstados);
            embarquesPorEstado.Legends.Add("MyLegend");
            embarquesPorEstado.Legends[0].LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Table;
            embarquesPorEstado.Legends[0].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            embarquesPorEstado.Legends[0].Alignment = StringAlignment.Center;
            embarquesPorEstado.Legends[0].BorderColor = Color.Black;
            embarquesPorEstado.Titles.Add("Origen X Destino");

            embarquesPorEstado.Series[0].IsValueShownAsLabel = true;
            embarquesPorEstado.Series[0].IsVisibleInLegend = true;
        }

        public void atualizaGraficos()
        {
            atualizaGraficoEstados();
        }

        public void atualizaGraficoEstados()
        {
            string[] classificaRotasEstados = new string[300];
            int[] numeroRotasEstados = new int[300];
            int z = 0;
            bool retorno = buscaDadosEmbaquesPorEstado();
            z++;
            Boolean repetido;
            int k;
            classificaRotasEstados[0] = rotasEstados[0];
            numeroRotasEstados[0] = 1;
            for (int i = 1; i <= j; i++)
            {
                repetido = false;
                for (k = 0; k < z; k++)
                {
                    if (classificaRotasEstados[k] == rotasEstados[i])
                    {
                        repetido = true;
                        numeroRotasEstados[k]++;
                        k = z;
                    }
                }
                if (!repetido)
                {
                    classificaRotasEstados[z] = rotasEstados[i];
                    numeroRotasEstados[z]++;
                    z++;
                }
            }

            embarquesPorEstado.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            embarquesPorEstado.Series[0].Points.DataBindXY(classificaRotasEstados, numeroRotasEstados); ;
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            Dashboard_2 dashboard = new Dashboard_2();
            dashboard.Show();
            this.Close();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            empresaSelecionada = sl_destinatario.Text;
            if (sl_contexto.SelectedIndex == 0)
            {
                contexto = "embarquetodos";
            }
            if (sl_contexto.SelectedIndex == 1)
            {
                contexto = "embarqueGloria";
            }
            if (sl_contexto.SelectedIndex == 2)
            {
                contexto = "embarqueParanavai";
            }
            if (sl_contexto.SelectedIndex == 3)
            {
                contexto = "embarqueToledo";
            }
            if (sl_contexto.SelectedIndex == 4)
            {
                contexto = "embarquerioverde";
            }

            atualizaGraficos();
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
