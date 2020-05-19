namespace ControlInventario.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateSuppliers : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Suppliers", "SupplierCode", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.Suppliers", "SupplierName", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.Suppliers", "Email", c => c.String(maxLength: 50));
            AlterColumn("dbo.Suppliers", "Phone", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Suppliers", "Phone", c => c.String());
            AlterColumn("dbo.Suppliers", "Email", c => c.String());
            AlterColumn("dbo.Suppliers", "SupplierName", c => c.String());
            AlterColumn("dbo.Suppliers", "SupplierCode", c => c.String());
        }
    }
}
