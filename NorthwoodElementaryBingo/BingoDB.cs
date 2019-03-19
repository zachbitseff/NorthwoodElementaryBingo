namespace NorthwoodElementaryBingo
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BingoDB : DbContext
    {
        public BingoDB()
            : base("name=BingoDB1")
        {
        }

        public virtual DbSet<Number> Numbers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Number>()
                .Property(e => e.SortColumn)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
