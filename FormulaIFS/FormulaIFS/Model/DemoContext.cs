namespace FormulaIFS.Model
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DemoContext : DbContext
    {
        // Your context has been configured to use a 'DemoContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'FormulaIFS.Model.DemoContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'DemoContext' 
        // connection string in the application configuration file.
        public DemoContext()
            : base("FormulaIFS")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        public DbSet<Campeonato> Campeonato { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Circuito> Circuito { get; set; }
        public DbSet<Equipe> Equipe { get; set; }
        public DbSet<TipoCampeonato> tipoCampeonato { get; set; }
        public DbSet<TipoCircuito> TipoCircuito { get; set; }
        public DbSet<TipoUsuario> TipoUsuario { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<SituacaoEquipe> situacaoEquipe { get; set; }
        public DbSet<Participacao> Participacao { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}