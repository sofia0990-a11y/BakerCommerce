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
    public partial class FormProdutos : Form
    {
        Model.Usuario usuario;
        private object dgvUsuarios;

        int idSelecionado = 0; // Armazenar o id do usuário selecionado p/apagar e editar

        private object Cadastro;
        private object produto;

        public FormProdutos(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            listarCategoriascmb();
            AtualizarDgv();
        }

        private void cmbCategoriaCadastrar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void AtualizarDgv()
        {
            Produto produto = new Produto();
            // Mostrar as informações do bd no DataGridView
            dgvProdutos.DataSource = produto.Listar();
        }



        public void listarCategoriascmb()
        {
            Model.Categoria categoria = new Model.Categoria();
            DataTable tabela = categoria.Listar();

            foreach (DataRow dr in tabela.Rows)
            {
                // 1- salgados
                // 2- Refrigerante
                cmbCategoriaCadastrar.Items.Add($"{dr["id"]} - {dr["nome"]}");
                cmdCategoriaEditar.Items.Add($"{dr["id"]} - {dr["nome"]}");

            }


        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Model.Produto produtoCadastro = new Model.Produto();

            produtoCadastro.Nome = txbNomeCadastro.Text;
            produtoCadastro.Preco = double.Parse(txbPrecoCadastrar.Text);
            produtoCadastro.IdRespCadastro = usuario.Id;
            produtoCadastro.IdCategoria = int.Parse(cmbCategoriaCadastrar.Text.Split('-')[0]);

            string linha = cmbCategoriaCadastrar.Text;
            string numero = linha.Split('-')[0].Trim();

            // Validar campos:
            if (txbNomeCadastro.Text.Length < 3)
            {
                MessageBox.Show("O nome deve ter no minimo 3 caractere.",
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbPrecoCadastrar.Text.Length < 1)
            {
                MessageBox.Show(" O preço deve ter no minimo 1 caractere.",
                  "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {

                // Executar  o INSERT:
                if (produtoCadastro.Cadastrar())
                {
                    MessageBox.Show("Produto Cadastrado com sucesso!", "Show!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Atualizar o dvg:
                    AtualizarDgv();

                    // Apagar os campos de cadastro:
                    txbNomeCadastro.Clear();
                    txbPrecoCadastrar.Clear();
                    cmbCategoriaCadastrar.Items.Clear();
                }
                else
                {
                    MessageBox.Show("Não foi possível cadastrar este produto!", "Erro!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);



                }
            }
        }

        private void btnCadastrarEditar_Click(object sender, EventArgs e)
        {
            if (txbNomeEditar.Text.Length < 3) // Uva
            {
                MessageBox.Show("O produto deve ter no mínimo 3 caracteres.",
                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbPrecoEditar.Text.Length < 1) // 1$
            {
                MessageBox.Show("O preço do produto deve ser no mínimo 1$.",
                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Fazer a edição...
                Model.Produto produtoEditar = new Model.Produto();

                // Salvar os valores dos campos nos atributos do obj:
                produtoEditar.Nome = txbNomeEditar.Text;
                produtoEditar.Preco = double.Parse(txbPrecoEditar.Text);
                produtoEditar.IdRespCadastro = usuario.Id;
                produtoEditar.Id = idSelecionado;
                produtoEditar.IdCategoria = int.Parse(cmbCategoriaCadastrar.Text.Split('-')[0]);

                // Executar o INSERT:
                if (produtoEditar.Modificar())
                {
                    MessageBox.Show("Editado com sucesso!", "Show!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Atualizar o dvg:
                    AtualizarDgv();

                    // Apagar os campos de cadastro:
                    txbNomeEditar.Clear();
                    txbPrecoEditar.Clear();
                    cmdCategoriaEditar.Items.Clear();
                }
                else
                {
                    MessageBox.Show("Não foi possível editar este produto!", "Erro!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Tem certeza que deseja apagar este produto?",
         "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                // Prosseguir com a exclusão...
                Model.Produto produtoApagar = new Model.Produto();

                produtoApagar.Id = idSelecionado;
                if (produtoApagar.Apagar())
                {
                    MessageBox.Show("Produto apagado com sucesso!", "Show!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ResetarCampos();

                }
                else
                {
                    MessageBox.Show("Falha ao apagar o produto.", "Erro!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void ResetarCampos()
        {
            // Atualizar o dgv:
            AtualizarDgv();

            // Limpar campos de edição:
            txbNomeEditar.Clear();
            txbPrecoCadastrar.Clear();
            cmdCategoriaEditar.Items.Clear();

            // Retornar o idSelecionado para 0:
            idSelecionado = 0;

            // Retornar o texto padrão do "apagar":
            lblDescriçãoApagar.Text = "Selecione um produto para apagar.";

            // Desabilitar os grbs:
            grbCadastrar.Enabled = false;
            grbEditar.Enabled = false;
        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Garante que não vai dar erro se clicar no cabeçalho
            if (e.RowIndex >= 0)
            {
                // Seleciona a linha inteira
                dgvProdutos.Rows[e.RowIndex].Selected = true;
                // Pegar a linha selecionada:
                int ls = dgvProdutos.SelectedCells[0].RowIndex;

                // Colocar os valores das células no txbs de edição:
                txbNomeEditar.Text = dgvProdutos.Rows[ls].Cells[1].Value.ToString();
                txbPrecoEditar.Text = dgvProdutos.Rows[ls].Cells[2].Value.ToString();
                cmdCategoriaEditar.Text = dgvProdutos.Rows[ls].Cells[3].Value.ToString();

                // Armazenar o ID de quem foi selecionado:
                idSelecionado = (int)dgvProdutos.Rows[ls].Cells[0].Value;

                // Ativar o grbEditarCadastro:
                grbEditar.Enabled = true;

                // Ajustes no grbApagarCadastro:
                lblDescriçãoApagar.Text = $"Apagar: {dgvProdutos.Rows[ls].Cells[1].Value.ToString()}";

                // Ativar o grbApagarCadastro:
                grbApagar.Enabled = true;
            }
        }
    }
}
