namespace Gerenciador_de_Transportes
{
    partial class Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.EstadoDestino = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.embarquesFilial = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.EmbarquesPrazo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_dataInicio = new System.Windows.Forms.DateTimePicker();
            this.tb_dataFinal = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_inicio = new System.Windows.Forms.CheckBox();
            this.cb_fim = new System.Windows.Forms.CheckBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.DestinoPrazo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GeralPrazo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sl_contexto = new System.Windows.Forms.ComboBox();
            this.page1 = new System.Windows.Forms.TableLayoutPanel();
            this.EstadoOrigem = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_proximo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EstadoDestino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.embarquesFilial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmbarquesPrazo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DestinoPrazo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeralPrazo)).BeginInit();
            this.page1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EstadoOrigem)).BeginInit();
            this.SuspendLayout();
            // 
            // EstadoDestino
            // 
            this.EstadoDestino.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EstadoDestino.BorderlineColor = System.Drawing.Color.Black;
            this.EstadoDestino.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.EstadoDestino.BorderlineWidth = 3;
            chartArea1.Name = "ChartArea1";
            this.EstadoDestino.ChartAreas.Add(chartArea1);
            this.EstadoDestino.Location = new System.Drawing.Point(601, 406);
            this.EstadoDestino.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EstadoDestino.Name = "EstadoDestino";
            this.EstadoDestino.Size = new System.Drawing.Size(589, 398);
            this.EstadoDestino.TabIndex = 15;
            this.EstadoDestino.Text = "Estados de Destino";
            // 
            // embarquesFilial
            // 
            this.embarquesFilial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.embarquesFilial.BorderlineColor = System.Drawing.Color.Black;
            this.embarquesFilial.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.embarquesFilial.BorderlineWidth = 3;
            chartArea2.Name = "ChartArea1";
            this.embarquesFilial.ChartAreas.Add(chartArea2);
            this.embarquesFilial.Location = new System.Drawing.Point(1198, 406);
            this.embarquesFilial.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.embarquesFilial.Name = "embarquesFilial";
            this.embarquesFilial.Size = new System.Drawing.Size(589, 398);
            this.embarquesFilial.TabIndex = 17;
            this.embarquesFilial.Text = "Embarques";
            // 
            // EmbarquesPrazo
            // 
            this.EmbarquesPrazo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmbarquesPrazo.BorderlineColor = System.Drawing.Color.Black;
            this.EmbarquesPrazo.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.EmbarquesPrazo.BorderlineWidth = 3;
            chartArea3.Name = "ChartArea1";
            this.EmbarquesPrazo.ChartAreas.Add(chartArea3);
            this.EmbarquesPrazo.Location = new System.Drawing.Point(4, 3);
            this.EmbarquesPrazo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EmbarquesPrazo.Name = "EmbarquesPrazo";
            this.EmbarquesPrazo.Size = new System.Drawing.Size(589, 397);
            this.EmbarquesPrazo.TabIndex = 2;
            this.EmbarquesPrazo.Text = "Embarques";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Selecione o período: ";
            // 
            // tb_dataInicio
            // 
            this.tb_dataInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_dataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tb_dataInicio.Location = new System.Drawing.Point(562, 8);
            this.tb_dataInicio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_dataInicio.Name = "tb_dataInicio";
            this.tb_dataInicio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_dataInicio.Size = new System.Drawing.Size(202, 26);
            this.tb_dataInicio.TabIndex = 20;
            // 
            // tb_dataFinal
            // 
            this.tb_dataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_dataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tb_dataFinal.Location = new System.Drawing.Point(984, 9);
            this.tb_dataFinal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_dataFinal.Name = "tb_dataFinal";
            this.tb_dataFinal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_dataFinal.Size = new System.Drawing.Size(202, 26);
            this.tb_dataFinal.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(772, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "até";
            // 
            // cb_inicio
            // 
            this.cb_inicio.AutoSize = true;
            this.cb_inicio.BackColor = System.Drawing.Color.Transparent;
            this.cb_inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_inicio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cb_inicio.Location = new System.Drawing.Point(392, 12);
            this.cb_inicio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cb_inicio.Name = "cb_inicio";
            this.cb_inicio.Size = new System.Drawing.Size(134, 24);
            this.cb_inicio.TabIndex = 23;
            this.cb_inicio.Text = "Todo Período";
            this.cb_inicio.UseVisualStyleBackColor = false;
            this.cb_inicio.CheckedChanged += new System.EventHandler(this.cb_inicio_CheckedChanged);
            // 
            // cb_fim
            // 
            this.cb_fim.AutoSize = true;
            this.cb_fim.BackColor = System.Drawing.Color.Transparent;
            this.cb_fim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_fim.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cb_fim.Location = new System.Drawing.Point(820, 11);
            this.cb_fim.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cb_fim.Name = "cb_fim";
            this.cb_fim.Size = new System.Drawing.Size(134, 24);
            this.cb_fim.TabIndex = 24;
            this.cb_fim.Text = "Todo Período";
            this.cb_fim.UseVisualStyleBackColor = false;
            this.cb_fim.CheckedChanged += new System.EventHandler(this.cb_fim_CheckedChanged);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Location = new System.Drawing.Point(1222, 9);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(156, 26);
            this.btn_buscar.TabIndex = 1;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // DestinoPrazo
            // 
            this.DestinoPrazo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DestinoPrazo.BorderlineColor = System.Drawing.Color.Black;
            this.DestinoPrazo.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.DestinoPrazo.BorderlineWidth = 3;
            chartArea4.Name = "ChartArea1";
            this.DestinoPrazo.ChartAreas.Add(chartArea4);
            this.DestinoPrazo.Location = new System.Drawing.Point(601, 3);
            this.DestinoPrazo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DestinoPrazo.Name = "DestinoPrazo";
            this.DestinoPrazo.Size = new System.Drawing.Size(589, 397);
            this.DestinoPrazo.TabIndex = 25;
            this.DestinoPrazo.Text = "Embarques";
            // 
            // GeralPrazo
            // 
            this.GeralPrazo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GeralPrazo.BorderlineColor = System.Drawing.Color.Black;
            this.GeralPrazo.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.GeralPrazo.BorderlineWidth = 3;
            chartArea5.Name = "ChartArea1";
            this.GeralPrazo.ChartAreas.Add(chartArea5);
            this.GeralPrazo.Location = new System.Drawing.Point(1198, 3);
            this.GeralPrazo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GeralPrazo.Name = "GeralPrazo";
            this.GeralPrazo.Size = new System.Drawing.Size(589, 397);
            this.GeralPrazo.TabIndex = 26;
            this.GeralPrazo.Text = "Embarques";
            // 
            // sl_contexto
            // 
            this.sl_contexto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sl_contexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sl_contexto.FormattingEnabled = true;
            this.sl_contexto.Items.AddRange(new object[] {
            "Todos",
            "Glória de Dourados",
            "Paranavaí",
            "Toledo",
            "Rio Verde"});
            this.sl_contexto.Location = new System.Drawing.Point(194, 9);
            this.sl_contexto.Name = "sl_contexto";
            this.sl_contexto.Size = new System.Drawing.Size(174, 26);
            this.sl_contexto.TabIndex = 27;
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
            this.page1.Controls.Add(this.EstadoOrigem, 0, 1);
            this.page1.Controls.Add(this.DestinoPrazo, 1, 0);
            this.page1.Controls.Add(this.GeralPrazo, 2, 0);
            this.page1.Controls.Add(this.EmbarquesPrazo, 0, 0);
            this.page1.Controls.Add(this.embarquesFilial, 2, 1);
            this.page1.Controls.Add(this.EstadoDestino, 1, 1);
            this.page1.Location = new System.Drawing.Point(12, 38);
            this.page1.Name = "page1";
            this.page1.RowCount = 2;
            this.page1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.page1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.page1.Size = new System.Drawing.Size(1791, 807);
            this.page1.TabIndex = 28;
            // 
            // EstadoOrigem
            // 
            this.EstadoOrigem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EstadoOrigem.BorderlineColor = System.Drawing.Color.Black;
            this.EstadoOrigem.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.EstadoOrigem.BorderlineWidth = 3;
            chartArea6.Name = "ChartArea1";
            this.EstadoOrigem.ChartAreas.Add(chartArea6);
            this.EstadoOrigem.Location = new System.Drawing.Point(4, 406);
            this.EstadoOrigem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EstadoOrigem.Name = "EstadoOrigem";
            this.EstadoOrigem.Size = new System.Drawing.Size(589, 398);
            this.EstadoOrigem.TabIndex = 28;
            this.EstadoOrigem.Text = "Embarques";
            // 
            // btn_proximo
            // 
            this.btn_proximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_proximo.Location = new System.Drawing.Point(1431, 11);
            this.btn_proximo.Name = "btn_proximo";
            this.btn_proximo.Size = new System.Drawing.Size(26, 26);
            this.btn_proximo.TabIndex = 29;
            this.btn_proximo.Text = ">";
            this.btn_proximo.UseVisualStyleBackColor = true;
            this.btn_proximo.Click += new System.EventHandler(this.btn_proximo_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1806, 857);
            this.Controls.Add(this.btn_proximo);
            this.Controls.Add(this.page1);
            this.Controls.Add(this.sl_contexto);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.cb_fim);
            this.Controls.Add(this.cb_inicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_dataFinal);
            this.Controls.Add(this.tb_dataInicio);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EstadoDestino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.embarquesFilial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmbarquesPrazo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DestinoPrazo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeralPrazo)).EndInit();
            this.page1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EstadoOrigem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart EstadoDestino;
        private System.Windows.Forms.DataVisualization.Charting.Chart embarquesFilial;
        private System.Windows.Forms.DataVisualization.Charting.Chart EmbarquesPrazo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker tb_dataInicio;
        private System.Windows.Forms.DateTimePicker tb_dataFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cb_inicio;
        private System.Windows.Forms.CheckBox cb_fim;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.DataVisualization.Charting.Chart DestinoPrazo;
        private System.Windows.Forms.DataVisualization.Charting.Chart GeralPrazo;
        private System.Windows.Forms.ComboBox sl_contexto;
        private System.Windows.Forms.TableLayoutPanel page1;
        private System.Windows.Forms.DataVisualization.Charting.Chart EstadoOrigem;
        private System.Windows.Forms.Button btn_proximo;
    }
}