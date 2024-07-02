using GestaoDeEventos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeEventos.Interfaces
{
    public interface IEvento
    {
        void Iniciar();
        void Pausar();
        void Concluir();
        void Cancelar();
    }
}
