﻿// <auto-generated />
using System;
using Gnexx.Repository.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Gnexx.Repository.Migrations
{
    [DbContext(typeof(GnexxDbContext))]
    [Migration("20231110030652_PrimeraMig")]
    partial class PrimeraMig
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Gnexx.Data.Entities.Coach", b =>
                {
                    b.Property<int>("CoachId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CoachId"));

                    b.Property<string>("Achievements")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C_Contact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("C_Datebirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("C_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C_Specialization")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EsportExp")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeamID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("CoachId");

                    b.HasIndex("TeamID")
                        .IsUnique();

                    b.HasIndex("UserID")
                        .IsUnique();

                    b.ToTable("Coaches");
                });

            modelBuilder.Entity("Gnexx.Data.Entities.Comments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cmt_body")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Cmt_date")
                        .HasColumnType("datetime2");

                    b.Property<int>("CoachID")
                        .HasColumnType("int");

                    b.Property<int>("PlayerID")
                        .HasColumnType("int");

                    b.Property<string>("Reaction")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeamID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CoachID");

                    b.HasIndex("PlayerID");

                    b.HasIndex("TeamID");

                    b.HasIndex("UserID");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Gnexx.Data.Entities.Response", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CoachID")
                        .HasColumnType("int");

                    b.Property<int>("CommentsID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("PlayerID")
                        .HasColumnType("int");

                    b.Property<string>("R_body")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Team")
                        .HasColumnType("int");

                    b.Property<int>("TeamsId")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CoachID");

                    b.HasIndex("CommentsID");

                    b.HasIndex("PlayerID");

                    b.HasIndex("TeamsId");

                    b.HasIndex("UserID");

                    b.ToTable("Responses");
                });

            modelBuilder.Entity("Gnexx.Models.Entities.News", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("News_body")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Pub_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TeamId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.HasIndex("UserID");

                    b.ToTable("News");
                });

            modelBuilder.Entity("Gnexx.Models.Entities.Player", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("P_Contact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("P_Datebirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("P_Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("P_Lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("P_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("P_Nickname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("P_Specialization")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("P_Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeamID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("TeamID");

                    b.HasIndex("UserID")
                        .IsUnique();

                    b.ToTable("Player");
                });

            modelBuilder.Entity("Gnexx.Models.Entities.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CoachID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Create_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeamName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("Gnexx.Models.Entities.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CoachID")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlayerID")
                        .HasColumnType("int");

                    b.Property<string>("Profile_img")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeamID")
                        .HasColumnType("int");

                    b.Property<string>("Type_user")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("TeamID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Gnexx.Data.Entities.Coach", b =>
                {
                    b.HasOne("Gnexx.Models.Entities.Team", "Teams")
                        .WithOne("Coach")
                        .HasForeignKey("Gnexx.Data.Entities.Coach", "TeamID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Gnexx.Models.Entities.Users", "Users")
                        .WithOne("Coaches")
                        .HasForeignKey("Gnexx.Data.Entities.Coach", "UserID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Teams");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Gnexx.Data.Entities.Comments", b =>
                {
                    b.HasOne("Gnexx.Data.Entities.Coach", "Coaches")
                        .WithMany()
                        .HasForeignKey("CoachID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gnexx.Models.Entities.Player", "Players")
                        .WithMany()
                        .HasForeignKey("PlayerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gnexx.Models.Entities.Team", "Teams")
                        .WithMany("Comments")
                        .HasForeignKey("TeamID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gnexx.Models.Entities.Users", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Coaches");

                    b.Navigation("Players");

                    b.Navigation("Teams");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Gnexx.Data.Entities.Response", b =>
                {
                    b.HasOne("Gnexx.Data.Entities.Coach", "Coaches")
                        .WithMany()
                        .HasForeignKey("CoachID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gnexx.Data.Entities.Comments", "Comments")
                        .WithMany("Responses")
                        .HasForeignKey("CommentsID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Gnexx.Models.Entities.Player", "Players")
                        .WithMany()
                        .HasForeignKey("PlayerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gnexx.Models.Entities.Team", "Teams")
                        .WithMany("Responses")
                        .HasForeignKey("TeamsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gnexx.Models.Entities.Users", "Users")
                        .WithMany("Responses")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Coaches");

                    b.Navigation("Comments");

                    b.Navigation("Players");

                    b.Navigation("Teams");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Gnexx.Models.Entities.News", b =>
                {
                    b.HasOne("Gnexx.Models.Entities.Team", null)
                        .WithMany("News")
                        .HasForeignKey("TeamId");

                    b.HasOne("Gnexx.Models.Entities.Users", "Users")
                        .WithMany("News")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Gnexx.Models.Entities.Player", b =>
                {
                    b.HasOne("Gnexx.Models.Entities.Team", "Teams")
                        .WithMany("Players")
                        .HasForeignKey("TeamID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Gnexx.Models.Entities.Users", "Users")
                        .WithOne("Players")
                        .HasForeignKey("Gnexx.Models.Entities.Player", "UserID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Teams");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Gnexx.Models.Entities.Users", b =>
                {
                    b.HasOne("Gnexx.Models.Entities.Team", "Teams")
                        .WithMany()
                        .HasForeignKey("TeamID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Teams");
                });

            modelBuilder.Entity("Gnexx.Data.Entities.Comments", b =>
                {
                    b.Navigation("Responses");
                });

            modelBuilder.Entity("Gnexx.Models.Entities.Team", b =>
                {
                    b.Navigation("Coach")
                        .IsRequired();

                    b.Navigation("Comments");

                    b.Navigation("News");

                    b.Navigation("Players");

                    b.Navigation("Responses");
                });

            modelBuilder.Entity("Gnexx.Models.Entities.Users", b =>
                {
                    b.Navigation("Coaches")
                        .IsRequired();

                    b.Navigation("Comments");

                    b.Navigation("News");

                    b.Navigation("Players")
                        .IsRequired();

                    b.Navigation("Responses");
                });
#pragma warning restore 612, 618
        }
    }
}
