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
    public partial class FormCaixa : Form
    {
        Model.Usuario usuario;
       
        public FormCaixa(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
             // Verificar se o campos está vazio:

             if (txbComanda.Text.Length == 0)
            {
                MessageBox.Show("Informe o número da Comanda! " , "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Model.OrdemComanda ordemComanda = new Model.OrdemComanda();
                ordemComanda.IdFicha = int.Parse(txbComanda.Text);

                // Tabela para receber o resultado da consulta SELECT

                DataTable resultado = ordemComanda.BuscarPorFicha();

                // verificar se existe linha em "resultados"

                if (resultado.Rows.Count > 0 )
                {
                     // Mostrar no dgv
                     dgvCaixa.DataSource= resultado.Rows; 
                    // Calcular o total e mostrar o lblTotal:
                    lblTotal.Text= "R$" + resultado.Compute("Sum(total_item)", "true").ToString();

                }
                else
                {  
                    // Limpar o dgv:
                    dgvCaixa.DataSource = null;

                    // Mostrar Menssagem de erro

                    MessageBox.Show("Não existe lançamentos nessa comanda! ", "Atenção!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void chbPagamento_CheckedChanged(object sender, EventArgs e)
        {
             btnEncerramento.Enabled = chbPagamento.Checked;
        }

        private void btnEncerramento_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(" Tem certeza que deseja encerrar essa comanda?", "Atenção!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(resultado == DialogResult.Yes)
            {
                 // Encerrar Comanda:
                 Model.OrdemComanda ordemComanda = new Model.OrdemComanda();
                ordemComanda.IdFicha = int.Parse(txbComanda.Text);

                // executar o update  para encerrar a comanda:
                if (ordemComanda.EncerrarComanda())
                {
                    MessageBox.Show("comanda encerrada! ", "Show!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Resetar os campos:
                    txbComanda.Clear();
                    dgvCaixa.DataSource = null;
                    chbPagamento.Checked = false;
                    btnEncerramento.Enabled = false;
                    lblTotal.Text = "R$ - ";
                }
                else
                {
                    MessageBox.Show("Falha ao encerrar a comanda! ", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

        }
    }
}
