using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAc4ySDTest
{
    class Context : DbContext
    {
        public Context() : base("Ac4ySD")
        {

        }

        public DbSet<Ac4ySDCommunication> ac4ySDCommunications { get; set; }
        public DbSet<Ac4ySDMessage> ac4ySDMessages { get; set; }
        public DbSet<Ac4ySDParticipant> ac4ySDParticipants { get; set; }
        public DbSet<Ac4ySDSequence> ac4ySDSequences { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // configures one-to-many relationship
            modelBuilder.Entity<Ac4ySDCommunication>()
                .HasRequired<Ac4ySDSequence>(s => s.ac4YSDSequence)
                .WithMany(g => g.Communications)
                .HasForeignKey<int>(s => s.Ac4ySDSequenceID);
        }
    }

}
