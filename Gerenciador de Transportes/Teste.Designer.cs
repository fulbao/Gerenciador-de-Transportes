namespace Gerenciador_de_Transportes
{
    partial class Teste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teste));
            this.tb_dataUm = new System.Windows.Forms.DateTimePicker();
            this.tb_dataDois = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_acao = new System.Windows.Forms.Button();
            this.btn_drop = new System.Windows.Forms.Button();
            this.tb_teste = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_dataUm
            // 
            this.tb_dataUm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_dataUm.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tb_dataUm.Location = new System.Drawing.Point(138, 143);
            this.tb_dataUm.Name = "tb_dataUm";
            this.tb_dataUm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_dataUm.Size = new System.Drawing.Size(174, 26);
            this.tb_dataUm.TabIndex = 7;
            // 
            // tb_dataDois
            // 
            this.tb_dataDois.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_dataDois.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tb_dataDois.Location = new System.Drawing.Point(442, 143);
            this.tb_dataDois.Name = "tb_dataDois";
            this.tb_dataDois.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_dataDois.Size = new System.Drawing.Size(174, 26);
            this.tb_dataDois.TabIndex = 8;
            this.tb_dataDois.ValueChanged += new System.EventHandler(this.tb_dataDois_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Você não deveria estar aqui!";
            // 
            // btn_acao
            // 
            this.btn_acao.Location = new System.Drawing.Point(304, 334);
            this.btn_acao.Name = "btn_acao";
            this.btn_acao.Size = new System.Drawing.Size(144, 30);
            this.btn_acao.TabIndex = 10;
            this.btn_acao.Text = "AÇÃO";
            this.btn_acao.UseVisualStyleBackColor = true;
            this.btn_acao.Click += new System.EventHandler(this.btn_acao_Click);
            // 
            // btn_drop
            // 
            this.btn_drop.Location = new System.Drawing.Point(615, 372);
            this.btn_drop.Name = "btn_drop";
            this.btn_drop.Size = new System.Drawing.Size(144, 30);
            this.btn_drop.TabIndex = 11;
            this.btn_drop.Text = "D VEICULOS";
            this.btn_drop.UseVisualStyleBackColor = true;
            this.btn_drop.Click += new System.EventHandler(this.btn_drop_Click);
            // 
            // tb_teste
            // 
            this.tb_teste.Location = new System.Drawing.Point(506, 234);
            this.tb_teste.Name = "tb_teste";
            this.tb_teste.Size = new System.Drawing.Size(242, 20);
            this.tb_teste.TabIndex = 12;
            // 
            // Teste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_teste);
            this.Controls.Add(this.btn_drop);
            this.Controls.Add(this.btn_acao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_dataDois);
            this.Controls.Add(this.tb_dataUm);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Teste";
            this.Text = "Testes";
            this.Load += new System.EventHandler(this.Teste_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker tb_dataUm;
        private System.Windows.Forms.DateTimePicker tb_dataDois;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_acao;
        private System.Windows.Forms.Button btn_drop;
        private System.Windows.Forms.TextBox tb_teste;
    }
}