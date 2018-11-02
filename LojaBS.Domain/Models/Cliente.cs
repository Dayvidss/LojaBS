using System;

namespace LojaBS.Domain.Models {
    public class Cliente {
        public Cliente(Guid id, string nome, string telefone, string endereco, string cpf) {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
            Cpf = cpf;
        }

        protected Cliente() {

        }

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string Cpf { get; set; }
        public DateTime DtUltVenda{ get; set; }
    }
}
