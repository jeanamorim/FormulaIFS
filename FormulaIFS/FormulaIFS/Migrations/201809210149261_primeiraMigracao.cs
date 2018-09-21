namespace FormulaIFS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class primeiraMigracao : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Campeonatoes",
                c => new
                    {
                        idCampeonato = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false),
                        descricao = c.String(nullable: false),
                        qtdVencedor = c.Int(nullable: false),
                        dataInicio = c.DateTime(nullable: false),
                        dataFim = c.DateTime(nullable: false),
                        visibilidade = c.String(nullable: false),
                        Categoria_idCategoria = c.Int(),
                        TipoCampeonato_idTipoCampeonato = c.Int(),
                    })
                .PrimaryKey(t => t.idCampeonato)
                .ForeignKey("dbo.Categorias", t => t.Categoria_idCategoria)
                .ForeignKey("dbo.TipoCampeonatoes", t => t.TipoCampeonato_idTipoCampeonato)
                .Index(t => t.Categoria_idCategoria)
                .Index(t => t.TipoCampeonato_idTipoCampeonato);
            
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        idCategoria = c.Int(nullable: false, identity: true),
                        nomeCategoria = c.String(nullable: false),
                        descricaoCategoria = c.String(),
                    })
                .PrimaryKey(t => t.idCategoria);
            
            CreateTable(
                "dbo.Circuitoes",
                c => new
                    {
                        idCircuito = c.Int(nullable: false, identity: true),
                        voltasTreino = c.Int(nullable: false),
                        voltasDisputa = c.Int(nullable: false),
                        imagem = c.String(),
                        tempoMaximo = c.String(nullable: false),
                        complexidade = c.String(nullable: false),
                        tamanho = c.String(nullable: false),
                        tentativasTreino = c.String(nullable: false),
                        tentativasDisputa = c.String(nullable: false),
                        TipoCircuito_idTipoCircuito = c.Int(),
                    })
                .PrimaryKey(t => t.idCircuito)
                .ForeignKey("dbo.TipoCircuitoes", t => t.TipoCircuito_idTipoCircuito)
                .Index(t => t.TipoCircuito_idTipoCircuito);
            
            CreateTable(
                "dbo.TipoCircuitoes",
                c => new
                    {
                        idTipoCircuito = c.Int(nullable: false, identity: true),
                        descricao = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.idTipoCircuito);
            
            CreateTable(
                "dbo.TipoCampeonatoes",
                c => new
                    {
                        idTipoCampeonato = c.Int(nullable: false, identity: true),
                        descricaoCamp = c.String(nullable: false),
                        tipoCampeonato = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.idTipoCampeonato);
            
            CreateTable(
                "dbo.Equipes",
                c => new
                    {
                        idEquipes = c.Int(nullable: false, identity: true),
                        nomeEquipes = c.String(nullable: false),
                        siglaEquipe = c.String(nullable: false),
                        imagem = c.String(),
                        situacao = c.String(nullable: false),
                        Campeonato_idCampeonato = c.Int(),
                        SituacaoEquipe_idSituacaoEquipe = c.Int(),
                    })
                .PrimaryKey(t => t.idEquipes)
                .ForeignKey("dbo.Campeonatoes", t => t.Campeonato_idCampeonato)
                .ForeignKey("dbo.SituacaoEquipes", t => t.SituacaoEquipe_idSituacaoEquipe)
                .Index(t => t.Campeonato_idCampeonato)
                .Index(t => t.SituacaoEquipe_idSituacaoEquipe);
            
            CreateTable(
                "dbo.SituacaoEquipes",
                c => new
                    {
                        idSituacaoEquipe = c.Int(nullable: false, identity: true),
                        descrição = c.String(),
                    })
                .PrimaryKey(t => t.idSituacaoEquipe);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        idUsuario = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false),
                        equipe = c.Int(nullable: false),
                        Campeonato_idCampeonato = c.Int(),
                        TipoUsuario_idTipoUsuario = c.Int(),
                    })
                .PrimaryKey(t => t.idUsuario)
                .ForeignKey("dbo.Campeonatoes", t => t.Campeonato_idCampeonato)
                .ForeignKey("dbo.TipoUsuarios", t => t.TipoUsuario_idTipoUsuario)
                .Index(t => t.Campeonato_idCampeonato)
                .Index(t => t.TipoUsuario_idTipoUsuario);
            
            CreateTable(
                "dbo.TipoUsuarios",
                c => new
                    {
                        idTipoUsuario = c.Int(nullable: false, identity: true),
                        descricaoTipo = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.idTipoUsuario);
            
            CreateTable(
                "dbo.CircuitoCampeonatoes",
                c => new
                    {
                        Circuito_idCircuito = c.Int(nullable: false),
                        Campeonato_idCampeonato = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Circuito_idCircuito, t.Campeonato_idCampeonato })
                .ForeignKey("dbo.Circuitoes", t => t.Circuito_idCircuito, cascadeDelete: true)
                .ForeignKey("dbo.Campeonatoes", t => t.Campeonato_idCampeonato, cascadeDelete: true)
                .Index(t => t.Circuito_idCircuito)
                .Index(t => t.Campeonato_idCampeonato);
            
            CreateTable(
                "dbo.UsuarioEquipes",
                c => new
                    {
                        Usuario_idUsuario = c.Int(nullable: false),
                        Equipe_idEquipes = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Usuario_idUsuario, t.Equipe_idEquipes })
                .ForeignKey("dbo.Usuarios", t => t.Usuario_idUsuario, cascadeDelete: true)
                .ForeignKey("dbo.Equipes", t => t.Equipe_idEquipes, cascadeDelete: true)
                .Index(t => t.Usuario_idUsuario)
                .Index(t => t.Equipe_idEquipes);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuarios", "TipoUsuario_idTipoUsuario", "dbo.TipoUsuarios");
            DropForeignKey("dbo.UsuarioEquipes", "Equipe_idEquipes", "dbo.Equipes");
            DropForeignKey("dbo.UsuarioEquipes", "Usuario_idUsuario", "dbo.Usuarios");
            DropForeignKey("dbo.Usuarios", "Campeonato_idCampeonato", "dbo.Campeonatoes");
            DropForeignKey("dbo.Equipes", "SituacaoEquipe_idSituacaoEquipe", "dbo.SituacaoEquipes");
            DropForeignKey("dbo.Equipes", "Campeonato_idCampeonato", "dbo.Campeonatoes");
            DropForeignKey("dbo.Campeonatoes", "TipoCampeonato_idTipoCampeonato", "dbo.TipoCampeonatoes");
            DropForeignKey("dbo.Circuitoes", "TipoCircuito_idTipoCircuito", "dbo.TipoCircuitoes");
            DropForeignKey("dbo.CircuitoCampeonatoes", "Campeonato_idCampeonato", "dbo.Campeonatoes");
            DropForeignKey("dbo.CircuitoCampeonatoes", "Circuito_idCircuito", "dbo.Circuitoes");
            DropForeignKey("dbo.Campeonatoes", "Categoria_idCategoria", "dbo.Categorias");
            DropIndex("dbo.UsuarioEquipes", new[] { "Equipe_idEquipes" });
            DropIndex("dbo.UsuarioEquipes", new[] { "Usuario_idUsuario" });
            DropIndex("dbo.CircuitoCampeonatoes", new[] { "Campeonato_idCampeonato" });
            DropIndex("dbo.CircuitoCampeonatoes", new[] { "Circuito_idCircuito" });
            DropIndex("dbo.Usuarios", new[] { "TipoUsuario_idTipoUsuario" });
            DropIndex("dbo.Usuarios", new[] { "Campeonato_idCampeonato" });
            DropIndex("dbo.Equipes", new[] { "SituacaoEquipe_idSituacaoEquipe" });
            DropIndex("dbo.Equipes", new[] { "Campeonato_idCampeonato" });
            DropIndex("dbo.Circuitoes", new[] { "TipoCircuito_idTipoCircuito" });
            DropIndex("dbo.Campeonatoes", new[] { "TipoCampeonato_idTipoCampeonato" });
            DropIndex("dbo.Campeonatoes", new[] { "Categoria_idCategoria" });
            DropTable("dbo.UsuarioEquipes");
            DropTable("dbo.CircuitoCampeonatoes");
            DropTable("dbo.TipoUsuarios");
            DropTable("dbo.Usuarios");
            DropTable("dbo.SituacaoEquipes");
            DropTable("dbo.Equipes");
            DropTable("dbo.TipoCampeonatoes");
            DropTable("dbo.TipoCircuitoes");
            DropTable("dbo.Circuitoes");
            DropTable("dbo.Categorias");
            DropTable("dbo.Campeonatoes");
        }
    }
}
