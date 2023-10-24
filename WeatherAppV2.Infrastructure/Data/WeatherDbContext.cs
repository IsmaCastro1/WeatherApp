using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WeatherAppV2.Domain;

namespace WeatherAppV2.Infrastructure.Data;

public partial class WeatherDbContext : DbContext
{
    public WeatherDbContext()
    {
    }

    public WeatherDbContext(DbContextOptions<WeatherDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Municipality> Municipalities { get; set; }

    public virtual DbSet<Province> Provinces { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Municipality>(entity =>
        {
            entity.HasKey(e => e.Codigoine);

            entity.Property(e => e.Codigoine).HasColumnName("CODIGOINE");
            entity.Property(e => e.Altitud).HasColumnName("ALTITUD");
            entity.Property(e => e.CodGeo).HasColumnName("COD_GEO");
            entity.Property(e => e.CodigoineCapital).HasColumnName("CODIGOINE_CAPITAL");
            entity.Property(e => e.Codprov).HasColumnName("CODPROV");
            entity.Property(e => e.DiscrepanteIne).HasColumnName("DISCREPANTE_INE");
            entity.Property(e => e.HojaMtn25).HasColumnName("HOJA_MTN25");
            entity.Property(e => e.IdRel).HasColumnName("ID_REL");
            entity.Property(e => e.LatitudEtrs89Regcan95).HasColumnName("LATITUD_ETRS89_REGCAN95");
            entity.Property(e => e.LongitudEtrs89Regcan95).HasColumnName("LONGITUD_ETRS89_REGCAN95");
            entity.Property(e => e.Nombre).HasColumnName("NOMBRE");
            entity.Property(e => e.NombreCapital).HasColumnName("NOMBRE_CAPITAL");
            entity.Property(e => e.NombreProvincia).HasColumnName("NOMBRE_PROVINCIA");
            entity.Property(e => e.OrigenAltitud).HasColumnName("ORIGEN_ALTITUD");
            entity.Property(e => e.OrigenCoord).HasColumnName("ORIGEN_COORD");
            entity.Property(e => e.Perimetro).HasColumnName("PERIMETRO");
            entity.Property(e => e.PoblacionCapital).HasColumnName("POBLACION_CAPITAL");
            entity.Property(e => e.PoblacionMuni).HasColumnName("POBLACION_MUNI");
            entity.Property(e => e.Superficie).HasColumnName("SUPERFICIE");
        });

        modelBuilder.Entity<Province>(entity =>
        {
            entity.HasKey(e => e.Codprov);

            entity.Property(e => e.Codprov).HasColumnName("CODPROV");
            entity.Property(e => e.CapitalProvincia).HasColumnName("CAPITAL_PROVINCIA");
            entity.Property(e => e.Codauton).HasColumnName("CODAUTON");
            entity.Property(e => e.ComunidadCiudadAutonoma).HasColumnName("COMUNIDAD_CIUDAD_AUTONOMA");
            entity.Property(e => e.NombreProvincia).HasColumnName("NOMBRE_PROVINCIA");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
