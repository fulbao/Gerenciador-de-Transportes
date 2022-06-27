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
    public partial class ModalYN : Form
    {
        public Boolean retorno;

        public ModalYN()
        {
            InitializeComponent();
        }

        public ModalYN(string titulo, string texto)
        {
            InitializeComponent();

            tb_Titulo.Text = titulo;
            tb_Texto.Text = texto;
        }

        private void btn_Yes_Click(object sender, EventArgs e)
        {   
            retorno = true;
            this.Close();
        }

        private void btn_No_Click(object sender, EventArgs e)
        {
            retorno = false;
            this.Close();
        }
    }
}
