using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciador_de_Transportes.Telas.Utilitarias
{
    public partial class ModalSucesso : Form
    {
        public ModalSucesso()
        {
            InitializeComponent();
        }

        public ModalSucesso(string titulo, string texto)
        {
            InitializeComponent();

            tb_Titulo.Text = titulo;
            tb_Texto.Text = texto;
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
