using System;
using GtMotive.Estimate.Microservice.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

#nullable disable

namespace GtMotive.Estimate.Microservice.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    internal partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GtMotive.Estimate.Microservice.Domain.Entities.car", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uniqueidentifier");

                b.Property<bool>("IsAvaible")
                    .HasColumnType("bit");

                b.Property<string>("Brand")
                    .HasColumnType("nvarchar(max)");

                b.Property<Guid?>("Registration")
                    .HasColumnType("uniqueidentifier");

                b.Property<int>("Year")
                    .HasColumnType("int");

                b.Property<string>("Model")
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("IsDeleted")
                    .HasColumnType("tyint");

                b.Property<DateTime>("CreatedAt")
                    .HasColumnType("timestamp");

                b.Property<DateTime>("UpdatedAt")
                    .HasColumnType("timestamp");

                b.HasKey("Id");
                b.ToTable("Cars");
            });
        }
    }
}
