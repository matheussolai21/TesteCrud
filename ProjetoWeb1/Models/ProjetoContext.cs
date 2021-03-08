namespace ProjetoWeb1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ProjetoContext : DbContext
    {
        public ProjetoContext()
            : base("name=ProjetoContext")
        {
        }

        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Produtos> Produtos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.senha)
                .IsUnicode(false);

            modelBuilder.Entity<Produtos>()
               .Property(e => e.Nome)
               .IsUnicode(false);

            modelBuilder.Entity<Produtos>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<Produtos>()
                .Property(e => e.Valor)
                .HasPrecision(38, 0);
        }
    }
}
