﻿// <auto-generated />
using System;
using Encyclopedy;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Encyclopedy.Migrations
{
    [DbContext(typeof(EncyclopedyContext))]
    [Migration("20190624191101_CreateEncyclopedyDB")]
    partial class CreateEncyclopedyDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Encyclopedy1.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content");

                    b.Property<int>("DisciplineId");

                    b.Property<string>("Intro");

                    b.Property<string>("Lasteditor");

                    b.Property<string>("Main");

                    b.Property<string>("Title");

                    b.Property<int?>("UserId");

                    b.Property<int?>("Version");

                    b.HasKey("Id");

                    b.HasIndex("DisciplineId");

                    b.HasIndex("UserId");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("Encyclopedy1.Discipline", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Branch");

                    b.Property<string>("Subbranch");

                    b.HasKey("Id");

                    b.ToTable("Disciplines");
                });

            modelBuilder.Entity("Encyclopedy1.Edit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ArticleId");

                    b.Property<DateTime>("EditDate");

                    b.Property<string>("Editable");

                    b.Property<string>("Oldtext");

                    b.Property<int>("Oldversion");

                    b.Property<string>("UserId");

                    b.Property<int?>("UserId1");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.HasIndex("UserId1");

                    b.ToTable("Edits");
                });

            modelBuilder.Entity("Encyclopedy1.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Editnum");

                    b.Property<string>("Email");

                    b.Property<string>("Login");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<string>("Surname");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Encyclopedy1.Article", b =>
                {
                    b.HasOne("Encyclopedy1.Discipline", "Discipline")
                        .WithMany("Articles")
                        .HasForeignKey("DisciplineId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Encyclopedy1.User", "User")
                        .WithMany("Articles")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Encyclopedy1.Edit", b =>
                {
                    b.HasOne("Encyclopedy1.Article", "Article")
                        .WithMany("Edits")
                        .HasForeignKey("ArticleId");

                    b.HasOne("Encyclopedy1.User", "User")
                        .WithMany("Edits")
                        .HasForeignKey("UserId1");
                });
#pragma warning restore 612, 618
        }
    }
}
