﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _3_Repositories;

#nullable disable

namespace _3_Repositories.Migrations
{
    [DbContext(typeof(SQLDataSource))]
    partial class SQLDataSourceModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("_3_Repositories.Entities.Complaints", b =>
                {
                    b.Property<int>("ComplaintId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ComplaintId"));

                    b.Property<string>("ComplaintStr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RecentUsesId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<int?>("VehicleId")
                        .HasColumnType("int");

                    b.Property<string>("src")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ComplaintId");

                    b.HasIndex("RecentUsesId");

                    b.HasIndex("UserId");

                    b.HasIndex("VehicleId");

                    b.ToTable("Complaints");
                });

            modelBuilder.Entity("_3_Repositories.Entities.Park", b =>
                {
                    b.Property<int>("ParkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ParkId"));

                    b.Property<int>("AdaptationVType")
                        .HasColumnType("int");

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ParkId");

                    b.HasIndex("UserId");

                    b.ToTable("Parks");
                });

            modelBuilder.Entity("_3_Repositories.Entities.PurchasePoints", b =>
                {
                    b.Property<int>("PurchasePointId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PurchasePointId"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("PurchasePointId");

                    b.HasIndex("UserId");

                    b.ToTable("PurchasePoints");
                });

            modelBuilder.Entity("_3_Repositories.Entities.RecentUses", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("EnterDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LeaveDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("RecentUses");
                });

            modelBuilder.Entity("_3_Repositories.Entities.SharedParking", b =>
                {
                    b.Property<int>("SharedParkingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SharedParkingId"));

                    b.Property<int>("Day")
                        .HasColumnType("int");

                    b.Property<int>("EndHour")
                        .HasColumnType("int");

                    b.Property<bool>("IsOccupied")
                        .HasColumnType("bit");

                    b.Property<int?>("ParkId")
                        .HasColumnType("int");

                    b.Property<DateTime>("SharedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("StartHour")
                        .HasColumnType("int");

                    b.HasKey("SharedParkingId");

                    b.HasIndex("ParkId");

                    b.ToTable("SharedParkings");
                });

            modelBuilder.Entity("_3_Repositories.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PassWord")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Scores")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("_3_Repositories.Entities.VehicleDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("LicensePlate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("VType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("VehiclesDetails");
                });

            modelBuilder.Entity("_3_Repositories.Entities.Complaints", b =>
                {
                    b.HasOne("_3_Repositories.Entities.RecentUses", "RecentUses")
                        .WithMany()
                        .HasForeignKey("RecentUsesId");

                    b.HasOne("_3_Repositories.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.HasOne("_3_Repositories.Entities.VehicleDetails", "Vehicle")
                        .WithMany()
                        .HasForeignKey("VehicleId");

                    b.Navigation("RecentUses");

                    b.Navigation("User");

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("_3_Repositories.Entities.Park", b =>
                {
                    b.HasOne("_3_Repositories.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("_3_Repositories.Entities.PurchasePoints", b =>
                {
                    b.HasOne("_3_Repositories.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("_3_Repositories.Entities.RecentUses", b =>
                {
                    b.HasOne("_3_Repositories.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("_3_Repositories.Entities.SharedParking", b =>
                {
                    b.HasOne("_3_Repositories.Entities.Park", "Park")
                        .WithMany()
                        .HasForeignKey("ParkId");

                    b.Navigation("Park");
                });

            modelBuilder.Entity("_3_Repositories.Entities.VehicleDetails", b =>
                {
                    b.HasOne("_3_Repositories.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
