﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using University.Models;

namespace University.Migrations
{
    [DbContext(typeof(UniversityContext))]
    partial class UniversityContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("University.Models.Discipline", b =>
                {
                    b.Property<int>("DisciplineID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NameDiscipline");

                    b.Property<int>("NumberOfHoursOfLectures");

                    b.Property<int>("NumberOfHoursOfPractice");

                    b.Property<int>("SpecialtyID");

                    b.Property<int>("TeacherID");

                    b.Property<int>("TypeOfDisciplineID");

                    b.Property<string>("TypeOfRporting");

                    b.HasKey("DisciplineID");

                    b.HasIndex("SpecialtyID");

                    b.HasIndex("TeacherID");

                    b.HasIndex("TypeOfDisciplineID");

                    b.ToTable("Disciplins");
                });

            modelBuilder.Entity("University.Models.Faculty", b =>
                {
                    b.Property<int>("FacultyID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NameFaculty");

                    b.HasKey("FacultyID");

                    b.ToTable("Faculties");
                });

            modelBuilder.Entity("University.Models.Pulpit", b =>
                {
                    b.Property<int>("PulpitID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("FacultyID");

                    b.Property<string>("KindOfChair");

                    b.Property<string>("NamePulpit");

                    b.HasKey("PulpitID");

                    b.HasIndex("FacultyID");

                    b.ToTable("Pulpits");
                });

            modelBuilder.Entity("University.Models.Specialty", b =>
                {
                    b.Property<int>("SpecialtyID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Course");

                    b.Property<string>("NameSpecialty");

                    b.Property<int>("PulpitID");

                    b.Property<int>("Semester");

                    b.HasKey("SpecialtyID");

                    b.HasIndex("PulpitID");

                    b.ToTable("Speciaties");
                });

            modelBuilder.Entity("University.Models.Teacher", b =>
                {
                    b.Property<int>("TeacherID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FullName");

                    b.Property<int>("Phone");

                    b.Property<string>("Position");

                    b.HasKey("TeacherID");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("University.Models.TypeOfDiscipline", b =>
                {
                    b.Property<int>("TypeOfDisciplineID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NameTypeOfDiscipline");

                    b.HasKey("TypeOfDisciplineID");

                    b.ToTable("TypeOfDisciplins");
                });

            modelBuilder.Entity("University.Models.Discipline", b =>
                {
                    b.HasOne("University.Models.Specialty", "Specialty")
                        .WithMany("Disciplins")
                        .HasForeignKey("SpecialtyID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("University.Models.Teacher", "Teachers")
                        .WithMany("Disciplins")
                        .HasForeignKey("TeacherID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("University.Models.TypeOfDiscipline", "TypeOfDiscipline")
                        .WithMany("Disciplins")
                        .HasForeignKey("TypeOfDisciplineID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("University.Models.Pulpit", b =>
                {
                    b.HasOne("University.Models.Faculty", "Faculty")
                        .WithMany("Pulpits")
                        .HasForeignKey("FacultyID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("University.Models.Specialty", b =>
                {
                    b.HasOne("University.Models.Pulpit", "Pulpit")
                        .WithMany("Specialties")
                        .HasForeignKey("PulpitID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}