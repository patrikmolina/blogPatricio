namespace DbConnectionBlog
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ContextBlog : DbContext
    {
        public ContextBlog()
            : base("name=ContextBlog")
        {
        }

        public virtual DbSet<blog_entrada> blog_entrada { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<blog_entrada>()
                .Property(e => e.titulo)
                .IsUnicode(false);

            modelBuilder.Entity<blog_entrada>()
                .Property(e => e.contenido)
                .IsUnicode(false);

            modelBuilder.Entity<blog_entrada>()
                .Property(e => e.imagen)
                .IsUnicode(false);

            modelBuilder.Entity<blog_entrada>()
                .Property(e => e.categoria)
                .IsUnicode(false);


        }
    }
}
