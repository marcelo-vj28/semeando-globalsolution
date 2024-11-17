using Semeando.Application.Dtos;
using Semeando.Domain.Entities;
using System.Collections.Generic;

namespace Semeando.Domain.Interfaces
{
    public interface IOpcaoRepository
    {
        void Create(OpcaoEntity opcao);
        OpcaoEntity GetById(int perguntaId, int idOpcao);
        IEnumerable<OpcaoEntity> GetAllByPerguntaId(int perguntaId);
        void Update(OpcaoEntity opcao);
        void Delete(int perguntaId, int idOpcao);
        void Create(OpcaoDto opcaoDto);
        void Update(OpcaoDto opcaoDto);
    }
}
