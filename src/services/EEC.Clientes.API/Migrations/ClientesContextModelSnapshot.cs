﻿// <auto-generated />
using System;
using EEC.Clientes.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EEC.Clientes.API.Migrations
{
    [DbContext(typeof(ClientesContext))]
    partial class ClientesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EEC.Clientes.API.Models.Cliente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Excluido")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("EEC.Clientes.API.Models.Endereco", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Bairro")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Cep")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Cidade")
                        .HasColumnType("varchar(100)");

                    b.Property<Guid>("ClienteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Complemento")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Estado")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Logradouro")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Numero")
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId")
                        .IsUnique();

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("EEC.Clientes.API.Models.Cliente", b =>
                {
                    b.OwnsOne("EEC.Core.DomainObjects.Cpf", "Cpf", b1 =>
                        {
                            b1.Property<Guid>("ClienteId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Numero")
                                .IsRequired()
                                .HasColumnName("Cpf")
                                .HasColumnType("varchar(11)")
                                .HasMaxLength(11);

                            b1.HasKey("ClienteId");

                            b1.ToTable("Clientes");

                            b1.WithOwner()
                                .HasForeignKey("ClienteId");
                        });

                    b.OwnsOne("EEC.Core.DomainObjects.Email", "Email", b1 =>
                        {
                            b1.Property<Guid>("ClienteId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Endereco")
                                .IsRequired()
                                .HasColumnName("Email")
                                .HasColumnType("varchar(254)");

                            b1.HasKey("ClienteId");

                            b1.ToTable("Clientes");

                            b1.WithOwner()
                                .HasForeignKey("ClienteId");
                        });
                });

            modelBuilder.Entity("EEC.Clientes.API.Models.Endereco", b =>
                {
                    b.HasOne("EEC.Clientes.API.Models.Cliente", "Cliente")
                        .WithOne("Endereco")
                        .HasForeignKey("EEC.Clientes.API.Models.Endereco", "ClienteId")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}