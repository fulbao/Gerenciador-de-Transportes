namespace Gerenciador_de_Transportes
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btn_Entrar = new System.Windows.Forms.Button();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.tb_usuario = new System.Windows.Forms.TextBox();
            this.Usuario = new System.Windows.Forms.Label();
            this.Senha = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Entrar
            // 
            resources.ApplyResources(this.btn_Entrar, "btn_Entrar");
            this.btn_Entrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Entrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btn_Entrar.Name = "btn_Entrar";
            this.btn_Entrar.UseVisualStyleBackColor = true;
            this.btn_Entrar.Click += new System.EventHandler(this.btn_Entrar_Click);
            // 
            // tb_senha
            // 
            resources.ApplyResources(this.tb_senha, "tb_senha");
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_senha_KeyPress);
            // 
            // tb_usuario
            // 
            resources.ApplyResources(this.tb_usuario, "tb_usuario");
            this.tb_usuario.Name = "tb_usuario";
            // 
            // Usuario
            // 
            resources.ApplyResources(this.Usuario, "Usuario");
            this.Usuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Usuario.Name = "Usuario";
            this.Usuario.Click += new System.EventHandler(this.Usuario_Click);
            // 
            // Senha
            // 
            resources.ApplyResources(this.Senha, "Senha");
            this.Senha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Senha.Name = "Senha";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.Controls.Add(this.btn_Entrar, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.tb_usuario, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Usuario, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Senha, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tb_senha, 0, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.Login_HelpButtonClicked);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Entrar;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.TextBox tb_usuario;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.Label Senha;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

