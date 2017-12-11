using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Interview.Data;

namespace Interview.Data.Migrations
{
    [DbContext(typeof(InterviewDbContext))]
    [Migration("20170627170957_InitialCreation")]
    partial class InitialCreation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Interview.Entities.Asset", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Assets");
                });

            modelBuilder.Entity("Interview.Entities.AssetFields", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AssetId");

                    b.Property<bool?>("BoolVal");

                    b.Property<double?>("DblVal");

                    b.Property<float?>("FloatVal");

                    b.Property<int?>("IntVal");

                    b.Property<string>("Name");

                    b.Property<string>("StringVal");

                    b.HasKey("Id");

                    b.HasIndex("AssetId");

                    b.ToTable("AssetFields");
                });

            modelBuilder.Entity("Interview.Entities.AssetFields", b =>
                {
                    b.HasOne("Interview.Entities.Asset")
                        .WithMany("Fields")
                        .HasForeignKey("AssetId");
                });
        }
    }
}
