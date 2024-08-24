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
    public class CursoRepository: ICursoRepository
    {
        private readonly ApplicationDbContext _context;

        public CursoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Curso ObterPorId(Guid id)
        {
            return _context.Cursos.Include(a => a.Matriculas).FirstOrDefault(a => a.Id == id);
        }

        public void Adicionar(Curso curso)
        {
            _context.Cursos.Add(curso);
            _context.SaveChanges();
        }

        public void Atualizar(Curso curso)
        {
            _context.Cursos.Update(curso);
            _context.SaveChanges();
        }

        public void Remover(Guid id)
        {
            var curso = _context.Cursos.Find(id);
            if (curso != null)
            {
                _context.Cursos.Remove(curso);
                _context.SaveChanges();
            }
        }
    }
}
