namespace Gerenciador_de_Transportes
{
    partial class Dashboard_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard_3));
            this.btn_anterior = new System.Windows.Forms.Button();
            this.page1 = new System.Windows.Forms.TableLayoutPanel();
            this.embarquesPorEstado = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sl_contexto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.sl_destinatario = new System.Windows.Forms.ComboBox();
            this.page1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.embarquesPorEstado)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_anterior
            // 
            this.btn_anterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_anterior.Location = new System.Drawing.Point(868, 6);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(26, 26);
            this.btn_anterior.TabIndex = 38;
            this.btn_anterior.Text = "<";
            this.btn_anterior.UseVisualStyleBackColor = true;
            this.btn_anterior.Click += new System.EventHandler(this.btn_anterior_Click);
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
            this.page1.Controls.Add(this.embarquesPorEstado, 0, 0);
            this.page1.Location = new System.Drawing.Point(8, 37);
            this.page1.Name = "page1";
            this.page1.RowCount = 2;
            this.page1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.page1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.page1.Size = new System.Drawing.Size(1791, 808);
            this.page1.TabIndex = 39;
            // 
            // embarquesPorEstado
            // 
            this.embarquesPorEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.embarquesPorEstado.BorderlineColor = System.Drawing.Color.Black;
            this.embarquesPorEstado.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.embarquesPorEstado.BorderlineWidth = 3;
            chartArea1.Name = "ChartArea1";
            this.embarquesPorEstado.ChartAreas.Add(chartArea1);
            this.embarquesPorEstado.Location = new System.Drawing.Point(4, 3);
            this.embarquesPorEstado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.embarquesPorEstado.Name = "embarquesPorEstado";
            this.embarquesPorEstado.Size = new System.Drawing.Size(589, 398);
            this.embarquesPorEstado.TabIndex = 43;
            this.embarquesPorEstado.Text = "Embarques/estado";
            // 
            // sl_contexto
            // 
            this.sl_contexto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sl_contexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sl_contexto.FormattingEnabled = true;
            this.sl_contexto.Items.AddRange(new object[] {
            "Todas",
            "Glória de Dourados",
            "Paranavaí",
            "Toledo",
            "Rio Verde"});
            this.sl_contexto.Location = new System.Drawing.Point(86, 5);
            this.sl_contexto.Name = "sl_contexto";
            this.sl_contexto.Size = new System.Drawing.Size(174, 26);
            this.sl_contexto.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "Filial:";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Location = new System.Drawing.Point(649, 5);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(156, 26);
            this.btn_buscar.TabIndex = 42;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(297, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "Destinatário:";
            // 
            // sl_destinatario
            // 
            this.sl_destinatario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sl_destinatario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sl_destinatario.FormattingEnabled = true;
            this.sl_destinatario.Location = new System.Drawing.Point(427, 5);
            this.sl_destinatario.Name = "sl_destinatario";
            this.sl_destinatario.Size = new System.Drawing.Size(174, 26);
            this.sl_destinatario.TabIndex = 44;
            // 
            // Dashboard_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1806, 857);
            this.Controls.Add(this.sl_destinatario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sl_contexto);
            this.Controls.Add(this.page1);
            this.Controls.Add(this.btn_anterior);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard_3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard 3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_3_Load);
            this.page1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.embarquesPorEstado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_anterior;
        private System.Windows.Forms.TableLayoutPanel page1;
        private System.Windows.Forms.DataVisualization.Charting.Chart embarquesPorEstado;
        private System.Windows.Forms.ComboBox sl_contexto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox sl_destinatario;
    }
}