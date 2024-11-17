using System.Collections.Generic;

namespace Semeando.Domain.Entities
{
    public class PerguntaEntity
    {
        public int Id { get; set; }
        public int? LevelId { get; set; }
        public required string Texto { get; set; }
        public required string TipoPergunta { get; set; }

        public required LevelEntity Level { get; set; }
        public required ICollection<OpcaoEntity> Opcoes { get; set; }
        public required ICollection<RespostaEntity> Respostas { get; set; }
    }
}
