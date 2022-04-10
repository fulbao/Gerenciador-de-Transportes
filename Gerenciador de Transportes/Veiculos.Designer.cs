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
            this.SuspendLayout();
            // 
            // btn_deletar
            // 
            this.btn_deletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletar.Location = new System.Drawing.Point(377, 607);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_deletar.Size = new System.Drawing.Size(152, 32);
            this.btn_deletar.TabIndex = 8;
            this.btn_deletar.Text = "Deletar";
            this.btn_deletar.UseVisualStyleBackColor = true;
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar.Location = new System.Drawing.Point(14, 607);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(152, 32);
            this.btn_cadastrar.TabIndex = 6;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // lv_Veiculos
            // 
            this.lv_Veiculos.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lv_Veiculos.Alignment = System.Windows.Forms.ListViewAlignment.Left;
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
            this.lv_Veiculos.Location = new System.Drawing.Point(14, 14);
            this.lv_Veiculos.Name = "lv_Veiculos";
            this.lv_Veiculos.Size = new System.Drawing.Size(1161, 587);
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
            this.btn_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_usuario.Location = new System.Drawing.Point(556, 607);
            this.btn_usuario.Name = "btn_usuario";
            this.btn_usuario.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_usuario.Size = new System.Drawing.Size(152, 32);
            this.btn_usuario.TabIndex = 9;
            this.btn_usuario.Text = "Obter Usuário";
            this.btn_usuario.UseVisualStyleBackColor = true;
            this.btn_usuario.Click += new System.EventHandler(this.btn_usuario_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.Location = new System.Drawing.Point(194, 607);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(152, 32);
            this.btn_editar.TabIndex = 7;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.Location = new System.Drawing.Point(919, 607);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_voltar.Size = new System.Drawing.Size(152, 32);
            this.btn_voltar.TabIndex = 11;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_motoristas
            // 
            this.btn_motoristas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_motoristas.Location = new System.Drawing.Point(737, 607);
            this.btn_motoristas.Name = "btn_motoristas";
            this.btn_motoristas.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_motoristas.Size = new System.Drawing.Size(152, 32);
            this.btn_motoristas.TabIndex = 10;
            this.btn_motoristas.Text = "Motoristas";
            this.btn_motoristas.UseVisualStyleBackColor = true;
            this.btn_motoristas.Click += new System.EventHandler(this.btn_motoristas_Click);
            // 
            // Veículos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1189, 653);
            this.Controls.Add(this.btn_motoristas);
            this.Controls.Add(this.btn_usuario);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_deletar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.lv_Veiculos);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Veículos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veiculos";
            this.Load += new System.EventHandler(this.Veículos_Load);
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
    }
}