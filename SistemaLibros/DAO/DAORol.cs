using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaLibros.Models;

namespace SistemaLibros.DAO
{
    public class DAORol
    {
        public List<Role> getAll()
        {
            List<Role> data = new List<Role>();
            using (SistemalibrosContext context = new SistemalibrosContext())
            {
                data = context.Roles.ToList();
            }
            
            return data;
        }
    }
}
