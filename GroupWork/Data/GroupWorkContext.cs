using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GroupWork.Models;

namespace GroupWork.Data
{
    public class GroupWorkContext : DbContext
    {
        public GroupWorkContext (DbContextOptions<GroupWorkContext> options)
            : base(options)
        {
        }

        public DbSet<GroupWork.Models.Contacto> Contacto { get; set; } = default!;
    }
}
