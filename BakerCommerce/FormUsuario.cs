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
     
    public partial class FormUsuario : Form
    {
        // Objetivo globais:
        Model.Usuario usuario;

        int idSelecionado = 0; // Armazenar o id do usuário selecionado p/apagar e editar

        private object usuarioCadastro;

        public FormUsuario(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;

            
        }
         public void AtualizarDgv()
        {   
            // Mostrar as informações 
            dgvUsuarios.DataSource = usuario.Listar();
        }
        
         
        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            // Validar campos:
            if(txbNome.Text.Length < 5)
            {
                MessageBox.Show("O nome deve ter no minimo 5 caractere.",
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbEmail.Text.Length <7) 
            {
                MessageBox.Show(" O email deve ter no minimo 7 caractere.",
                  "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbSenha.Text.Length < 6)
            {
                MessageBox.Show("A email deve ter no minimo 6 caractere.",
                 "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         

            else
            {
                // Fazer o cadastro...
                Model.Usuario usuarioCadastro = new Model.Usuario();
                // Salvar os Valores dos campos nos atributos do obj:

                usuarioCadastro.Nome = txbNome.Text;
                usuarioCadastro.Email = txbEmail.Text;
                usuarioCadastro.Senha = txbSenha.Text;

                // Executar  o INSERT:
                if (usuarioCadastro.Cadastrar())
                {
                    MessageBox.Show("Úsuario cadastrado com sucesso!",
                        "Show!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Atualizar o dgv
                    AtualizarDgv();

                    // Apagar os campos de cadastro:
                    txbNome.Clear();
                    txbEmail.Clear();
                    txbSenha.Clear();

                }
                else
                {
                    MessageBox.Show("Falha ao Cadastrar o Usuário!",
                        "Show!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }  
            
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pegar a linha selecionada:
            int ls = dgvUsuarios.SelectedCells[0].RowIndex;

            // Colocar os valores dás células no txbs de edição
            txbNomeEditar.Text = dgvUsuarios.Rows[ls].Cells[1].Value.ToString();
            txbEmailEditar.Text = dgvUsuarios.Rows[ls].Cells[2].Value.ToString();

            // Armazenar o id de quem foi selecionado:
            idSelecionado = (int)dgvUsuarios.Rows[ls].Cells[0].Value;

            // Ativar o grbEditar
            grbEditar.Enabled = true;

            // Ajuste no grbApagar
            lblDescricao.Text=$"Apagar: {dgvUsuarios.Rows[ls].Cells[1].Value }";

            // Ativar o grbApagar:
            grbApagar.Enabled = true;   
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            // Perguntar se realmente quer apagar:

            DialogResult r = MessageBox.Show(" Tem certeza que deseja apagar esse Usuário?",
                "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                 // prosseguir com a exclusão..
                 Model.Usuario usuarioApagar = new Model.Usuario();
                usuarioApagar.Id = idSelecionado;
                if(usuarioApagar.Apagar())
                {
                    MessageBox.Show("Úsuario Apagado com sucesso com sucesso!",
                         "Show!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                      ResetarCampos();
                }
                else
                {
                    MessageBox.Show("Falha ao Apagar o Usuário!",
                       "Show!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

         public void ResetarCampos()
        {
            // Atuslizar o dgv:

            AtualizarDgv();

            // Limpar campos de edição

            txbNomeEditar.Clear();
            txbEmailEditar.Clear();
            txbSenhaEditar.Clear();

            // Retornar o idSelecionado para 0

            idSelecionado = 0;

            // Retornar o texto padrão do "Apagar"

            lblDescricao.Text = "Selecione o usuário que deseja apagar";

            // Desabilitar o grb

            grbApagar.Enabled = false;
            grbEditar.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            // Validar campos:

            if (txbNome.Text.Length < 5)
            {
                MessageBox.Show("O nome deve ter no minimo 5 caractere.",
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbEmail.Text.Length < 7)
            {
                MessageBox.Show(" O email deve ter no minimo 7 caractere.",
                  "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbSenha.Text.Length < 6)
            {
                MessageBox.Show("A email deve ter no minimo 6 caractere.",
                 "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Prosseguir a edição

                Model.Usuario usuarioEditar = new Model.Usuario();
                usuarioEditar.Id = idSelecionado;
                usuarioEditar.Nome =txbNomeEditar.Text;
                usuarioEditar.Email = txbEmailEditar.Text;
                usuarioEditar.Senha = txbSenhaEditar.Text;

                if(usuarioEditar.Modificar())
                {
                    MessageBox.Show("Úsuario Modificado com sucesso com sucesso!",
                         "Show!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Falha ao Modificar o Usuário!",
                       "Show!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

        }
    }
}
