﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using loanprocessapi.Contexts;

#nullable disable

namespace loanprocessapi.Migrations
{
    [DbContext(typeof(SoftwareRequestContext))]
    [Migration("20220706093624_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("loanprocessapi.Models.SoftwareRequest", b =>
                {
                    b.Property<long?>("SoftwareId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long?>("SoftwareCost")
                        .IsRequired()
                        .HasColumnType("bigint");

                    b.Property<string>("SoftwareName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("SoftwareVersion")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("SoftwareId");

                    b.ToTable("swrequests");
                });
#pragma warning restore 612, 618
        }
    }
}
