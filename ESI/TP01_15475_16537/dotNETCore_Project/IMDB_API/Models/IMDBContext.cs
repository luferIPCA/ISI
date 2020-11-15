using Microsoft.EntityFrameworkCore;

namespace IMDB_API.Models
{
    public partial class IMDBContext : DbContext
    {
        public IMDBContext() {}

        public IMDBContext(DbContextOptions<IMDBContext> options) : base(options) {}

        public virtual DbSet<Filme> Filme { get; set; }
        public virtual DbSet<FilmeGenero> FilmeGenero { get; set; }
        public virtual DbSet<Genero> Genero { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-B8TO0CN;Initial Catalog=ISI_IMDB;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Filme>(entity =>
            {
                entity.HasKey(e => e.Tconst);

                entity.Property(e => e.Tconst)
                    .HasColumnName("tconst")
                    .ValueGeneratedNever();

                entity.Property(e => e.EndYear).HasColumnName("endYear");

                entity.Property(e => e.IsAdult).HasColumnName("isAdult");

                entity.Property(e => e.OriginalTitle).HasColumnName("originalTitle");

                entity.Property(e => e.PrimaryTitle).HasColumnName("primaryTitle");

                entity.Property(e => e.RuntimeMinutes).HasColumnName("runtimeMinutes");

                entity.Property(e => e.StartYear).HasColumnName("startYear");

                entity.Property(e => e.TitleType)
                    .IsRequired()
                    .HasColumnName("titleType")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<FilmeGenero>(entity =>
            {
                entity.HasKey(e => new { e.Tconst, e.IdGenero });

                entity.Property(e => e.Tconst).HasColumnName("tconst");

                entity.Property(e => e.IdGenero).HasColumnName("idGenero");

                entity.HasOne(d => d.IdGeneroNavigation)
                    .WithMany(p => p.FilmeGenero)
                    .HasForeignKey(d => d.IdGenero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FilmeGenero_Genero");

                entity.HasOne(d => d.TconstNavigation)
                    .WithMany(p => p.FilmeGenero)
                    .HasForeignKey(d => d.Tconst)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FilmeGenero_Filme");
            });

            modelBuilder.Entity<Genero>(entity =>
            {
                entity.HasKey(e => e.IdGenero);

                entity.Property(e => e.IdGenero).HasColumnName("idGenero");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
