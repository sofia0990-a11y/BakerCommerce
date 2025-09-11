using BakerCommerce.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BakerCommerce
{
    public partial class FormComandas : Form
    {
        public FormComandas(Model.Usuario usuario)
        {
            InitializeComponent();
        }

        public void AtualizarDgv()
        {
            Model.Produto produto = new Model.Produto();
            dgvProdutos.DataSource = produto.Listar();

        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pagar a linha selecionada:
            int ls = dgvProdutos.SelectedCells[0].RowIndex;
            // Colocar  o ID  do produto no campo do Código:
            txbComandas.Text = dgvProdutos.Rows[ls].Cells[3].Value.ToString();
            // Colocar o nome do produto no campo de informações
            txbProdutos.Text = dgvProdutos.Rows[ls].Cells[3].Value.ToString();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            // verificar se os campos estão vazios:
            if (txbComandas.Text.Length == 0)
            {
                MessageBox.Show("informe o numero da comanda! ", "Erro!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (txbProdutos.Text.Length == 0)
            {

                MessageBox.Show("informe o código do produto! ", "Erro!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Desativar o grbinfos:
                grbInformacoes.Enabled = false;
                grbLancamennto.Enabled = true;
            }


        }

        private void btnLancar_Click(object sender, EventArgs e)
        {
            // Verificar se a quantidade foi preenchida 
            if (txbQuantidade.Text.Length == 0)
            {
                MessageBox.Show("informe a Quantidade! ", "Erro!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                Model.OrdemComanda ordemComanda = new Model.OrdemComanda();
                ordemComanda.IdFicha = int.Parse(txbComandas.Text);
                ordemComanda.IdProduto = int.Parse(txbProdutos.Text);
                ordemComanda.IdQuantidade = int.Parse(txbQuantidade.Text);
                ordemComanda.IdResp = Usuario.Id;

                if (ordemComanda.Cadastrar())
                {
                    MessageBox.Show("Lançamento efetuado! ", "Sucesso!",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetarCampos();

                }
                else
                {
                    MessageBox.Show("Falha ao efetuar o Lançamento! ", "Erro!",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void ResetarCampos()
        {
            txbProdutos.Clear();
            txbQuantidade.Clear();
            txbProdutosLancamento.Clear();
            txbComandas.Clear();
            // Resetar os groupboxes
            grbInformacoes.Enabled = false;
            grbLancamennto.Enabled = true;


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ResetarCampos();
        }
    } 
}
