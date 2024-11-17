using System.Collections.Generic;

namespace Semeando.Domain.Entities
{
    public class LevelEntity
    {
        public int Id { get; set; }
        public required string Titulo { get; set; }
        public required string Descricao { get; set; }
        public required string Dificuldade { get; set; }

        public required ICollection<PerguntaEntity> Perguntas { get; set; }
    }
}
