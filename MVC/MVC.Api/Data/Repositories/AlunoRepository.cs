using Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Models.Entities;

namespace Data.Repositories
{
    public class AlunoRepository : IAlunoRepository
    {
        private readonly ApplicationDbContext _context;

        public AlunoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Aluno ObterPorId(Guid id)
        {
            return _context.Alunos.Include(a => a.Matriculas).FirstOrDefault(a => a.Id == id);
        }

        public void Adicionar(Aluno aluno)
        {
            _context.Alunos.Add(aluno);
            _context.SaveChanges();
        }

        public void Atualizar(Aluno aluno)
        {
            _context.Alunos.Update(aluno);
            _context.SaveChanges();
        }

        public void Remover(Guid id)
        {
            var aluno = _context.Alunos.Find(id);
            if (aluno != null)
            {
                _context.Alunos.Remove(aluno);
                _context.SaveChanges();
            }
        }
    }
}
