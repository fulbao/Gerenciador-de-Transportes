namespace Gerenciador_de_Transportes
{
    partial class Rotas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rotas));
            this.lv_rotas = new System.Windows.Forms.ListView();
            this.col_Rota = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CidadeOrigem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EstadoOrigem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CidadeDestino = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EstadoDestino = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_usuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_rotas
            // 
            this.lv_rotas.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lv_rotas.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lv_rotas.AutoArrange = false;
            this.lv_rotas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_Rota,
            this.CidadeOrigem,
            this.EstadoOrigem,
            this.CidadeDestino,
            this.EstadoDestino});
            this.lv_rotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_rotas.FullRowSelect = true;
            this.lv_rotas.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_rotas.HideSelection = false;
            this.lv_rotas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lv_rotas.Location = new System.Drawing.Point(12, 12);
            this.lv_rotas.Name = "lv_rotas";
            this.lv_rotas.Size = new System.Drawing.Size(1161, 587);
            this.lv_rotas.TabIndex = 0;
            this.lv_rotas.UseCompatibleStateImageBehavior = false;
            this.lv_rotas.View = System.Windows.Forms.View.Details;
            // 
            // col_Rota
            // 
            this.col_Rota.Text = "Rota";
            this.col_Rota.Width = 258;
            // 
            // CidadeOrigem
            // 
            this.CidadeOrigem.Text = "Cidade de Origem";
            this.CidadeOrigem.Width = 220;
            // 
            // EstadoOrigem
            // 
            this.EstadoOrigem.Text = "Estado de Origem";
            this.EstadoOrigem.Width = 206;
            // 
            // CidadeDestino
            // 
            this.CidadeDestino.Text = "Cidade de Destino";
            this.CidadeDestino.Width = 219;
            // 
            // EstadoDestino
            // 
            this.EstadoDestino.Text = "Estado de Destino";
            this.EstadoDestino.Width = 253;
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar.Location = new System.Drawing.Point(12, 605);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(152, 32);
            this.btn_cadastrar.TabIndex = 1;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.Location = new System.Drawing.Point(192, 605);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(152, 32);
            this.btn_editar.TabIndex = 2;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_deletar
            // 
            this.btn_deletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletar.Location = new System.Drawing.Point(375, 605);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_deletar.Size = new System.Drawing.Size(152, 32);
            this.btn_deletar.TabIndex = 3;
            this.btn_deletar.Text = "Deletar";
            this.btn_deletar.UseVisualStyleBackColor = true;
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.Location = new System.Drawing.Point(746, 605);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_voltar.Size = new System.Drawing.Size(152, 32);
            this.btn_voltar.TabIndex = 4;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_usuario
            // 
            this.btn_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_usuario.Location = new System.Drawing.Point(560, 605);
            this.btn_usuario.Name = "btn_usuario";
            this.btn_usuario.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_usuario.Size = new System.Drawing.Size(152, 32);
            this.btn_usuario.TabIndex = 16;
            this.btn_usuario.Text = "Obter Usuário";
            this.btn_usuario.UseVisualStyleBackColor = true;
            this.btn_usuario.Click += new System.EventHandler(this.btn_usuario_Click);
            // 
            // Rotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1185, 649);
            this.Controls.Add(this.btn_usuario);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_deletar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.lv_rotas);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Rotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rotas";
            this.Load += new System.EventHandler(this.Rotas_Load);
            this.MouseCaptureChanged += new System.EventHandler(this.Rotas_MouseCaptureChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_rotas;
        private System.Windows.Forms.ColumnHeader col_Rota;
        private System.Windows.Forms.ColumnHeader CidadeOrigem;
        private System.Windows.Forms.ColumnHeader EstadoOrigem;
        private System.Windows.Forms.ColumnHeader CidadeDestino;
        private System.Windows.Forms.ColumnHeader EstadoDestino;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_usuario;
    }
}