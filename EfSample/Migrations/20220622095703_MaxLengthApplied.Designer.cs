// <auto-generated />
using System;
using EfSample.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EfSample.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220622095703_MaxLengthApplied")]
    partial class MaxLengthApplied
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EfSample.DataModels.Class", b =>
                {
                    b.Property<int>("ClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClassLanguage")
                        .HasColumnType("int");

                    b.Property<string>("ClassName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("MaxClassSize")
                        .HasColumnType("int");

                    b.Property<int?>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("ClassId");

                    b.HasIndex("StudentId");

                    b.ToTable("Class");
                });

            modelBuilder.Entity("EfSample.DataModels.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("StudentName")
                        .HasColumnType("int");

                    b.HasKey("StudentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("EfSample.DataModels.Class", b =>
                {
                    b.HasOne("EfSample.DataModels.Student", null)
                        .WithMany("StudentClasses")
                        .HasForeignKey("StudentId");
                });

            modelBuilder.Entity("EfSample.DataModels.Student", b =>
                {
                    b.Navigation("StudentClasses");
                });
#pragma warning restore 612, 618
        }
    }
}
