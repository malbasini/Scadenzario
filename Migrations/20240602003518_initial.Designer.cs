﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Scadenzario.Areas.Identity.Data;

#nullable disable

namespace Scadenzario.Migrations
{
    [DbContext(typeof(ScadenzarioIdentityDbContext))]
    [Migration("20240602003518_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("utf8_general_ci")
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Scadenzario.Models.Entities.Beneficiario", b =>
                {
                    b.Property<int>("IdBeneficiario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdBeneficiario"));

                    b.Property<string>("Denominazione")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar")
                        .HasColumnName("Beneficiario");

                    b.Property<string>("Descrizione")
                        .IsRequired()
                        .HasColumnType("nvarchar(3000)")
                        .HasColumnName("Descrizione");

                    b.Property<string>("Email")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar")
                        .HasColumnName("Email");

                    b.Property<string>("IdUser")
                        .IsRequired()
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar")
                        .HasColumnName("IdUser");

                    b.Property<string>("SitoWeb")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar")
                        .HasColumnName("SitoWeb");

                    b.Property<string>("Telefono")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar")
                        .HasColumnName("Telefono");

                    b.HasKey("IdBeneficiario");

                    b.HasIndex("IdUser");

                    b.ToTable("Beneficiari", (string)null);
                });

            modelBuilder.Entity("Scadenzario.Models.Entities.Ricevuta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Beneficiario")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar")
                        .HasColumnName("Beneficiario");

                    b.Property<byte[]>("FileContent")
                        .IsRequired()
                        .HasColumnType("image")
                        .HasColumnName("FileContent");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar")
                        .HasColumnName("FileName");

                    b.Property<string>("FileType")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar")
                        .HasColumnName("FileType");

                    b.Property<int>("IdScadenza")
                        .HasColumnType("int");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar")
                        .HasColumnName("Path");

                    b.HasKey("Id");

                    b.HasIndex("IdScadenza");

                    b.ToTable("Ricevute", (string)null);
                });

            modelBuilder.Entity("Scadenzario.Models.Entities.Scadenza", b =>
                {
                    b.Property<int>("IDScadenza")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataPagamento")
                        .HasColumnType("datetime")
                        .HasColumnName("DataPagamento");

                    b.Property<DateTime>("DataScadenza")
                        .HasColumnType("datetime")
                        .HasColumnName("DataScadenza");

                    b.Property<string>("Denominazione")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Beneficiario");

                    b.Property<short?>("GiorniRitardo")
                        .HasColumnType("smallint")
                        .HasColumnName("GiorniRitardo");

                    b.Property<int>("IDBeneficiario")
                        .HasColumnType("int");

                    b.Property<string>("IDUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Importo")
                        .HasColumnType("decimal(10,2)");

                    b.Property<bool>("Sollecito")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false)
                        .HasColumnName("Sollecito");

                    b.HasKey("IDScadenza");

                    b.ToTable("Scadenze", (string)null);
                });

            modelBuilder.Entity("Scadenzario.Models.Entity.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Scadenzario.Models.Entity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Scadenzario.Models.Entity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Scadenzario.Models.Entity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Scadenzario.Models.Entity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Scadenzario.Models.Entities.Beneficiario", b =>
                {
                    b.HasOne("Scadenzario.Models.Entity.ApplicationUser", "ApplicationUser")
                        .WithMany("Beneficiario")
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUser");
                });

            modelBuilder.Entity("Scadenzario.Models.Entities.Ricevuta", b =>
                {
                    b.HasOne("Scadenzario.Models.Entities.Scadenza", "Scadenza")
                        .WithMany("Ricevute")
                        .HasForeignKey("IdScadenza")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Scadenze_Ricevute");

                    b.Navigation("Scadenza");
                });

            modelBuilder.Entity("Scadenzario.Models.Entities.Scadenza", b =>
                {
                    b.HasOne("Scadenzario.Models.Entities.Beneficiario", "Beneficiario")
                        .WithMany("Scadenze")
                        .HasForeignKey("IDScadenza")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Scadenze_Beneficiario");

                    b.Navigation("Beneficiario");
                });

            modelBuilder.Entity("Scadenzario.Models.Entities.Beneficiario", b =>
                {
                    b.Navigation("Scadenze");
                });

            modelBuilder.Entity("Scadenzario.Models.Entities.Scadenza", b =>
                {
                    b.Navigation("Ricevute");
                });

            modelBuilder.Entity("Scadenzario.Models.Entity.ApplicationUser", b =>
                {
                    b.Navigation("Beneficiario");
                });
#pragma warning restore 612, 618
        }
    }
}
