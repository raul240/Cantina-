namespace tellinhas_cantina
{
    public partial class Form1 : Form
    {

        decimal total = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listProdutos.Items.Add(new Produto("Cachorro Quente", 11.00m));
            listProdutos.Items.Add(new Produto("Cachorro Quente Duplo", 12.00m));
            listProdutos.Items.Add(new Produto("X-Salada", 12.00m));
            listProdutos.Items.Add(new Produto("X-Egg", 13.00m));
            listProdutos.Items.Add(new Produto("X-Bacon", 14.00m));
            listProdutos.Items.Add(new Produto("X-Tudo", 15.00m));
            listProdutos.Items.Add(new Produto("Refrigerante Lata", 4.00m));
            listProdutos.Items.Add(new Produto("Ch� Gelado", 5.00m));

            comboBox1.Items.Add("Dinheiro");
            comboBox1.Items.Add("Debito");
            comboBox1.Items.Add("Credito");
            comboBox1.Items.Add("pix");
        }


        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            if (listProdutos.SelectedItem != null)
            {
                Produto produtoSelecionado = (Produto)listProdutos.SelectedItem;
                listCarrinho.Items.Add(produtoSelecionado);
                total += produtoSelecionado.valor;
                lblTotal.Text = $"total R$ {total:F2}";
            }
        }

        private void btnremover_Click(object sender, EventArgs e)
        {
            Produto produtoSelecionado = (Produto)listCarrinho.SelectedItem;
            listCarrinho.Items.Remove(listCarrinho.SelectedItem);
            total -= produtoSelecionado.valor;
            lblTotal.Text = $"tatal R$ {total:F2}";
        }

        private void bntfinalizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"o valor total do pedido foi R${total:F2}");
            Pedido pedido = new Pedido();
            pedido.Cliente=txtnome.Text;
            pedido.Pagamento = comboBox1.Text;
            foreach(Produto produto in listCarrinho.Items)
            {
                pedido.Produtos.Add(produto);
            }
            pedido.Viagem = cbviagem.Checked;
            
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Dinheiro")
            {
                txttroco.Visible = true;
                txtvalor.Visible = true;
                lblValor.Visible = true;
                lblTroco.Visible = true;
            }
            else
            {
                txttroco.Visible = false;
                txtvalor.Visible = false;
                lblValor.Visible = false;
                lblTroco.Visible = false;
            }
        }

        private void txtvalor_TextChanged(object sender, EventArgs e)
        {
            if (txtvalor.Text != null)
            {
                decimal dinheiro = 0;
                Decimal.TryParse(txtvalor.Text, out dinheiro);
                txttroco.Text = (dinheiro - total).ToString();
            }

        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {
            if (txtnome.Text == "")
            {
                lblAviso.Visible = true;
            }
            else 
            {
                lblAviso.Visible = false;
            }
        }
    }
}
