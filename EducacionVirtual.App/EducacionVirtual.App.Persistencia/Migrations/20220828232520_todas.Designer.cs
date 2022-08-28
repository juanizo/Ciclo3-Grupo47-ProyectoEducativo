﻿// <auto-generated />
using System;
using EducacionVirtual.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EducacionVirtual.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20220828232520_todas")]
    partial class todas
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("EducacionVirtual.App.Dominio.Grado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Max_Estudiantes")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Grado");
                });

            modelBuilder.Entity("EducacionVirtual.App.Dominio.Materia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Actividad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Calificacion")
                        .HasColumnType("real");

                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("profesorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("profesorId");

                    b.ToTable("Materias");
                });

            modelBuilder.Entity("EducacionVirtual.App.Dominio.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contrasena")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Usuario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("EducacionVirtual.App.Dominio.Estudiante", b =>
                {
                    b.HasBaseType("EducacionVirtual.App.Dominio.Persona");

                    b.Property<int?>("GradoId")
                        .HasColumnType("int");

                    b.Property<int?>("MateriaId")
                        .HasColumnType("int");

                    b.Property<int?>("ProfesorId")
                        .HasColumnType("int");

                    b.HasIndex("GradoId");

                    b.HasIndex("MateriaId");

                    b.HasIndex("ProfesorId");

                    b.HasDiscriminator().HasValue("Estudiante");
                });

            modelBuilder.Entity("EducacionVirtual.App.Dominio.Profesor", b =>
                {
                    b.HasBaseType("EducacionVirtual.App.Dominio.Persona");

                    b.Property<string>("Especializacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GradoId")
                        .HasColumnType("int")
                        .HasColumnName("Profesor_GradoId");

                    b.HasIndex("GradoId");

                    b.HasDiscriminator().HasValue("Profesor");
                });

            modelBuilder.Entity("EducacionVirtual.App.Dominio.Materia", b =>
                {
                    b.HasOne("EducacionVirtual.App.Dominio.Profesor", "profesor")
                        .WithMany()
                        .HasForeignKey("profesorId");

                    b.Navigation("profesor");
                });

            modelBuilder.Entity("EducacionVirtual.App.Dominio.Estudiante", b =>
                {
                    b.HasOne("EducacionVirtual.App.Dominio.Grado", "Grado")
                        .WithMany()
                        .HasForeignKey("GradoId");

                    b.HasOne("EducacionVirtual.App.Dominio.Materia", "Materia")
                        .WithMany()
                        .HasForeignKey("MateriaId");

                    b.HasOne("EducacionVirtual.App.Dominio.Profesor", "Profesor")
                        .WithMany()
                        .HasForeignKey("ProfesorId");

                    b.Navigation("Grado");

                    b.Navigation("Materia");

                    b.Navigation("Profesor");
                });

            modelBuilder.Entity("EducacionVirtual.App.Dominio.Profesor", b =>
                {
                    b.HasOne("EducacionVirtual.App.Dominio.Grado", "Grado")
                        .WithMany()
                        .HasForeignKey("GradoId");

                    b.Navigation("Grado");
                });
#pragma warning restore 612, 618
        }
    }
}
