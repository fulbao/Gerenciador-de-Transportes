using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Gerenciador_de_Transportes
{
    public partial class Dashboard_2 : Form
    {
        int numeroEmbarquesBrf = 0;

        int numeroDesembaqueBrf = 0;

        double kmEmbarqueBrf = 0;

        double kmDesembarqueBrf = 0;

        int[] numeroEmbarquesTodos = new int[4];

        double[] kmEmbarquesTodos = new double[4];

        string dataInicio;

        string dataFinal;

        public Dashboard_2()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void Dashboard_2_Load(object sender, EventArgs e)
        {
            dataInicio = "01/01/2001";
            dataFinal = "31/12/2099";
            cb_fim.Checked = true;
            cb_inicio.Checked = true;
            tb_dataInicio.Enabled = false;
            tb_dataFinal.Enabled = false;
            chamadaGraficos();
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

        public void chamadaGraficos()
        {
            gerarGraficoEmbarques();
            gerarGraficoKm();
            lb_contexto.Text = "Dados Todos";
            lb_kmTodosEmbarque.Text = kmEmbarqueBrf.ToString() + " Km";
            lb_kmTodosDesembarque.Text = kmDesembarqueBrf.ToString() + " Km";
            lb_kmTodosGeral.Text = (kmDesembarqueBrf + kmEmbarqueBrf).ToString() + " Km";

            retornaEmbarques("embarqueGloria");
            lb_kmGloriaEmbarque.Text = kmEmbarqueBrf.ToString() + " Km";
            lm_kmDesembarqueGloria.Text = kmDesembarqueBrf.ToString() + " Km";
            lb_kmGeralGloria.Text = (kmDesembarqueBrf + kmEmbarqueBrf).ToString() + " Km";
            numeroEmbarquesTodos[0] = numeroEmbarquesBrf + numeroDesembaqueBrf;
            kmEmbarquesTodos[0] = kmEmbarqueBrf + kmDesembarqueBrf;

            retornaEmbarques("embarqueParanavai");
            lb_KmEmbarquePRVI.Text = kmEmbarqueBrf.ToString() + " Km";
            lb_kmdesembarquepvai.Text = kmDesembarqueBrf.ToString() + " Km";
            lb_kmGeralPVAI.Text = (kmDesembarqueBrf + kmEmbarqueBrf).ToString() + " Km";
            numeroEmbarquesTodos[1] = numeroEmbarquesBrf + numeroDesembaqueBrf;
            kmEmbarquesTodos[1] = kmEmbarqueBrf + kmDesembarqueBrf;

            retornaEmbarques("embarqueToledo");
            lb_LmEmbarqueToo.Text = kmEmbarqueBrf.ToString() + " Km";
            lb_KmDesembarqueToo.Text = kmDesembarqueBrf.ToString() + " Km";
            lb_KmGeralToo.Text = (kmDesembarqueBrf + kmEmbarqueBrf).ToString() + " Km";
            numeroEmbarquesTodos[2] = numeroEmbarquesBrf + numeroDesembaqueBrf;
            kmEmbarquesTodos[2] = kmEmbarqueBrf + kmDesembarqueBrf;

            retornaEmbarques("embarqueRioVerde");
            lb_KmEmbarqueRvio.Text = kmEmbarqueBrf.ToString() + " Km";
            lb_KmDesembarqueRvio.Text = kmDesembarqueBrf.ToString() + " Km";
            lb_KmGeralRvio.Text = (kmDesembarqueBrf + kmEmbarqueBrf).ToString() + " Km";
            numeroEmbarquesTodos[3] = numeroEmbarquesBrf + numeroDesembaqueBrf;
            kmEmbarquesTodos[3] = kmEmbarqueBrf + kmDesembarqueBrf;

            gerarGraficoEmbarquesTodos();
            gerarGraficoKmTodos();
        }

        public void atualizaGraficos()
        {
            retornaEmbarques("embarquetodos");
            lb_contexto.Text = "Dados Todos";
            lb_kmTodosEmbarque.Text = kmEmbarqueBrf.ToString() + " Km";
            lb_kmTodosDesembarque.Text = kmDesembarqueBrf.ToString() + " Km";
            lb_kmTodosGeral.Text = (kmDesembarqueBrf + kmEmbarqueBrf).ToString() + " Km";

            retornaEmbarques("embarqueGloria");
            lb_kmGloriaEmbarque.Text = kmEmbarqueBrf.ToString() + " Km";
            lm_kmDesembarqueGloria.Text = kmDesembarqueBrf.ToString() + " Km";
            lb_kmGeralGloria.Text = (kmDesembarqueBrf + kmEmbarqueBrf).ToString() + " Km";
            numeroEmbarquesTodos[0] = numeroEmbarquesBrf + numeroDesembaqueBrf;
            kmEmbarquesTodos[0] = kmEmbarqueBrf + kmDesembarqueBrf;

            retornaEmbarques("embarqueParanavai");
            lb_KmEmbarquePRVI.Text = kmEmbarqueBrf.ToString() + " Km";
            lb_kmdesembarquepvai.Text = kmDesembarqueBrf.ToString() + " Km";
            lb_kmGeralPVAI.Text = (kmDesembarqueBrf + kmEmbarqueBrf).ToString() + " Km";
            numeroEmbarquesTodos[1] = numeroEmbarquesBrf + numeroDesembaqueBrf;
            kmEmbarquesTodos[1] = kmEmbarqueBrf + kmDesembarqueBrf;

            retornaEmbarques("embarqueToledo");
            lb_LmEmbarqueToo.Text = kmEmbarqueBrf.ToString() + " Km";
            lb_KmDesembarqueToo.Text = kmDesembarqueBrf.ToString() + " Km";
            lb_KmGeralToo.Text = (kmDesembarqueBrf + kmEmbarqueBrf).ToString() + " Km";
            numeroEmbarquesTodos[2] = numeroEmbarquesBrf + numeroDesembaqueBrf;
            kmEmbarquesTodos[2] = kmEmbarqueBrf + kmDesembarqueBrf;

            retornaEmbarques("embarqueRioVerde");
            lb_KmEmbarqueRvio.Text = kmEmbarqueBrf.ToString() + " Km";
            lb_KmDesembarqueRvio.Text = kmDesembarqueBrf.ToString() + " Km";
            lb_KmGeralRvio.Text = (kmDesembarqueBrf + kmEmbarqueBrf).ToString() + " Km";
            numeroEmbarquesTodos[3] = numeroEmbarquesBrf + numeroDesembaqueBrf;
            kmEmbarquesTodos[3] = kmEmbarqueBrf + kmDesembarqueBrf;

            atualizaGraficoEmbarquesTodos();
            atualizaGraficoKmTodos();
        }

        public Boolean retornaEmbarques(string cont)
        {
            numeroEmbarquesBrf = 0;

            numeroDesembaqueBrf = 0;

            kmEmbarqueBrf = 0;

            kmDesembarqueBrf = 0;

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
                        string dataEmbarque = readerUsuario.GetString(10);

                        if (dataEmbarque != "")
                        {
                            string[] dataE = dataEmbarque.Split('/');
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

                            if ((anoE <= anoF) && (anoE >= anoI) && (diaE <= diaF) && (diaE >= diaI) && (mesE <= mesF) && (mesE >= mesI))
                            {
                                string embarcador = readerUsuario.GetString(32);
                                string destinatario = readerUsuario.GetString(33);
                                double km = Convert.ToDouble(readerUsuario.GetValue(30));

                                embarcador = embarcador.ToLower();
                                destinatario = destinatario.ToLower();

                                if (destinatario.Contains("brf"))
                                {
                                    numeroDesembaqueBrf++;
                                    kmDesembarqueBrf += km;
                                }
                                if (embarcador.Contains("brf"))
                                {
                                    numeroEmbarquesBrf++;
                                    kmEmbarqueBrf += km;
                                }
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

        public void gerarGraficoEmbarques()
        {
            retornaEmbarques("embarquetodos");
            double[] numeroGrafico = { numeroEmbarquesBrf, numeroDesembaqueBrf, numeroEmbarquesBrf + numeroDesembaqueBrf };
            string[] embarques = { "Embarques BRF", "Desembarques BRF", "Total BRF" };

            embarquesBrf.Series.Add("Embarques BRF");
            embarquesBrf.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            embarquesBrf.Series[0].Points.DataBindXY(embarques, numeroGrafico);
            embarquesBrf.Titles.Add("Número Embarques BRF");
        }

        public void gerarGraficoKm()
        {
            double[] numeroGrafico = { kmEmbarqueBrf, kmDesembarqueBrf, kmDesembarqueBrf + kmEmbarqueBrf };
            string[] embarques = { "Km Embarcador BRF", "Km Destinatário BRF", "Km Total BRF" };

            kmBrf.Series.Add("Embarques BRF");
            kmBrf.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            kmBrf.Series[0].Points.DataBindXY(embarques, numeroGrafico);
            kmBrf.Titles.Add("Km Embarques BRF");
        }

        public void gerarGraficoKmTodos()
        {
            string[] embarques = { "Glória de Dourados", "Paranavaí", "Toledo", "Rio Verde" };
            kmTodos.Series.Add("Estados de Origem");
            kmTodos.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            kmTodos.Series[0].Points.DataBindXY(embarques, kmEmbarquesTodos);
            kmTodos.Legends.Add("MyLegend");
            kmTodos.Legends[0].LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Table;
            kmTodos.Legends[0].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            kmTodos.Legends[0].Alignment = StringAlignment.Center;
            kmTodos.Legends[0].BorderColor = Color.Black;
            kmTodos.Titles.Add("Km BRF Por Filial");

            kmTodos.Series[0].IsValueShownAsLabel = true;
            kmTodos.Series[0].IsVisibleInLegend = true;
        }

        public void gerarGraficoEmbarquesTodos()
        {
            string[] embarques = { "Glória de Dourados", "Paranavaí", "Toledo", "Rio Verde" };
            embarqueTodos.Series.Add("Estados de Origem");
            embarqueTodos.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            embarqueTodos.Series[0].Points.DataBindXY(embarques, numeroEmbarquesTodos);
            embarqueTodos.Legends.Add("MyLegend");
            embarqueTodos.Legends[0].LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Table;
            embarqueTodos.Legends[0].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            embarqueTodos.Legends[0].Alignment = StringAlignment.Center;
            embarqueTodos.Legends[0].BorderColor = Color.Black;
            embarqueTodos.Titles.Add("Embarques BRF Por Filial");

            embarqueTodos.Series[0].IsValueShownAsLabel = true;
            embarqueTodos.Series[0].IsVisibleInLegend = true;
        }

        public void atualizaGraficoKmTodos()
        {
            string[] embarques = { "Glória de Dourados", "Paranavaí", "Toledo", "Rio Verde" };
            kmTodos.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            kmTodos.Series[0].Points.DataBindXY(embarques, kmEmbarquesTodos);
        }

        public void atualizaGraficoEmbarquesTodos()
        {
            string[] embarques = { "Glória de Dourados", "Paranavaí", "Toledo", "Rio Verde" };
            embarqueTodos.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            embarqueTodos.Series[0].Points.DataBindXY(embarques, numeroEmbarquesTodos);
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Close();
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

            if (cb_fim.Checked)
            {
                dataFinal = "31/12/2099";
            }
            else
            {
                dataFinal = tb_dataFinal.Text;
            }

            atualizaGraficos();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tb_dataFinal_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tb_dataInicio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard_3 dashboard = new Dashboard_3();
            dashboard.Show();
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
