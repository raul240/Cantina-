namespace tellinhas_cantina
{
    public partial class Form1 : Form
    {

        decimal total = 0;
        decimal dinheiro = 0;
        Form2 form2 = new Form2();
        Form3 form3 = new Form3();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listProdutos.Items.Add(new Produto("Pão de queijo", 3.50m) { cozinha = false });
            listProdutos.Items.Add(new Produto("Coxinha", 5.00m) { cozinha = false });
            listProdutos.Items.Add(new Produto("Pastel de carne", 6.00m) { cozinha = false });
            listProdutos.Items.Add(new Produto("Pastel de queijo", 5.50m) { cozinha = false });
            listProdutos.Items.Add(new Produto("Suco natural (300ml)", 4.00m) { cozinha = false });
            listProdutos.Items.Add(new Produto("Refrigerante lata", 4.50m) { cozinha = false });
            listProdutos.Items.Add(new Produto("Hambúrguer simples", 8.00m) { cozinha = true });
            listProdutos.Items.Add(new Produto("Hambúerguer com queijo", 9.00m) { cozinha = true });
            listProdutos.Items.Add(new Produto("x-Tudo", 12.00m) { cozinha = true });
            listProdutos.Items.Add(new Produto("Água Mineral", 2.50m) { cozinha = false });

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
            if (listCarrinho.Items.Count == 0)
            {
                MessageBox.Show("Não tem nenhum produto para ser removido");
                return;
            }
            else if (listCarrinho.SelectedItem != null)
            {
                Produto produtoSelecionado = (Produto)listCarrinho.SelectedItem;
                listCarrinho.Items.Remove(listCarrinho.SelectedItem);
                total -= produtoSelecionado.valor;
                lblTotal.Text = $"tatal R$ {total:F2}";
            }
            else
            {
                MessageBox.Show("Selecione um produto para remover");
            }

            }

        private void bntfinalizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"o valor total do pedido foi R${total:F2}");
            Pedido pedido = new Pedido();
            pedido.Cliente = txtnome.Text;
            pedido.Pagamento = comboBox1.Text;
            foreach (Produto produto in listCarrinho.Items)
            {
                pedido.Produtos.Add(produto);

            }
            foreach (Produto produto in pedido.Produtos)
            {
                if (produto.cozinha)
                {
                    pedido.status = Status.status.PREPARANDO;

                    break;
                }
                else
                {
                    pedido.status = Status.status.PRONTO;
                }
            }

            pedido.Viagem = cbviagem.Checked;
            ListaPedido.pedidos.Add(pedido);
            listCarrinho.Items.Clear();
            comboBox1.SelectedIndex = -1;
            txtnome.Text = "";
            txttroco.Text = "";
            txtvalor.Text = "";
            lblTotal.ResetText();
            total = 0;
            dinheiro = 0;
            cbviagem.Checked = false;




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (comboBox1.SelectedItem == null)
            {
                txttroco.Visible = false;
                txtvalor.Visible = false;
                lblValor.Visible = false;
                lblTroco.Visible = false;
            }
            else if (comboBox1.SelectedItem.ToString() == "Dinheiro")
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

        private void btbalcao_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void btcozinha_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void btchamada_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }
    }
}
