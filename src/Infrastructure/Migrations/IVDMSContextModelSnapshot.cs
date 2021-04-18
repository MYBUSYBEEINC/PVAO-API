﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PVAO.Infrastructure.Data;

namespace PVAO.Infrastructure.Migrations
{
    [DbContext(typeof(IVDMSContext))]
    partial class IVDMSContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PVAO.ApplicationCore.Entities.Structure.Bank", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("bankAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("bankBranch")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("bankCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("bankName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("zipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("mdm_banks");
                });

            modelBuilder.Entity("PVAO.ApplicationCore.Entities.Structure.Beneficiary", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("currentAddress1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("currentAddress2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("currentAddress3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("currentZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("dateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("dateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("dateOfDeath")
                        .HasColumnType("datetime2");

                    b.Property<string>("emailaddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("extensionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("middleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mortalStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("placeOfBirth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("placeOfDeath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("relationCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sex")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telephone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("vdmsNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("claims_family");
                });

            modelBuilder.Entity("PVAO.ApplicationCore.Entities.Structure.Veteran", b =>
                {
                    b.Property<int>("vdmsno")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("age")
                        .HasColumnType("int");

                    b.Property<string>("causeOfDeath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("currentAddress1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("currentAddress2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("currentAddress3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("currentZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("dateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("dateModified")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("dateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("dateOfDeath")
                        .HasColumnType("datetime2");

                    b.Property<string>("extensionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("firstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("middleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mortalStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nationality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("placeOfBirth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("placeOfDeath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sex")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("vfpOrganization")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("vdmsno");

                    b.ToTable("claims_veteran");
                });
#pragma warning restore 612, 618
        }
    }
}
