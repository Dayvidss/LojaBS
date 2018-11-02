using System;

namespace LojaBS.Domain.Models {
    public class Produto {
        public Produto(Guid id, string descricao, double valorCompra, DateTime dtUltCompra, DateTime dtUltVenda) {
            Id = id;
            Descricao = descricao;
            ValorCompra = valorCompra;
            DtUltCompra = dtUltCompra;
            DtUltVenda = dtUltVenda;
        }

        protected Produto() {

        }

        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public double ValorCompra { get; set; }
        public DateTime DtUltCompra { get; set; }
        public DateTime DtUltVenda { get; set; }
    }
}
