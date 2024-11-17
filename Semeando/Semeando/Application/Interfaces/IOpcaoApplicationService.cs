using Semeando.Application.Dtos;
using System.Collections.Generic;

namespace Semeando.Application.Interfaces
{
    public interface IOpcaoApplicationService
    {
        OpcaoDto GetOpcaoById(int idPergunta, int idOpcao);
        IEnumerable<OpcaoDto> GetAllOpcoesByPerguntaId(int idPergunta);
        void CreateOpcao(OpcaoDto opcaoDto);
        void UpdateOpcao(OpcaoDto opcaoDto);
        void DeleteOpcao(int idPergunta, int idOpcao);
    }
}
