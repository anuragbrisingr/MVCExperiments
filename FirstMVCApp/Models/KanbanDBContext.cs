namespace FirstMVCApp.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class KanbanDBContext : DbContext
    {
        public KanbanDBContext()
            : base("name=KanbanDBContext")
        {
        }

        public virtual DbSet<KanbanCard> KanbanCards { get; set; }
        public virtual DbSet<KanbanColumn> KanbanColumns { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KanbanCard>()
                .HasMany(e => e.KanbanColumns)
                .WithOptional(e => e.KanbanCard)
                .HasForeignKey(e => e.KanbanCardId);

            modelBuilder.Entity<KanbanColumn>()
                .HasMany(e => e.KanbanCards)
                .WithOptional(e => e.KanbanColumn)
                .HasForeignKey(e => e.KanbanColumnId);
        }
    }
}
