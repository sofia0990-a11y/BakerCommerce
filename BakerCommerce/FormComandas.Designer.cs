namespace BakerCommerce
{
    partial class FormComandas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.grbInformacoes = new System.Windows.Forms.GroupBox();
            this.lblComandas = new System.Windows.Forms.Label();
            this.txbComandas = new System.Windows.Forms.TextBox();
            this.lblProdutos = new System.Windows.Forms.Label();
            this.txbProdutos = new System.Windows.Forms.TextBox();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.grbLancamennto = new System.Windows.Forms.GroupBox();
            this.lblProdutoLancamento = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txbProdutosLancamento = new System.Windows.Forms.TextBox();
            this.txbQuantidade = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnLancar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.grbInformacoes.SuspendLayout();
            this.grbLancamennto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvProdutos.Location = new System.Drawing.Point(378, 53);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(393, 385);
            this.dgvProdutos.TabIndex = 0;
            this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellClick);
            // 
            // grbInformacoes
            // 
            this.grbInformacoes.Controls.Add(this.btnContinuar);
            this.grbInformacoes.Controls.Add(this.txbProdutos);
            this.grbInformacoes.Controls.Add(this.lblProdutos);
            this.grbInformacoes.Controls.Add(this.txbComandas);
            this.grbInformacoes.Controls.Add(this.lblComandas);
            this.grbInformacoes.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInformacoes.Location = new System.Drawing.Point(24, 53);
            this.grbInformacoes.Name = "grbInformacoes";
            this.grbInformacoes.Size = new System.Drawing.Size(289, 221);
            this.grbInformacoes.TabIndex = 1;
            this.grbInformacoes.TabStop = false;
            this.grbInformacoes.Text = "Informações";
            // 
            // lblComandas
            // 
            this.lblComandas.AutoSize = true;
            this.lblComandas.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComandas.Location = new System.Drawing.Point(48, 59);
            this.lblComandas.Name = "lblComandas";
            this.lblComandas.Size = new System.Drawing.Size(90, 18);
            this.lblComandas.TabIndex = 0;
            this.lblComandas.Text = "Comanda:";
            // 
            // txbComandas
            // 
            this.txbComandas.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbComandas.Location = new System.Drawing.Point(144, 53);
            this.txbComandas.Name = "txbComandas";
            this.txbComandas.Size = new System.Drawing.Size(80, 30);
            this.txbComandas.TabIndex = 1;
            // 
            // lblProdutos
            // 
            this.lblProdutos.AutoSize = true;
            this.lblProdutos.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutos.Location = new System.Drawing.Point(53, 112);
            this.lblProdutos.Name = "lblProdutos";
            this.lblProdutos.Size = new System.Drawing.Size(85, 18);
            this.lblProdutos.TabIndex = 2;
            this.lblProdutos.Text = "Produtos:";
            // 
            // txbProdutos
            // 
            this.txbProdutos.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProdutos.Location = new System.Drawing.Point(144, 106);
            this.txbProdutos.Name = "txbProdutos";
            this.txbProdutos.Size = new System.Drawing.Size(78, 30);
            this.txbProdutos.TabIndex = 3;
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.FloralWhite;
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuar.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnContinuar.Location = new System.Drawing.Point(35, 159);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(195, 42);
            this.btnContinuar.TabIndex = 4;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // grbLancamennto
            // 
            this.grbLancamennto.Controls.Add(this.btnCancelar);
            this.grbLancamennto.Controls.Add(this.btnLancar);
            this.grbLancamennto.Controls.Add(this.txbQuantidade);
            this.grbLancamennto.Controls.Add(this.txbProdutosLancamento);
            this.grbLancamennto.Controls.Add(this.lblQuantidade);
            this.grbLancamennto.Controls.Add(this.lblProdutoLancamento);
            this.grbLancamennto.Enabled = false;
            this.grbLancamennto.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbLancamennto.Location = new System.Drawing.Point(24, 291);
            this.grbLancamennto.Name = "grbLancamennto";
            this.grbLancamennto.Size = new System.Drawing.Size(289, 209);
            this.grbLancamennto.TabIndex = 2;
            this.grbLancamennto.TabStop = false;
            this.grbLancamennto.Text = "Lançamento";
            // 
            // lblProdutoLancamento
            // 
            this.lblProdutoLancamento.AutoSize = true;
            this.lblProdutoLancamento.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutoLancamento.Location = new System.Drawing.Point(48, 28);
            this.lblProdutoLancamento.Name = "lblProdutoLancamento";
            this.lblProdutoLancamento.Size = new System.Drawing.Size(85, 18);
            this.lblProdutoLancamento.TabIndex = 0;
            this.lblProdutoLancamento.Text = "Produtos:";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(25, 62);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(108, 18);
            this.lblQuantidade.TabIndex = 1;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // txbProdutosLancamento
            // 
            this.txbProdutosLancamento.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProdutosLancamento.Location = new System.Drawing.Point(144, 28);
            this.txbProdutosLancamento.Name = "txbProdutosLancamento";
            this.txbProdutosLancamento.ReadOnly = true;
            this.txbProdutosLancamento.Size = new System.Drawing.Size(111, 26);
            this.txbProdutosLancamento.TabIndex = 2;
            // 
            // txbQuantidade
            // 
            this.txbQuantidade.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbQuantidade.Location = new System.Drawing.Point(144, 62);
            this.txbQuantidade.Name = "txbQuantidade";
            this.txbQuantidade.Size = new System.Drawing.Size(111, 26);
            this.txbQuantidade.TabIndex = 3;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(189, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(335, 27);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Lançamento de Comandas";
            // 
            // btnLancar
            // 
            this.btnLancar.BackColor = System.Drawing.Color.FloralWhite;
            this.btnLancar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLancar.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnLancar.Location = new System.Drawing.Point(29, 105);
            this.btnLancar.Name = "btnLancar";
            this.btnLancar.Size = new System.Drawing.Size(195, 42);
            this.btnLancar.TabIndex = 5;
            this.btnLancar.Text = "Lançar";
            this.btnLancar.UseVisualStyleBackColor = false;
            this.btnLancar.Click += new System.EventHandler(this.btnLancar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BakerCommerce.Properties.Resources.comandas;
            this.pictureBox1.Location = new System.Drawing.Point(549, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FloralWhite;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.Red;
            this.btnCancelar.Location = new System.Drawing.Point(23, 161);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(201, 42);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormComandas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(800, 538);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grbLancamennto);
            this.Controls.Add(this.grbInformacoes);
            this.Controls.Add(this.dgvProdutos);
            this.Name = "FormComandas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormComandas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.grbInformacoes.ResumeLayout(false);
            this.grbInformacoes.PerformLayout();
            this.grbLancamennto.ResumeLayout(false);
            this.grbLancamennto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.GroupBox grbInformacoes;
        private System.Windows.Forms.Label lblComandas;
        private System.Windows.Forms.TextBox txbComandas;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.TextBox txbProdutos;
        private System.Windows.Forms.Label lblProdutos;
        private System.Windows.Forms.GroupBox grbLancamennto;
        private System.Windows.Forms.TextBox txbQuantidade;
        private System.Windows.Forms.TextBox txbProdutosLancamento;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblProdutoLancamento;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnLancar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCancelar;
    }
}