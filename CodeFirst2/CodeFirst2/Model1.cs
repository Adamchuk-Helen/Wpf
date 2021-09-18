using System;
using System.Data.Entity;
using System.Linq;

namespace CodeFirst2
{
    public class Model1 : DbContext
    {
     
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Game> Games { get; set; }
        public virtual DbSet<Studio> Studios { get; set; }
        public virtual DbSet<Style> Styles { get; set; }
    }

  
}