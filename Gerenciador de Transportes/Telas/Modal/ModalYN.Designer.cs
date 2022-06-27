namespace Gerenciador_de_Transportes.Telas.Utilitarias
{
    partial class ModalYN
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_Texto = new System.Windows.Forms.Label();
            this.tb_Titulo = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_No = new System.Windows.Forms.Button();
            this.btn_Yes = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_Texto, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb_Titulo, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 10);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.21212F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.78788F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(582, 261);
            this.tableLayoutPanel1.TabIndex = 166;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackgroundImage = global::Gerenciador_de_Transportes.Properties.Resources.alerta;
            this.panel1.Location = new System.Drawing.Point(227, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(128, 128);
            this.panel1.TabIndex = 163;
            // 
            // tb_Texto
            // 
            this.tb_Texto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_Texto.AutoSize = true;
            this.tb_Texto.BackColor = System.Drawing.Color.Transparent;
            this.tb_Texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Texto.ForeColor = System.Drawing.Color.White;
            this.tb_Texto.Location = new System.Drawing.Point(135, 178);
            this.tb_Texto.Name = "tb_Texto";
            this.tb_Texto.Size = new System.Drawing.Size(312, 20);
            this.tb_Texto.TabIndex = 160;
            this.tb_Texto.Text = "Verifique sua conexão com a internet.";
            // 
            // tb_Titulo
            // 
            this.tb_Titulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_Titulo.AutoSize = true;
            this.tb_Titulo.BackColor = System.Drawing.Color.Transparent;
            this.tb_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Titulo.ForeColor = System.Drawing.Color.White;
            this.tb_Titulo.Location = new System.Drawing.Point(234, 145);
            this.tb_Titulo.Name = "tb_Titulo";
            this.tb_Titulo.Size = new System.Drawing.Size(114, 29);
            this.tb_Titulo.TabIndex = 159;
            this.tb_Titulo.Text = "Atenção!";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 172F));
            this.tableLayoutPanel2.Controls.Add(this.btn_No, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Yes, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(127, 275);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(343, 81);
            this.tableLayoutPanel2.TabIndex = 167;
            // 
            // btn_No
            // 
            this.btn_No.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_No.BackColor = System.Drawing.Color.Yellow;
            this.btn_No.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_No.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_No.Location = new System.Drawing.Point(181, 3);
            this.btn_No.Name = "btn_No";
            this.btn_No.Size = new System.Drawing.Size(152, 32);
            this.btn_No.TabIndex = 163;
            this.btn_No.Text = "NÃO";
            this.btn_No.UseVisualStyleBackColor = false;
            this.btn_No.Click += new System.EventHandler(this.btn_No_Click);
            // 
            // btn_Yes
            // 
            this.btn_Yes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Yes.BackColor = System.Drawing.Color.Yellow;
            this.btn_Yes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Yes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Yes.Location = new System.Drawing.Point(9, 3);
            this.btn_Yes.Name = "btn_Yes";
            this.btn_Yes.Size = new System.Drawing.Size(152, 32);
            this.btn_Yes.TabIndex = 162;
            this.btn_Yes.Text = "SIM";
            this.btn_Yes.UseVisualStyleBackColor = false;
            this.btn_Yes.Click += new System.EventHandler(this.btn_Yes_Click);
            // 
            // ModalYN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ModalYN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModalYN";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label tb_Texto;
        private System.Windows.Forms.Label tb_Titulo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_No;
        private System.Windows.Forms.Button btn_Yes;
    }
}