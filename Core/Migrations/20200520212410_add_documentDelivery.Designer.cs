﻿// <auto-generated />
using System;
using Core.AppContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Core.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20200520212410_add_documentDelivery")]
    partial class add_documentDelivery
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Core.Models.Assignment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("05/20/2020 17:24:10");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Assignments");
                });

            modelBuilder.Entity("Core.Models.Classroom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("05/20/2020 17:24:10");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeacherId");

                    b.ToTable("Classrooms");
                });

            modelBuilder.Entity("Core.Models.Delivery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AssignmentId")
                        .HasColumnType("int");

                    b.Property<string>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("05/20/2020 17:24:10");

                    b.Property<int?>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AssignmentId");

                    b.HasIndex("StudentId");

                    b.ToTable("Deliveries");
                });

            modelBuilder.Entity("Core.Models.Document", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AssignmentId")
                        .HasColumnType("int");

                    b.Property<string>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("05/20/2020 17:24:10");

                    b.Property<string>("Format")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AssignmentId");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("Core.Models.DocumentDelivery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("05/20/2020 17:24:10");

                    b.Property<int?>("DeliveryId")
                        .HasColumnType("int");

                    b.Property<string>("Format")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DeliveryId");

                    b.ToTable("documentDeliveries");
                });

            modelBuilder.Entity("Core.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClassroomId")
                        .HasColumnType("int");

                    b.Property<string>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("05/20/2020 17:24:10");

                    b.Property<int?>("TeacherId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClassroomId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("Core.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("05/20/2020 17:24:10");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Core.Models.UserStudent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClassroomId")
                        .HasColumnType("int");

                    b.Property<string>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("05/20/2020 17:24:10");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClassroomId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserStudents");
                });

            modelBuilder.Entity("Core.Models.UserTeacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("05/20/2020 17:24:10");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("UserTeachers");
                });

            modelBuilder.Entity("Core.Models.Classroom", b =>
                {
                    b.HasOne("Core.Models.UserTeacher", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherId");
                });

            modelBuilder.Entity("Core.Models.Delivery", b =>
                {
                    b.HasOne("Core.Models.Assignment", "Assignment")
                        .WithMany("Delivery")
                        .HasForeignKey("AssignmentId");

                    b.HasOne("Core.Models.UserStudent", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId");
                });

            modelBuilder.Entity("Core.Models.Document", b =>
                {
                    b.HasOne("Core.Models.Assignment", "Assignment")
                        .WithMany("Documents")
                        .HasForeignKey("AssignmentId");
                });

            modelBuilder.Entity("Core.Models.DocumentDelivery", b =>
                {
                    b.HasOne("Core.Models.Delivery", "Delivery")
                        .WithMany("Documents")
                        .HasForeignKey("DeliveryId");
                });

            modelBuilder.Entity("Core.Models.Post", b =>
                {
                    b.HasOne("Core.Models.Classroom", "Classroom")
                        .WithMany("Posts")
                        .HasForeignKey("ClassroomId");

                    b.HasOne("Core.Models.UserTeacher", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherId");
                });

            modelBuilder.Entity("Core.Models.UserStudent", b =>
                {
                    b.HasOne("Core.Models.Classroom", null)
                        .WithMany("Students")
                        .HasForeignKey("ClassroomId");

                    b.HasOne("Core.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId");
                });

            modelBuilder.Entity("Core.Models.UserTeacher", b =>
                {
                    b.HasOne("Core.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId");
                });
#pragma warning restore 612, 618
        }
    }
}
