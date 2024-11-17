using System.ComponentModel.DataAnnotations;

namespace Semeando.Application.Dtos
{
    public class OpcaoDto
    {
        [Required(ErrorMessage = "O ID da pergunta é obrigatório.")]
        public int IdPergunta { get; set; }

        [Required(ErrorMessage = "O ID da opção é obrigatório.")]
        [Range(1, 9, ErrorMessage = "O ID da opção deve estar entre 1 e 9.")]
        public int IdOpcao { get; set; }

        [StringLength(255, ErrorMessage = "O texto da opção não pode ter mais de 255 caracteres.")]
        public required string Texto { get; set; }

        public bool OpcaoCorreta { get; set; } = false;
    }
}
