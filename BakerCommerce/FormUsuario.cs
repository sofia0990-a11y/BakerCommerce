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
    }
}
