using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IProfessorRepository
    {
        Professor ObterPorId(Guid id);
        void Adicionar(Professor professor);
        void Atualizar(Professor professor);
        void Remover(Guid id);
    }
}
