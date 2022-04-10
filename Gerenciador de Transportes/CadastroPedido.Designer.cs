namespace Gerenciador_de_Transportes
{
    partial class CadastroPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroPedido));
            this.tb_cidadeDestino = new System.Windows.Forms.TextBox();
            this.sl_rota = new System.Windows.Forms.ComboBox();
            this.tb_cidadeOrigem = new System.Windows.Forms.TextBox();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Pedido = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_Cliente = new System.Windows.Forms.TextBox();
            this.tb_Pedagio = new System.Windows.Forms.TextBox();
            this.tb_Icms = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.D = new System.Windows.Forms.Label();
            this.tb_freteFiscal = new System.Windows.Forms.TextBox();
            this.tb_Classificao = new System.Windows.Forms.TextBox();
            this.tb_Km = new System.Windows.Forms.TextBox();
            this.tb_freteMotorista = new System.Windows.Forms.TextBox();
            this.tb_Embarcador = new System.Windows.Forms.ComboBox();
            this.sl_estadoDestinatario = new System.Windows.Forms.TextBox();
            this.sl_EstadoEmbarcador = new System.Windows.Forms.TextBox();
            this.tb_destinatario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_cidadeDestino
            // 
            this.tb_cidadeDestino.Enabled = false;
            this.tb_cidadeDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cidadeDestino.Location = new System.Drawing.Point(834, 63);
            this.tb_cidadeDestino.Name = "tb_cidadeDestino";
            this.tb_cidadeDestino.Size = new System.Drawing.Size(174, 26);
            this.tb_cidadeDestino.TabIndex = 5;
            this.tb_cidadeDestino.TabStop = false;
            // 
            // sl_rota
            // 
            this.sl_rota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sl_rota.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sl_rota.FormattingEnabled = true;
            this.sl_rota.Location = new System.Drawing.Point(221, 64);
            this.sl_rota.Name = "sl_rota";
            this.sl_rota.Size = new System.Drawing.Size(174, 26);
            this.sl_rota.TabIndex = 2;
            this.sl_rota.SelectedIndexChanged += new System.EventHandler(this.sl_rota_SelectedIndexChanged);
            // 
            // tb_cidadeOrigem
            // 
            this.tb_cidadeOrigem.Enabled = false;
            this.tb_cidadeOrigem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cidadeOrigem.Location = new System.Drawing.Point(630, 63);
            this.tb_cidadeOrigem.Name = "tb_cidadeOrigem";
            this.tb_cidadeOrigem.Size = new System.Drawing.Size(174, 26);
            this.tb_cidadeOrigem.TabIndex = 85;
            this.tb_cidadeOrigem.TabStop = false;
            // 
            // btn_voltar
            // 
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.Location = new System.Drawing.Point(209, 313);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(152, 32);
            this.btn_voltar.TabIndex = 15;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar.Location = new System.Drawing.Point(16, 313);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(152, 32);
            this.btn_cadastrar.TabIndex = 14;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(830, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Cidade de Destino:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(626, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Cidade de Origem:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(12, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Pedido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(217, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tipo de Rota:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(419, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Frete Fiscal:";
            // 
            // tb_Pedido
            // 
            this.tb_Pedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Pedido.Location = new System.Drawing.Point(16, 63);
            this.tb_Pedido.Name = "tb_Pedido";
            this.tb_Pedido.Size = new System.Drawing.Size(174, 26);
            this.tb_Pedido.TabIndex = 1;
            this.tb_Pedido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Pedido_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(419, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "Km:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(626, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 35;
            this.label7.Text = "Cliente:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(12, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 34;
            this.label8.Text = "Icms:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(217, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 20);
            this.label9.TabIndex = 33;
            this.label9.Text = "Pedágio:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(830, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(202, 20);
            this.label10.TabIndex = 32;
            this.label10.Text = "Classificação/Descarga:";
            // 
            // tb_Cliente
            // 
            this.tb_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Cliente.Location = new System.Drawing.Point(630, 159);
            this.tb_Cliente.Name = "tb_Cliente";
            this.tb_Cliente.Size = new System.Drawing.Size(174, 26);
            this.tb_Cliente.TabIndex = 7;
            // 
            // tb_Pedagio
            // 
            this.tb_Pedagio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Pedagio.Location = new System.Drawing.Point(221, 159);
            this.tb_Pedagio.Name = "tb_Pedagio";
            this.tb_Pedagio.Size = new System.Drawing.Size(174, 26);
            this.tb_Pedagio.TabIndex = 5;
            this.tb_Pedagio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Pedagio_KeyPress);
            // 
            // tb_Icms
            // 
            this.tb_Icms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Icms.Location = new System.Drawing.Point(16, 159);
            this.tb_Icms.Name = "tb_Icms";
            this.tb_Icms.Size = new System.Drawing.Size(174, 26);
            this.tb_Icms.TabIndex = 4;
            this.tb_Icms.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Icms_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(830, 215);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 20);
            this.label11.TabIndex = 46;
            this.label11.Text = "Frete Motorista:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(419, 322);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(174, 20);
            this.label12.TabIndex = 45;
            this.label12.Text = "Estado Destinatario:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(12, 215);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 20);
            this.label13.TabIndex = 44;
            this.label13.Text = "Embarcador:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(626, 215);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(173, 20);
            this.label14.TabIndex = 43;
            this.label14.Text = "Estado Embarcador:";
            // 
            // D
            // 
            this.D.AutoSize = true;
            this.D.BackColor = System.Drawing.Color.Transparent;
            this.D.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.D.Location = new System.Drawing.Point(419, 215);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(112, 20);
            this.D.TabIndex = 42;
            this.D.Text = "Destinatário:";
            // 
            // tb_freteFiscal
            // 
            this.tb_freteFiscal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_freteFiscal.Location = new System.Drawing.Point(423, 64);
            this.tb_freteFiscal.Name = "tb_freteFiscal";
            this.tb_freteFiscal.Size = new System.Drawing.Size(174, 26);
            this.tb_freteFiscal.TabIndex = 3;
            this.tb_freteFiscal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_freteFiscal_KeyPress);
            // 
            // tb_Classificao
            // 
            this.tb_Classificao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Classificao.Location = new System.Drawing.Point(834, 159);
            this.tb_Classificao.Name = "tb_Classificao";
            this.tb_Classificao.Size = new System.Drawing.Size(174, 26);
            this.tb_Classificao.TabIndex = 8;
            // 
            // tb_Km
            // 
            this.tb_Km.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Km.Location = new System.Drawing.Point(423, 159);
            this.tb_Km.Name = "tb_Km";
            this.tb_Km.Size = new System.Drawing.Size(174, 26);
            this.tb_Km.TabIndex = 6;
            this.tb_Km.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Km_KeyPress);
            // 
            // tb_freteMotorista
            // 
            this.tb_freteMotorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_freteMotorista.Location = new System.Drawing.Point(834, 254);
            this.tb_freteMotorista.Name = "tb_freteMotorista";
            this.tb_freteMotorista.Size = new System.Drawing.Size(174, 26);
            this.tb_freteMotorista.TabIndex = 13;
            this.tb_freteMotorista.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_freteMotorista_KeyPress);
            // 
            // tb_Embarcador
            // 
            this.tb_Embarcador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tb_Embarcador.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Embarcador.FormattingEnabled = true;
            this.tb_Embarcador.Location = new System.Drawing.Point(16, 254);
            this.tb_Embarcador.Name = "tb_Embarcador";
            this.tb_Embarcador.Size = new System.Drawing.Size(379, 26);
            this.tb_Embarcador.TabIndex = 186;
            this.tb_Embarcador.SelectedIndexChanged += new System.EventHandler(this.tb_Embarcador_SelectedIndexChanged);
            // 
            // sl_estadoDestinatario
            // 
            this.sl_estadoDestinatario.Enabled = false;
            this.sl_estadoDestinatario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sl_estadoDestinatario.Location = new System.Drawing.Point(630, 319);
            this.sl_estadoDestinatario.Name = "sl_estadoDestinatario";
            this.sl_estadoDestinatario.Size = new System.Drawing.Size(174, 26);
            this.sl_estadoDestinatario.TabIndex = 187;
            // 
            // sl_EstadoEmbarcador
            // 
            this.sl_EstadoEmbarcador.Enabled = false;
            this.sl_EstadoEmbarcador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sl_EstadoEmbarcador.Location = new System.Drawing.Point(630, 253);
            this.sl_EstadoEmbarcador.Name = "sl_EstadoEmbarcador";
            this.sl_EstadoEmbarcador.Size = new System.Drawing.Size(174, 26);
            this.sl_EstadoEmbarcador.TabIndex = 188;
            // 
            // tb_destinatario
            // 
            this.tb_destinatario.Enabled = false;
            this.tb_destinatario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_destinatario.Location = new System.Drawing.Point(423, 253);
            this.tb_destinatario.Name = "tb_destinatario";
            this.tb_destinatario.Size = new System.Drawing.Size(174, 26);
            this.tb_destinatario.TabIndex = 189;
            // 
            // CadastroPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1031, 354);
            this.Controls.Add(this.tb_destinatario);
            this.Controls.Add(this.sl_EstadoEmbarcador);
            this.Controls.Add(this.sl_estadoDestinatario);
            this.Controls.Add(this.tb_Embarcador);
            this.Controls.Add(this.tb_freteMotorista);
            this.Controls.Add(this.tb_Km);
            this.Controls.Add(this.tb_Classificao);
            this.Controls.Add(this.tb_freteFiscal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.D);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_Cliente);
            this.Controls.Add(this.tb_Pedagio);
            this.Controls.Add(this.tb_Icms);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Pedido);
            this.Controls.Add(this.tb_cidadeOrigem);
            this.Controls.Add(this.sl_rota);
            this.Controls.Add(this.tb_cidadeDestino);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CadastroPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Pedido";
            this.Load += new System.EventHandler(this.CadastroPedido_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_cidadeDestino;
        private System.Windows.Forms.ComboBox sl_rota;
        private System.Windows.Forms.TextBox tb_cidadeOrigem;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Pedido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_Cliente;
        private System.Windows.Forms.TextBox tb_Pedagio;
        private System.Windows.Forms.TextBox tb_Icms;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label D;
        private System.Windows.Forms.TextBox tb_freteFiscal;
        private System.Windows.Forms.TextBox tb_Classificao;
        private System.Windows.Forms.TextBox tb_Km;
        private System.Windows.Forms.TextBox tb_freteMotorista;
        private System.Windows.Forms.ComboBox tb_Embarcador;
        private System.Windows.Forms.TextBox sl_estadoDestinatario;
        private System.Windows.Forms.TextBox sl_EstadoEmbarcador;
        private System.Windows.Forms.TextBox tb_destinatario;
    }
}