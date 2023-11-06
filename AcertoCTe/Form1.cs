using FuncoesWinthor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AcertoCTe
{
    public partial class Form1 : Form
    {
        private UsuarioVO logado;

        public Form1()
        {
            try
            {
                frmLogin login = new frmLogin(9865);
                if (login.ShowDialog() == DialogResult.Yes)
                {
                    InitializeComponent();
                    logado = login.usuario;
                }
            }
            catch (Exception erro)
            {
                Funcoes.ExibirMensagem(erro.Message, TipoMensagem.Erro);
            }
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            if (rbCancel.Checked)
            {
                viewNotas.DataSource = ConhecimentoDAO.pesquisarCancelamento(Convert.ToInt32(txtCarregamento.Text), "FESTPAN");
            }
            else if (rbTransf.Checked)
            {
                viewNotas.DataSource = ConhecimentoDAO.pesquisarTransferencia(Convert.ToInt32(txtCarregamento.Text), "FESTPAN");
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                List<ConhecimentoVO> conhecimentos = new List<ConhecimentoVO>();
                foreach (DataGridViewRow linha in viewNotas.SelectedRows)
                {
                    ConhecimentoVO c = new ConhecimentoVO();

                    c.Carregamento = Convert.ToInt32(txtCarregamento.Text);
                    c.Filial = Convert.ToInt32(linha.Cells["codfilial"].Value);
                    c.Nota = Convert.ToInt32(linha.Cells["numnota"].Value);
                    if (rbCancel.Checked)
                        c.Tipo = TipoAtualizacao.Cancelamento;
                    else
                        c.Tipo = TipoAtualizacao.Transferencia;

                    conhecimentos.Add(c);
                }

                ConhecimentoDAO.alterarDados(conhecimentos, logado);
                Funcoes.ExibirMensagem("CT-es alterados com sucesso", TipoMensagem.Sucesso);
            }
            catch (Exception erro)
            {
                Funcoes.ExibirMensagem(erro.Message, TipoMensagem.Erro);
            }
        }
    }
}
