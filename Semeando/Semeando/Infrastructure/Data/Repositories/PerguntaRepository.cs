using Microsoft.EntityFrameworkCore;
using Semeando.Domain.Entities;
using Semeando.Domain.Interfaces;
using Semeando.Infrastructure.Data.AppData;
using System.Collections.Generic;
using System.Linq;

namespace Semeando.Infrastructure.Data.Repositories
{
    public class PerguntaRepository : IPerguntaRepository
    {
        private readonly ApplicationContext _context;

        public PerguntaRepository(ApplicationContext context)
        {
            _context = context;
        }

        public void Create(PerguntaEntity pergunta)
        {
            _context.Perguntas.Add(pergunta);
            _context.SaveChanges();
        }

        public PerguntaEntity GetById(int id)
        {
            return _context.Perguntas.Include(p => p.Level).FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<PerguntaEntity> GetAll()
        {
            return _context.Perguntas.Include(p => p.Level).ToList();
        }

        public IEnumerable<PerguntaEntity> GetByLevelId(int levelId)
        {
            return _context.Perguntas.Where(p => p.LevelId == levelId).Include(p => p.Level).ToList();
        }

        public void Update(PerguntaEntity pergunta)
        {
            _context.Perguntas.Update(pergunta);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var pergunta = GetById(id);
            if (pergunta != null)
            {
                _context.Perguntas.Remove(pergunta);
                _context.SaveChanges();
            }
        }
    }
}
