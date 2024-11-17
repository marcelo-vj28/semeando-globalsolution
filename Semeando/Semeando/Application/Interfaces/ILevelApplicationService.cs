using Semeando.Application.Dtos;
using System.Collections.Generic;

namespace Semeando.Application.Interfaces
{
    public interface ILevelApplicationService
    {
        LevelDto GetLevelById(int id);
        IEnumerable<LevelDto> GetAllLevels();
        void CreateLevel(LevelDto levelDto);
        void UpdateLevel(LevelDto levelDto);
        void DeleteLevel(int id);
    }
}
