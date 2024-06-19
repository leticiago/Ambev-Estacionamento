using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico.Interfaces
{
    public interface INadar
    {
        public int LimiteProfundidade { get;set; }
        void Subir(int metros);
        void Descer(int metros);

    }
}
