﻿// <auto-generated />
using System;
using CallManagementSystem.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CallManagementSystem.Persistance.Migrations
{
    [DbContext(typeof(CallManagamentSystemDbContext))]
    [Migration("20230406062342_mig_3")]
    partial class mig_3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CallManagamentSystem.Domain.Entities.Authority", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("AuthorityName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("GeneratedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Authority");
                });

            modelBuilder.Entity("CallManagamentSystem.Domain.Entities.DeveloperUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AuthorityId")
                        .HasColumnType("integer");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("GeneratedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TelNo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("AuthorityId");

                    b.ToTable("DeveloperUsers");
                });

            modelBuilder.Entity("CallManagamentSystem.Domain.Entities.ManagerUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AuthorityId")
                        .HasColumnType("integer");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("GeneratedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TelNo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("AuthorityId");

                    b.ToTable("ManagerUsers");
                });

            modelBuilder.Entity("CallManagamentSystem.Domain.Entities.Notification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("GeneratedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("NotificationTypeId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("NotificationTypeId");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("CallManagamentSystem.Domain.Entities.NotificationType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("GeneratedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NotificationTypeName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("NotificationTypes");
                });

            modelBuilder.Entity("CallManagamentSystem.Domain.Entities.Priority", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("GeneratedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("PriorityName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Priority");
                });

            modelBuilder.Entity("CallManagamentSystem.Domain.Entities.Request", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("DeveloperUserId")
                        .HasColumnType("integer");

                    b.Property<string>("EndDate")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("GeneratedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("ManagerUserId")
                        .HasColumnType("integer");

                    b.Property<int>("PriorityId")
                        .HasColumnType("integer");

                    b.Property<int>("StatuId")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("DeveloperUserId");

                    b.HasIndex("ManagerUserId");

                    b.HasIndex("PriorityId");

                    b.HasIndex("StatuId");

                    b.ToTable("Requests");
                });

            modelBuilder.Entity("CallManagamentSystem.Domain.Entities.Statu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("GeneratedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("StatuName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Status");
                });

            modelBuilder.Entity("CallManagamentSystem.Domain.Entities.DeveloperUser", b =>
                {
                    b.HasOne("CallManagamentSystem.Domain.Entities.Authority", "Authority")
                        .WithMany("DeveloperUsers")
                        .HasForeignKey("AuthorityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Authority");
                });

            modelBuilder.Entity("CallManagamentSystem.Domain.Entities.ManagerUser", b =>
                {
                    b.HasOne("CallManagamentSystem.Domain.Entities.Authority", "Authority")
                        .WithMany("ManagerUsers")
                        .HasForeignKey("AuthorityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Authority");
                });

            modelBuilder.Entity("CallManagamentSystem.Domain.Entities.Notification", b =>
                {
                    b.HasOne("CallManagamentSystem.Domain.Entities.NotificationType", "NotificationType")
                        .WithMany("Notifications")
                        .HasForeignKey("NotificationTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NotificationType");
                });

            modelBuilder.Entity("CallManagamentSystem.Domain.Entities.Request", b =>
                {
                    b.HasOne("CallManagamentSystem.Domain.Entities.DeveloperUser", "DeveloperUser")
                        .WithMany("Requests")
                        .HasForeignKey("DeveloperUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CallManagamentSystem.Domain.Entities.ManagerUser", "ManagerUser")
                        .WithMany("Requests")
                        .HasForeignKey("ManagerUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CallManagamentSystem.Domain.Entities.Priority", "Priority")
                        .WithMany("Requests")
                        .HasForeignKey("PriorityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CallManagamentSystem.Domain.Entities.Statu", "Statu")
                        .WithMany("Requests")
                        .HasForeignKey("StatuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DeveloperUser");

                    b.Navigation("ManagerUser");

                    b.Navigation("Priority");

                    b.Navigation("Statu");
                });

            modelBuilder.Entity("CallManagamentSystem.Domain.Entities.Authority", b =>
                {
                    b.Navigation("DeveloperUsers");

                    b.Navigation("ManagerUsers");
                });

            modelBuilder.Entity("CallManagamentSystem.Domain.Entities.DeveloperUser", b =>
                {
                    b.Navigation("Requests");
                });

            modelBuilder.Entity("CallManagamentSystem.Domain.Entities.ManagerUser", b =>
                {
                    b.Navigation("Requests");
                });

            modelBuilder.Entity("CallManagamentSystem.Domain.Entities.NotificationType", b =>
                {
                    b.Navigation("Notifications");
                });

            modelBuilder.Entity("CallManagamentSystem.Domain.Entities.Priority", b =>
                {
                    b.Navigation("Requests");
                });

            modelBuilder.Entity("CallManagamentSystem.Domain.Entities.Statu", b =>
                {
                    b.Navigation("Requests");
                });
#pragma warning restore 612, 618
        }
    }
}
