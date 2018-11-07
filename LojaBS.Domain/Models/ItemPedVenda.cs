using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaBS.Domain.Models {
    public class ItemPedVenda {

        public ItemPedVenda(int id, int qtd, Produto produto, Cliente cliente) {
            Id = id;
            Qtd = qtd;
            this.produto = produto;
            Cliente = cliente;
        }

        public int Id { get; set; }
        public int Qtd { get; set; }
        public Produto produto { get; set; }
        public Cliente Cliente { get; set; }

    }
}
