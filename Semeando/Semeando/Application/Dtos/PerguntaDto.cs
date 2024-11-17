using System.ComponentModel.DataAnnotations;

namespace Semeando.Application.Dtos
{
    public class PerguntaDto
    {
        public int IdPergunta { get; set; }

        [Required(ErrorMessage = "O ID do level é obrigatório.")]
        public int IdLevel { get; set; }

        [Required(ErrorMessage = "O texto da pergunta é obrigatório.")]
        [StringLength(255, ErrorMessage = "O texto da pergunta não pode ter mais de 255 caracteres.")]
        public required string Texto { get; set; }

        [StringLength(50, ErrorMessage = "O tipo de pergunta não pode ter mais de 50 caracteres.")]
        public required string TipoPergunta { get; set; }
    }
}
