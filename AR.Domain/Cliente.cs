using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AR.Domain
{
    [Table("Cliente")] // Se deixar sem ele já pega por reflexo o nome da classe, vai gerar com nome da classe
    public class Cliente
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [MaxLength(50, ErrorMessage = "O campo {0} dete ter no máximo {1} caracteres")]
        public string Nome { get; set; }

        public string CPF { get; set; }

        public int Idade { get; set; }

    }
}
