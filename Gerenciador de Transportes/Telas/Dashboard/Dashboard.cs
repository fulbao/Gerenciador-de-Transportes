using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Gerenciador_de_Transportes
{
    public partial class Dashboard : Form
    {
        string[] estadoDestino = new string[10000];

        string[] classificaEstadoDestino = new string[27];

        string[] estadoOrigem = new string[10000];

        string[] classificaEstadOrigem = new string[27];

        int[] numeroEstadoDestino = new int[27];

        int[] numeroEstadoOrigem = new int[27];

        int j;

        string[] nomeEmbarques = new string[4];

        int[] numeroEmbarques = new int[4];

        string dataInicio;

        string dataFinal;

        int numeroEmbarquesPrevisao;

        int numeroEmbarquesForaPrevisao;

        int numeroEmbarquesNaoFinalizado;

        int numeroEmbarquesPrevisaoDestino;

        int numeroEmbarquesForaPrevisaoDestino;

        int numeroEmbarquesNaoFinalizadoDestino;

        string contexto;

        public Dashboard()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            contexto = "embarquetodos";
            nomeEmbarques[0] = "Glória de Dourados";
            nomeEmbarques[1] = "Toledo";
            nomeEmbarques[2] = "Rio Verde";
            nomeEmbarques[3] = "Paranavaí";
            gerarGraficoEmbarques();
            gerarGraficoEstadoDestino();
            gerarGraficoEstadoOrigem();
            btn_buscar.Focus();
            dataFinal = "31/12/2099";
            dataInicio = "01/01/2001";
            geraGraficoPontualidade();
            geraGraficoPontualidadeDestino();
            geraGraficoPontualidadeGeral();
            cb_fim.Checked = true;
            cb_inicio.Checked = true;
            tb_dataInicio.Enabled = false;
            tb_dataFinal.Enabled = false;
            sl_contexto.SelectedIndex = 0;
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

        public Boolean pegarValoresEmbarque()
        {
            numeroEmbarquesPrevisao = 0;
            numeroEmbarquesForaPrevisao = 0;
            numeroEmbarquesNaoFinalizado = 0;
            string dataPrevisaoEmbarque;
            string dataEmbarque;
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
                        dataPrevisaoEmbarque = readerUsuario.GetString(9);
                        dataEmbarque = readerUsuario.GetString(10);

                        if (dataEmbarque != "")
                        {
                            string[] dataP = dataPrevisaoEmbarque.Split('/');
                            string[] dataE = dataEmbarque.Split('/');
                            int diaP = Int32.Parse(dataP[0]);
                            int mesP = Int32.Parse(dataP[1]);
                            int anoP = Int32.Parse(dataP[2]);
                            int diaE = Int32.Parse(dataE[0]);
                            int mesE = Int32.Parse(dataE[1]);
                            int anoE = Int32.Parse(dataE[2]);

                            string[] dataI = dataInicio.Split('/');
                            int diaI = Int32.Parse(dataI[0]);
                            int mesI = Int32.Parse(dataI[1]);
                            int anoI = Int32.Parse(dataI[2]);

                            string[] dataF = dataFinal.Split('/');
                            int diaF = Int32.Parse(dataF[0]);
                            int mesF = Int32.Parse(dataF[1]);
                            int anoF = Int32.Parse(dataF[2]);

                            if ((anoP >= anoI) && (anoP <= anoF))
                            {
                                if ((mesP >= mesI) && (mesP <= mesF))
                                {
                                    if ((diaP >= diaI) && (diaP <= diaF))
                                    {
                                        if (anoE < anoP)
                                        {
                                            numeroEmbarquesPrevisao++;
                                        }
                                        else
                                        {
                                            if (mesE < mesP)
                                            {
                                                numeroEmbarquesPrevisao++;
                                            }
                                            else
                                            {
                                                if (diaE <= diaP)
                                                {
                                                    numeroEmbarquesPrevisao++;
                                                }
                                                else
                                                {
                                                    numeroEmbarquesForaPrevisao++;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            numeroEmbarquesNaoFinalizado++;
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

        public Boolean pegarValoresEmbarqueDestino()
        {
            numeroEmbarquesPrevisaoDestino = 0;
            numeroEmbarquesForaPrevisaoDestino = 0;
            numeroEmbarquesNaoFinalizadoDestino = 0;
            string dataPrevisaoEmbarque;
            string dataEmbarque;
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
                        dataPrevisaoEmbarque = readerUsuario.GetString(11);
                        dataEmbarque = readerUsuario.GetString(12);

                        if (dataEmbarque != "")
                        {
                            string[] dataP = dataPrevisaoEmbarque.Split('/');
                            string[] dataE = dataEmbarque.Split('/');
                            int diaP = Int32.Parse(dataP[0]);
                            int mesP = Int32.Parse(dataP[1]);
                            int anoP = Int32.Parse(dataP[2]);
                            int diaE = Int32.Parse(dataE[0]);
                            int mesE = Int32.Parse(dataE[1]);
                            int anoE = Int32.Parse(dataE[2]);

                            string[] dataI = dataInicio.Split('/');
                            int diaI = Int32.Parse(dataI[0]);
                            int mesI = Int32.Parse(dataI[1]);
                            int anoI = Int32.Parse(dataI[2]);

                            string[] dataF = dataFinal.Split('/');
                            int diaF = Int32.Parse(dataF[0]);
                            int mesF = Int32.Parse(dataF[1]);
                            int anoF = Int32.Parse(dataF[2]);

                            if ((anoP >= anoI) && (anoP <= anoF))
                            {
                                if ((mesP >= mesI) && (mesP <= mesF))
                                {
                                    if ((diaP >= diaI) && (diaP <= diaF))
                                    {
                                        if (anoE < anoP)
                                        {
                                            numeroEmbarquesPrevisaoDestino++;
                                        }
                                        else
                                        {
                                            if (mesE < mesP)
                                            {
                                                numeroEmbarquesPrevisaoDestino++;
                                            }
                                            else
                                            {
                                                if (diaE <= diaP)
                                                {
                                                    numeroEmbarquesPrevisaoDestino++;
                                                }
                                                else
                                                {
                                                    numeroEmbarquesForaPrevisaoDestino++;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            numeroEmbarquesNaoFinalizadoDestino++;
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

        public Boolean retornaEmbarques(string cont)
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

                    usuarioQuery.CommandText = "SELECT * FROM gerenciadortransportes." + cont + " WHERE id = " + (i + 1).ToString();
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
                        if (cont == "embarqueGloria")
                        {
                            numeroEmbarques[0]++;
                        }
                        if (cont == "embarqueToledo")
                        {
                            numeroEmbarques[1]++;
                        }
                        if (cont == "embarqueRioVerde")
                        {
                            numeroEmbarques[2]++;
                        }
                        if (cont == "embarqueParanavai")
                        {
                            numeroEmbarques[3]++;
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

        public Boolean retornaEstadoDestino()
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

                    usuarioQuery.CommandText = "SELECT * FROM gerenciadortransportes.embarqueTodos WHERE id = " + (i + 1).ToString();
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
                        estadoDestino[j] = readerUsuario.GetString(7);
                        j++;
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

        public void classificaEstadosDestino()
        {
            Boolean repetido;
            int k;
            for (int i = 0; i < estadoDestino.Length; i++)
            {
                if (estadoDestino[i] == "São Paulo")
                {
                    estadoDestino[i] = "SP";
                }
                if ("Paraná" == estadoDestino[i])
                {
                    estadoDestino[i] = "PR";
                }
                if ("Mato Grosso" == estadoDestino[i])
                {
                    estadoDestino[i] = "MT";
                }
                if ("Mato Grosso do Sul" == estadoDestino[i])
                {
                    estadoDestino[i] = "MS";
                }
                if ("Minas Gerais" == estadoDestino[i])
                {
                    estadoDestino[i] = "MG";
                }
                if ("Goiás" == estadoDestino[i])
                {
                    estadoDestino[i] = "GO";
                }
                if ("Acre" == estadoDestino[i])
                {
                    estadoDestino[i] = "AC";
                }
                if ("Alagoas" == estadoDestino[i])
                {
                    estadoDestino[i] = "AL";
                }
                if ("Amapá" == estadoDestino[i])
                {
                    estadoDestino[i] = "AP";
                }
                if ("Amazonas" == estadoDestino[i])
                {
                    estadoDestino[i] = "AM";
                }
                if ("Bahia" == estadoDestino[i])
                {
                    estadoDestino[i] = "BA";
                }
                if ("Ceará" == estadoDestino[i])
                {
                    estadoDestino[i] = "CE";
                }
                if ("Distrito Federal" == estadoDestino[i])
                {
                    estadoDestino[i] = "DF";
                }
                if ("Espírito Santo" == estadoDestino[i])
                {
                    estadoDestino[i] = "ES";
                }
                if ("Maranhão" == estadoDestino[i])
                {
                    estadoDestino[i] = "MA";
                }
                if ("Pará" == estadoDestino[i])
                {
                    estadoDestino[i] = "PA";
                }
                if ("Paraíba" == estadoDestino[i])
                {
                    estadoDestino[i] = "PB";
                }
                if ("Pernambuco" == estadoDestino[i])
                {
                    estadoDestino[i] = "PE";
                }
                if ("Piauí" == estadoDestino[i])
                {
                    estadoDestino[i] = "PI";
                }
                if ("Rio de Janeiro" == estadoDestino[i])
                {
                    estadoDestino[i] = "RJ";
                }
                if ("Rio Grande do Norte" == estadoDestino[i])
                {
                    estadoDestino[i] = "RN";
                }
                if ("Rio Grande do Sul" == estadoDestino[i])
                {
                    estadoDestino[i] = "RS";
                }
                if ("Rondônia" == estadoDestino[i])
                {
                    estadoDestino[i] = "RO";
                }
                if ("Roraima" == estadoDestino[i])
                {
                    estadoDestino[i] = "RR";
                }
                if ("Santa Catarina" == estadoDestino[i])
                {
                    estadoDestino[i] = "SC";
                }
                if ("Sergipe" == estadoDestino[i])
                {
                    estadoDestino[i] = "SE";
                }
                if ("Tocantins" == estadoDestino[i])
                {
                    estadoDestino[i] = "TO";
                }
            }
            int novo = 1;
            classificaEstadoDestino[0] = estadoDestino[0];
            numeroEstadoDestino[0] = 1;
            for (int i = 1; i <= j; i++)
            {
                repetido = false;
                for (k = 0; k < 27; k++)
                {
                    if (classificaEstadoDestino[k] == estadoDestino[i])
                    {
                        repetido = true;
                        numeroEstadoDestino[k]++;
                        k = 27;
                    }
                }
                if (!repetido)
                {
                    classificaEstadoDestino[novo] = estadoDestino[i];
                    numeroEstadoDestino[novo]++;
                    novo++;
                }
            }
        }

        public Boolean retornaEstadoOrigem()
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

                    usuarioQuery.CommandText = "SELECT * FROM gerenciadortransportes.embarqueTodos WHERE id = " + (i + 1).ToString();
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
                        estadoOrigem[j] = readerUsuario.GetString(5);
                        j++;
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

        public void classificaEstadosOrigem()
        {
            Boolean repetido;
            int k;
            for (int i = 0; i < estadoOrigem.Length; i++)
            {
                if (estadoOrigem[i] == "São Paulo")
                {
                    estadoOrigem[i] = "SP";
                }
                if ("Paraná" == estadoOrigem[i])
                {
                    estadoOrigem[i] = "PR";
                }
                if ("Mato Grosso" == estadoOrigem[i])
                {
                    estadoOrigem[i] = "MT";
                }
                if ("Mato Grosso do Sul" == estadoOrigem[i])
                {
                    estadoOrigem[i] = "MS";
                }
                if ("Minas Gerais" == estadoOrigem[i])
                {
                    estadoOrigem[i] = "MG";
                }
                if ("Goiás" == estadoOrigem[i])
                {
                    estadoOrigem[i] = "GO";
                }
                if ("Acre" == estadoOrigem[i])
                {
                    estadoOrigem[i] = "AC";
                }
                if ("Alagoas" == estadoOrigem[i])
                {
                    estadoOrigem[i] = "AL";
                }
                if ("Amapá" == estadoOrigem[i])
                {
                    estadoOrigem[i] = "AP";
                }
                if ("Amazonas" == estadoOrigem[i])
                {
                    estadoOrigem[i] = "AM";
                }
                if ("Bahia" == estadoOrigem[i])
                {
                    estadoOrigem[i] = "BA";
                }
                if ("Ceará" == estadoOrigem[i])
                {
                    estadoOrigem[i] = "CE";
                }
                if ("Distrito Federal" == estadoOrigem[i])
                {
                    estadoOrigem[i] = "DF";
                }
                if ("Espírito Santo" == estadoOrigem[i])
                {
                    estadoOrigem[i] = "ES";
                }
                if ("Maranhão" == estadoOrigem[i])
                {
                    estadoOrigem[i] = "MA";
                }
                if ("Pará" == estadoOrigem[i])
                {
                    estadoOrigem[i] = "PA";
                }
                if ("Paraíba" == estadoOrigem[i])
                {
                    estadoOrigem[i] = "PB";
                }
                if ("Pernambuco" == estadoOrigem[i])
                {
                    estadoOrigem[i] = "PE";
                }
                if ("Piauí" == estadoOrigem[i])
                {
                    estadoOrigem[i] = "PI";
                }
                if ("Rio de Janeiro" == estadoOrigem[i])
                {
                    estadoOrigem[i] = "RJ";
                }
                if ("Rio Grande do Norte" == estadoOrigem[i])
                {
                    estadoOrigem[i] = "RN";
                }
                if ("Rio Grande do Sul" == estadoOrigem[i])
                {
                    estadoOrigem[i] = "RS";
                }
                if ("Rondônia" == estadoOrigem[i])
                {
                    estadoOrigem[i] = "RO";
                }
                if ("Roraima" == estadoOrigem[i])
                {
                    estadoOrigem[i] = "RR";
                }
                if ("Santa Catarina" == estadoOrigem[i])
                {
                    estadoOrigem[i] = "SC";
                }
                if ("Sergipe" == estadoOrigem[i])
                {
                    estadoOrigem[i] = "SE";
                }
                if ("Tocantins" == estadoOrigem[i])
                {
                    estadoOrigem[i] = "TO";
                }
            }
            int novo = 1;
            classificaEstadOrigem[0] = estadoOrigem[0];
            numeroEstadoOrigem[0] = 1;
            for (int i = 1; i <= j; i++)
            {
                repetido = false;
                for (k = 0; k < 27; k++)
                {
                    if (classificaEstadOrigem[k] == estadoOrigem[i])
                    {
                        repetido = true;
                        numeroEstadoOrigem[k]++;
                        k = 27;
                    }
                }
                if (!repetido)
                {
                    classificaEstadOrigem[novo] = estadoOrigem[i];
                    numeroEstadoOrigem[novo]++;
                    novo++;
                }
            }
        }

        public void zera()
        {
            for (int i = 0; i < 27; i++)
            {
                numeroEstadoDestino[i] = 0;
            }
            for (int i = 0; i < 4; i++)
            {
                numeroEmbarques[i] = 0;
            }
        }

        public void gerarGraficoEstadoDestino()
        {
            Boolean retorno = retornaEstadoDestino();
            classificaEstadosDestino();
            EstadoDestino.Series.Add("Estados de Destino");
            EstadoDestino.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            EstadoDestino.Series[0].Points.DataBindXY(classificaEstadoDestino, numeroEstadoDestino);
            EstadoDestino.Legends.Add("MyLegend");
            EstadoDestino.Legends[0].LegendStyle = LegendStyle.Table;
            EstadoDestino.Legends[0].Docking = Docking.Bottom;
            EstadoDestino.Legends[0].Alignment = StringAlignment.Center;
            EstadoDestino.Legends[0].BorderColor = Color.Black;
            EstadoDestino.Titles.Add("Estado de Destino");

            EstadoDestino.Series[0].IsValueShownAsLabel = true;
            EstadoDestino.Series[0].IsVisibleInLegend = true;
        }

        public void atualizaGraficoEstadoDestino()
        {
            Boolean retorno = retornaEstadoDestino();
            classificaEstadosDestino();
            EstadoDestino.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            EstadoDestino.Series[0].Points.DataBindXY(classificaEstadoDestino, numeroEstadoDestino);
        }

        public void gerarGraficoEstadoOrigem()
        {
            Boolean retorno = retornaEstadoOrigem();
            classificaEstadosOrigem();
            EstadoOrigem.Series.Add("Estados de Origem");
            EstadoOrigem.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            EstadoOrigem.Series[0].Points.DataBindXY(classificaEstadOrigem, numeroEstadoOrigem);
            EstadoOrigem.Legends.Add("MyLegend");
            EstadoOrigem.Legends[0].LegendStyle = LegendStyle.Table;
            EstadoOrigem.Legends[0].Docking = Docking.Bottom;
            EstadoOrigem.Legends[0].Alignment = StringAlignment.Center;
            EstadoOrigem.Legends[0].BorderColor = Color.Black;
            EstadoOrigem.Titles.Add("Estado de Origem");

            EstadoOrigem.Series[0].IsValueShownAsLabel = true;
            EstadoOrigem.Series[0].IsVisibleInLegend = true;
        }

        public void atualizaGraficoEstadoOrigem()
        {
            Boolean retorno = retornaEstadoOrigem();
            classificaEstadosOrigem();
            EstadoOrigem.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            EstadoOrigem.Series[0].Points.DataBindXY(classificaEstadOrigem, numeroEstadoOrigem);
        }

        public void gerarGraficoEmbarques()
        {
            retornaEmbarques("embarqueGloria");
            retornaEmbarques("embarqueToledo");
            retornaEmbarques("embarqueRioVerde");
            retornaEmbarques("embarqueParanavai");

            embarquesFilial.Series.Add("Embarques");
            embarquesFilial.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            embarquesFilial.Series[0].Points.DataBindXY(nomeEmbarques, numeroEmbarques);
            embarquesFilial.Titles.Add("Embarques por Filial");
        }

        private void cb_inicio_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_inicio.Checked)
            {
                tb_dataInicio.Enabled = false;
            }
            if (!cb_inicio.Checked)
            {
                tb_dataInicio.Enabled = true;
            }
        }

        private void cb_fim_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_fim.Checked)
            {
                tb_dataFinal.Enabled = false;
            }
            if (!cb_fim.Checked)
            {
                tb_dataFinal.Enabled = true;
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (cb_inicio.Checked)
            {
                dataInicio = "01/01/2001";
            }
            else
            {
                dataInicio = tb_dataInicio.Text;
            }
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

            if (cb_fim.Checked)
            {
                dataFinal = "31/12/2099";
            }
            else
            {
                dataFinal = tb_dataFinal.Text;
            }

            atualizaGraficoPontualidade();
            atualizaGraficoPontualidadeDestino();
            atualizaGraficoPontualidadeGeral();
        }

        public void geraGraficoPontualidade()
        {
            Boolean semUso = pegarValoresEmbarque();
            int[] prazo = { numeroEmbarquesPrevisao, numeroEmbarquesForaPrevisao, numeroEmbarquesNaoFinalizado };
            string[] prazoNome = { "No prazo", "Atrasado", "Não Finalizado" };
            EmbarquesPrazo.Series.Add("Embarques");
            EmbarquesPrazo.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            EmbarquesPrazo.Series[0].Points.DataBindXY(prazoNome, prazo);
            EmbarquesPrazo.Titles.Add("Embarques dentro do prazo");
            EmbarquesPrazo.Legends.Add("MyLegend");
            EmbarquesPrazo.Legends[0].LegendStyle = LegendStyle.Table;
            EmbarquesPrazo.Legends[0].Docking = Docking.Bottom;
            EmbarquesPrazo.Legends[0].Alignment = StringAlignment.Center;
            EmbarquesPrazo.Legends[0].BorderColor = Color.Black;

            EmbarquesPrazo.Series[0].IsValueShownAsLabel = true;
            EmbarquesPrazo.Series[0].IsVisibleInLegend = true;
        }

        public void atualizaGraficoPontualidade()
        {
            Boolean semUso = pegarValoresEmbarque();
            int[] prazo = { numeroEmbarquesPrevisao, numeroEmbarquesForaPrevisao, numeroEmbarquesNaoFinalizado };
            string[] prazoNome = { "Em Ponto", "Atrasado", "Não Finalizado" };
            EmbarquesPrazo.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            EmbarquesPrazo.Series[0].Points.DataBindXY(prazoNome, prazo);
        }

        public void geraGraficoPontualidadeDestino()
        {
            Boolean semUso = pegarValoresEmbarqueDestino();
            int[] prazo = { numeroEmbarquesPrevisaoDestino, numeroEmbarquesForaPrevisaoDestino, numeroEmbarquesNaoFinalizadoDestino };
            string[] prazoNome = { "No prazo", "Atrasado", "Não Finalizado" };
            DestinoPrazo.Series.Add("Embarques");
            DestinoPrazo.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            DestinoPrazo.Series[0].Points.DataBindXY(prazoNome, prazo);
            DestinoPrazo.Titles.Add("Embarques destino dentro do prazo");
            DestinoPrazo.Legends.Add("MyLegend");
            DestinoPrazo.Legends[0].LegendStyle = LegendStyle.Table;
            DestinoPrazo.Legends[0].Docking = Docking.Bottom;
            DestinoPrazo.Legends[0].Alignment = StringAlignment.Center;
            DestinoPrazo.Legends[0].BorderColor = Color.Black;

            DestinoPrazo.Series[0].IsValueShownAsLabel = true;
            DestinoPrazo.Series[0].IsVisibleInLegend = true;
        }

        public void atualizaGraficoPontualidadeDestino()
        {
            Boolean semUso = pegarValoresEmbarqueDestino();
            int[] prazo = { numeroEmbarquesPrevisaoDestino, numeroEmbarquesForaPrevisaoDestino, numeroEmbarquesNaoFinalizadoDestino };
            string[] prazoNome = { "Em Ponto", "Atrasado", "Não Finalizado" };
            DestinoPrazo.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            DestinoPrazo.Series[0].Points.DataBindXY(prazoNome, prazo);
        }

        public void geraGraficoPontualidadeGeral()
        {
            Boolean semUso = pegarValoresEmbarqueDestino();
            int[] prazo = { numeroEmbarquesPrevisaoDestino + numeroEmbarquesPrevisao, numeroEmbarquesForaPrevisaoDestino + numeroEmbarquesForaPrevisao, numeroEmbarquesNaoFinalizadoDestino + numeroEmbarquesNaoFinalizado };
            string[] prazoNome = { "No prazo", "Atrasado", "Não Finalizado" };
            GeralPrazo.Series.Add("Embarques");
            GeralPrazo.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            GeralPrazo.Series[0].Points.DataBindXY(prazoNome, prazo);
            GeralPrazo.Titles.Add("Prazo Geral");
            GeralPrazo.Legends.Add("MyLegend");
            GeralPrazo.Legends[0].LegendStyle = LegendStyle.Table;
            GeralPrazo.Legends[0].Docking = Docking.Bottom;
            GeralPrazo.Legends[0].Alignment = StringAlignment.Center;
            GeralPrazo.Legends[0].BorderColor = Color.Black;

            GeralPrazo.Series[0].IsValueShownAsLabel = true;
            GeralPrazo.Series[0].IsVisibleInLegend = true;
        }

        public void atualizaGraficoPontualidadeGeral()
        {
            Boolean semUso = pegarValoresEmbarqueDestino();
            int[] prazo = { numeroEmbarquesPrevisaoDestino + numeroEmbarquesPrevisao, numeroEmbarquesForaPrevisaoDestino + numeroEmbarquesForaPrevisao, numeroEmbarquesNaoFinalizadoDestino + numeroEmbarquesNaoFinalizado };
            string[] prazoNome = { "Em Ponto", "Atrasado", "Não Finalizado" };
            GeralPrazo.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            GeralPrazo.Series[0].Points.DataBindXY(prazoNome, prazo);
        }

        private void btn_proximo_Click(object sender, EventArgs e)
        {
            Dashboard_2 dashboard_2 = new Dashboard_2();
            dashboard_2.Show();
            this.Close();
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
