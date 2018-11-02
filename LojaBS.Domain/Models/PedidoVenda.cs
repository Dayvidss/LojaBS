using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaBS.Domain.Models {
    public class PedidoVenda {
        public Guid Id { get; set; }
        public DateTime DtVenda { get; set; }
        public double VlTotal { get; set; }
        public Cliente Cliente { get; set; }

        List<Cliente> clientes = new List<Cliente>();

        protected PedidoVenda() {

        }

        public PedidoVenda(Guid id, DateTime dtVenda, double vlTotal, Cliente cliente) {
            Id = id;
            DtVenda = dtVenda;
            VlTotal = vlTotal;
            Cliente = cliente;
        }
    }
}
