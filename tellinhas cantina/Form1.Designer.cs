namespace tellinhas_cantina
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listProdutos = new ListBox();
            listCarrinho = new ListBox();
            btnadicionar = new Button();
            btnremover = new Button();
            bntconcluir = new Button();
            lblTotal = new Label();
            cbviagem = new CheckBox();
            comboBox1 = new ComboBox();
            txtvalor = new TextBox();
            txttroco = new TextBox();
            lblValor = new Label();
            lblTroco = new Label();
            txtnome = new TextBox();
            label1 = new Label();
            lblAviso = new Label();
            btbalcao = new Button();
            btcozinha = new Button();
            SuspendLayout();
            // 
            // listProdutos
            // 
            listProdutos.BackColor = SystemColors.InactiveCaptionText;
            listProdutos.ForeColor = Color.Yellow;
            listProdutos.FormattingEnabled = true;
            listProdutos.ItemHeight = 15;
            listProdutos.Location = new Point(12, 27);
            listProdutos.Name = "listProdutos";
            listProdutos.Size = new Size(251, 94);
            listProdutos.TabIndex = 0;
            listProdutos.Click += listBox1_SelectedIndexChanged;
            listProdutos.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listCarrinho
            // 
            listCarrinho.BackColor = SystemColors.InfoText;
            listCarrinho.ForeColor = Color.Yellow;
            listCarrinho.FormattingEnabled = true;
            listCarrinho.ItemHeight = 15;
            listCarrinho.Location = new Point(12, 203);
            listCarrinho.Name = "listCarrinho";
            listCarrinho.Size = new Size(251, 94);
            listCarrinho.TabIndex = 1;
            listCarrinho.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // btnadicionar
            // 
            btnadicionar.BackColor = Color.Black;
            btnadicionar.ForeColor = Color.Yellow;
            btnadicionar.Location = new Point(88, 157);
            btnadicionar.Name = "btnadicionar";
            btnadicionar.Size = new Size(75, 23);
            btnadicionar.TabIndex = 2;
            btnadicionar.Text = "adicionar >";
            btnadicionar.UseVisualStyleBackColor = false;
            btnadicionar.Click += btnadicionar_Click;
            // 
            // btnremover
            // 
            btnremover.BackColor = Color.Black;
            btnremover.ForeColor = Color.Yellow;
            btnremover.Location = new Point(88, 336);
            btnremover.Name = "btnremover";
            btnremover.Size = new Size(75, 23);
            btnremover.TabIndex = 3;
            btnremover.Text = "remover >";
            btnremover.UseVisualStyleBackColor = false;
            btnremover.Click += btnremover_Click;
            // 
            // bntconcluir
            // 
            bntconcluir.BackColor = Color.Black;
            bntconcluir.ForeColor = Color.Yellow;
            bntconcluir.Location = new Point(698, 415);
            bntconcluir.Name = "bntconcluir";
            bntconcluir.Size = new Size(75, 23);
            bntconcluir.TabIndex = 4;
            bntconcluir.Text = "concluir";
            bntconcluir.UseVisualStyleBackColor = false;
            bntconcluir.Click += bntfinalizar_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.Yellow;
            lblTotal.Location = new Point(574, 384);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(47, 15);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "total:R$";
            // 
            // cbviagem
            // 
            cbviagem.AutoSize = true;
            cbviagem.ForeColor = Color.Yellow;
            cbviagem.Location = new Point(537, 187);
            cbviagem.Name = "cbviagem";
            cbviagem.Size = new Size(169, 19);
            cbviagem.TabIndex = 6;
            cbviagem.Text = "deseja levar para a viagem?";
            cbviagem.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.InfoText;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.ForeColor = Color.Yellow;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(537, 63);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtvalor
            // 
            txtvalor.BackColor = SystemColors.InfoText;
            txtvalor.ForeColor = Color.Yellow;
            txtvalor.Location = new Point(537, 98);
            txtvalor.Name = "txtvalor";
            txtvalor.Size = new Size(121, 23);
            txtvalor.TabIndex = 9;
            txtvalor.Visible = false;
            txtvalor.TextChanged += txtvalor_TextChanged;
            // 
            // txttroco
            // 
            txttroco.BackColor = SystemColors.InfoText;
            txttroco.ForeColor = Color.Yellow;
            txttroco.Location = new Point(537, 129);
            txttroco.Name = "txttroco";
            txttroco.Size = new Size(121, 23);
            txttroco.TabIndex = 10;
            txttroco.Visible = false;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.BackColor = Color.Yellow;
            lblValor.Location = new Point(431, 106);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(100, 15);
            lblValor.TabIndex = 11;
            lblValor.Text = "valor em dinheiro";
            lblValor.Visible = false;
            // 
            // lblTroco
            // 
            lblTroco.AutoSize = true;
            lblTroco.BackColor = Color.Yellow;
            lblTroco.Location = new Point(431, 137);
            lblTroco.Name = "lblTroco";
            lblTroco.Size = new Size(92, 15);
            lblTroco.TabIndex = 12;
            lblTroco.Text = "troco a ser dado";
            lblTroco.Visible = false;
            // 
            // txtnome
            // 
            txtnome.BackColor = Color.Black;
            txtnome.ForeColor = Color.Yellow;
            txtnome.Location = new Point(537, 158);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(119, 23);
            txtnome.TabIndex = 13;
            txtnome.TextChanged += txtnome_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Yellow;
            label1.Location = new Point(431, 166);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 14;
            label1.Text = "nome do cliente";
            // 
            // lblAviso
            // 
            lblAviso.AutoSize = true;
            lblAviso.ForeColor = Color.Yellow;
            lblAviso.Location = new Point(537, 220);
            lblAviso.Name = "lblAviso";
            lblAviso.Size = new Size(236, 15);
            lblAviso.TabIndex = 15;
            lblAviso.Text = "Nome do cliente não pode estar em branco";
            lblAviso.Visible = false;
            // 
            // btbalcao
            // 
            btbalcao.BackColor = Color.Black;
            btbalcao.ForeColor = Color.Yellow;
            btbalcao.Location = new Point(2, 415);
            btbalcao.Name = "btbalcao";
            btbalcao.Size = new Size(75, 23);
            btbalcao.TabIndex = 16;
            btbalcao.Text = "balcao";
            btbalcao.UseVisualStyleBackColor = false;
            btbalcao.Click += btbalcao_Click;
            // 
            // btcozinha
            // 
            btcozinha.BackColor = Color.Black;
            btcozinha.ForeColor = Color.Yellow;
            btcozinha.Location = new Point(2, 386);
            btcozinha.Name = "btcozinha";
            btcozinha.Size = new Size(75, 23);
            btcozinha.TabIndex = 17;
            btcozinha.Text = "cozinha";
            btcozinha.UseVisualStyleBackColor = false;
            btcozinha.Click += btcozinha_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(800, 450);
            Controls.Add(btcozinha);
            Controls.Add(btbalcao);
            Controls.Add(lblAviso);
            Controls.Add(label1);
            Controls.Add(txtnome);
            Controls.Add(lblTroco);
            Controls.Add(lblValor);
            Controls.Add(txttroco);
            Controls.Add(txtvalor);
            Controls.Add(comboBox1);
            Controls.Add(cbviagem);
            Controls.Add(lblTotal);
            Controls.Add(bntconcluir);
            Controls.Add(btnremover);
            Controls.Add(btnadicionar);
            Controls.Add(listCarrinho);
            Controls.Add(listProdutos);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listProdutos;
        private ListBox listCarrinho;
        private Button btnadicionar;
        private Button btnremover;
        private Button bntconcluir;
        private Label lblTotal;
        private CheckBox cbviagem;
        private ComboBox comboBox1;
        private TextBox txtvalor;
        private TextBox txttroco;
        private Label lblValor;
        private Label lblTroco;
        private TextBox txtnome;
        private Label label1;
        private Label lblAviso;
        private Button btbalcao;
        private Button btcozinha;
    }
}
