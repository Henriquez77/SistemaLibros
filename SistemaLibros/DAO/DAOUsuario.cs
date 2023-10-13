using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
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
        public bool findByNameAndPass(Usuario usuario)
        {
            using (SistemalibrosContext context = new SistemalibrosContext())
            {
                var list = context.Usuarios.FirstOrDefault(x => x.AliasUsuario.Equals(usuario.AliasUsuario) && x.ContraseniaUsuario.Equals(usuario.ContraseniaUsuario));
                if (list != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            } 
        }
    }
}
