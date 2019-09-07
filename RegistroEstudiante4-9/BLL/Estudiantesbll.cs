using System;
using RegistroEstudiante4_9.DAL;
using RegistroEstudiante4_9.Entidades;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RegistroEstudiante4_9.BLL
{
    public class EstudiantesBll
    {
        public static bool Guardar(Estudiantes estudiante)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.Estudiante.Add(estudiante) != null)
                    paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }
        public static bool Modificar(Estudiantes estudiante)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                
                db.Entry(estudiante).State = EntityState.Modified;
                paso = (db.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }

        public static bool Eliminar(int Id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                var eliminar = db.Estudiante.Find(Id);
                db.Entry(eliminar).State = EntityState.Deleted;
                paso = (db.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static Estudiantes Buscar(int id)
        {
            Contexto db = new Contexto();
            Estudiantes estudiante = new Estudiantes();

            try
            {
                estudiante = db.Estudiante.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return estudiante;
                
        }

        public static List<Estudiantes> GetList(Expression<Func<Estudiantes, bool>> estudiante)
        {
            List<Estudiantes> Lista = new List<Estudiantes>();
            Contexto db = new Contexto();
            try
            {
                Lista = db.Estudiante.Where(estudiante).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return Lista;
        }


    }
}
