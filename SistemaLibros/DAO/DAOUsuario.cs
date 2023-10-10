using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaLibros.Models;

namespace SistemaLibros.DAO
{
    public class DAOUsuario
    {
        public bool insertInto(Usuario usuario)
        {
            using (SistemalibrosContext context = new SistemalibrosContext())
            {
                context.Usuarios.Add(usuario);
                if (context.SaveChanges() > 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
