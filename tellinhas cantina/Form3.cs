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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            foreach (Pedido pedido in ListaPedido.pedidos)
            {
                if (pedido.status == Status.status.PREPARANDO)
                {
                    listcozinha.Items.Add(pedido);
                }
                
                }
            }
    }
}
