using Axelot.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Axelot.DAL.EntitesConfiguration
{
    public class TaskEntityConfiguration : IEntityTypeConfiguration<TaskEntity>
    {
        public void Configure(EntityTypeBuilder<TaskEntity> builder)
        {
            builder.Property(taskEntity => taskEntity.Id)
                .HasColumnType("uuid")
                .ValueGeneratedOnAdd();
            builder.Property(taskEntity => taskEntity.ProjectId)
                .HasColumnType("uuid")
                .IsRequired(true);
            builder.Property(taskEntity => taskEntity.Name)
                .HasColumnType("varchar(50)")
                .IsRequired(true);
            builder.Property(taskEntity => taskEntity.Description)
                .HasColumnType("varchar(100)")
                .IsRequired(true);
            builder.Property(taskEntity => taskEntity.Status)
                .IsRequired(true);
            builder.Property(taskEntity => taskEntity.Priority)
                .HasColumnType("integer")
                .IsRequired(true);

            builder.HasKey(taskEntity => taskEntity.Id)
                .HasName("PK_Tasks");

            builder.HasOne(taskEntity => taskEntity.Project)
                .WithMany(projectEntity => projectEntity.Tasks)
                .HasForeignKey(taskEntity => taskEntity.ProjectId)
                .OnDelete(DeleteBehavior.NoAction)
                .HasConstraintName("FK_Tasks_Projects");

            builder.ToTable("Tasks");
        }
    }
}
