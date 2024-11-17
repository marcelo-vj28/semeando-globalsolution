namespace Semeando.Domain.Entities
{
    public class OpcaoEntity
    {
        public int Id { get; set; }
        public int PerguntaId { get; set; }
        public required string Texto { get; set; }
        public char OpCorreta { get; set; }

        public required PerguntaEntity Pergunta { get; set; }
    }
}
