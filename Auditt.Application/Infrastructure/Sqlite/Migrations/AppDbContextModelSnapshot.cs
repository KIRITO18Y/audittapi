﻿// <auto-generated />
using System;
using Auditt.Application.Infrastructure.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Auditt.Application.Infrastructure.Sqlite.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.4");

            modelBuilder.Entity("Auditt.Application.Domain.Entities.Assessment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("DataCutId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Eps")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("FunctionaryId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("GuideId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdDataCut")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdFunctionary")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdInstitution")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdPatient")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdUserCreated")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdUserUpdate")
                        .HasColumnType("INTEGER");

                    b.Property<int>("InstitutionId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PatientId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("YearOld")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DataCutId");

                    b.HasIndex("FunctionaryId");

                    b.HasIndex("GuideId");

                    b.HasIndex("InstitutionId");

                    b.HasIndex("PatientId");

                    b.ToTable("Assessments");
                });

            modelBuilder.Entity("Auditt.Application.Domain.Entities.DataCut", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cycle")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FinalDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("InitialDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("InstitutionId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MaxHistory")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("InstitutionId");

                    b.ToTable("DataCuts", (string)null);
                });

            modelBuilder.Entity("Auditt.Application.Domain.Entities.Equivalence", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdScale")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ScaleId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ScaleId");

                    b.ToTable("Equivalences");
                });

            modelBuilder.Entity("Auditt.Application.Domain.Entities.Functionary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Identification")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Functionaries");
                });

            modelBuilder.Entity("Auditt.Application.Domain.Entities.Guide", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("IdScale")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ScaleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ScaleId");

                    b.ToTable("Guides");
                });

            modelBuilder.Entity("Auditt.Application.Domain.Entities.Institution", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Abbreviation")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nit")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Institutions");
                });

            modelBuilder.Entity("Auditt.Application.Domain.Entities.Log", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("IdInstitution")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdUser")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Operation")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("Auditt.Application.Domain.Entities.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Eps")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Identification")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("Auditt.Application.Domain.Entities.Permission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("Auditt.Application.Domain.Entities.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("GuideId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdGuide")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdUserCreate")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdUserUpdate")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Order")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("GuideId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("Auditt.Application.Domain.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Auditt.Application.Domain.Entities.Scale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Scales");
                });

            modelBuilder.Entity("Auditt.Application.Domain.Entities.Setting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("Auditt.Application.Domain.Entities.SettingUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdSetting")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdUser")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SettingId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("SettingId");

                    b.HasIndex("UserId");

                    b.ToTable("SettingUsers");
                });

            modelBuilder.Entity("Auditt.Application.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("IdAvatar")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdRol")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("InstitutionId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("RoleId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurePharse")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("StatusId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("InstitutionId");

                    b.HasIndex("RoleId");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("Auditt.Application.Domain.Entities.Valuation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AssessmentId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("EquivalenceId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdAssessment")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdEquivalence")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdUserCreated")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdUserUpdate")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Order")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AssessmentId");

                    b.HasIndex("EquivalenceId");

                    b.ToTable("Valuations");
                });

            modelBuilder.Entity("PermissionRole", b =>
                {
                    b.Property<int>("PermissionsId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RolesId")
                        .HasColumnType("INTEGER");

                    b.HasKey("PermissionsId", "RolesId");

                    b.HasIndex("RolesId");

                    b.ToTable("PermissionRole");
                });

            modelBuilder.Entity("Auditt.Application.Domain.Entities.Assessment", b =>
                {
                    b.HasOne("Auditt.Application.Domain.Entities.DataCut", "DataCut")
                        .WithMany()
                        .HasForeignKey("DataCutId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Auditt.Application.Domain.Entities.Functionary", "Functionary")
                        .WithMany()
                        .HasForeignKey("FunctionaryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Auditt.Application.Domain.Entities.Guide", null)
                        .WithMany("Assessments")
                        .HasForeignKey("GuideId");

                    b.HasOne("Auditt.Application.Domain.Entities.Institution", "Institution")
                        .WithMany()
                        .HasForeignKey("InstitutionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Auditt.Application.Domain.Entities.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DataCut");

                    b.Navigation("Functionary");

                    b.Navigation("Institution");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Auditt.Application.Domain.Entities.DataCut", b =>
                {
                    b.HasOne("Auditt.Application.Domain.Entities.Institution", "Institution")
                        .WithMany("DataCuts")
                        .HasForeignKey("InstitutionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Institution");
                });

            modelBuilder.Entity("Auditt.Application.Domain.Entities.Equivalence", b =>
                {
                    b.HasOne("Auditt.Application.Domain.Entities.Scale", "Scale")
                        .WithMany("Equivalences")
                        .HasForeignKey("ScaleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Scale");
                });

            modelBuilder.Entity("Auditt.Application.Domain.Entities.Guide", b =>
                {
                    b.HasOne("Auditt.Application.Domain.Entities.Scale", "Scale")
                        .WithMany()
                        .HasForeignKey("ScaleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Scale");
                });

            modelBuilder.Entity("Auditt.Application.Domain.Entities.Log", b =>
                {
                    b.HasOne("Auditt.Application.Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Auditt.Application.Domain.Entities.Question", b =>
                {
                    b.HasOne("Auditt.Application.Domain.Entities.Guide", "Guide")
                        .WithMany("Questions")
                        .HasForeignKey("GuideId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Guide");
                });

            modelBuilder.Entity("Auditt.Application.Domain.Entities.SettingUser", b =>
                {
                    b.HasOne("Auditt.Application.Domain.Entities.Setting", "Setting")
                        .WithMany("SettingUsers")
                        .HasForeignKey("SettingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Auditt.Application.Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Setting");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Auditt.Application.Domain.Entities.User", b =>
                {
                    b.HasOne("Auditt.Application.Domain.Entities.Institution", null)
                        .WithMany("Users")
                        .HasForeignKey("InstitutionId");

                    b.HasOne("Auditt.Application.Domain.Entities.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Auditt.Application.Domain.Entities.Valuation", b =>
                {
                    b.HasOne("Auditt.Application.Domain.Entities.Assessment", "Assessment")
                        .WithMany("Valuations")
                        .HasForeignKey("AssessmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Auditt.Application.Domain.Entities.Equivalence", "Equivalence")
                        .WithMany()
                        .HasForeignKey("EquivalenceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Assessment");

                    b.Navigation("Equivalence");
                });

            modelBuilder.Entity("PermissionRole", b =>
                {
                    b.HasOne("Auditt.Application.Domain.Entities.Permission", null)
                        .WithMany()
                        .HasForeignKey("PermissionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Auditt.Application.Domain.Entities.Role", null)
                        .WithMany()
                        .HasForeignKey("RolesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Auditt.Application.Domain.Entities.Assessment", b =>
                {
                    b.Navigation("Valuations");
                });

            modelBuilder.Entity("Auditt.Application.Domain.Entities.Guide", b =>
                {
                    b.Navigation("Assessments");

                    b.Navigation("Questions");
                });

            modelBuilder.Entity("Auditt.Application.Domain.Entities.Institution", b =>
                {
                    b.Navigation("DataCuts");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Auditt.Application.Domain.Entities.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Auditt.Application.Domain.Entities.Scale", b =>
                {
                    b.Navigation("Equivalences");
                });

            modelBuilder.Entity("Auditt.Application.Domain.Entities.Setting", b =>
                {
                    b.Navigation("SettingUsers");
                });
#pragma warning restore 612, 618
        }
    }
}
