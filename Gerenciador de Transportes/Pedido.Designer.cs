﻿namespace Gerenciador_de_Transportes
{
    partial class Pedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pedido));
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.lv_Pedido = new System.Windows.Forms.ListView();
            this.col_Rota = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CidadeOrigem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EstadoOrigem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CidadeDestino = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EstadoDestino = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_usuario = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_voltar
            // 
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.Location = new System.Drawing.Point(763, 3);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_voltar.Size = new System.Drawing.Size(152, 32);
            this.btn_voltar.TabIndex = 9;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_deletar
            // 
            this.btn_deletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletar.Location = new System.Drawing.Point(383, 3);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_deletar.Size = new System.Drawing.Size(152, 32);
            this.btn_deletar.TabIndex = 8;
            this.btn_deletar.Text = "Deletar";
            this.btn_deletar.UseVisualStyleBackColor = true;
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.Location = new System.Drawing.Point(193, 3);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(152, 32);
            this.btn_editar.TabIndex = 7;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar.Location = new System.Drawing.Point(3, 3);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(152, 32);
            this.btn_cadastrar.TabIndex = 6;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // lv_Pedido
            // 
            this.lv_Pedido.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lv_Pedido.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lv_Pedido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_Pedido.AutoArrange = false;
            this.lv_Pedido.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_Rota,
            this.CidadeOrigem,
            this.EstadoOrigem,
            this.CidadeDestino,
            this.EstadoDestino,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.lv_Pedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_Pedido.FullRowSelect = true;
            this.lv_Pedido.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_Pedido.HideSelection = false;
            this.lv_Pedido.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lv_Pedido.Location = new System.Drawing.Point(12, 12);
            this.lv_Pedido.Name = "lv_Pedido";
            this.lv_Pedido.Size = new System.Drawing.Size(1532, 587);
            this.lv_Pedido.TabIndex = 5;
            this.lv_Pedido.UseCompatibleStateImageBehavior = false;
            this.lv_Pedido.View = System.Windows.Forms.View.Details;
            this.lv_Pedido.SelectedIndexChanged += new System.EventHandler(this.lv_rotas_SelectedIndexChanged);
            // 
            // col_Rota
            // 
            this.col_Rota.Text = "Pedido";
            this.col_Rota.Width = 64;
            // 
            // CidadeOrigem
            // 
            this.CidadeOrigem.Text = "Tipo de Rota";
            this.CidadeOrigem.Width = 261;
            // 
            // EstadoOrigem
            // 
            this.EstadoOrigem.Text = "Frete Fiscal";
            this.EstadoOrigem.Width = 102;
            // 
            // CidadeDestino
            // 
            this.CidadeDestino.Text = "ICMS";
            this.CidadeDestino.Width = 78;
            // 
            // EstadoDestino
            // 
            this.EstadoDestino.Text = "Pedágio";
            this.EstadoDestino.Width = 87;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Classificação/Descarga";
            this.columnHeader1.Width = 181;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Km";
            this.columnHeader2.Width = 52;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cliente";
            this.columnHeader3.Width = 125;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Embarcador";
            this.columnHeader4.Width = 119;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Estado";
            this.columnHeader5.Width = 125;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Destinatário";
            this.columnHeader6.Width = 119;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Estado";
            this.columnHeader7.Width = 120;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Frete Motorista";
            this.columnHeader8.Width = 134;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Cidade Origem";
            this.columnHeader9.Width = 134;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Cidade Destino";
            this.columnHeader10.Width = 134;
            // 
            // btn_usuario
            // 
            this.btn_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_usuario.Location = new System.Drawing.Point(573, 3);
            this.btn_usuario.Name = "btn_usuario";
            this.btn_usuario.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_usuario.Size = new System.Drawing.Size(152, 32);
            this.btn_usuario.TabIndex = 17;
            this.btn_usuario.Text = "Obter Usuário";
            this.btn_usuario.UseVisualStyleBackColor = true;
            this.btn_usuario.Click += new System.EventHandler(this.btn_usuario_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btn_cadastrar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_voltar, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_usuario, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_editar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_deletar, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 605);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(950, 40);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1556, 649);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lv_Pedido);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido";
            this.Load += new System.EventHandler(this.Pedido_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.ListView lv_Pedido;
        private System.Windows.Forms.ColumnHeader col_Rota;
        private System.Windows.Forms.ColumnHeader CidadeOrigem;
        private System.Windows.Forms.ColumnHeader EstadoOrigem;
        private System.Windows.Forms.ColumnHeader CidadeDestino;
        private System.Windows.Forms.ColumnHeader EstadoDestino;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Button btn_usuario;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}