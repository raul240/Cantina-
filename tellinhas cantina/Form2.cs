﻿using System;
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
    public partial class Form2 : Form
    {
        string prontto = "";
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (Pedido pedido in ListaPedido.pedidos)
            {
                if (pedido.status == Status.status.PRONTO)
                {
                    listPreparando.Items.Add(pedido);
                }
                else if (pedido.status == Status.status.ENTREGUE)
                {
                    listEntregue.Items.Add(pedido);
                }




            }


        }

        private void listPreparando_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btPronto_Click(object sender, EventArgs e)
        {
            if (listPreparando.SelectedItem != null)
            {
                listEntregue.Items.Add(listPreparando.SelectedItem);
                Pedido selecionado = (Pedido)listPreparando.SelectedItem;
                selecionado.status = Status.status.ENTREGUE;
                listPreparando.Items.Remove(selecionado);
            }
            else
            {
                MessageBox.Show("nao existe pedido selecionado");
            }
        }

        private void listEntregue_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}
