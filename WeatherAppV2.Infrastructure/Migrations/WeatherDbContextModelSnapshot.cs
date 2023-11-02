﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WeatherAppV2.Infrastructure.Data;

#nullable disable

namespace WeatherAppV2.Infrastructure.Migrations
{
    [DbContext(typeof(WeatherDbContext))]
    partial class WeatherDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WeatherAppV2.Domain.Entities.EMunicipality.Municipality", b =>
                {
                    b.Property<string>("Codigoine")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Altitud")
                        .HasColumnType("int");

                    b.Property<string>("CodGeo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CodigoineCapital")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Codprov")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DiscrepanteIne")
                        .HasColumnType("int");

                    b.Property<string>("HojaMtn25")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdRel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("LatitudEtrs89Regcan95")
                        .HasColumnType("real");

                    b.Property<float>("LongitudEtrs89Regcan95")
                        .HasColumnType("real");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreCapital")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreProvincia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrigenAltitud")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrigenCoord")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Perimetro")
                        .HasColumnType("int");

                    b.Property<string>("PoblacionCapital")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PoblacionMuni")
                        .HasColumnType("int");

                    b.Property<float>("Superficie")
                        .HasColumnType("real");

                    b.HasKey("Codigoine");

                    b.ToTable("Municipalities");
                });

            modelBuilder.Entity("WeatherAppV2.Domain.Entities.EMunicipality.Popular_Municipalities", b =>
                {
                    b.Property<string>("CODIGOINE")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CODIGOINE");

                    b.ToTable("popular_Municipalities");
                });

            modelBuilder.Entity("WeatherAppV2.Domain.Entities.EProvince.Province", b =>
                {
                    b.Property<string>("Codprov")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CapitalProvincia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Codauton")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ComunidadCiudadAutonoma")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreProvincia")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Codprov");

                    b.ToTable("Provinces");
                });

            modelBuilder.Entity("WeatherAppV2.Domain.Entities.EUser.User", b =>
                {
                    b.Property<int>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUser"));

                    b.Property<string>("Email")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("LasName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Username")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdUser");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("WeatherAppV2.Domain.Entities.EUser.User_Bank_Detail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Card_Number")
                        .HasColumnType("int");

                    b.Property<DateTime>("Expiry_Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdUser");

                    b.ToTable("User_Bank_Details");
                });

            modelBuilder.Entity("WeatherAppV2.Domain.Entities.EUser.User_Municipalities", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CODIGOINE")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CODIGOINE");

                    b.HasIndex("IdUser");

                    b.ToTable("User_Municipalities");
                });

            modelBuilder.Entity("WeatherAppV2.Domain.Entities.EUser.Users_Password", b =>
                {
                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.HasKey("IdUser");

                    b.ToTable("Users_Passwords");
                });

            modelBuilder.Entity("WeatherAppV2.Domain.Entities.EMunicipality.Popular_Municipalities", b =>
                {
                    b.HasOne("WeatherAppV2.Domain.Entities.EMunicipality.Municipality", "municipality")
                        .WithMany()
                        .HasForeignKey("CODIGOINE")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("municipality");
                });

            modelBuilder.Entity("WeatherAppV2.Domain.Entities.EUser.User_Bank_Detail", b =>
                {
                    b.HasOne("WeatherAppV2.Domain.Entities.EUser.User", "User")
                        .WithMany()
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("WeatherAppV2.Domain.Entities.EUser.User_Municipalities", b =>
                {
                    b.HasOne("WeatherAppV2.Domain.Entities.EMunicipality.Municipality", "municipality")
                        .WithMany()
                        .HasForeignKey("CODIGOINE")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WeatherAppV2.Domain.Entities.EUser.User", "user")
                        .WithMany()
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("municipality");

                    b.Navigation("user");
                });

            modelBuilder.Entity("WeatherAppV2.Domain.Entities.EUser.Users_Password", b =>
                {
                    b.HasOne("WeatherAppV2.Domain.Entities.EUser.User", "User")
                        .WithMany()
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
