using Semeando.Application.Dtos;
using Semeando.Application.Interfaces;
using Semeando.Domain.Interfaces;
using System.Collections.Generic;

namespace Semeando.Application.Services
{
    public class LevelApplicationService : ILevelApplicationService
    {
        private readonly ILevelRepository _levelRepository;

        public LevelApplicationService(ILevelRepository levelRepository)
        {
            _levelRepository = levelRepository;
        }

        public void CreateLevel(LevelDto levelDto)
        {
            _levelRepository.Create(levelDto);
        }

        public void DeleteLevel(int id)
        {
            _levelRepository.Delete(id);
        }

        public IEnumerable<LevelDto> GetAllLevels()
        {
            return (IEnumerable<LevelDto>)_levelRepository.GetAll();
        }

        public LevelDto GetLevelById(int id)
        {
            return _levelRepository.GetById(id);
        }

        public void UpdateLevel(LevelDto levelDto)
        {
            _levelRepository.Update(levelDto);
        }
    }
}
