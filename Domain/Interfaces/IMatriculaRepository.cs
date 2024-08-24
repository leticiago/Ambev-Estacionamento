using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IMatriculaRepository
    {
        Matricula ObterPorId(Guid id);
        void Adicionar(Matricula matricula);
        void Atualizar(Matricula matricula);
        void Remover(Guid id);
    }
}
