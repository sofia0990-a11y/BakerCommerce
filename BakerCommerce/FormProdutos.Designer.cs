namespace BakerCommerce
{
    partial class FormProdutos
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
            this.grbCadastrar = new System.Windows.Forms.GroupBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.cmbCategoriaCadastrar = new System.Windows.Forms.ComboBox();
            this.lblCategoriaCadastro = new System.Windows.Forms.Label();
            this.txbPrecoCadastrar = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txbNomeCadastro = new System.Windows.Forms.TextBox();
            this.lblNomeCadastro = new System.Windows.Forms.Label();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.btnCadastrarEditar = new System.Windows.Forms.Button();
            this.cmdCategoriaEditar = new System.Windows.Forms.ComboBox();
            this.lblCategoriaEditar = new System.Windows.Forms.Label();
            this.txbPrecoEditar = new System.Windows.Forms.TextBox();
            this.lblPrecoEditar = new System.Windows.Forms.Label();
            this.txbNomeEditar = new System.Windows.Forms.TextBox();
            this.lblNomeEditar = new System.Windows.Forms.Label();
            this.grbApagar = new System.Windows.Forms.GroupBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.lblDescriçãoApagar = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.grbCadastrar.SuspendLayout();
            this.grbEditar.SuspendLayout();
            this.grbApagar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(90, 63);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(568, 278);
            this.dgvProdutos.TabIndex = 0;
            this.dgvProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellContentClick);
            // 
            // grbCadastrar
            // 
            this.grbCadastrar.Controls.Add(this.btnCadastrar);
            this.grbCadastrar.Controls.Add(this.cmbCategoriaCadastrar);
            this.grbCadastrar.Controls.Add(this.lblCategoriaCadastro);
            this.grbCadastrar.Controls.Add(this.txbPrecoCadastrar);
            this.grbCadastrar.Controls.Add(this.lblPreco);
            this.grbCadastrar.Controls.Add(this.txbNomeCadastro);
            this.grbCadastrar.Controls.Add(this.lblNomeCadastro);
            this.grbCadastrar.Location = new System.Drawing.Point(90, 347);
            this.grbCadastrar.Name = "grbCadastrar";
            this.grbCadastrar.Size = new System.Drawing.Size(262, 149);
            this.grbCadastrar.TabIndex = 1;
            this.grbCadastrar.TabStop = false;
            this.grbCadastrar.Text = "Cadastrar";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(36, 106);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(191, 37);
            this.btnCadastrar.TabIndex = 7;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // cmbCategoriaCadastrar
            // 
            this.cmbCategoriaCadastrar.FormattingEnabled = true;
            this.cmbCategoriaCadastrar.Location = new System.Drawing.Point(87, 71);
            this.cmbCategoriaCadastrar.Name = "cmbCategoriaCadastrar";
            this.cmbCategoriaCadastrar.Size = new System.Drawing.Size(114, 21);
            this.cmbCategoriaCadastrar.TabIndex = 6;
            this.cmbCategoriaCadastrar.SelectedIndexChanged += new System.EventHandler(this.cmbCategoriaCadastrar_SelectedIndexChanged);
            // 
            // lblCategoriaCadastro
            // 
            this.lblCategoriaCadastro.AutoSize = true;
            this.lblCategoriaCadastro.Location = new System.Drawing.Point(12, 71);
            this.lblCategoriaCadastro.Name = "lblCategoriaCadastro";
            this.lblCategoriaCadastro.Size = new System.Drawing.Size(63, 13);
            this.lblCategoriaCadastro.TabIndex = 5;
            this.lblCategoriaCadastro.Text = "Cadegorias:";
            // 
            // txbPrecoCadastrar
            // 
            this.txbPrecoCadastrar.Location = new System.Drawing.Point(87, 47);
            this.txbPrecoCadastrar.Name = "txbPrecoCadastrar";
            this.txbPrecoCadastrar.Size = new System.Drawing.Size(114, 20);
            this.txbPrecoCadastrar.TabIndex = 3;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(33, 47);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(37, 13);
            this.lblPreco.TabIndex = 2;
            this.lblPreco.Text = "preço:";
            // 
            // txbNomeCadastro
            // 
            this.txbNomeCadastro.Location = new System.Drawing.Point(87, 20);
            this.txbNomeCadastro.Name = "txbNomeCadastro";
            this.txbNomeCadastro.Size = new System.Drawing.Size(114, 20);
            this.txbNomeCadastro.TabIndex = 1;
            // 
            // lblNomeCadastro
            // 
            this.lblNomeCadastro.AutoSize = true;
            this.lblNomeCadastro.Location = new System.Drawing.Point(33, 20);
            this.lblNomeCadastro.Name = "lblNomeCadastro";
            this.lblNomeCadastro.Size = new System.Drawing.Size(38, 13);
            this.lblNomeCadastro.TabIndex = 0;
            this.lblNomeCadastro.Text = "Nome:";
            // 
            // grbEditar
            // 
            this.grbEditar.Controls.Add(this.btnCadastrarEditar);
            this.grbEditar.Controls.Add(this.cmdCategoriaEditar);
            this.grbEditar.Controls.Add(this.lblCategoriaEditar);
            this.grbEditar.Controls.Add(this.txbPrecoEditar);
            this.grbEditar.Controls.Add(this.lblPrecoEditar);
            this.grbEditar.Controls.Add(this.txbNomeEditar);
            this.grbEditar.Controls.Add(this.lblNomeEditar);
            this.grbEditar.Location = new System.Drawing.Point(408, 347);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Size = new System.Drawing.Size(250, 149);
            this.grbEditar.TabIndex = 8;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "Editar";
            // 
            // btnCadastrarEditar
            // 
            this.btnCadastrarEditar.Location = new System.Drawing.Point(36, 106);
            this.btnCadastrarEditar.Name = "btnCadastrarEditar";
            this.btnCadastrarEditar.Size = new System.Drawing.Size(191, 37);
            this.btnCadastrarEditar.TabIndex = 7;
            this.btnCadastrarEditar.Text = "Cadastrar";
            this.btnCadastrarEditar.UseVisualStyleBackColor = true;
            this.btnCadastrarEditar.Click += new System.EventHandler(this.btnCadastrarEditar_Click);
            // 
            // cmdCategoriaEditar
            // 
            this.cmdCategoriaEditar.FormattingEnabled = true;
            this.cmdCategoriaEditar.Location = new System.Drawing.Point(87, 71);
            this.cmdCategoriaEditar.Name = "cmdCategoriaEditar";
            this.cmdCategoriaEditar.Size = new System.Drawing.Size(114, 21);
            this.cmdCategoriaEditar.TabIndex = 6;
            // 
            // lblCategoriaEditar
            // 
            this.lblCategoriaEditar.AutoSize = true;
            this.lblCategoriaEditar.Location = new System.Drawing.Point(12, 71);
            this.lblCategoriaEditar.Name = "lblCategoriaEditar";
            this.lblCategoriaEditar.Size = new System.Drawing.Size(63, 13);
            this.lblCategoriaEditar.TabIndex = 5;
            this.lblCategoriaEditar.Text = "Cadegorias:";
            // 
            // txbPrecoEditar
            // 
            this.txbPrecoEditar.Location = new System.Drawing.Point(87, 47);
            this.txbPrecoEditar.Name = "txbPrecoEditar";
            this.txbPrecoEditar.Size = new System.Drawing.Size(114, 20);
            this.txbPrecoEditar.TabIndex = 3;
            // 
            // lblPrecoEditar
            // 
            this.lblPrecoEditar.AutoSize = true;
            this.lblPrecoEditar.Location = new System.Drawing.Point(33, 47);
            this.lblPrecoEditar.Name = "lblPrecoEditar";
            this.lblPrecoEditar.Size = new System.Drawing.Size(37, 13);
            this.lblPrecoEditar.TabIndex = 2;
            this.lblPrecoEditar.Text = "preço:";
            // 
            // txbNomeEditar
            // 
            this.txbNomeEditar.Location = new System.Drawing.Point(87, 20);
            this.txbNomeEditar.Name = "txbNomeEditar";
            this.txbNomeEditar.Size = new System.Drawing.Size(114, 20);
            this.txbNomeEditar.TabIndex = 1;
            // 
            // lblNomeEditar
            // 
            this.lblNomeEditar.AutoSize = true;
            this.lblNomeEditar.Location = new System.Drawing.Point(33, 20);
            this.lblNomeEditar.Name = "lblNomeEditar";
            this.lblNomeEditar.Size = new System.Drawing.Size(38, 13);
            this.lblNomeEditar.TabIndex = 0;
            this.lblNomeEditar.Text = "Nome:";
            // 
            // grbApagar
            // 
            this.grbApagar.Controls.Add(this.btnApagar);
            this.grbApagar.Controls.Add(this.lblDescriçãoApagar);
            this.grbApagar.Location = new System.Drawing.Point(90, 508);
            this.grbApagar.Name = "grbApagar";
            this.grbApagar.Size = new System.Drawing.Size(568, 92);
            this.grbApagar.TabIndex = 9;
            this.grbApagar.TabStop = false;
            this.grbApagar.Text = "Apagar";
            // 
            // btnApagar
            // 
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.ForeColor = System.Drawing.Color.DarkRed;
            this.btnApagar.Location = new System.Drawing.Point(391, 22);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(154, 40);
            this.btnApagar.TabIndex = 1;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // lblDescriçãoApagar
            // 
            this.lblDescriçãoApagar.AutoSize = true;
            this.lblDescriçãoApagar.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriçãoApagar.Location = new System.Drawing.Point(11, 29);
            this.lblDescriçãoApagar.Name = "lblDescriçãoApagar";
            this.lblDescriçãoApagar.Size = new System.Drawing.Size(351, 22);
            this.lblDescriçãoApagar.TabIndex = 0;
            this.lblDescriçãoApagar.Text = "Selecione um produto para apagar";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Lucida Handwriting", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(135, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(427, 37);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "Gerenciador de Produtos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BakerCommerce.Properties.Resources.Carrinho;
            this.pictureBox1.Location = new System.Drawing.Point(568, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // FormProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(855, 601);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grbApagar);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.grbCadastrar);
            this.Controls.Add(this.dgvProdutos);
            this.Name = "FormProdutos";
            this.Text = "FormProdutos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.grbCadastrar.ResumeLayout(false);
            this.grbCadastrar.PerformLayout();
            this.grbEditar.ResumeLayout(false);
            this.grbEditar.PerformLayout();
            this.grbApagar.ResumeLayout(false);
            this.grbApagar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.GroupBox grbCadastrar;
        private System.Windows.Forms.ComboBox cmbCategoriaCadastrar;
        private System.Windows.Forms.Label lblCategoriaCadastro;
        private System.Windows.Forms.TextBox txbPrecoCadastrar;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txbNomeCadastro;
        private System.Windows.Forms.Label lblNomeCadastro;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.Button btnCadastrarEditar;
        private System.Windows.Forms.ComboBox cmdCategoriaEditar;
        private System.Windows.Forms.Label lblCategoriaEditar;
        private System.Windows.Forms.TextBox txbPrecoEditar;
        private System.Windows.Forms.Label lblPrecoEditar;
        private System.Windows.Forms.TextBox txbNomeEditar;
        private System.Windows.Forms.Label lblNomeEditar;
        private System.Windows.Forms.GroupBox grbApagar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label lblDescriçãoApagar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}