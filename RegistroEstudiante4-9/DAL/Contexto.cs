using System;
using RegistroEstudiante4_9.Entidades;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroEstudiante4_9.DAL
{
    public class Contexto : DbContext 
    {
        public DbSet<Estudiantes> Estudiante { get; set; }

        public Contexto() : base("ConStr")
        {

        }
    }
}
