using Semeando.Application.Dtos;
using Semeando.Domain.Entities;
using System.Collections.Generic;

namespace Semeando.Domain.Interfaces
{
    public interface ILevelRepository
    {
        void Create(LevelEntity level);
        LevelEntity GetById(int id);
        IEnumerable<LevelEntity> GetAll();
        void Update(LevelEntity level);
        void Delete(int id);
        void Create(LevelDto levelDto);
        void Update(LevelDto levelDto);
    }
}
