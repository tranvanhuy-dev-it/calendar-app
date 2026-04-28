namespace CalendarApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        appointment_id = c.Int(nullable: false, identity: true),
                        user_id = c.Int(nullable: false),
                        title = c.String(nullable: false, maxLength: 255),
                        location = c.String(),
                        date = c.DateTime(nullable: false),
                        start_time = c.DateTime(nullable: false),
                        end_time = c.DateTime(nullable: false),
                        is_group_meeting = c.Boolean(nullable: false),
                        duration_minutes = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.appointment_id)
                .ForeignKey("dbo.Users", t => t.user_id)
                .Index(t => t.user_id);
            
            CreateTable(
                "dbo.Participants",
                c => new
                    {
                        participant_id = c.Int(nullable: false, identity: true),
                        appointment_id = c.Int(nullable: false),
                        user_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.participant_id)
                .ForeignKey("dbo.Appointments", t => t.appointment_id)
                .ForeignKey("dbo.Users", t => t.user_id)
                .Index(t => new { t.appointment_id, t.user_id }, unique: true, name: "IX_Participant_Unique");
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        user_id = c.Int(nullable: false, identity: true),
                        username = c.String(nullable: false, maxLength: 50),
                        email = c.String(nullable: false, maxLength: 100),
                        password = c.String(nullable: false),
                        full_name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.user_id)
                .Index(t => t.username, unique: true, name: "IX_Username")
                .Index(t => t.email, unique: true, name: "IX_Email");
            
            CreateTable(
                "dbo.Reminders",
                c => new
                    {
                        reminder_id = c.Int(nullable: false, identity: true),
                        appointment_id = c.Int(nullable: false),
                        remind_minutes_before = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.reminder_id)
                .ForeignKey("dbo.Appointments", t => t.appointment_id)
                .Index(t => t.appointment_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Appointments", "user_id", "dbo.Users");
            DropForeignKey("dbo.Reminders", "appointment_id", "dbo.Appointments");
            DropForeignKey("dbo.Participants", "user_id", "dbo.Users");
            DropForeignKey("dbo.Participants", "appointment_id", "dbo.Appointments");
            DropIndex("dbo.Reminders", new[] { "appointment_id" });
            DropIndex("dbo.Users", "IX_Email");
            DropIndex("dbo.Users", "IX_Username");
            DropIndex("dbo.Participants", "IX_Participant_Unique");
            DropIndex("dbo.Appointments", new[] { "user_id" });
            DropTable("dbo.Reminders");
            DropTable("dbo.Users");
            DropTable("dbo.Participants");
            DropTable("dbo.Appointments");
        }
    }
}
