using System;
using System.Collections.Generic;

namespace LojaBS.Domain.Models {
    public class SaldoProduto {
        public Guid Id { get; set; }
        public DateTime DtMov { get; set; }
        public int QtdAtual { get; set; }
        public double VlAtual { get; set; }

        List<Cliente> clientes = new List<Cliente>();
        List<Fornecedor> fornecedores = new List<Fornecedor>();
        List<Produto> produtos = new List<Produto>();

        protected SaldoProduto() {

        }

        public SaldoProduto(Guid id, DateTime dtMov, int qtdAtual, double vlAtual) {
            Id = id;
            DtMov = dtMov;
            QtdAtual = qtdAtual;
            VlAtual = vlAtual;
        }
    }
}
