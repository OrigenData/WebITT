using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Tareas.Models
{
    public class TaskDbContext:DbContext
    {
        public TaskDbContext():base("MyConnection")
        {

        }


        public System.Data.Entity.DbSet<Tareas.Models.Genero> Generoes { get; set; }

        public System.Data.Entity.DbSet<Tareas.Models.Movies> Movies { get; set; }
    }
}