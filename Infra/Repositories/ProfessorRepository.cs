using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class ProfessorRepository: IProfessorRepository
    {
        private readonly ApplicationDbContext _context;

        public ProfessorRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Professor ObterPorId(Guid id)
        {
            return _context.Professores.FirstOrDefault(a => a.Id == id);
        }

        public void Adicionar(Professor Professor)
        {
            _context.Professores.Add(Professor);
            _context.SaveChanges();
        }

        public void Atualizar(Professor Professor)
        {
            _context.Professores.Update(Professor);
            _context.SaveChanges();
        }

        public void Remover(Guid id)
        {
            var Professor = _context.Professores.Find(id);
            if (Professor != null)
            {
                _context.Professores.Remove(Professor);
                _context.SaveChanges();
            }
        }
    }
}
