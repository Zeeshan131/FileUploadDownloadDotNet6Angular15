using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }
    // public DbSet<Conversation> Conversations { get; set; }
    public DbSet<FileData> FileDatas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<FileData>(
            fileData => {
                fileData.HasKey(f => f.FileId);
                fileData.Property(f => f.FileName).HasMaxLength(500);
                fileData.Property(f => f.FilePath).HasMaxLength(500);
                fileData.Property(f => f.FileExtension).HasMaxLength(50);
                fileData.Property(f => f.MimeType).HasMaxLength(100);
            }
        );

        // modelBuilder.Entity<Conversation>(
        //     conversation =>
        //     {
        //         conversation.HasKey(c => c.ConversationId);

        //         conversation.Property(c => c.Message).IsRequired();

        //         conversation
        //             .HasOne<Ticket>()
        //             .WithMany(t => t.Conversations)
        //             .HasForeignKey(c => c.TicketId)
        //             .OnDelete(DeleteBehavior.Cascade);
        //     }
        // );
    }
}