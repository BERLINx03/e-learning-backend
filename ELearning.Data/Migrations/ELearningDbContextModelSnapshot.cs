﻿// <auto-generated />
using System;
using ELearning.Data.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ELearning.Data.Migrations
{
    [DbContext(typeof(ELearningDbContext))]
    partial class ELearningDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ELearning.Data.Models.Certificate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CertificateNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CertificateUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EnrollmentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("IssuedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("EnrollmentId")
                        .IsUnique();

                    b.ToTable("Certificates");
                });

            modelBuilder.Entity("ELearning.Data.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Duration")
                        .HasColumnType("real");

                    b.Property<int>("InstructorId")
                        .HasColumnType("int");

                    b.Property<bool>("IsPublished")
                        .HasColumnType("bit");

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Level")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Price")
                        .HasColumnType("bigint");

                    b.PrimitiveCollection<string>("ThisCourseInclude")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.PrimitiveCollection<string>("WhatYouWillLearn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("InstructorId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("ELearning.Data.Models.CourseMessage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("InstructorId")
                        .HasColumnType("int");

                    b.Property<bool>("IsRead")
                        .HasColumnType("bit");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("SentAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("InstructorId");

                    b.ToTable("CourseMessages");
                });

            modelBuilder.Entity("ELearning.Data.Models.Enrollment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CompletedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EnrolledAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("FinalGrade")
                        .HasColumnType("int");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("Enrollments");
                });

            modelBuilder.Entity("ELearning.Data.Models.Lesson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DocumentUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsQuiz")
                        .HasColumnType("bit");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("VideoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Lessons");
                });

            modelBuilder.Entity("ELearning.Data.Models.LessonProgress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CompletedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("EnrollmentId")
                        .HasColumnType("int");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.Property<int>("LessonId")
                        .HasColumnType("int");

                    b.Property<int?>("QuizScore")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EnrollmentId");

                    b.HasIndex("LessonId");

                    b.ToTable("LessonProgress");
                });

            modelBuilder.Entity("ELearning.Data.Models.QuizAnswer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AnswerText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsCorrect")
                        .HasColumnType("bit");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("QuizAnswers");
                });

            modelBuilder.Entity("ELearning.Data.Models.QuizQuestion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("LessonId")
                        .HasColumnType("int");

                    b.Property<int>("Points")
                        .HasColumnType("int");

                    b.Property<string>("QuestionText")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LessonId");

                    b.ToTable("QuizQuestions");
                });

            modelBuilder.Entity("ELearning.Data.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsBanned")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastLogin")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePictureUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("TimeoutUntil")
                        .HasColumnType("datetime2");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ELearning.Data.Models.UserReport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AdminNotes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsReviewed")
                        .HasColumnType("bit");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReportedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("ReportedUserId")
                        .HasColumnType("int");

                    b.Property<int>("ReporterUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ReviewedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ReportedUserId");

                    b.HasIndex("ReporterUserId");

                    b.ToTable("UserReports");
                });

            modelBuilder.Entity("ELearning.Data.Models.Certificate", b =>
                {
                    b.HasOne("ELearning.Data.Models.Enrollment", "Enrollment")
                        .WithOne("Certificate")
                        .HasForeignKey("ELearning.Data.Models.Certificate", "EnrollmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Enrollment");
                });

            modelBuilder.Entity("ELearning.Data.Models.Course", b =>
                {
                    b.HasOne("ELearning.Data.Models.User", "Instructor")
                        .WithMany()
                        .HasForeignKey("InstructorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("ELearning.Data.Models.CourseMessage", b =>
                {
                    b.HasOne("ELearning.Data.Models.Course", "Course")
                        .WithMany("Messages")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ELearning.Data.Models.User", "Instructor")
                        .WithMany()
                        .HasForeignKey("InstructorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("ELearning.Data.Models.Enrollment", b =>
                {
                    b.HasOne("ELearning.Data.Models.Course", "Course")
                        .WithMany("Enrollments")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ELearning.Data.Models.User", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("ELearning.Data.Models.Lesson", b =>
                {
                    b.HasOne("ELearning.Data.Models.Course", "Course")
                        .WithMany("Lessons")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("ELearning.Data.Models.LessonProgress", b =>
                {
                    b.HasOne("ELearning.Data.Models.Enrollment", "Enrollment")
                        .WithMany("Progress")
                        .HasForeignKey("EnrollmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ELearning.Data.Models.Lesson", "Lesson")
                        .WithMany("Progress")
                        .HasForeignKey("LessonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Enrollment");

                    b.Navigation("Lesson");
                });

            modelBuilder.Entity("ELearning.Data.Models.QuizAnswer", b =>
                {
                    b.HasOne("ELearning.Data.Models.QuizQuestion", "Question")
                        .WithMany("Answers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("ELearning.Data.Models.QuizQuestion", b =>
                {
                    b.HasOne("ELearning.Data.Models.Lesson", "Lesson")
                        .WithMany("QuizQuestions")
                        .HasForeignKey("LessonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lesson");
                });

            modelBuilder.Entity("ELearning.Data.Models.UserReport", b =>
                {
                    b.HasOne("ELearning.Data.Models.User", "ReportedUser")
                        .WithMany()
                        .HasForeignKey("ReportedUserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ELearning.Data.Models.User", "ReporterUser")
                        .WithMany()
                        .HasForeignKey("ReporterUserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("ReportedUser");

                    b.Navigation("ReporterUser");
                });

            modelBuilder.Entity("ELearning.Data.Models.Course", b =>
                {
                    b.Navigation("Enrollments");

                    b.Navigation("Lessons");

                    b.Navigation("Messages");
                });

            modelBuilder.Entity("ELearning.Data.Models.Enrollment", b =>
                {
                    b.Navigation("Certificate");

                    b.Navigation("Progress");
                });

            modelBuilder.Entity("ELearning.Data.Models.Lesson", b =>
                {
                    b.Navigation("Progress");

                    b.Navigation("QuizQuestions");
                });

            modelBuilder.Entity("ELearning.Data.Models.QuizQuestion", b =>
                {
                    b.Navigation("Answers");
                });
#pragma warning restore 612, 618
        }
    }
}
