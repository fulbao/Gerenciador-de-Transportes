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
    public partial class UsuarioSelecionado : Form
    {
        public UsuarioSelecionado()
        {
            InitializeComponent();
        }

        public UsuarioSelecionado(string usuario)
        {
            InitializeComponent();
            tb_Usuario.Text = usuario;
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
