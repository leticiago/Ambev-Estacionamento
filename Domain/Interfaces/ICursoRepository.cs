using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ICursoRepository
    {
        Curso ObterPorId(Guid id);
        void Adicionar(Curso curso);
        void Atualizar(Curso curso);
        void Remover(Guid id);
    }
}
