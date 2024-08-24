using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Professor
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        [JsonIgnore]
        public ICollection<Curso> Cursos { get; private set; }

        public Professor(Guid id, string nome, string email)
        {
            Id = id;
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            Email = email ?? throw new ArgumentNullException(nameof(email));
            Cursos = new List<Curso>();
        }
    }
}
