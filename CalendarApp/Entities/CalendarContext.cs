using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;

namespace CalendarApp.Entities
{
    public class CalendarContext : DbContext
    {
        public CalendarContext() : base("name=CalendarAppConnection") { }

        public DbSet<User> Users { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<Reminder> Reminders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // ========== UNIQUE CONSTRAINTS ==========

            // Unique constraint cho username
            modelBuilder.Entity<User>()
                .Property(u => u.username)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnAnnotation("Index", new IndexAnnotation(
                    new IndexAttribute("IX_Username") { IsUnique = true }
                ));

            // Unique constraint cho email
            modelBuilder.Entity<User>()
                .Property(u => u.email)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnAnnotation("Index", new IndexAnnotation(
                    new IndexAttribute("IX_Email") { IsUnique = true }
                ));

            // Composite unique constraint cho Participant (appointment_id + user_id)
            // Đảm bảo một user chỉ tham gia một appointment một lần
            modelBuilder.Entity<Participant>()
                .HasIndex(p => new { p.appointment_id, p.user_id })
                .IsUnique()
                .HasName("IX_Participant_Unique");


            // ========== QUAN HỆ (FOREIGN KEYS) ==========

            // User 1 - n Appointment
            modelBuilder.Entity<Appointment>()
                .HasRequired(a => a.User)                    // Appointment bắt buộc có User
                .WithMany(u => u.Appointments)                // User có nhiều Appointment
                .HasForeignKey(a => a.user_id)               // Khóa ngoại là user_id
                .WillCascadeOnDelete(false);                 // KHÔNG xóa cascade (tránh lỗi)

            // Appointment 1 - n Participant
            modelBuilder.Entity<Participant>()
                .HasRequired(p => p.Appointment)             // Participant bắt buộc có Appointment
                .WithMany(a => a.Participants)               // Appointment có nhiều Participant
                .HasForeignKey(p => p.appointment_id)        // Khóa ngoại là appointment_id
                .WillCascadeOnDelete(false);                 // KHÔNG xóa cascade

            // User 1 - n Participant
            modelBuilder.Entity<Participant>()
                .HasRequired(p => p.User)                    // Participant bắt buộc có User
                .WithMany(u => u.Participants)               // User có nhiều Participant
                .HasForeignKey(p => p.user_id)               // Khóa ngoại là user_id
                .WillCascadeOnDelete(false);                 // KHÔNG xóa cascade

            // Appointment 1 - n Reminder
            modelBuilder.Entity<Reminder>()
                .HasRequired(r => r.Appointment)             // Reminder bắt buộc có Appointment
                .WithMany(a => a.Reminders)                  // Appointment có nhiều Reminder
                .HasForeignKey(r => r.appointment_id)        // Khóa ngoại là appointment_id
                .WillCascadeOnDelete(false);                 // KHÔNG xóa cascade


            // ========== CẤU HÌNH THÊM ==========

            // Đặt tên bảng (tùy chọn - giữ nguyên tên mặc định cũng được)
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Appointment>().ToTable("Appointments");
            modelBuilder.Entity<Participant>().ToTable("Participants");
            modelBuilder.Entity<Reminder>().ToTable("Reminders");

            // Cấu hình cho Appointment: start_time và end_time là bắt buộc
            modelBuilder.Entity<Appointment>()
                .Property(a => a.start_time)
                .IsRequired();

            modelBuilder.Entity<Appointment>()
                .Property(a => a.end_time)
                .IsRequired();

            // Cấu hình cho Reminder: remind_minutes_before mặc định là 15 phút
            modelBuilder.Entity<Reminder>()
                .Property(r => r.remind_minutes_before)
                .IsRequired();

            base.OnModelCreating(modelBuilder);
        }
    }
}