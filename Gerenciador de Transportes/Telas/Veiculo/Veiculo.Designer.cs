namespace Gerenciador_de_Transportes
{
    partial class Veículos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Veículos));
            this.btn_deletar = new System.Windows.Forms.Button();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.lv_Veiculos = new System.Windows.Forms.ListView();
            this.col_Rota = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CidadeOrigem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EstadoOrigem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CidadeDestino = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EstadoDestino = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_usuario = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_motoristas = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Maximizar = new System.Windows.Forms.Button();
            this.btn_Minimizar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_deletar
            // 
            this.btn_deletar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_deletar.BackColor = System.Drawing.Color.Honeydew;
            this.btn_deletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletar.Image = global::Gerenciador_de_Transportes.Properties.Resources.botao_excluir;
            this.btn_deletar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_deletar.Location = new System.Drawing.Point(377, 635);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_deletar.Size = new System.Drawing.Size(152, 32);
            this.btn_deletar.TabIndex = 8;
            this.btn_deletar.Text = "Deletar";
            this.btn_deletar.UseVisualStyleBackColor = false;
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_cadastrar.BackColor = System.Drawing.Color.Honeydew;
            this.btn_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar.Image = global::Gerenciador_de_Transportes.Properties.Resources.confirme;
            this.btn_cadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cadastrar.Location = new System.Drawing.Point(14, 635);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(152, 32);
            this.btn_cadastrar.TabIndex = 6;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = false;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // lv_Veiculos
            // 
            this.lv_Veiculos.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lv_Veiculos.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lv_Veiculos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_Veiculos.AutoArrange = false;
            this.lv_Veiculos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_Rota,
            this.CidadeOrigem,
            this.EstadoOrigem,
            this.CidadeDestino,
            this.EstadoDestino});
            this.lv_Veiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_Veiculos.FullRowSelect = true;
            this.lv_Veiculos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_Veiculos.HideSelection = false;
            this.lv_Veiculos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lv_Veiculos.Location = new System.Drawing.Point(14, 38);
            this.lv_Veiculos.Name = "lv_Veiculos";
            this.lv_Veiculos.Size = new System.Drawing.Size(1161, 569);
            this.lv_Veiculos.TabIndex = 5;
            this.lv_Veiculos.UseCompatibleStateImageBehavior = false;
            this.lv_Veiculos.View = System.Windows.Forms.View.Details;
            // 
            // col_Rota
            // 
            this.col_Rota.Text = "Placa Cavalo";
            this.col_Rota.Width = 139;
            // 
            // CidadeOrigem
            // 
            this.CidadeOrigem.Text = "Placa Carreta";
            this.CidadeOrigem.Width = 158;
            // 
            // EstadoOrigem
            // 
            this.EstadoOrigem.Text = "Placa Segunda Carreta";
            this.EstadoOrigem.Width = 206;
            // 
            // CidadeDestino
            // 
            this.CidadeDestino.Text = "Proprietário";
            this.CidadeDestino.Width = 290;
            // 
            // EstadoDestino
            // 
            this.EstadoDestino.Text = "Motorista";
            this.EstadoDestino.Width = 364;
            // 
            // btn_usuario
            // 
            this.btn_usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_usuario.BackColor = System.Drawing.Color.Honeydew;
            this.btn_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_usuario.Image = global::Gerenciador_de_Transportes.Properties.Resources.lupa;
            this.btn_usuario.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_usuario.Location = new System.Drawing.Point(556, 635);
            this.btn_usuario.Name = "btn_usuario";
            this.btn_usuario.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_usuario.Size = new System.Drawing.Size(152, 32);
            this.btn_usuario.TabIndex = 9;
            this.btn_usuario.Text = "Obter Usuário";
            this.btn_usuario.UseVisualStyleBackColor = false;
            this.btn_usuario.Click += new System.EventHandler(this.btn_usuario_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_editar.BackColor = System.Drawing.Color.Honeydew;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.Image = global::Gerenciador_de_Transportes.Properties.Resources.editar;
            this.btn_editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_editar.Location = new System.Drawing.Point(194, 635);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(152, 32);
            this.btn_editar.TabIndex = 7;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_voltar.BackColor = System.Drawing.Color.Honeydew;
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.Image = global::Gerenciador_de_Transportes.Properties.Resources.voltar;
            this.btn_voltar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_voltar.Location = new System.Drawing.Point(919, 635);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_voltar.Size = new System.Drawing.Size(152, 32);
            this.btn_voltar.TabIndex = 11;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_motoristas
            // 
            this.btn_motoristas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_motoristas.BackColor = System.Drawing.Color.Honeydew;
            this.btn_motoristas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_motoristas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_motoristas.Image = global::Gerenciador_de_Transportes.Properties.Resources.condutor__1_;
            this.btn_motoristas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_motoristas.Location = new System.Drawing.Point(737, 635);
            this.btn_motoristas.Name = "btn_motoristas";
            this.btn_motoristas.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_motoristas.Size = new System.Drawing.Size(152, 32);
            this.btn_motoristas.TabIndex = 10;
            this.btn_motoristas.Text = "Motoristas";
            this.btn_motoristas.UseVisualStyleBackColor = false;
            this.btn_motoristas.Click += new System.EventHandler(this.btn_motoristas_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btn_Close, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Maximizar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Minimizar, 0, 0);
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1077, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(110, 35);
            this.tableLayoutPanel1.TabIndex = 24;
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
            // Veículos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gerenciador_de_Transportes.Properties.Resources.transscalcom;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1189, 683);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btn_motoristas);
            this.Controls.Add(this.btn_usuario);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_deletar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.lv_Veiculos);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Veículos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veiculos";
            this.Load += new System.EventHandler(this.Veículos_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.ListView lv_Veiculos;
        private System.Windows.Forms.ColumnHeader col_Rota;
        private System.Windows.Forms.ColumnHeader CidadeOrigem;
        private System.Windows.Forms.ColumnHeader EstadoOrigem;
        private System.Windows.Forms.ColumnHeader CidadeDestino;
        private System.Windows.Forms.ColumnHeader EstadoDestino;
        private System.Windows.Forms.Button btn_usuario;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_motoristas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Maximizar;
        private System.Windows.Forms.Button btn_Minimizar;
    }
}