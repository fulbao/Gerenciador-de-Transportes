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
    public partial class Usuario : Form
    {
        string usuarioLogado;

        List<UsuarioCs> usuarioList = new List<UsuarioCs>();
        public Usuario(string usuarioLogado)
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            this.usuarioLogado = usuarioLogado;
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            geraListaTela();
        }

        public void geraListaTela ()
        {
            usuarioList.Clear();
            lv_usuarios.Items.Clear();

            usuarioList = BancoUsuario.leUsuarios();

            for (int i = 0; i < usuarioList.Count; i++)
            {
                string[] itensOrganizados = retornaClassificado(usuarioList[i]);

                ListViewItem l = new ListViewItem(itensOrganizados);

                lv_usuarios.Items.Add(l);
            }
        }

        private string [] retornaClassificado (UsuarioCs user)
        {
            string[] itensOrganizados = new string[11];

            itensOrganizados[0] = user.Nome;

            if (user.Gloria == true)
            {
                itensOrganizados[1] = "Permitido";
            }
            else
            {
                itensOrganizados[1] = "Não Permitido";
            }

            if (user.Paranavai == true)
            {
                itensOrganizados[2] = "Permitido";
            }
            else
            {
                itensOrganizados[2] = "Não Permitido";
            }

            if (user.Toledo == true)
            {
                itensOrganizados[3] = "Permitido";
            }
            else
            {
                itensOrganizados[3] = "Não Permitido";
            }

            if (user.RioVerde == true)
            {
                itensOrganizados[4] = "Permitido";
            }
            else
            {
                itensOrganizados[4] = "Não Permitido";
            }

            if (user.Pedido == true)
            {
                itensOrganizados[5] = "Permitido";
            }
            else
            {
                itensOrganizados[5] = "Não Permitido";
            }

            if (user.Veiculos == true)
            {
                itensOrganizados[6] = "Permitido";
            }
            else
            {
                itensOrganizados[6] = "Não Permitido";
            }

            if (user.Rotas == true)
            {
                itensOrganizados[7] = "Permitido";
            }
            else
            {
                itensOrganizados[7] = "Não Permitido";
            }

            if (user.Cadastro == true)
            {
                itensOrganizados[8] = "Permitido";
            }
            else
            {
                itensOrganizados[8] = "Não Permitido";
            }

            if (user.Dashboard == true)
            {
                itensOrganizados[9] = "Permitido";
            }
            else
            {
                itensOrganizados[9] = "Não Permitido";
            }

            if (user.ObterUsuario == true)
            {
                itensOrganizados[10] = "Permitido";
            }
            else
            {
                itensOrganizados[10] = "Não Permitido";
            }

            return itensOrganizados;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;
                return handleParam;
            }
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Cadastro_de_Usuario cadastro_De_Usuario = new Cadastro_de_Usuario(usuarioLogado);
            cadastro_De_Usuario.ShowDialog();

            geraListaTela();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            ModalYN modal = new ModalYN("Atenção!", "Você tem certeza que deseja apagar esse item?");
            modal.ShowDialog();

            Boolean retorno = modal.retorno;

            if (retorno == true)
            {
                retorno = BancoUsuario.deletar(lv_usuarios.SelectedItems[0].Text);

                if (retorno == true)
                {
                    ModalSucesso modal2 = new ModalSucesso("Atenção!", "Usuário deletado com sucesso!");
                    modal2.ShowDialog();
                }
                else
                {
                    ModalErro modal3 = new ModalErro("Atenção!", "Ocoreu um erro no banco de dados de usuário, por favor entre em contato com o desenvolvedor!");
                    modal3.ShowDialog();
                }
                geraListaTela();
            }
        }

        private Boolean[] converteStringEmBool (string [] permissoes)
        {
            Boolean [] permissoesBool = new Boolean [permissoes.Length];
            for (int i = 0; i < permissoes.Length; i++)
            {
                if (permissoes[i] == "Permitido")
                {
                    permissoesBool[i] = true;
                } else
                {
                    permissoesBool[i] = false;
                }
            }

            return permissoesBool;
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (lv_usuarios.SelectedIndices.Count <= 0)
            {
                ModalAlerta modal = new ModalAlerta("Atenção!", "Selecione um item");
                modal.ShowDialog();
            }
            else
            {
                string[] permissoesString = { lv_usuarios.SelectedItems[0].SubItems[1].Text, lv_usuarios.SelectedItems[0].SubItems[2].Text, lv_usuarios.SelectedItems[0].SubItems[3].Text, lv_usuarios.SelectedItems[0].SubItems[4].Text, lv_usuarios.SelectedItems[0].SubItems[5].Text, lv_usuarios.SelectedItems[0].SubItems[6].Text, lv_usuarios.SelectedItems[0].SubItems[7].Text, lv_usuarios.SelectedItems[0].SubItems[8].Text, lv_usuarios.SelectedItems[0].SubItems[9].Text, lv_usuarios.SelectedItems[0].SubItems[10].Text };
                Boolean[] permissoes = converteStringEmBool(permissoesString);
                EditarUsuario editarUsuario = new EditarUsuario(lv_usuarios.SelectedItems[0].SubItems[0].Text, permissoes);
                editarUsuario.ShowDialog();

                geraListaTela();
            }
        }

        private void btn_Redefinir_Click(object sender, EventArgs e)
        {
            if (lv_usuarios.SelectedIndices.Count <= 0)
            {
                ModalAlerta modal = new ModalAlerta("Atenção!", "Selecione um item");
                modal.ShowDialog();
            }
            else
            {
                ModalYN modalYN = new ModalYN("Atenção", "Você tem certeza que quer redefinir a senha desse usuario?\nSenha será: 12345678");

                modalYN.ShowDialog();

                if (modalYN.retorno == true)
                {
                    Boolean retorno = BancoUsuario.alteraSenha(lv_usuarios.SelectedItems[0].SubItems[0].Text, "12345678");
                    if (retorno == true)
                    {
                        ModalSucesso modalSucesso = new ModalSucesso("Sucesso!", "Senha redefinida para: 12345678");
                        modalSucesso.ShowDialog();
                    } else
                    {
                        ModalErro modalErro = new ModalErro("Erro", "Ocorreu um erro com a operação de redefinir a senha!\nPor favor entre em contato com o desenvolvedor");
                        modalErro.ShowDialog();
                    }
                }
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Maximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }
    }
}
