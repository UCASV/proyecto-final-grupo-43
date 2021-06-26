﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace FinalProjectBDPOO.Models
{
    public partial class ProyectoFialContext : DbContext
    {
        public ProyectoFialContext()
        {
        }

        public ProyectoFialContext(DbContextOptions<ProyectoFialContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cabina> Cabinas { get; set; }
        public virtual DbSet<Cabinaxciudadano> Cabinaxciudadanos { get; set; }
        public virtual DbSet<Ciudadano> Ciudadanos { get; set; }
        public virtual DbSet<EfectosSecundario> EfectosSecundarios { get; set; }
        public virtual DbSet<Institucion> Institucions { get; set; }
        public virtual DbSet<Personal> Personals { get; set; }
        public virtual DbSet<ProcesoCitum> ProcesoCita { get; set; }
        public virtual DbSet<ProcesoVacuna> ProcesoVacunas { get; set; }
        public virtual DbSet<Procesocitaxprocesovacuna> Procesocitaxprocesovacunas { get; set; }
        public virtual DbSet<Procesoxefecto> Procesoxefectos { get; set; }
        public virtual DbSet<Registro> Registros { get; set; }
        public virtual DbSet<TipoPersonal> TipoPersonals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost;Database=ProyectoFial;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Cabina>(entity =>
            {
                entity.HasKey(e => e.IdCabina)
                    .HasName("PK__CABINA__FAD33CFDBB523B0E");

                entity.ToTable("CABINA");

                entity.Property(e => e.IdCabina).HasColumnName("id_cabina");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.Identificador).HasColumnName("identificador");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("telefono");

                entity.HasOne(d => d.IdentificadorNavigation)
                    .WithMany(p => p.Cabinas)
                    .HasForeignKey(d => d.Identificador)
                    .HasConstraintName("FK_IDENTIFICADOR_EN_CABINA");
            });

            modelBuilder.Entity<Cabinaxciudadano>(entity =>
            {
                entity.HasKey(e => e.IdCabinaXciudadano)
                    .HasName("PK__CABINAXC__BA17E72387DB009B");

                entity.ToTable("CABINAXCIUDADANO");

                entity.Property(e => e.IdCabinaXciudadano).HasColumnName("id_cabinaXciudadano");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdCabina).HasColumnName("id_cabina");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.Cabinaxciudadanos)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("FK_CABINAXCIUDADANO");

                entity.HasOne(d => d.IdCabinaNavigation)
                    .WithMany(p => p.Cabinaxciudadanos)
                    .HasForeignKey(d => d.IdCabina)
                    .HasConstraintName("FK_CABINXCIUDA");
            });

            modelBuilder.Entity<Ciudadano>(entity =>
            {
                entity.ToTable("CIUDADANO");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CorreoElectronico)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("correo_electronico");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.Dui)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("dui");

                entity.Property(e => e.Edad).HasColumnName("edad");

                entity.Property(e => e.EnfermedadCronica)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("enfermedad_cronica");

                entity.Property(e => e.IdInstitucion).HasColumnName("id_institucion");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("telefono");

                entity.HasOne(d => d.IdInstitucionNavigation)
                    .WithMany(p => p.Ciudadanos)
                    .HasForeignKey(d => d.IdInstitucion)
                    .HasConstraintName("FK_INSTITUCION_CIUDADANO");
            });

            modelBuilder.Entity<EfectosSecundario>(entity =>
            {
                entity.HasKey(e => e.IdEfecto)
                    .HasName("PK__EFECTOS___010E34D393F2AE22");

                entity.ToTable("EFECTOS_SECUNDARIOS");

                entity.Property(e => e.IdEfecto).HasColumnName("id_efecto");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");
            });

            modelBuilder.Entity<Institucion>(entity =>
            {
                entity.HasKey(e => e.IdInstitucion)
                    .HasName("PK__INSTITUC__680718D3EA9240A3");

                entity.ToTable("INSTITUCION");

                entity.Property(e => e.IdInstitucion).HasColumnName("id_institucion");

                entity.Property(e => e.Institucion1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("institucion");
            });

            modelBuilder.Entity<Personal>(entity =>
            {
                entity.HasKey(e => e.Identificador)
                    .HasName("PK__PERSONAL__C83612B15FE6D34D");

                entity.ToTable("PERSONAL");

                entity.Property(e => e.Identificador).HasColumnName("identificador");

                entity.Property(e => e.Contrasena)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("contrasena");

                entity.Property(e => e.CorreoElectronico)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("correo_electronico");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.IdTipo).HasColumnName("id_tipo");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario");

                entity.HasOne(d => d.IdTipoNavigation)
                    .WithMany(p => p.Personals)
                    .HasForeignKey(d => d.IdTipo)
                    .HasConstraintName("FK_TIPO_PERSONAL");
            });

            modelBuilder.Entity<ProcesoCitum>(entity =>
            {
                entity.HasKey(e => e.IdCita)
                    .HasName("PK__PROCESO___6AEC3C09482B3C7D");

                entity.ToTable("PROCESO_CITA");

                entity.Property(e => e.IdCita).HasColumnName("id_cita");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.Hora)
                    .HasColumnType("datetime")
                    .HasColumnName("hora");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Identificador).HasColumnName("identificador");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.ProcesoCita)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("FK_DUI");

                entity.HasOne(d => d.IdentificadorNavigation)
                    .WithMany(p => p.ProcesoCita)
                    .HasForeignKey(d => d.Identificador)
                    .HasConstraintName("FK_IDENTIFICADOR");
            });

            modelBuilder.Entity<ProcesoVacuna>(entity =>
            {
                entity.HasKey(e => e.IdProceso)
                    .HasName("PK__PROCESO___4D1766E48B759D7D");

                entity.ToTable("PROCESO_VACUNA");

                entity.Property(e => e.IdProceso).HasColumnName("id_proceso");

                entity.Property(e => e.HoraInicio)
                    .HasColumnType("datetime")
                    .HasColumnName("hora_inicio");

                entity.Property(e => e.HoraVacunacion)
                    .HasColumnType("datetime")
                    .HasColumnName("hora_vacunacion");

                entity.Property(e => e.Identificador).HasColumnName("identificador");

                entity.HasOne(d => d.IdentificadorNavigation)
                    .WithMany(p => p.ProcesoVacunas)
                    .HasForeignKey(d => d.Identificador)
                    .HasConstraintName("FK_IDENTIFICADOR_PERSONAL");
            });

            modelBuilder.Entity<Procesocitaxprocesovacuna>(entity =>
            {
                entity.HasKey(e => e.IdCitaXvacuna)
                    .HasName("PK__PROCESOC__103FBF49EEDC171B");

                entity.ToTable("PROCESOCITAXPROCESOVACUNA");

                entity.Property(e => e.IdCitaXvacuna).HasColumnName("id_citaXvacuna");

                entity.Property(e => e.IdCita).HasColumnName("id_cita");

                entity.Property(e => e.IdProceso).HasColumnName("id_proceso");

                entity.HasOne(d => d.IdCitaNavigation)
                    .WithMany(p => p.Procesocitaxprocesovacunas)
                    .HasForeignKey(d => d.IdCita)
                    .HasConstraintName("FK_PROCITA");

                entity.HasOne(d => d.IdProcesoNavigation)
                    .WithMany(p => p.Procesocitaxprocesovacunas)
                    .HasForeignKey(d => d.IdProceso)
                    .HasConstraintName("FK_PROVACUNA");
            });

            modelBuilder.Entity<Procesoxefecto>(entity =>
            {
                entity.HasKey(e => e.IdProcesoXefecto)
                    .HasName("PK__PROCESOX__CE5714A02CDD6AC1");

                entity.ToTable("PROCESOXEFECTO");

                entity.Property(e => e.IdProcesoXefecto).HasColumnName("id_procesoXefecto");

                entity.Property(e => e.IdEfecto).HasColumnName("id_efecto");

                entity.Property(e => e.IdProceso).HasColumnName("id_proceso");

                entity.HasOne(d => d.IdEfectoNavigation)
                    .WithMany(p => p.Procesoxefectos)
                    .HasForeignKey(d => d.IdEfecto)
                    .HasConstraintName("FK_PROEFEC");

                entity.HasOne(d => d.IdProcesoNavigation)
                    .WithMany(p => p.Procesoxefectos)
                    .HasForeignKey(d => d.IdProceso)
                    .HasConstraintName("FK_PROEFECTO");
            });

            modelBuilder.Entity<Registro>(entity =>
            {
                entity.ToTable("REGISTRO");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.Hora)
                    .HasColumnType("datetime")
                    .HasColumnName("hora");

                entity.Property(e => e.IdCabina).HasColumnName("id_cabina");

                entity.Property(e => e.Identificador).HasColumnName("identificador");

                entity.HasOne(d => d.IdCabinaNavigation)
                    .WithMany(p => p.Registros)
                    .HasForeignKey(d => d.IdCabina)
                    .HasConstraintName("FK_REGISTROCABINA");

                entity.HasOne(d => d.IdentificadorNavigation)
                    .WithMany(p => p.Registros)
                    .HasForeignKey(d => d.Identificador)
                    .HasConstraintName("FK_REGISTROPERSONAL");
            });

            modelBuilder.Entity<TipoPersonal>(entity =>
            {
                entity.HasKey(e => e.IdTipo)
                    .HasName("PK__TIPO_PER__CF9010892043F1B8");

                entity.ToTable("TIPO_PERSONAL");

                entity.Property(e => e.IdTipo).HasColumnName("id_tipo");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tipo");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
