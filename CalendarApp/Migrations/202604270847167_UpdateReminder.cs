namespace CalendarApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateReminder : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reminders", "reminder_message", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reminders", "reminder_message");
        }
    }
}
