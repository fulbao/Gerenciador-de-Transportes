namespace Gerenciador_de_Transportes
{
    partial class Cadastro_de_Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro_de_Usuario));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Usuario = new System.Windows.Forms.Label();
            this.tb_usuario = new System.Windows.Forms.TextBox();
            this.Senha = new System.Windows.Forms.Label();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cb_obterUsuario = new System.Windows.Forms.CheckBox();
            this.cb_dashboard = new System.Windows.Forms.CheckBox();
            this.cb_cadastroUsuario = new System.Windows.Forms.CheckBox();
            this.cb_rota = new System.Windows.Forms.CheckBox();
            this.cb_veiculos = new System.Windows.Forms.CheckBox();
            this.cb_pedido = new System.Windows.Forms.CheckBox();
            this.cb_rioVerde = new System.Windows.Forms.CheckBox();
            this.cb_toledo = new System.Windows.Forms.CheckBox();
            this.cb_paranavai = new System.Windows.Forms.CheckBox();
            this.cb_gloria = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Usuario, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_usuario, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Senha, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb_senha, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(75, 39);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(167, 178);
            this.tableLayoutPanel1.TabIndex = 6;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // Usuario
            // 
            this.Usuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Usuario.AutoSize = true;
            this.Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Usuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Usuario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Usuario.Location = new System.Drawing.Point(45, 15);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(76, 20);
            this.Usuario.TabIndex = 3;
            this.Usuario.Text = "Usuário:";
            // 
            // tb_usuario
            // 
            this.tb_usuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_usuario.Location = new System.Drawing.Point(5, 53);
            this.tb_usuario.Name = "tb_usuario";
            this.tb_usuario.Size = new System.Drawing.Size(157, 26);
            this.tb_usuario.TabIndex = 1;
            this.tb_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Senha
            // 
            this.Senha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Senha.AutoSize = true;
            this.Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Senha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Senha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Senha.Location = new System.Drawing.Point(50, 93);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(66, 20);
            this.Senha.TabIndex = 4;
            this.Senha.Text = "Senha:";
            // 
            // tb_senha
            // 
            this.tb_senha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_senha.Location = new System.Drawing.Point(5, 131);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.PasswordChar = '*';
            this.tb_senha.Size = new System.Drawing.Size(157, 26);
            this.tb_senha.TabIndex = 2;
            this.tb_senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Cadastrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Cadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btn_Cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_Cadastrar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Cadastrar.Location = new System.Drawing.Point(92, 585);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(135, 30);
            this.btn_Cadastrar.TabIndex = 4;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.cb_obterUsuario, 0, 10);
            this.tableLayoutPanel2.Controls.Add(this.cb_dashboard, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.cb_cadastroUsuario, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.cb_rota, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.cb_veiculos, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.cb_pedido, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.cb_rioVerde, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.cb_toledo, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.cb_paranavai, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.cb_gloria, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(75, 207);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 11;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(167, 372);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // cb_obterUsuario
            // 
            this.cb_obterUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_obterUsuario.AutoSize = true;
            this.cb_obterUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_obterUsuario.ForeColor = System.Drawing.Color.Cornsilk;
            this.cb_obterUsuario.Location = new System.Drawing.Point(3, 333);
            this.cb_obterUsuario.Name = "cb_obterUsuario";
            this.cb_obterUsuario.Size = new System.Drawing.Size(161, 36);
            this.cb_obterUsuario.TabIndex = 17;
            this.cb_obterUsuario.Text = "Obter Usuário";
            this.cb_obterUsuario.UseVisualStyleBackColor = true;
            // 
            // cb_dashboard
            // 
            this.cb_dashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_dashboard.AutoSize = true;
            this.cb_dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_dashboard.ForeColor = System.Drawing.Color.Cornsilk;
            this.cb_dashboard.Location = new System.Drawing.Point(3, 300);
            this.cb_dashboard.Name = "cb_dashboard";
            this.cb_dashboard.Size = new System.Drawing.Size(161, 27);
            this.cb_dashboard.TabIndex = 16;
            this.cb_dashboard.Text = "Dashboard";
            this.cb_dashboard.UseVisualStyleBackColor = true;
            // 
            // cb_cadastroUsuario
            // 
            this.cb_cadastroUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_cadastroUsuario.AutoSize = true;
            this.cb_cadastroUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_cadastroUsuario.ForeColor = System.Drawing.Color.Cornsilk;
            this.cb_cadastroUsuario.Location = new System.Drawing.Point(3, 267);
            this.cb_cadastroUsuario.Name = "cb_cadastroUsuario";
            this.cb_cadastroUsuario.Size = new System.Drawing.Size(161, 27);
            this.cb_cadastroUsuario.TabIndex = 15;
            this.cb_cadastroUsuario.Text = "Cadastro Usuário";
            this.cb_cadastroUsuario.UseVisualStyleBackColor = true;
            // 
            // cb_rota
            // 
            this.cb_rota.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_rota.AutoSize = true;
            this.cb_rota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_rota.ForeColor = System.Drawing.Color.Cornsilk;
            this.cb_rota.Location = new System.Drawing.Point(3, 234);
            this.cb_rota.Name = "cb_rota";
            this.cb_rota.Size = new System.Drawing.Size(161, 27);
            this.cb_rota.TabIndex = 14;
            this.cb_rota.Text = "Rotas";
            this.cb_rota.UseVisualStyleBackColor = true;
            // 
            // cb_veiculos
            // 
            this.cb_veiculos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_veiculos.AutoSize = true;
            this.cb_veiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_veiculos.ForeColor = System.Drawing.Color.Cornsilk;
            this.cb_veiculos.Location = new System.Drawing.Point(3, 201);
            this.cb_veiculos.Name = "cb_veiculos";
            this.cb_veiculos.Size = new System.Drawing.Size(161, 27);
            this.cb_veiculos.TabIndex = 13;
            this.cb_veiculos.Text = "Veículos";
            this.cb_veiculos.UseVisualStyleBackColor = true;
            // 
            // cb_pedido
            // 
            this.cb_pedido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_pedido.AutoSize = true;
            this.cb_pedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_pedido.ForeColor = System.Drawing.Color.Cornsilk;
            this.cb_pedido.Location = new System.Drawing.Point(3, 168);
            this.cb_pedido.Name = "cb_pedido";
            this.cb_pedido.Size = new System.Drawing.Size(161, 27);
            this.cb_pedido.TabIndex = 12;
            this.cb_pedido.Text = "Pedido";
            this.cb_pedido.UseVisualStyleBackColor = true;
            // 
            // cb_rioVerde
            // 
            this.cb_rioVerde.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_rioVerde.AutoSize = true;
            this.cb_rioVerde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_rioVerde.ForeColor = System.Drawing.Color.Cornsilk;
            this.cb_rioVerde.Location = new System.Drawing.Point(3, 135);
            this.cb_rioVerde.Name = "cb_rioVerde";
            this.cb_rioVerde.Size = new System.Drawing.Size(161, 27);
            this.cb_rioVerde.TabIndex = 11;
            this.cb_rioVerde.Text = "Rio Verde";
            this.cb_rioVerde.UseVisualStyleBackColor = true;
            // 
            // cb_toledo
            // 
            this.cb_toledo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_toledo.AutoSize = true;
            this.cb_toledo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_toledo.ForeColor = System.Drawing.Color.Cornsilk;
            this.cb_toledo.Location = new System.Drawing.Point(3, 102);
            this.cb_toledo.Name = "cb_toledo";
            this.cb_toledo.Size = new System.Drawing.Size(161, 27);
            this.cb_toledo.TabIndex = 10;
            this.cb_toledo.Text = "Toledo";
            this.cb_toledo.UseVisualStyleBackColor = true;
            // 
            // cb_paranavai
            // 
            this.cb_paranavai.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_paranavai.AutoSize = true;
            this.cb_paranavai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_paranavai.ForeColor = System.Drawing.Color.Cornsilk;
            this.cb_paranavai.Location = new System.Drawing.Point(3, 69);
            this.cb_paranavai.Name = "cb_paranavai";
            this.cb_paranavai.Size = new System.Drawing.Size(161, 27);
            this.cb_paranavai.TabIndex = 9;
            this.cb_paranavai.Text = "Paranavaí";
            this.cb_paranavai.UseVisualStyleBackColor = true;
            // 
            // cb_gloria
            // 
            this.cb_gloria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_gloria.AutoSize = true;
            this.cb_gloria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_gloria.ForeColor = System.Drawing.Color.Cornsilk;
            this.cb_gloria.Location = new System.Drawing.Point(3, 36);
            this.cb_gloria.Name = "cb_gloria";
            this.cb_gloria.Size = new System.Drawing.Size(161, 27);
            this.cb_gloria.TabIndex = 8;
            this.cb_gloria.Text = "Glória";
            this.cb_gloria.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(30, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Permissões:";
            // 
            // Cadastro_de_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(319, 654);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btn_Cadastrar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Cadastro_de_Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuário";
            this.Load += new System.EventHandler(this.Cadastro_de_Usuario_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.TextBox tb_usuario;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.Label Senha;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckBox cb_dashboard;
        private System.Windows.Forms.CheckBox cb_cadastroUsuario;
        private System.Windows.Forms.CheckBox cb_rota;
        private System.Windows.Forms.CheckBox cb_veiculos;
        private System.Windows.Forms.CheckBox cb_pedido;
        private System.Windows.Forms.CheckBox cb_rioVerde;
        private System.Windows.Forms.CheckBox cb_toledo;
        private System.Windows.Forms.CheckBox cb_paranavai;
        private System.Windows.Forms.CheckBox cb_gloria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cb_obterUsuario;
    }
}