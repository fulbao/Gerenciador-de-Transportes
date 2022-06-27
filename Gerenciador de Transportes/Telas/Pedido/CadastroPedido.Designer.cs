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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label39 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Minimizar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_cidadeDestino
            // 
            this.tb_cidadeDestino.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_cidadeDestino.Enabled = false;
            this.tb_cidadeDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cidadeDestino.Location = new System.Drawing.Point(1126, 23);
            this.tb_cidadeDestino.Name = "tb_cidadeDestino";
            this.tb_cidadeDestino.Size = new System.Drawing.Size(174, 26);
            this.tb_cidadeDestino.TabIndex = 5;
            this.tb_cidadeDestino.TabStop = false;
            // 
            // sl_rota
            // 
            this.sl_rota.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sl_rota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sl_rota.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sl_rota.FormattingEnabled = true;
            this.sl_rota.Location = new System.Drawing.Point(465, 23);
            this.sl_rota.Name = "sl_rota";
            this.sl_rota.Size = new System.Drawing.Size(174, 26);
            this.sl_rota.TabIndex = 2;
            this.sl_rota.SelectedIndexChanged += new System.EventHandler(this.sl_rota_SelectedIndexChanged);
            // 
            // tb_cidadeOrigem
            // 
            this.tb_cidadeOrigem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_cidadeOrigem.Enabled = false;
            this.tb_cidadeOrigem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cidadeOrigem.Location = new System.Drawing.Point(909, 23);
            this.tb_cidadeOrigem.Name = "tb_cidadeOrigem";
            this.tb_cidadeOrigem.Size = new System.Drawing.Size(174, 26);
            this.tb_cidadeOrigem.TabIndex = 85;
            this.tb_cidadeOrigem.TabStop = false;
            // 
            // btn_voltar
            // 
            this.btn_voltar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.Image = global::Gerenciador_de_Transportes.Properties.Resources.voltar;
            this.btn_voltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_voltar.Location = new System.Drawing.Point(920, 223);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(152, 32);
            this.btn_voltar.TabIndex = 15;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar.Image = global::Gerenciador_de_Transportes.Properties.Resources.confirme;
            this.btn_cadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cadastrar.Location = new System.Drawing.Point(1137, 223);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(152, 32);
            this.btn_cadastrar.TabIndex = 14;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(175)))), ((int)(((byte)(75)))));
            this.label5.Location = new System.Drawing.Point(1132, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Cidade de Destino:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(175)))), ((int)(((byte)(75)))));
            this.label4.Location = new System.Drawing.Point(917, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Cidade de Origem:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(175)))), ((int)(((byte)(75)))));
            this.label3.Location = new System.Drawing.Point(183, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Pedido:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(175)))), ((int)(((byte)(75)))));
            this.label2.Location = new System.Drawing.Point(494, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tipo de Rota:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(175)))), ((int)(((byte)(75)))));
            this.label1.Location = new System.Drawing.Point(729, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Frete Fiscal:";
            // 
            // tb_Pedido
            // 
            this.tb_Pedido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_Pedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Pedido.Location = new System.Drawing.Point(130, 23);
            this.tb_Pedido.Name = "tb_Pedido";
            this.tb_Pedido.Size = new System.Drawing.Size(174, 26);
            this.tb_Pedido.TabIndex = 1;
            this.tb_Pedido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Pedido_KeyPress);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(175)))), ((int)(((byte)(75)))));
            this.label6.Location = new System.Drawing.Point(764, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "Km:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(175)))), ((int)(((byte)(75)))));
            this.label7.Location = new System.Drawing.Point(961, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 35;
            this.label7.Text = "Cliente:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(175)))), ((int)(((byte)(75)))));
            this.label8.Location = new System.Drawing.Point(191, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 34;
            this.label8.Text = "Icms:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(175)))), ((int)(((byte)(75)))));
            this.label9.Location = new System.Drawing.Point(513, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 20);
            this.label9.TabIndex = 33;
            this.label9.Text = "Pedágio:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(175)))), ((int)(((byte)(75)))));
            this.label10.Location = new System.Drawing.Point(1112, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(202, 20);
            this.label10.TabIndex = 32;
            this.label10.Text = "Classificação/Descarga:";
            // 
            // tb_Cliente
            // 
            this.tb_Cliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Cliente.Location = new System.Drawing.Point(909, 98);
            this.tb_Cliente.Name = "tb_Cliente";
            this.tb_Cliente.Size = new System.Drawing.Size(174, 26);
            this.tb_Cliente.TabIndex = 7;
            // 
            // tb_Pedagio
            // 
            this.tb_Pedagio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_Pedagio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Pedagio.Location = new System.Drawing.Point(465, 98);
            this.tb_Pedagio.Name = "tb_Pedagio";
            this.tb_Pedagio.Size = new System.Drawing.Size(174, 26);
            this.tb_Pedagio.TabIndex = 5;
            this.tb_Pedagio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Pedagio_KeyPress);
            // 
            // tb_Icms
            // 
            this.tb_Icms.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_Icms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Icms.Location = new System.Drawing.Point(130, 98);
            this.tb_Icms.Name = "tb_Icms";
            this.tb_Icms.Size = new System.Drawing.Size(174, 26);
            this.tb_Icms.TabIndex = 4;
            this.tb_Icms.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Icms_KeyPress);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(175)))), ((int)(((byte)(75)))));
            this.label11.Location = new System.Drawing.Point(927, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 20);
            this.label11.TabIndex = 46;
            this.label11.Text = "Frete Motorista:";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(175)))), ((int)(((byte)(75)))));
            this.label12.Location = new System.Drawing.Point(1126, 145);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(174, 20);
            this.label12.TabIndex = 45;
            this.label12.Text = "Estado Destinatario:";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(175)))), ((int)(((byte)(75)))));
            this.label13.Location = new System.Drawing.Point(162, 145);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 20);
            this.label13.TabIndex = 44;
            this.label13.Text = "Embarcador:";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(175)))), ((int)(((byte)(75)))));
            this.label14.Location = new System.Drawing.Point(697, 145);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(173, 20);
            this.label14.TabIndex = 43;
            this.label14.Text = "Estado Embarcador:";
            // 
            // D
            // 
            this.D.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.D.AutoSize = true;
            this.D.BackColor = System.Drawing.Color.Transparent;
            this.D.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(175)))), ((int)(((byte)(75)))));
            this.D.Location = new System.Drawing.Point(496, 145);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(112, 20);
            this.D.TabIndex = 42;
            this.D.Text = "Destinatário:";
            // 
            // tb_freteFiscal
            // 
            this.tb_freteFiscal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_freteFiscal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_freteFiscal.Location = new System.Drawing.Point(696, 23);
            this.tb_freteFiscal.Name = "tb_freteFiscal";
            this.tb_freteFiscal.Size = new System.Drawing.Size(174, 26);
            this.tb_freteFiscal.TabIndex = 3;
            this.tb_freteFiscal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_freteFiscal_KeyPress);
            // 
            // tb_Classificao
            // 
            this.tb_Classificao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_Classificao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Classificao.Location = new System.Drawing.Point(1126, 98);
            this.tb_Classificao.Name = "tb_Classificao";
            this.tb_Classificao.Size = new System.Drawing.Size(174, 26);
            this.tb_Classificao.TabIndex = 8;
            // 
            // tb_Km
            // 
            this.tb_Km.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_Km.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Km.Location = new System.Drawing.Point(696, 98);
            this.tb_Km.Name = "tb_Km";
            this.tb_Km.Size = new System.Drawing.Size(174, 26);
            this.tb_Km.TabIndex = 6;
            this.tb_Km.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Km_KeyPress);
            // 
            // tb_freteMotorista
            // 
            this.tb_freteMotorista.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_freteMotorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_freteMotorista.Location = new System.Drawing.Point(909, 173);
            this.tb_freteMotorista.Name = "tb_freteMotorista";
            this.tb_freteMotorista.Size = new System.Drawing.Size(174, 26);
            this.tb_freteMotorista.TabIndex = 13;
            this.tb_freteMotorista.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_freteMotorista_KeyPress);
            // 
            // tb_Embarcador
            // 
            this.tb_Embarcador.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_Embarcador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tb_Embarcador.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Embarcador.FormattingEnabled = true;
            this.tb_Embarcador.Location = new System.Drawing.Point(28, 173);
            this.tb_Embarcador.Name = "tb_Embarcador";
            this.tb_Embarcador.Size = new System.Drawing.Size(379, 26);
            this.tb_Embarcador.TabIndex = 186;
            this.tb_Embarcador.SelectedIndexChanged += new System.EventHandler(this.tb_Embarcador_SelectedIndexChanged);
            // 
            // sl_estadoDestinatario
            // 
            this.sl_estadoDestinatario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sl_estadoDestinatario.Enabled = false;
            this.sl_estadoDestinatario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sl_estadoDestinatario.Location = new System.Drawing.Point(1126, 173);
            this.sl_estadoDestinatario.Name = "sl_estadoDestinatario";
            this.sl_estadoDestinatario.Size = new System.Drawing.Size(174, 26);
            this.sl_estadoDestinatario.TabIndex = 187;
            // 
            // sl_EstadoEmbarcador
            // 
            this.sl_EstadoEmbarcador.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sl_EstadoEmbarcador.Enabled = false;
            this.sl_EstadoEmbarcador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sl_EstadoEmbarcador.Location = new System.Drawing.Point(696, 173);
            this.sl_EstadoEmbarcador.Name = "sl_EstadoEmbarcador";
            this.sl_EstadoEmbarcador.Size = new System.Drawing.Size(174, 26);
            this.sl_EstadoEmbarcador.TabIndex = 188;
            // 
            // tb_destinatario
            // 
            this.tb_destinatario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_destinatario.Enabled = false;
            this.tb_destinatario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_destinatario.Location = new System.Drawing.Point(465, 173);
            this.tb_destinatario.Name = "tb_destinatario";
            this.tb_destinatario.Size = new System.Drawing.Size(174, 26);
            this.tb_destinatario.TabIndex = 189;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(175)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.label39);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(12, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1360, 361);
            this.panel1.TabIndex = 190;
            // 
            // label39
            // 
            this.label39.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label39.AutoSize = true;
            this.label39.BackColor = System.Drawing.Color.Transparent;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.ForeColor = System.Drawing.Color.White;
            this.label39.Location = new System.Drawing.Point(600, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(167, 20);
            this.label39.TabIndex = 94;
            this.label39.Text = "Cadastro de Pedido";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Honeydew;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel6, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label15, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(14, 35);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1332, 32);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(3, 23);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1326, 2);
            this.panel6.TabIndex = 112;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(175)))), ((int)(((byte)(75)))));
            this.label15.Location = new System.Drawing.Point(603, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(126, 20);
            this.label15.TabIndex = 22;
            this.label15.Text = "Dados Pedido:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Honeydew;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.95868F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.04132F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 227F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 198F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 236F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.sl_EstadoEmbarcador, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.tb_freteMotorista, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.tb_destinatario, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label11, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.tb_Pedido, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.sl_rota, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_Embarcador, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label14, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_freteFiscal, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_Classificao, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.D, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tb_Km, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_cidadeOrigem, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_cidadeDestino, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label10, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb_Cliente, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.tb_Icms, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label9, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb_Pedagio, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label12, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.sl_estadoDestinatario, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.btn_voltar, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.btn_cadastrar, 4, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 66);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1332, 272);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.btn_Close, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_Minimizar, 1, 0);
            this.tableLayoutPanel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(1272, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(110, 35);
            this.tableLayoutPanel3.TabIndex = 191;
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
            // btn_Minimizar
            // 
            this.btn_Minimizar.BackColor = System.Drawing.Color.Black;
            this.btn_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_Minimizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(175)))), ((int)(((byte)(75)))));
            this.btn_Minimizar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Minimizar.Location = new System.Drawing.Point(39, 3);
            this.btn_Minimizar.Name = "btn_Minimizar";
            this.btn_Minimizar.Size = new System.Drawing.Size(30, 29);
            this.btn_Minimizar.TabIndex = 0;
            this.btn_Minimizar.Text = "-";
            this.btn_Minimizar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Minimizar.UseVisualStyleBackColor = false;
            this.btn_Minimizar.Click += new System.EventHandler(this.btn_Minimizar_Click);
            // 
            // CadastroPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gerenciador_de_Transportes.Properties.Resources.transscalcom;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1384, 414);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CadastroPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Pedido";
            this.Load += new System.EventHandler(this.CadastroPedido_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Minimizar;
    }
}