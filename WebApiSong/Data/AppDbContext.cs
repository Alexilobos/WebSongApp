using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiSong.Models;

namespace WebApiSong.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        // Agregar los modelos a utilizar
        public DbSet<Song> Cancion { get; set; }
    }
}
