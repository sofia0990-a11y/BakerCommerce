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
            }

        }
    }
}
