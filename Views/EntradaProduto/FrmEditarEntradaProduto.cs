﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGPPC.Views.EntradaProduto
{
    public partial class FrmEditarEntradaProduto : Form
    {
        private string descricaoOrignalPreco;

        private string descricaoOriginalQuantidade;

        public FrmEditarEntradaProduto()
        {
            InitializeComponent();
        }

        public FrmEditarEntradaProduto(string precoUnitario, string quantidade, string id)
        {
            InitializeComponent();

            txbPreco.Text = precoUnitario;
            txbQuantidade.Text = quantidade;
            txbId.Text = id;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmEditarEntradaProduto_Load(object sender, EventArgs e)
        {
            descricaoOrignalPreco = txbPreco.Text;
                
            descricaoOriginalQuantidade = txbQuantidade.Text;
        }
    }
}
