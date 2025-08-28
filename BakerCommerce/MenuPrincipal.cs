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
    public partial class MenuPrincipal : Form
    { 
        // Variaveis globais:
        Model.Usuario Usuario = new Model.Usuario();


        public MenuPrincipal(Model.Usuario usuario)
        {
            InitializeComponent();
            this.Usuario = usuario;
            lblDescricao.Text = $"olá {usuario.NameCompleto},\nEscolha uma opção abaixo:";
        }

        private void btnComandas_Click(object sender, EventArgs e)
        {

        }
    }
}
