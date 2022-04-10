namespace Gerenciador_de_Transportes
{
    partial class CadastoEmbarcador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastoEmbarcador));
            this.tb_embarcador = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.lv_embarcador = new System.Windows.Forms.ListView();
            this.col_Rota = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.btn_usuario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_destinatario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_embarcador
            // 
            this.tb_embarcador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_embarcador.Location = new System.Drawing.Point(365, 74);
            this.tb_embarcador.Name = "tb_embarcador";
            this.tb_embarcador.Size = new System.Drawing.Size(174, 26);
            this.tb_embarcador.TabIndex = 1;
            this.tb_embarcador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_embarcador_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(393, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 97;
            this.label4.Text = "Embarcador:";
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar.Location = new System.Drawing.Point(375, 315);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(152, 32);
            this.btn_cadastrar.TabIndex = 3;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.Location = new System.Drawing.Point(375, 565);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(152, 32);
            this.btn_voltar.TabIndex = 7;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // lv_embarcador
            // 
            this.lv_embarcador.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lv_embarcador.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lv_embarcador.AutoArrange = false;
            this.lv_embarcador.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_Rota,
            this.columnHeader1});
            this.lv_embarcador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_embarcador.FullRowSelect = true;
            this.lv_embarcador.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_embarcador.HideSelection = false;
            this.lv_embarcador.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lv_embarcador.Location = new System.Drawing.Point(12, 12);
            this.lv_embarcador.Name = "lv_embarcador";
            this.lv_embarcador.Size = new System.Drawing.Size(311, 590);
            this.lv_embarcador.TabIndex = 100;
            this.lv_embarcador.UseCompatibleStateImageBehavior = false;
            this.lv_embarcador.View = System.Windows.Forms.View.Details;
            // 
            // col_Rota
            // 
            this.col_Rota.Text = "Embarcadores";
            this.col_Rota.Width = 151;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Destinatário";
            this.columnHeader1.Width = 142;
            // 
            // btn_editar
            // 
            this.btn_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.Location = new System.Drawing.Point(375, 377);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(152, 32);
            this.btn_editar.TabIndex = 4;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_deletar
            // 
            this.btn_deletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletar.Location = new System.Drawing.Point(375, 440);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(152, 32);
            this.btn_deletar.TabIndex = 5;
            this.btn_deletar.Text = "Deletar";
            this.btn_deletar.UseVisualStyleBackColor = true;
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // btn_usuario
            // 
            this.btn_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_usuario.Location = new System.Drawing.Point(375, 505);
            this.btn_usuario.Name = "btn_usuario";
            this.btn_usuario.Size = new System.Drawing.Size(152, 32);
            this.btn_usuario.TabIndex = 6;
            this.btn_usuario.Text = "Obter Usúario";
            this.btn_usuario.UseVisualStyleBackColor = true;
            this.btn_usuario.Click += new System.EventHandler(this.btn_usuario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(392, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 105;
            this.label1.Text = "Destinatário:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_destinatario
            // 
            this.tb_destinatario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_destinatario.Location = new System.Drawing.Point(365, 181);
            this.tb_destinatario.Name = "tb_destinatario";
            this.tb_destinatario.Size = new System.Drawing.Size(174, 26);
            this.tb_destinatario.TabIndex = 2;
            this.tb_destinatario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_destinatario_KeyPress);
            // 
            // CadastoEmbarcador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(569, 614);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_destinatario);
            this.Controls.Add(this.btn_usuario);
            this.Controls.Add(this.btn_deletar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.lv_embarcador);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_embarcador);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CadastoEmbarcador";
            this.Text = "Cadasto Embarcador Desembarcador";
            this.Load += new System.EventHandler(this.CadastoEmbarcador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_embarcador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.ListView lv_embarcador;
        private System.Windows.Forms.ColumnHeader col_Rota;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.Button btn_usuario;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_destinatario;
    }
}