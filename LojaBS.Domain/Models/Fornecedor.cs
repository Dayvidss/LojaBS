using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaBS.Domain.Models {
    public class Fornecedor {
        public Fornecedor(Guid id, string nome, string cnpj, string endereco, DateTime dtUltCompra) {
            Id = id;
            Nome = nome;
            Cnpj = cnpj;
            Endereco = endereco;
            DtUltCompra = dtUltCompra;
        }

        protected Fornecedor() {

        }

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public string Endereco { get; set; }
        public DateTime DtUltCompra { get; set; }
    }
}
