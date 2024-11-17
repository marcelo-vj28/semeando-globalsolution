using Semeando.Application.Dtos;
using Semeando.Domain.Entities;
using System.Collections.Generic;

namespace Semeando.Domain.Interfaces
{
    public interface IPerguntaRepository
    {
        void Create(PerguntaEntity pergunta);
        PerguntaEntity GetById(int id);
        IEnumerable<PerguntaEntity> GetAll();
        IEnumerable<PerguntaEntity> GetByLevelId(int levelId);
        void Update(PerguntaEntity pergunta);
        void Delete(int id);
        void Create(PerguntaDto perguntaDto);
        void Update(PerguntaDto perguntaDto);
    }
}
