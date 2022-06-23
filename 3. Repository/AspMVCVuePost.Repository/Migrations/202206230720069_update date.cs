namespace AspMVCVuePost.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Post", "DateCreated", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Post", "DateCreated");
        }
    }
}
