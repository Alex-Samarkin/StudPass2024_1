using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudPass2024_1
{
    
    public class PersonContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<EContact> EContacts { get; set; }
        public DbSet<AntropData> AntropDatas { get; set; }
        public DbSet<MeasuredData> MeasuredDatas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite("Data Source=stud_pass.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}