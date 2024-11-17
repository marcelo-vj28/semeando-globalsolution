using System.ComponentModel.DataAnnotations;

namespace Semeando.Application.Dtos
{
    public class UsuarioDto
    {
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "O nome do usuário é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome do usuário não pode ter mais de 100 caracteres.")]
        public required string NomeUsuario { get; set; }

        [Required(ErrorMessage = "O email é obrigatório.")]
        [EmailAddress(ErrorMessage = "O email fornecido não é válido.")]
        [StringLength(100, ErrorMessage = "O email não pode ter mais de 100 caracteres.")]
        public required string Email { get; set; }

        [StringLength(1, ErrorMessage = "O ranking deve ter exatamente 1 caractere.")]
        public char? Ranking { get; set; }

        public int Streak { get; set; } = 0;

        [StringLength(255, ErrorMessage = "A bio não pode ter mais de 255 caracteres.")]
        public required string Bio { get; set; }
    }
}
