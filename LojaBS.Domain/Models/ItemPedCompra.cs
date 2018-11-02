using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaBS.Domain.Models {
    public class ItemPedCompra {
        public Guid Id { get; set; }
        public int Qtd { get; set; }
        public PedidoCompra PedidoCompra { get; set; }
        public Fornecedor Fornecedor { get; set; }

        List<PedidoCompra> pedidos = new List<PedidoCompra>();
        List<Produto> produtos = new List<Produto>();
    }
}
