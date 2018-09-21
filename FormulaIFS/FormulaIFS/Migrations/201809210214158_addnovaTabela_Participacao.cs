namespace FormulaIFS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addnovaTabela_Participacao : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Participacaos",
                c => new
                    {
                        idParticipacao = c.Int(nullable: false, identity: true),
                        descricao = c.String(),
                        Campeonato_idCampeonato = c.Int(),
                        Equipe_idEquipes = c.Int(),
                        Usuario_idUsuario = c.Int(),
                    })
                .PrimaryKey(t => t.idParticipacao)
                .ForeignKey("dbo.Campeonatoes", t => t.Campeonato_idCampeonato)
                .ForeignKey("dbo.Equipes", t => t.Equipe_idEquipes)
                .ForeignKey("dbo.Usuarios", t => t.Usuario_idUsuario)
                .Index(t => t.Campeonato_idCampeonato)
                .Index(t => t.Equipe_idEquipes)
                .Index(t => t.Usuario_idUsuario);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Participacaos", "Usuario_idUsuario", "dbo.Usuarios");
            DropForeignKey("dbo.Participacaos", "Equipe_idEquipes", "dbo.Equipes");
            DropForeignKey("dbo.Participacaos", "Campeonato_idCampeonato", "dbo.Campeonatoes");
            DropIndex("dbo.Participacaos", new[] { "Usuario_idUsuario" });
            DropIndex("dbo.Participacaos", new[] { "Equipe_idEquipes" });
            DropIndex("dbo.Participacaos", new[] { "Campeonato_idCampeonato" });
            DropTable("dbo.Participacaos");
        }
    }
}
