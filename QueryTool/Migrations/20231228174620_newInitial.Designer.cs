﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QueryTool.Data;

#nullable disable

namespace QueryTool.Migrations
{
    [DbContext(typeof(CourseContext))]
    [Migration("20231228174620_newInitial")]
    partial class newInitial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("CourseRecordFacultyRecord", b =>
                {
                    b.Property<string>("CoursesSisId")
                        .HasColumnType("TEXT");

                    b.Property<string>("FacultyNo")
                        .HasColumnType("TEXT");

                    b.HasKey("CoursesSisId", "FacultyNo");

                    b.HasIndex("FacultyNo");

                    b.ToTable("CourseRecordFacultyRecord");
                });

            modelBuilder.Entity("QueryTool.Data.DTOs.CourseRecord", b =>
                {
                    b.Property<string>("SisId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Campus")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("CanvasCode")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CanvasName")
                        .HasColumnType("TEXT");

                    b.Property<string>("CanvasState")
                        .HasColumnType("TEXT");

                    b.Property<int>("Cap")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Catalog")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ClassNo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateOnly>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("Enrolled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Mode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("Semester")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateOnly>("StartDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Term")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("SisId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("QueryTool.Data.DTOs.FacultyRecord", b =>
                {
                    b.Property<string>("FacultyNo")
                        .HasColumnType("TEXT");

                    b.Property<int?>("CanvasCode")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CanvasName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("FacultyNo");

                    b.ToTable("Faculty");
                });

            modelBuilder.Entity("CourseRecordFacultyRecord", b =>
                {
                    b.HasOne("QueryTool.Data.DTOs.CourseRecord", null)
                        .WithMany()
                        .HasForeignKey("CoursesSisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QueryTool.Data.DTOs.FacultyRecord", null)
                        .WithMany()
                        .HasForeignKey("FacultyNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
