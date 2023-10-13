using SistemaLibros.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLibros.DAO
{
    public class DAOLibro
    {
        public List<Libro> getAll()
        {
            List<Libro> data = new List<Libro>();
            using (SistemalibrosContext context = new SistemalibrosContext())
            {
                data = context.Libros.ToList();
            }

            return data;
        }
        public Libro getById(Libro libro)
        {
           
            using (SistemalibrosContext context = new SistemalibrosContext())
            {
                var data = context.Libros.FirstOrDefault(x => x.IdLibro.Equals(libro.IdLibro));
                return data;
            }

            
        }
        public bool insertInto(Libro libro)
        {
            using (SistemalibrosContext context = new SistemalibrosContext())
            {
                context.Libros.Add(libro);
                if (context.SaveChanges() > 0)
                {
                    return true;
                }
            }
            return false;
        }
        public bool updateLibro(Libro libro)
        {
            using (SistemalibrosContext context = new SistemalibrosContext())
            {
                context.Libros.Update(libro);
                if (context.SaveChanges() > 0)
                {
                    return true;
                }
            }
            return false;
        }
        public bool deleteLibro(Libro libro)
        {
            using (SistemalibrosContext context = new SistemalibrosContext())
            {
                context.Libros.Remove(libro);
                if (context.SaveChanges() > 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
