﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiEFCoreUnableCreateController.Domain.Data;

#nullable disable

namespace WebApiEFCoreUnableCreateController.Domain.Migrations
{
    [DbContext(typeof(ContosoUniversityContext))]
    [Migration("20230822020805_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CourseInstructor", b =>
                {
                    b.Property<int>("CourseId")
                        .HasColumnType("int")
                        .HasColumnName("CourseID");

                    b.Property<int>("InstructorId")
                        .HasColumnType("int")
                        .HasColumnName("InstructorID");

                    b.HasKey("CourseId", "InstructorId")
                        .HasName("PK_dbo.CourseInstructor");

                    b.HasIndex(new[] { "CourseId" }, "IX_CourseID");

                    b.HasIndex(new[] { "InstructorId" }, "IX_InstructorID");

                    b.ToTable("CourseInstructor");
                });

            modelBuilder.Entity("WebApiEFCoreUnableCreateController.Domain.Entities.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CourseID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseId"));

                    b.Property<int>("Credits")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("DepartmentID")
                        .HasDefaultValueSql("((1))");

                    b.Property<string>("Title")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CourseId")
                        .HasName("PK_dbo.Course");

                    b.HasIndex(new[] { "DepartmentId" }, "IX_DepartmentID");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("WebApiEFCoreUnableCreateController.Domain.Entities.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("DepartmentID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentId"));

                    b.Property<decimal>("Budget")
                        .HasColumnType("money");

                    b.Property<int?>("InstructorId")
                        .HasColumnType("int")
                        .HasColumnName("InstructorID");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime");

                    b.HasKey("DepartmentId")
                        .HasName("PK_dbo.Department");

                    b.HasIndex(new[] { "InstructorId" }, "IX_InstructorID");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("WebApiEFCoreUnableCreateController.Domain.Entities.Enrollment", b =>
                {
                    b.Property<int>("EnrollmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("EnrollmentID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EnrollmentId"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int")
                        .HasColumnName("CourseID");

                    b.Property<int?>("Grade")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int")
                        .HasColumnName("StudentID");

                    b.HasKey("EnrollmentId")
                        .HasName("PK_dbo.Enrollment");

                    b.HasIndex(new[] { "CourseId" }, "IX_CourseID");

                    b.HasIndex(new[] { "StudentId" }, "IX_StudentID");

                    b.ToTable("Enrollment");
                });

            modelBuilder.Entity("WebApiEFCoreUnableCreateController.Domain.Entities.OfficeAssignment", b =>
                {
                    b.Property<int>("InstructorId")
                        .HasColumnType("int")
                        .HasColumnName("InstructorID");

                    b.Property<string>("Location")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("InstructorId")
                        .HasName("PK_dbo.OfficeAssignment");

                    b.HasIndex(new[] { "InstructorId" }, "IX_InstructorID");

                    b.ToTable("OfficeAssignment");
                });

            modelBuilder.Entity("WebApiEFCoreUnableCreateController.Domain.Entities.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)")
                        .HasDefaultValueSql("('Instructor')");

                    b.Property<DateTime?>("EnrollmentDate")
                        .HasColumnType("datetime");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("HireDate")
                        .HasColumnType("datetime");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id")
                        .HasName("PK_dbo.Person");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("CourseInstructor", b =>
                {
                    b.HasOne("WebApiEFCoreUnableCreateController.Domain.Entities.Course", null)
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_dbo.CourseInstructor_dbo.Course_CourseID");

                    b.HasOne("WebApiEFCoreUnableCreateController.Domain.Entities.Person", null)
                        .WithMany()
                        .HasForeignKey("InstructorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_dbo.CourseInstructor_dbo.Instructor_InstructorID");
                });

            modelBuilder.Entity("WebApiEFCoreUnableCreateController.Domain.Entities.Course", b =>
                {
                    b.HasOne("WebApiEFCoreUnableCreateController.Domain.Entities.Department", "Department")
                        .WithMany("Course")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_dbo.Course_dbo.Department_DepartmentID");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("WebApiEFCoreUnableCreateController.Domain.Entities.Department", b =>
                {
                    b.HasOne("WebApiEFCoreUnableCreateController.Domain.Entities.Person", "Instructor")
                        .WithMany("Department")
                        .HasForeignKey("InstructorId")
                        .HasConstraintName("FK_dbo.Department_dbo.Instructor_InstructorID");

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("WebApiEFCoreUnableCreateController.Domain.Entities.Enrollment", b =>
                {
                    b.HasOne("WebApiEFCoreUnableCreateController.Domain.Entities.Course", "Course")
                        .WithMany("Enrollment")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_dbo.Enrollment_dbo.Course_CourseID");

                    b.HasOne("WebApiEFCoreUnableCreateController.Domain.Entities.Person", "Student")
                        .WithMany("Enrollment")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_dbo.Enrollment_dbo.Person_StudentID");

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("WebApiEFCoreUnableCreateController.Domain.Entities.OfficeAssignment", b =>
                {
                    b.HasOne("WebApiEFCoreUnableCreateController.Domain.Entities.Person", "Instructor")
                        .WithOne("OfficeAssignment")
                        .HasForeignKey("WebApiEFCoreUnableCreateController.Domain.Entities.OfficeAssignment", "InstructorId")
                        .IsRequired()
                        .HasConstraintName("FK_dbo.OfficeAssignment_dbo.Instructor_InstructorID");

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("WebApiEFCoreUnableCreateController.Domain.Entities.Course", b =>
                {
                    b.Navigation("Enrollment");
                });

            modelBuilder.Entity("WebApiEFCoreUnableCreateController.Domain.Entities.Department", b =>
                {
                    b.Navigation("Course");
                });

            modelBuilder.Entity("WebApiEFCoreUnableCreateController.Domain.Entities.Person", b =>
                {
                    b.Navigation("Department");

                    b.Navigation("Enrollment");

                    b.Navigation("OfficeAssignment");
                });
#pragma warning restore 612, 618
        }
    }
}