namespace LojaBS.Domain.Models.ValueObjects {
    public class Nome {
        public Nome(string primeiroNome, string segundoNome) {
            PrimeiroNome = primeiroNome;
            SegundoNome = segundoNome;
        }

        public string PrimeiroNome { get; set; }
        public string SegundoNome { get; set; }

        public override string ToString() {
            return PrimeiroNome + " " + SegundoNome;
        }
    }
}
