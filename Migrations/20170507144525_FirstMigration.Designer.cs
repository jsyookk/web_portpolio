using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MyFirstProj_TreeView.DataContext;

namespace MyFirstProj_TreeView.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20170507144525_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyFirstProj_TreeView.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CategoryName")
                        .IsRequired();

                    b.Property<int>("OrderNum");

                    b.Property<int>("ParentId");

                    b.Property<int>("UserNo");

                    b.HasKey("CategoryID");

                    b.HasIndex("UserNo");

                    b.ToTable("Categorys");
                });

            modelBuilder.Entity("MyFirstProj_TreeView.Models.File", b =>
                {
                    b.Property<int>("FileID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FIleName");

                    b.Property<string>("OrignalFileName");

                    b.Property<DateTime>("RegDate");

                    b.HasKey("FileID");

                    b.ToTable("Files");
                });

            modelBuilder.Entity("MyFirstProj_TreeView.Models.User", b =>
                {
                    b.Property<int>("UserNo")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("RegDate");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.Property<string>("UserName")
                        .IsRequired();

                    b.Property<string>("UserPassword")
                        .IsRequired();

                    b.HasKey("UserNo");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MyFirstProj_TreeView.Models.Category", b =>
                {
                    b.HasOne("MyFirstProj_TreeView.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserNo")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
