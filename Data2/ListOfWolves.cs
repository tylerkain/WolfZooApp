using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WolfWorld.Models;
namespace WolfWorld.Data2
{
    public class WolfWorldContext : DbContext
    {
        public WolfWorldContext(DbContextOptions<WolfWorldContext> options)
           : base(options)
        {
        }

        public DbSet<ListOfWolves> Wolves { get; set; }

       
    }
}

