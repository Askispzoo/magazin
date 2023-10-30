using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace magazin
{
    public class ModelContext : DbContext
    {
        public ModelContext() : base("name=con") { }

        public DbSet<Pracownik> ListaPracownikow { get; set; }
    }
}
