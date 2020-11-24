using System.Collections.Generic;

namespace App.api.Modelos
{
    public class Profesor
    {
      public int Id { get; set; }
      public string Nombre { get; set; }
      public int EscuelaId { get; set; }

      public Escuela Escuela { get; set; }
      public ICollection<Curso> Cursos { get; set; }

    }
}
