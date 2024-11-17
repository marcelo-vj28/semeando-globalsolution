using System.ComponentModel.DataAnnotations;

namespace Semeando.Application.Dtos
{
    public class LevelDto
    {
        public int IdLevel { get; set; }

        [Required(ErrorMessage = "O título do level é obrigatório.")]
        [StringLength(100, ErrorMessage = "O título do level não pode ter mais de 100 caracteres.")]
        public required string Titulo { get; set; }

        [StringLength(255, ErrorMessage = "A descrição não pode ter mais de 255 caracteres.")]
        public required string Descricao { get; set; }

        [StringLength(50, ErrorMessage = "A dificuldade não pode ter mais de 50 caracteres.")]
        public required string Dificuldade { get; set; }
    }
}
