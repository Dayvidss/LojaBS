using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LojaBS.Domain.Models {
    [Table("unMedida")]
    public class UnidadeMedida {

        public UnidadeMedida() {

        }

        public UnidadeMedida(string un, string descricao) {
            Un = un;
            Descricao = descricao;
        }

        [Key]
        [Column("id",Order =0)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Column("um", Order = 1)]
        [MinLength(1,ErrorMessage ="Tamanho mínimo de 1 caractere")]
        [MaxLength(3,ErrorMessage ="Tamanho máximo de 3 caracteres")]
        public string Un { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Column("descricao", Order = 2)]
        [MinLength(3,ErrorMessage ="Tamanho mínimo de 3 caracteres")]
        [MaxLength(30,ErrorMessage ="Tamanho máximo de 30 caracteres")]
        public string Descricao { get; set; }
    }
}
