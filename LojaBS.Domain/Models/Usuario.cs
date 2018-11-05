using LojaBS.Domain.Models.ValueObjects;

namespace LojaBS.Domain.Models {
    public class Usuario {
        public Usuario(int guid, string login, string senha, Nome nome) {
            Guid = guid;
            Login = login;
            Senha = senha;
            Nome = nome;
        }

        public int Guid { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public Nome Nome { get; set; }
    }
}
