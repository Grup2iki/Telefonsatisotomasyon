namespace MvcTelefonSatısOtomasyon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class denemekargo11 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.KargoTakips", "Aciklama", c => c.String(maxLength: 100, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.KargoTakips", "Aciklama", c => c.String(maxLength: 10, unicode: false));
        }
    }
}
