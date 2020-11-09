namespace EmpleadosMVC2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class categoria : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Empleadoes", "Categoria", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Empleadoes", "Categoria");
        }
    }
}
