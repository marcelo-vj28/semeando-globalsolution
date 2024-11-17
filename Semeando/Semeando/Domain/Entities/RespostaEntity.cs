namespace Semeando.Domain.Entities
{
    public class RespostaEntity
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int PerguntaId { get; set; } 
        public int OpcaoEscolhida { get; set; } 

        public required UsuarioEntity Usuario { get; set; } 
        public required PerguntaEntity Pergunta { get; set; } 
        public required OpcaoEntity Opcao { get; set; } 
    }
}
