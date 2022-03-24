using Microsoft.EntityFrameworkCore;
using Session_14.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S14.EF.Context
{
    internal class Context : DbContext
    {
        public DbSet<Prop> Props { get; set; }
    }
}
