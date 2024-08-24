using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IAlunoRepository
    {
        Aluno ObterPorId(Guid id);
        void Adicionar(Aluno aluno);
        void Atualizar(Aluno aluno);
        void Remover(Guid id);
    }
}
