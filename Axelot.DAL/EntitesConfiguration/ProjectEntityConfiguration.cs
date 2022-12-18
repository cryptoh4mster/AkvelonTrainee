using Axelot.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Axelot.DAL.EntitesConfiguration
{
    public class ProjectEntityConfiguration : IEntityTypeConfiguration<ProjectEntity>
    {
        public void Configure(EntityTypeBuilder<ProjectEntity> builder)
        {
            builder.Property(projectEntity => projectEntity.Id)
                .HasColumnType("uuid")
                .ValueGeneratedOnAdd();
            builder.Property(projectEntity => projectEntity.Name)
                .HasColumnType("varchar(50)")
                .IsRequired(true);
            builder.Property(projectEntity => projectEntity.StartDate)
                .HasColumnType("date")
                .IsRequired(true);
            builder.Property(projectEntity => projectEntity.CompletionDate)
                .HasColumnType("date")
                .IsRequired(true);
            builder.Property(projectEntity => projectEntity.Priority)
                .HasColumnType("integer")
                .IsRequired(true);

            builder.HasKey(projectEntity => projectEntity.Id)
                .HasName("PK_Projects");

            builder.ToTable("Projects");
        }
    }
}
