using Microsoft.EntityFrameworkCore;
using Semeando.Domain.Entities;
using Semeando.Domain.Interfaces;
using Semeando.Infrastructure.Data.AppData;
using System.Collections.Generic;
using System.Linq;

namespace Semeando.Infrastructure.Data.Repositories
{
    public class LevelRepository : ILevelRepository
    {
        private readonly ApplicationContext _context;

        public LevelRepository(ApplicationContext context)
        {
            _context = context;
        }

        public void Create(LevelEntity level)
        {
            _context.Levels.Add(level);
            _context.SaveChanges();
        }

        public LevelEntity GetById(int id)
        {
            return _context.Levels.Find(id);
        }

        public IEnumerable<LevelEntity> GetAll()
        {
            return _context.Levels.ToList();
        }

        public void Update(LevelEntity level)
        {
            _context.Levels.Update(level);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var level = GetById(id);
            if (level != null)
            {
                _context.Levels.Remove(level);
                _context.SaveChanges();
            }
        }
    }
}
