using Models.Entities;

namespace Data.Repositories.Interfaces;
    public interface ICursoRepository
    {
        Curso ObterPorId(Guid id);
        void Adicionar(Curso curso);
        void Atualizar(Curso curso);
        void Remover(Guid id);
    }
