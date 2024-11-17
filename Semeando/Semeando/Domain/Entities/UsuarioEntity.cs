using System.Collections.Generic;

namespace Semeando.Domain.Entities
{
    public class UsuarioEntity
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required string Email { get; set; }
        public required string Ranking { get; set; }
        public int Streak { get; set; }
        public required string Bio { get; set; }

        public required ICollection<RespostaEntity> Respostas { get; set; }
    }
}
