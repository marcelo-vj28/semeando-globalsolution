using Semeando.Application.Dtos;
using System.Collections.Generic;

namespace Semeando.Application.Interfaces
{
    public interface IPerguntaApplicationService
    {
        PerguntaDto GetPerguntaById(int id);
        IEnumerable<PerguntaDto> GetAllPerguntas();
        void CreatePergunta(PerguntaDto perguntaDto);
        void UpdatePergunta(PerguntaDto perguntaDto);
        void DeletePergunta(int id);
    }
}
