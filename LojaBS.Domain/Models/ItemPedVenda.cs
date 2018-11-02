using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaBS.Domain.Models {
    public class ItemPedVenda {
        public Guid Id { get; set; }
        public int Qtd { get; set; }
        public PedidoVenda PedidoVenda { get; set; }
        public Cliente Cliente { get; set; }

        List<PedidoVenda> pedidos = new List<PedidoVenda>();
        List<Produto> produtos = new List<Produto>();
    }
}
