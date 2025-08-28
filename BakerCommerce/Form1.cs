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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // Verificar se a pessoa digitou o email e a senha:
            if (txbEmail.Text.Length <6  )
            {
                MessageBox.Show("Digite um E-mail Valido!",
                "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbEmail.Text.Length < 4)
            {
                MessageBox.Show("Digite uma Senha Valida!",
                "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                 // Prosseguir...
                 Model.Usuario usuario = new Model.Usuario();

                // Colocar os Valores dos campos nos atributos do usuario:
                usuario.Email =txbEmail.Text;
                usuario.Email = txbsenha.Text;

                // Tabela que vai receber o resultado do SELECT (logar)
                DataTable Resultado = usuario.Logar();

                // Verificar se acertou e-mail e asenha:
                if (Resultado.Rows.Count == 0) 
                {
                    MessageBox.Show("E-mail e/ou Senhas invalidos!", "Erro!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    // Armazenar as infos vindas do bd objeto "usuario"
                    usuario.Id = int.Parse(Resultado.Rows[0]["id"].ToString());
                    usuario.NameCompleto = (Resultado.Rows[0]["nome_completo"].ToString());

                    // Mudar para o Menu Principal:
                     MenuPrincipal menuPrincipal = new MenuPrincipal(usuario);
                    Hide(); // Esconder a janela atual
                    menuPrincipal.ShowDialog(); // mostrar o Menu principal

                    Show(); // Mostrar a tela de login ao sair do menu principal

                }

            }

        }
    }
}
