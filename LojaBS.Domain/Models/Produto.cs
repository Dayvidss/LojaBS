using System.Collections;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace LojaBS.Domain.Models {
    [Table("Produto")]
    public class Produto {
        public Produto(string descricao, string unidMedida) {
            Descricao = descricao;
            UnidMedida = unidMedida;
        }

        public Produto() {

        }

        [Key]
        [Column("id",Order =0)]
        public int Id { get; set; }

        [Column("descricao",Order =1)]
        [Required]
        [MaxLength(50, ErrorMessage = "Quantidade de caracteres não permitido.")]
        public string Descricao { get; set; }

        [Column("um",Order =2)]
        [Required(ErrorMessage ="Campo Obrigatório")]
        [MaxLength(2, ErrorMessage = "Quantidade de caracteres não permitido.")]
        public string UnidMedida { get; set; }

        [Column("valorVenda",Order = 3)]
        public double ValorVenda { get; set; }

        [Column("valorCompra",Order = 4)]
        public double ValorCompra { get; set; }

        [Column("dtUltCompra",Order = 5)]
        public DateTime DtUltCompra { get; set; }

        [Column("dtUltVenda", Order = 6)]
        public DateTime DtUltVenda { get; set; }

        //public UnidadeMedida UM = new UnidadeMedida();
    }
}
