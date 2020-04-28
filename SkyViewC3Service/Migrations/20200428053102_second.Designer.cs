﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RobotStoreContextLib;

namespace SkyViewC3Service.Migrations
{
    [DbContext(typeof(RobotStoreContext))]
    [Migration("20200428053102_second")]
    partial class second
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("RobotStoreEntitiesLib.Box", b =>
                {
                    b.Property<string>("BoxID")
                        .HasColumnType("TEXT");

                    b.Property<string>("BoxTypeName")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsOut")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RackID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Slot")
                        .HasColumnType("INTEGER");

                    b.HasKey("BoxID");

                    b.HasIndex("BoxTypeName");

                    b.HasIndex("RackID");

                    b.ToTable("Box");
                });

            modelBuilder.Entity("RobotStoreEntitiesLib.BoxHistory", b =>
                {
                    b.Property<int>("BoxHistoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AddByUserID")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("AddDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("BoxID")
                        .HasColumnType("TEXT");

                    b.Property<string>("BoxTypeName")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsOut")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RackID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Slot")
                        .HasColumnType("INTEGER");

                    b.HasKey("BoxHistoryID");

                    b.HasIndex("AddByUserID");

                    b.HasIndex("BoxID");

                    b.HasIndex("BoxTypeName");

                    b.HasIndex("RackID");

                    b.ToTable("BoxHistory");
                });

            modelBuilder.Entity("RobotStoreEntitiesLib.BoxType", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("Capacity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Name");

                    b.ToTable("BoxType");
                });

            modelBuilder.Entity("RobotStoreEntitiesLib.Grade", b =>
                {
                    b.Property<string>("GradeID")
                        .HasColumnType("TEXT");

                    b.HasKey("GradeID");

                    b.ToTable("Grade");
                });

            modelBuilder.Entity("RobotStoreEntitiesLib.GradeInitialPermission", b =>
                {
                    b.Property<string>("GradeID")
                        .HasColumnType("TEXT");

                    b.Property<string>("PermissionID")
                        .HasColumnType("TEXT");

                    b.HasKey("GradeID", "PermissionID");

                    b.HasIndex("PermissionID");

                    b.ToTable("GradeInitialPermission");
                });

            modelBuilder.Entity("RobotStoreEntitiesLib.Permission", b =>
                {
                    b.Property<string>("PermissionID")
                        .HasColumnType("TEXT");

                    b.HasKey("PermissionID");

                    b.ToTable("Permission");
                });

            modelBuilder.Entity("RobotStoreEntitiesLib.Rack", b =>
                {
                    b.Property<int>("RackID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("RackTypeName")
                        .HasColumnType("TEXT");

                    b.HasKey("RackID");

                    b.HasIndex("RackTypeName");

                    b.ToTable("Rack");
                });

            modelBuilder.Entity("RobotStoreEntitiesLib.RackType", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("Capacity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Name");

                    b.ToTable("RackType");
                });

            modelBuilder.Entity("RobotStoreEntitiesLib.SpaceOwnerShipHistory", b =>
                {
                    b.Property<int>("SpaceOwnerShipHistoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Action")
                        .HasColumnType("TEXT");

                    b.Property<string>("AddByUserID")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("AddDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("getdate()");

                    b.Property<int>("RackID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Slot")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserID")
                        .HasColumnType("TEXT");

                    b.HasKey("SpaceOwnerShipHistoryID");

                    b.HasIndex("AddByUserID");

                    b.HasIndex("RackID");

                    b.HasIndex("UserID");

                    b.ToTable("SpaceOwnerShipHistory");
                });

            modelBuilder.Entity("RobotStoreEntitiesLib.SpaceOwnership", b =>
                {
                    b.Property<int>("RackID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Slot")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserID")
                        .HasColumnType("TEXT");

                    b.HasKey("RackID", "Slot", "UserID");

                    b.HasIndex("UserID");

                    b.ToTable("SpaceOwnership");
                });

            modelBuilder.Entity("RobotStoreEntitiesLib.User", b =>
                {
                    b.Property<string>("UserID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<string>("GradeID")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDelete")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("UserID");

                    b.HasIndex("GradeID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("RobotStoreEntitiesLib.UserAction", b =>
                {
                    b.Property<int>("UserActionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Message")
                        .HasColumnType("TEXT");

                    b.Property<string>("Section")
                        .HasColumnType("TEXT");

                    b.Property<string>("Subsection")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserID")
                        .HasColumnType("TEXT");

                    b.HasKey("UserActionID");

                    b.HasIndex("UserID");

                    b.ToTable("UserAction");
                });

            modelBuilder.Entity("RobotStoreEntitiesLib.UserHistory", b =>
                {
                    b.Property<int>("UserHistoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AddByUserID")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("AddDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("GradeID")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserID")
                        .HasColumnType("TEXT");

                    b.HasKey("UserHistoryID");

                    b.HasIndex("AddByUserID");

                    b.HasIndex("GradeID");

                    b.HasIndex("UserID");

                    b.ToTable("UserHistory");
                });

            modelBuilder.Entity("RobotStoreEntitiesLib.UserPermission", b =>
                {
                    b.Property<string>("UserID")
                        .HasColumnType("TEXT");

                    b.Property<string>("PermissionID")
                        .HasColumnType("TEXT");

                    b.HasKey("UserID", "PermissionID");

                    b.HasIndex("PermissionID");

                    b.ToTable("UserPermission");
                });

            modelBuilder.Entity("RobotStoreEntitiesLib.UserPermissionHistory", b =>
                {
                    b.Property<int>("UserPermissionHistoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Action")
                        .HasColumnType("TEXT")
                        .HasMaxLength(10);

                    b.Property<string>("AddByUserID")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("AddDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("PermissionID")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserID")
                        .HasColumnType("TEXT");

                    b.HasKey("UserPermissionHistoryID");

                    b.HasIndex("AddByUserID");

                    b.HasIndex("PermissionID");

                    b.HasIndex("UserID");

                    b.ToTable("UserPermissionHistory");
                });

            modelBuilder.Entity("RobotStoreEntitiesLib.Vial", b =>
                {
                    b.Property<string>("VialID")
                        .HasColumnType("TEXT");

                    b.Property<string>("BoxID")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsOut")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Position")
                        .HasColumnType("INTEGER");

                    b.Property<string>("VialTypeName")
                        .HasColumnType("TEXT");

                    b.HasKey("VialID");

                    b.HasIndex("BoxID");

                    b.HasIndex("VialTypeName");

                    b.ToTable("Vial");
                });

            modelBuilder.Entity("RobotStoreEntitiesLib.VialHistory", b =>
                {
                    b.Property<int>("VialHistoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AddByUserID")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("AddDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("BoxID")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsOut")
                        .HasColumnType("INTEGER");

                    b.Property<string>("VialID")
                        .HasColumnType("TEXT");

                    b.Property<string>("VialTypeName")
                        .HasColumnType("TEXT");

                    b.Property<int>("posisiton")
                        .HasColumnType("INTEGER");

                    b.HasKey("VialHistoryID");

                    b.HasIndex("AddByUserID");

                    b.HasIndex("BoxID");

                    b.HasIndex("VialID");

                    b.HasIndex("VialTypeName");

                    b.ToTable("VialHistory");
                });

            modelBuilder.Entity("RobotStoreEntitiesLib.VialType", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Name");

                    b.ToTable("VialType");
                });

            modelBuilder.Entity("RobotStoreEntitiesLib.Box", b =>
                {
                    b.HasOne("RobotStoreEntitiesLib.BoxType", "BoxType")
                        .WithMany()
                        .HasForeignKey("BoxTypeName");

                    b.HasOne("RobotStoreEntitiesLib.Rack", "Rack")
                        .WithMany("Boxes")
                        .HasForeignKey("RackID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RobotStoreEntitiesLib.BoxHistory", b =>
                {
                    b.HasOne("RobotStoreEntitiesLib.User", "AddBy")
                        .WithMany()
                        .HasForeignKey("AddByUserID");

                    b.HasOne("RobotStoreEntitiesLib.Box", "Box")
                        .WithMany()
                        .HasForeignKey("BoxID");

                    b.HasOne("RobotStoreEntitiesLib.BoxType", "BoxType")
                        .WithMany()
                        .HasForeignKey("BoxTypeName");

                    b.HasOne("RobotStoreEntitiesLib.Rack", "Rack")
                        .WithMany()
                        .HasForeignKey("RackID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RobotStoreEntitiesLib.GradeInitialPermission", b =>
                {
                    b.HasOne("RobotStoreEntitiesLib.Grade", "Grade")
                        .WithMany("Permissions")
                        .HasForeignKey("GradeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RobotStoreEntitiesLib.Permission", "Permission")
                        .WithMany()
                        .HasForeignKey("PermissionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RobotStoreEntitiesLib.Rack", b =>
                {
                    b.HasOne("RobotStoreEntitiesLib.RackType", "RackType")
                        .WithMany()
                        .HasForeignKey("RackTypeName");
                });

            modelBuilder.Entity("RobotStoreEntitiesLib.SpaceOwnerShipHistory", b =>
                {
                    b.HasOne("RobotStoreEntitiesLib.User", "AddBy")
                        .WithMany()
                        .HasForeignKey("AddByUserID");

                    b.HasOne("RobotStoreEntitiesLib.Rack", "Rack")
                        .WithMany()
                        .HasForeignKey("RackID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RobotStoreEntitiesLib.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID");
                });

            modelBuilder.Entity("RobotStoreEntitiesLib.SpaceOwnership", b =>
                {
                    b.HasOne("RobotStoreEntitiesLib.Rack", "Rack")
                        .WithMany()
                        .HasForeignKey("RackID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RobotStoreEntitiesLib.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RobotStoreEntitiesLib.User", b =>
                {
                    b.HasOne("RobotStoreEntitiesLib.Grade", "Grade")
                        .WithMany("Users")
                        .HasForeignKey("GradeID");
                });

            modelBuilder.Entity("RobotStoreEntitiesLib.UserAction", b =>
                {
                    b.HasOne("RobotStoreEntitiesLib.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID");
                });

            modelBuilder.Entity("RobotStoreEntitiesLib.UserHistory", b =>
                {
                    b.HasOne("RobotStoreEntitiesLib.User", "AddBy")
                        .WithMany()
                        .HasForeignKey("AddByUserID");

                    b.HasOne("RobotStoreEntitiesLib.Grade", "Grade")
                        .WithMany()
                        .HasForeignKey("GradeID");

                    b.HasOne("RobotStoreEntitiesLib.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID");
                });

            modelBuilder.Entity("RobotStoreEntitiesLib.UserPermission", b =>
                {
                    b.HasOne("RobotStoreEntitiesLib.Permission", "Permission")
                        .WithMany()
                        .HasForeignKey("PermissionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RobotStoreEntitiesLib.User", "User")
                        .WithMany("Permissions")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RobotStoreEntitiesLib.UserPermissionHistory", b =>
                {
                    b.HasOne("RobotStoreEntitiesLib.User", "AddBy")
                        .WithMany()
                        .HasForeignKey("AddByUserID");

                    b.HasOne("RobotStoreEntitiesLib.Permission", "Permission")
                        .WithMany()
                        .HasForeignKey("PermissionID");

                    b.HasOne("RobotStoreEntitiesLib.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID");
                });

            modelBuilder.Entity("RobotStoreEntitiesLib.Vial", b =>
                {
                    b.HasOne("RobotStoreEntitiesLib.Box", "Box")
                        .WithMany("Vials")
                        .HasForeignKey("BoxID");

                    b.HasOne("RobotStoreEntitiesLib.VialType", "VialType")
                        .WithMany()
                        .HasForeignKey("VialTypeName");
                });

            modelBuilder.Entity("RobotStoreEntitiesLib.VialHistory", b =>
                {
                    b.HasOne("RobotStoreEntitiesLib.User", "AddBy")
                        .WithMany()
                        .HasForeignKey("AddByUserID");

                    b.HasOne("RobotStoreEntitiesLib.Box", "Box")
                        .WithMany()
                        .HasForeignKey("BoxID");

                    b.HasOne("RobotStoreEntitiesLib.Vial", "Vial")
                        .WithMany()
                        .HasForeignKey("VialID");

                    b.HasOne("RobotStoreEntitiesLib.VialType", "VialType")
                        .WithMany()
                        .HasForeignKey("VialTypeName");
                });
#pragma warning restore 612, 618
        }
    }
}
