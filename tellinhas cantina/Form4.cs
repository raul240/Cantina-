using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tellinhas_cantina
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void listchamada_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            foreach (Pedido pedido in ListaPedido.pedidos)
            {
                if (pedido.status == Status.status.ENTREGUE)
                {
                    listchamada.Items.Add(pedido);
                }
            }

        }
    }
}
