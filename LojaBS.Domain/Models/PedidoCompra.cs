using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaBS.Domain.Models {
    public class PedidoCompra {
        public Guid Id { get; set; }
        public DateTime DtVenda { get; set; }
        public double VlTotal { get; set; }
        public Fornecedor Fornecedor { get; set; }

        List<Fornecedor> fornecedores = new List<Fornecedor>();

        protected PedidoCompra() {

        }

        public PedidoCompra(Guid id, DateTime dtVenda, double vlTotal, Fornecedor fornecedor) {
            Id = id;
            DtVenda = dtVenda;
            VlTotal = vlTotal;
            Fornecedor = fornecedor;
        }
    }
}
