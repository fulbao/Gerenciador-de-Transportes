using Gerenciador_de_Transportes.Telas.Utilitarias;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciador_de_Transportes.Telas.Usuario
{
    public partial class EditarUsuario : Form
    {
        private UsuarioCs user;

        string usuarioAntigo;

        public EditarUsuario(string login, Boolean[] permissoes)
        {
            InitializeComponent();
            UsuarioCs usuarioCs = new UsuarioCs(login, permissoes[0], permissoes[1], permissoes[2], permissoes[3], permissoes[4], permissoes[5], permissoes[6], permissoes[7], permissoes[8], permissoes[9]);
            user = usuarioCs;
            this.usuarioAntigo = login;
        }

        private void EditarUsuario_Load(object sender, EventArgs e)
        {
            tb_usuario.Text = user.Nome;
            cb_dashboard.Checked = user.Dashboard;
            cb_cadastroUsuario.Checked = user.Cadastro;
            cb_gloria.Checked = user.Gloria;
            cb_obterUsuario.Checked = user.ObterUsuario;
            cb_paranavai.Checked = user.Paranavai;
            cb_pedido.Checked = user.Pedido;
            cb_rioVerde.Checked = user.RioVerde;
            cb_rota.Checked = user.Rotas;
            cb_toledo.Checked = user.Toledo;
            cb_veiculos.Checked = user.Veiculos;
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            int retorno;
            int nivelPermissao;

            if (tb_usuario.Text.Length > 3)
            {

                Boolean banco;
                banco = BancoUsuario.alterarUsuario(usuarioAntigo, tb_usuario.Text, cb_gloria.Checked.ToString(), cb_paranavai.Checked.ToString(), cb_toledo.Checked.ToString(), cb_rioVerde.Checked.ToString(), cb_pedido.Checked.ToString(), cb_veiculos.Checked.ToString(), cb_rota.Checked.ToString(), cb_cadastroUsuario.Checked.ToString(), cb_dashboard.Checked.ToString(), cb_obterUsuario.Checked.ToString());
                if (banco == false)
                {
                    ModalErro modal = new ModalErro("Atenção!", "Ocorreu um erro! Contate o desenvolvedor!");
                    modal.ShowDialog();
                }
                if (banco == true)
                {
                    ModalSucesso modal = new ModalSucesso("Atenção!", "Usuario cadastrado com sucesso!");
                    modal.ShowDialog();

                }
            }
            else if (tb_usuario.Text.Length <= 3)
            {
                ModalAlerta modal = new ModalAlerta("Atenção!", "Usuario deve ter no minímo 4 caracteres");
                modal.ShowDialog();
                tb_usuario.Clear();
                tb_usuario.Focus();
            }

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
