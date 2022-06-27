namespace Gerenciador_de_Transportes
{
    partial class Dashboard_2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard_2));
            this.btn_buscar = new System.Windows.Forms.Button();
            this.cb_fim = new System.Windows.Forms.CheckBox();
            this.cb_inicio = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_dataFinal = new System.Windows.Forms.DateTimePicker();
            this.tb_dataInicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_anterior = new System.Windows.Forms.Button();
            this.embarquesBrf = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.kmBrf = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.page1 = new System.Windows.Forms.TableLayoutPanel();
            this.kmTodos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.embarqueTodos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lb_KmEmbarquePRVI = new System.Windows.Forms.Label();
            this.lb_kmGeralGloria = new System.Windows.Forms.Label();
            this.lm_kmDesembarqueGloria = new System.Windows.Forms.Label();
            this.lb_kmGloriaEmbarque = new System.Windows.Forms.Label();
            this.lb_kmTodosGeral = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_kmTodosDesembarque = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_kmTodosEmbarque = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_contexto = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_KmGeralRvio = new System.Windows.Forms.Label();
            this.lb_KmDesembarqueRvio = new System.Windows.Forms.Label();
            this.lb_KmEmbarqueRvio = new System.Windows.Forms.Label();
            this.lb_LmEmbarqueToo = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.lb_kmGeralPVAI = new System.Windows.Forms.Label();
            this.lb_kmdesembarquepvai = new System.Windows.Forms.Label();
            this.lb_KmDesembarqueToo = new System.Windows.Forms.Label();
            this.lb_KmGeralToo = new System.Windows.Forms.Label();
            this.btn_proximo = new System.Windows.Forms.Button();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Maximizar = new System.Windows.Forms.Button();
            this.btn_Minimizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.embarquesBrf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kmBrf)).BeginInit();
            this.page1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kmTodos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.embarqueTodos)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_buscar
            // 
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Location = new System.Drawing.Point(1029, 5);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(156, 26);
            this.btn_buscar.TabIndex = 28;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // cb_fim
            // 
            this.cb_fim.AutoSize = true;
            this.cb_fim.BackColor = System.Drawing.Color.Transparent;
            this.cb_fim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_fim.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cb_fim.Location = new System.Drawing.Point(627, 7);
            this.cb_fim.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cb_fim.Name = "cb_fim";
            this.cb_fim.Size = new System.Drawing.Size(134, 24);
            this.cb_fim.TabIndex = 34;
            this.cb_fim.Text = "Todo Período";
            this.cb_fim.UseVisualStyleBackColor = false;
            this.cb_fim.CheckedChanged += new System.EventHandler(this.cb_fim_CheckedChanged);
            // 
            // cb_inicio
            // 
            this.cb_inicio.AutoSize = true;
            this.cb_inicio.BackColor = System.Drawing.Color.Transparent;
            this.cb_inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_inicio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cb_inicio.Location = new System.Drawing.Point(199, 8);
            this.cb_inicio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cb_inicio.Name = "cb_inicio";
            this.cb_inicio.Size = new System.Drawing.Size(134, 24);
            this.cb_inicio.TabIndex = 33;
            this.cb_inicio.Text = "Todo Período";
            this.cb_inicio.UseVisualStyleBackColor = false;
            this.cb_inicio.CheckedChanged += new System.EventHandler(this.cb_inicio_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(579, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "até";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tb_dataFinal
            // 
            this.tb_dataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_dataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tb_dataFinal.Location = new System.Drawing.Point(791, 5);
            this.tb_dataFinal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_dataFinal.Name = "tb_dataFinal";
            this.tb_dataFinal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_dataFinal.Size = new System.Drawing.Size(202, 26);
            this.tb_dataFinal.TabIndex = 31;
            this.tb_dataFinal.ValueChanged += new System.EventHandler(this.tb_dataFinal_ValueChanged);
            // 
            // tb_dataInicio
            // 
            this.tb_dataInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_dataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tb_dataInicio.Location = new System.Drawing.Point(369, 4);
            this.tb_dataInicio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_dataInicio.Name = "tb_dataInicio";
            this.tb_dataInicio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_dataInicio.Size = new System.Drawing.Size(202, 26);
            this.tb_dataInicio.TabIndex = 30;
            this.tb_dataInicio.ValueChanged += new System.EventHandler(this.tb_dataInicio_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Selecione o período: ";
            // 
            // btn_anterior
            // 
            this.btn_anterior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_anterior.BackColor = System.Drawing.Color.Black;
            this.btn_anterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_anterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_anterior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(175)))), ((int)(((byte)(75)))));
            this.btn_anterior.Location = new System.Drawing.Point(1336, 3);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(30, 29);
            this.btn_anterior.TabIndex = 37;
            this.btn_anterior.Text = "<";
            this.btn_anterior.UseVisualStyleBackColor = false;
            this.btn_anterior.Click += new System.EventHandler(this.btn_anterior_Click);
            // 
            // embarquesBrf
            // 
            this.embarquesBrf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.embarquesBrf.BorderlineColor = System.Drawing.Color.Black;
            this.embarquesBrf.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.embarquesBrf.BorderlineWidth = 3;
            chartArea1.Name = "ChartArea1";
            this.embarquesBrf.ChartAreas.Add(chartArea1);
            this.embarquesBrf.Location = new System.Drawing.Point(4, 3);
            this.embarquesBrf.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.embarquesBrf.Name = "embarquesBrf";
            this.embarquesBrf.Size = new System.Drawing.Size(499, 389);
            this.embarquesBrf.TabIndex = 39;
            this.embarquesBrf.Text = "Embarques BRF";
            // 
            // kmBrf
            // 
            this.kmBrf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kmBrf.BorderlineColor = System.Drawing.Color.Black;
            this.kmBrf.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.kmBrf.BorderlineWidth = 3;
            chartArea2.Name = "ChartArea1";
            this.kmBrf.ChartAreas.Add(chartArea2);
            this.kmBrf.Location = new System.Drawing.Point(511, 3);
            this.kmBrf.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.kmBrf.Name = "kmBrf";
            this.kmBrf.Size = new System.Drawing.Size(499, 389);
            this.kmBrf.TabIndex = 40;
            this.kmBrf.Text = "Embarques BRF";
            // 
            // page1
            // 
            this.page1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.page1.BackColor = System.Drawing.Color.Transparent;
            this.page1.ColumnCount = 3;
            this.page1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.page1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.page1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.page1.Controls.Add(this.kmTodos, 0, 1);
            this.page1.Controls.Add(this.embarqueTodos, 0, 1);
            this.page1.Controls.Add(this.kmBrf, 1, 0);
            this.page1.Controls.Add(this.embarquesBrf, 0, 0);
            this.page1.Controls.Add(this.tableLayoutPanel1, 2, 0);
            this.page1.Controls.Add(this.tableLayoutPanel2, 2, 1);
            this.page1.Location = new System.Drawing.Point(6, 38);
            this.page1.Name = "page1";
            this.page1.RowCount = 2;
            this.page1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.page1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.page1.Size = new System.Drawing.Size(1521, 791);
            this.page1.TabIndex = 38;
            // 
            // kmTodos
            // 
            this.kmTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kmTodos.BorderlineColor = System.Drawing.Color.Black;
            this.kmTodos.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.kmTodos.BorderlineWidth = 3;
            chartArea3.Name = "ChartArea1";
            this.kmTodos.ChartAreas.Add(chartArea3);
            this.kmTodos.Location = new System.Drawing.Point(511, 398);
            this.kmTodos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.kmTodos.Name = "kmTodos";
            this.kmTodos.Size = new System.Drawing.Size(499, 390);
            this.kmTodos.TabIndex = 44;
            this.kmTodos.Text = "Embarques BRF";
            // 
            // embarqueTodos
            // 
            this.embarqueTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.embarqueTodos.BorderlineColor = System.Drawing.Color.Black;
            this.embarqueTodos.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.embarqueTodos.BorderlineWidth = 3;
            chartArea4.Name = "ChartArea1";
            this.embarqueTodos.ChartAreas.Add(chartArea4);
            this.embarqueTodos.Location = new System.Drawing.Point(4, 398);
            this.embarqueTodos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.embarqueTodos.Name = "embarqueTodos";
            this.embarqueTodos.Size = new System.Drawing.Size(499, 390);
            this.embarqueTodos.TabIndex = 43;
            this.embarqueTodos.Text = "Embarques BRF";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(175)))), ((int)(((byte)(75)))));
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.00507F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.99492F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label16, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.lb_KmEmbarquePRVI, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.lb_kmGeralGloria, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lm_kmDesembarqueGloria, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lb_kmGloriaEmbarque, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lb_kmTodosGeral, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lb_kmTodosDesembarque, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lb_kmTodosEmbarque, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_contexto, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 8);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1017, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882353F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882353F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882353F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882353F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882353F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882353F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882353F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882353F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882353F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882353F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(501, 389);
            this.tableLayoutPanel1.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(80, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 20);
            this.label4.TabIndex = 64;
            this.label4.Text = "Glória de Dourados: ";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(58, 355);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(218, 20);
            this.label16.TabIndex = 61;
            this.label16.Text = "Km Percorrido Embarque: ";
            // 
            // lb_KmEmbarquePRVI
            // 
            this.lb_KmEmbarquePRVI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_KmEmbarquePRVI.AutoSize = true;
            this.lb_KmEmbarquePRVI.BackColor = System.Drawing.Color.Transparent;
            this.lb_KmEmbarquePRVI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_KmEmbarquePRVI.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_KmEmbarquePRVI.Location = new System.Drawing.Point(417, 355);
            this.lb_KmEmbarquePRVI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_KmEmbarquePRVI.Name = "lb_KmEmbarquePRVI";
            this.lb_KmEmbarquePRVI.Size = new System.Drawing.Size(0, 20);
            this.lb_KmEmbarquePRVI.TabIndex = 57;
            // 
            // lb_kmGeralGloria
            // 
            this.lb_kmGeralGloria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_kmGeralGloria.AutoSize = true;
            this.lb_kmGeralGloria.BackColor = System.Drawing.Color.Transparent;
            this.lb_kmGeralGloria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_kmGeralGloria.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_kmGeralGloria.Location = new System.Drawing.Point(417, 276);
            this.lb_kmGeralGloria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_kmGeralGloria.Name = "lb_kmGeralGloria";
            this.lb_kmGeralGloria.Size = new System.Drawing.Size(0, 20);
            this.lb_kmGeralGloria.TabIndex = 53;
            // 
            // lm_kmDesembarqueGloria
            // 
            this.lm_kmDesembarqueGloria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lm_kmDesembarqueGloria.AutoSize = true;
            this.lm_kmDesembarqueGloria.BackColor = System.Drawing.Color.Transparent;
            this.lm_kmDesembarqueGloria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lm_kmDesembarqueGloria.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lm_kmDesembarqueGloria.Location = new System.Drawing.Point(417, 238);
            this.lm_kmDesembarqueGloria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lm_kmDesembarqueGloria.Name = "lm_kmDesembarqueGloria";
            this.lm_kmDesembarqueGloria.Size = new System.Drawing.Size(0, 20);
            this.lm_kmDesembarqueGloria.TabIndex = 51;
            // 
            // lb_kmGloriaEmbarque
            // 
            this.lb_kmGloriaEmbarque.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_kmGloriaEmbarque.AutoSize = true;
            this.lb_kmGloriaEmbarque.BackColor = System.Drawing.Color.Transparent;
            this.lb_kmGloriaEmbarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_kmGloriaEmbarque.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_kmGloriaEmbarque.Location = new System.Drawing.Point(417, 200);
            this.lb_kmGloriaEmbarque.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_kmGloriaEmbarque.Name = "lb_kmGloriaEmbarque";
            this.lb_kmGloriaEmbarque.Size = new System.Drawing.Size(0, 20);
            this.lb_kmGloriaEmbarque.TabIndex = 49;
            // 
            // lb_kmTodosGeral
            // 
            this.lb_kmTodosGeral.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_kmTodosGeral.AutoSize = true;
            this.lb_kmTodosGeral.BackColor = System.Drawing.Color.Transparent;
            this.lb_kmTodosGeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_kmTodosGeral.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_kmTodosGeral.Location = new System.Drawing.Point(417, 124);
            this.lb_kmTodosGeral.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_kmTodosGeral.Name = "lb_kmTodosGeral";
            this.lb_kmTodosGeral.Size = new System.Drawing.Size(0, 20);
            this.lb_kmTodosGeral.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(80, 124);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 20);
            this.label8.TabIndex = 44;
            this.label8.Text = "Km Percorrido Geral:";
            // 
            // lb_kmTodosDesembarque
            // 
            this.lb_kmTodosDesembarque.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_kmTodosDesembarque.AutoSize = true;
            this.lb_kmTodosDesembarque.BackColor = System.Drawing.Color.Transparent;
            this.lb_kmTodosDesembarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_kmTodosDesembarque.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_kmTodosDesembarque.Location = new System.Drawing.Point(417, 86);
            this.lb_kmTodosDesembarque.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_kmTodosDesembarque.Name = "lb_kmTodosDesembarque";
            this.lb_kmTodosDesembarque.Size = new System.Drawing.Size(0, 20);
            this.lb_kmTodosDesembarque.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(48, 86);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 20);
            this.label6.TabIndex = 42;
            this.label6.Text = "Km Percorrido Desembarque";
            // 
            // lb_kmTodosEmbarque
            // 
            this.lb_kmTodosEmbarque.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_kmTodosEmbarque.AutoSize = true;
            this.lb_kmTodosEmbarque.BackColor = System.Drawing.Color.Transparent;
            this.lb_kmTodosEmbarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_kmTodosEmbarque.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_kmTodosEmbarque.Location = new System.Drawing.Point(417, 48);
            this.lb_kmTodosEmbarque.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_kmTodosEmbarque.Name = "lb_kmTodosEmbarque";
            this.lb_kmTodosEmbarque.Size = new System.Drawing.Size(0, 20);
            this.lb_kmTodosEmbarque.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(417, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 40;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_contexto
            // 
            this.lb_contexto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_contexto.AutoSize = true;
            this.lb_contexto.BackColor = System.Drawing.Color.Transparent;
            this.lb_contexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_contexto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_contexto.Location = new System.Drawing.Point(167, 10);
            this.lb_contexto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_contexto.Name = "lb_contexto";
            this.lb_contexto.Size = new System.Drawing.Size(0, 20);
            this.lb_contexto.TabIndex = 39;
            this.lb_contexto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb
            // 
            this.lb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb.AutoSize = true;
            this.lb.BackColor = System.Drawing.Color.Transparent;
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.ForeColor = System.Drawing.Color.White;
            this.lb.Location = new System.Drawing.Point(58, 48);
            this.lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(218, 20);
            this.lb.TabIndex = 39;
            this.lb.Text = "Km Percorrido Embarque: ";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(80, 276);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(175, 20);
            this.label12.TabIndex = 63;
            this.label12.Text = "Km Percorrido Geral:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(48, 238);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 20);
            this.label5.TabIndex = 59;
            this.label5.Text = "Km Percorrido Desembarque";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(58, 200);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(218, 20);
            this.label10.TabIndex = 58;
            this.label10.Text = "Km Percorrido Embarque: ";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(118, 314);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 20);
            this.label11.TabIndex = 65;
            this.label11.Text = "Paranavaí: ";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(175)))), ((int)(((byte)(75)))));
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.00507F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.99492F));
            this.tableLayoutPanel2.Controls.Add(this.lb_KmGeralRvio, 1, 9);
            this.tableLayoutPanel2.Controls.Add(this.lb_KmDesembarqueRvio, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.lb_KmEmbarqueRvio, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.lb_LmEmbarqueToo, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label29, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label27, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label33, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label14, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label35, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label34, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label37, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.label18, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.label36, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.label32, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.label24, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.label31, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lb_kmGeralPVAI, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lb_kmdesembarquepvai, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lb_KmDesembarqueToo, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.lb_KmGeralToo, 1, 5);
            this.tableLayoutPanel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1017, 398);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 10;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882353F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882353F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882353F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882353F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882353F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882353F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882353F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882353F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882353F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882353F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(501, 390);
            this.tableLayoutPanel2.TabIndex = 42;
            // 
            // lb_KmGeralRvio
            // 
            this.lb_KmGeralRvio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_KmGeralRvio.AutoSize = true;
            this.lb_KmGeralRvio.BackColor = System.Drawing.Color.Transparent;
            this.lb_KmGeralRvio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_KmGeralRvio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_KmGeralRvio.Location = new System.Drawing.Point(417, 356);
            this.lb_KmGeralRvio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_KmGeralRvio.Name = "lb_KmGeralRvio";
            this.lb_KmGeralRvio.Size = new System.Drawing.Size(0, 20);
            this.lb_KmGeralRvio.TabIndex = 57;
            // 
            // lb_KmDesembarqueRvio
            // 
            this.lb_KmDesembarqueRvio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_KmDesembarqueRvio.AutoSize = true;
            this.lb_KmDesembarqueRvio.BackColor = System.Drawing.Color.Transparent;
            this.lb_KmDesembarqueRvio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_KmDesembarqueRvio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_KmDesembarqueRvio.Location = new System.Drawing.Point(417, 314);
            this.lb_KmDesembarqueRvio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_KmDesembarqueRvio.Name = "lb_KmDesembarqueRvio";
            this.lb_KmDesembarqueRvio.Size = new System.Drawing.Size(0, 20);
            this.lb_KmDesembarqueRvio.TabIndex = 55;
            // 
            // lb_KmEmbarqueRvio
            // 
            this.lb_KmEmbarqueRvio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_KmEmbarqueRvio.AutoSize = true;
            this.lb_KmEmbarqueRvio.BackColor = System.Drawing.Color.Transparent;
            this.lb_KmEmbarqueRvio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_KmEmbarqueRvio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_KmEmbarqueRvio.Location = new System.Drawing.Point(417, 276);
            this.lb_KmEmbarqueRvio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_KmEmbarqueRvio.Name = "lb_KmEmbarqueRvio";
            this.lb_KmEmbarqueRvio.Size = new System.Drawing.Size(0, 20);
            this.lb_KmEmbarqueRvio.TabIndex = 53;
            // 
            // lb_LmEmbarqueToo
            // 
            this.lb_LmEmbarqueToo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_LmEmbarqueToo.AutoSize = true;
            this.lb_LmEmbarqueToo.BackColor = System.Drawing.Color.Transparent;
            this.lb_LmEmbarqueToo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LmEmbarqueToo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_LmEmbarqueToo.Location = new System.Drawing.Point(417, 124);
            this.lb_LmEmbarqueToo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_LmEmbarqueToo.Name = "lb_LmEmbarqueToo";
            this.lb_LmEmbarqueToo.Size = new System.Drawing.Size(0, 20);
            this.lb_LmEmbarqueToo.TabIndex = 45;
            // 
            // label29
            // 
            this.label29.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.White;
            this.label29.Location = new System.Drawing.Point(48, 10);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(238, 20);
            this.label29.TabIndex = 42;
            this.label29.Text = "Km Percorrido Desembarque";
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(80, 48);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(175, 20);
            this.label27.TabIndex = 44;
            this.label27.Text = "Km Percorrido Geral:";
            // 
            // label33
            // 
            this.label33.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.White;
            this.label33.Location = new System.Drawing.Point(58, 124);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(218, 20);
            this.label33.TabIndex = 39;
            this.label33.Text = "Km Percorrido Embarque: ";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(133, 86);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 20);
            this.label14.TabIndex = 64;
            this.label14.Text = "Toledo:";
            // 
            // label35
            // 
            this.label35.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.Transparent;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.White;
            this.label35.Location = new System.Drawing.Point(48, 162);
            this.label35.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(238, 20);
            this.label35.TabIndex = 59;
            this.label35.Text = "Km Percorrido Desembarque";
            // 
            // label34
            // 
            this.label34.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.Transparent;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.White;
            this.label34.Location = new System.Drawing.Point(80, 200);
            this.label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(175, 20);
            this.label34.TabIndex = 63;
            this.label34.Text = "Km Percorrido Geral:";
            // 
            // label37
            // 
            this.label37.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label37.AutoSize = true;
            this.label37.BackColor = System.Drawing.Color.Transparent;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = System.Drawing.Color.White;
            this.label37.Location = new System.Drawing.Point(120, 238);
            this.label37.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(94, 20);
            this.label37.TabIndex = 65;
            this.label37.Text = "Rio Verde:";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(58, 276);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(218, 20);
            this.label18.TabIndex = 61;
            this.label18.Text = "Km Percorrido Embarque: ";
            // 
            // label36
            // 
            this.label36.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.Transparent;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.White;
            this.label36.Location = new System.Drawing.Point(48, 314);
            this.label36.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(238, 20);
            this.label36.TabIndex = 66;
            this.label36.Text = "Km Percorrido Desembarque";
            // 
            // label32
            // 
            this.label32.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Transparent;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label32.Location = new System.Drawing.Point(417, 238);
            this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(0, 20);
            this.label32.TabIndex = 39;
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(80, 356);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(175, 20);
            this.label24.TabIndex = 51;
            this.label24.Text = "Km Percorrido Geral:";
            // 
            // label31
            // 
            this.label31.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label31.Location = new System.Drawing.Point(417, 86);
            this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(0, 20);
            this.label31.TabIndex = 40;
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_kmGeralPVAI
            // 
            this.lb_kmGeralPVAI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_kmGeralPVAI.AutoSize = true;
            this.lb_kmGeralPVAI.BackColor = System.Drawing.Color.Transparent;
            this.lb_kmGeralPVAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_kmGeralPVAI.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_kmGeralPVAI.Location = new System.Drawing.Point(417, 48);
            this.lb_kmGeralPVAI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_kmGeralPVAI.Name = "lb_kmGeralPVAI";
            this.lb_kmGeralPVAI.Size = new System.Drawing.Size(0, 20);
            this.lb_kmGeralPVAI.TabIndex = 43;
            // 
            // lb_kmdesembarquepvai
            // 
            this.lb_kmdesembarquepvai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_kmdesembarquepvai.AutoSize = true;
            this.lb_kmdesembarquepvai.BackColor = System.Drawing.Color.Transparent;
            this.lb_kmdesembarquepvai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_kmdesembarquepvai.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_kmdesembarquepvai.Location = new System.Drawing.Point(417, 10);
            this.lb_kmdesembarquepvai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_kmdesembarquepvai.Name = "lb_kmdesembarquepvai";
            this.lb_kmdesembarquepvai.Size = new System.Drawing.Size(0, 20);
            this.lb_kmdesembarquepvai.TabIndex = 68;
            // 
            // lb_KmDesembarqueToo
            // 
            this.lb_KmDesembarqueToo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_KmDesembarqueToo.AutoSize = true;
            this.lb_KmDesembarqueToo.BackColor = System.Drawing.Color.Transparent;
            this.lb_KmDesembarqueToo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_KmDesembarqueToo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_KmDesembarqueToo.Location = new System.Drawing.Point(417, 162);
            this.lb_KmDesembarqueToo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_KmDesembarqueToo.Name = "lb_KmDesembarqueToo";
            this.lb_KmDesembarqueToo.Size = new System.Drawing.Size(0, 20);
            this.lb_KmDesembarqueToo.TabIndex = 49;
            // 
            // lb_KmGeralToo
            // 
            this.lb_KmGeralToo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_KmGeralToo.AutoSize = true;
            this.lb_KmGeralToo.BackColor = System.Drawing.Color.Transparent;
            this.lb_KmGeralToo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_KmGeralToo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_KmGeralToo.Location = new System.Drawing.Point(417, 200);
            this.lb_KmGeralToo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_KmGeralToo.Name = "lb_KmGeralToo";
            this.lb_KmGeralToo.Size = new System.Drawing.Size(0, 20);
            this.lb_KmGeralToo.TabIndex = 69;
            // 
            // btn_proximo
            // 
            this.btn_proximo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_proximo.BackColor = System.Drawing.Color.Black;
            this.btn_proximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_proximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_proximo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(175)))), ((int)(((byte)(75)))));
            this.btn_proximo.Location = new System.Drawing.Point(1372, 3);
            this.btn_proximo.Name = "btn_proximo";
            this.btn_proximo.Size = new System.Drawing.Size(30, 29);
            this.btn_proximo.TabIndex = 39;
            this.btn_proximo.Text = ">";
            this.btn_proximo.UseVisualStyleBackColor = false;
            this.btn_proximo.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel9.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel9.ColumnCount = 3;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel9.Controls.Add(this.btn_Close, 2, 0);
            this.tableLayoutPanel9.Controls.Add(this.btn_Maximizar, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.btn_Minimizar, 0, 0);
            this.tableLayoutPanel9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(1426, 0);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(110, 35);
            this.tableLayoutPanel9.TabIndex = 269;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Black;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(175)))), ((int)(((byte)(75)))));
            this.btn_Close.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Close.Location = new System.Drawing.Point(75, 3);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(32, 29);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.Text = "X";
            this.btn_Close.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Maximizar
            // 
            this.btn_Maximizar.BackColor = System.Drawing.Color.Black;
            this.btn_Maximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Maximizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Maximizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(175)))), ((int)(((byte)(75)))));
            this.btn_Maximizar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Maximizar.Location = new System.Drawing.Point(39, 3);
            this.btn_Maximizar.Name = "btn_Maximizar";
            this.btn_Maximizar.Size = new System.Drawing.Size(30, 29);
            this.btn_Maximizar.TabIndex = 1;
            this.btn_Maximizar.Text = "□";
            this.btn_Maximizar.UseVisualStyleBackColor = false;
            this.btn_Maximizar.Click += new System.EventHandler(this.btn_Maximizar_Click);
            // 
            // btn_Minimizar
            // 
            this.btn_Minimizar.BackColor = System.Drawing.Color.Black;
            this.btn_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_Minimizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(175)))), ((int)(((byte)(75)))));
            this.btn_Minimizar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Minimizar.Location = new System.Drawing.Point(3, 3);
            this.btn_Minimizar.Name = "btn_Minimizar";
            this.btn_Minimizar.Size = new System.Drawing.Size(30, 29);
            this.btn_Minimizar.TabIndex = 0;
            this.btn_Minimizar.Text = "-";
            this.btn_Minimizar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Minimizar.UseVisualStyleBackColor = false;
            this.btn_Minimizar.Click += new System.EventHandler(this.btn_Minimizar_Click);
            // 
            // Dashboard_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1536, 841);
            this.Controls.Add(this.tableLayoutPanel9);
            this.Controls.Add(this.btn_proximo);
            this.Controls.Add(this.page1);
            this.Controls.Add(this.btn_anterior);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.cb_fim);
            this.Controls.Add(this.cb_inicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_dataFinal);
            this.Controls.Add(this.tb_dataInicio);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard 2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.embarquesBrf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kmBrf)).EndInit();
            this.page1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kmTodos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.embarqueTodos)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.CheckBox cb_fim;
        private System.Windows.Forms.CheckBox cb_inicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker tb_dataFinal;
        private System.Windows.Forms.DateTimePicker tb_dataInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_anterior;
        private System.Windows.Forms.DataVisualization.Charting.Chart embarquesBrf;
        private System.Windows.Forms.DataVisualization.Charting.Chart kmBrf;
        private System.Windows.Forms.TableLayoutPanel page1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lb_contexto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_kmGeralGloria;
        private System.Windows.Forms.Label lm_kmDesembarqueGloria;
        private System.Windows.Forms.Label lb_kmGloriaEmbarque;
        private System.Windows.Forms.Label lb_kmTodosGeral;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_kmTodosDesembarque;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_kmTodosEmbarque;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lb_KmGeralRvio;
        private System.Windows.Forms.Label lb_KmDesembarqueRvio;
        private System.Windows.Forms.Label lb_KmEmbarqueRvio;
        private System.Windows.Forms.Label lb_KmDesembarqueToo;
        private System.Windows.Forms.Label lb_LmEmbarqueToo;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label lb_kmGeralPVAI;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lb_kmdesembarquepvai;
        private System.Windows.Forms.Label lb_KmGeralToo;
        private System.Windows.Forms.DataVisualization.Charting.Chart kmTodos;
        private System.Windows.Forms.DataVisualization.Charting.Chart embarqueTodos;
        private System.Windows.Forms.Button btn_proximo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lb_KmEmbarquePRVI;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Maximizar;
        private System.Windows.Forms.Button btn_Minimizar;
    }
}