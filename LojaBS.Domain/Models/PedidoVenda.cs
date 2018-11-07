using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaBS.Domain.Models {
    public class PedidoVenda {
        public Guid Id { get; set; }
        public DateTime DtVenda { get; set; }
        public Cliente Cliente { get; set; }

        public ICollection<ItemPedVenda> itens { get; set; } = new List<ItemPedVenda>();

        protected PedidoVenda() {

        }

        public PedidoVenda( Cliente cliente) {
            DtVenda = DateTime.Now.Date;
            Cliente = cliente;
        }
        
        public void addVenda(ItemPedVenda itemPedido) {
            itens.Add(itemPedido);
        }
    }
}
