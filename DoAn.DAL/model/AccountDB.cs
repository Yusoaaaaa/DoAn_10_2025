using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DoAn.model
{
    public partial class AccountDB : DbContext
    {
        public AccountDB()
            : base("name=AccountDB")
        {
        }

        public virtual DbSet<ACCOUNT> ACCOUNTs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ACCOUNT>()
                .Property(e => e.MK_TK)
                .IsUnicode(false);

            modelBuilder.Entity<ACCOUNT>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<ACCOUNT>()
                .Property(e => e.SDT)
                .IsUnicode(false);
        }
    }
}
