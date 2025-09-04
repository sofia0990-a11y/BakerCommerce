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
        public FormProdutos(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void cmbCategoriaCadastrar_SelectedIndexChanged(object sender, EventArgs e)
        {
             
        }

        public void listarCategoriascmb()
        {
             Model.Categoria categoria = new Model.Categoria();
            DataTable tabela = categoria.Listar();

            foreach(DataRow dr in tabela.Rows)
            {
                // 1- salgados
                // 2- Refrigerante
                cmbCategoriaCadastrar.Items.Add($"{dr["id"]} - {dr["nome"]}");
                cmdCategoriaEditar.Items
                    .Add($"{dr["id"]} - {dr["nome"]}");
            }
        }

        
    }
}
