﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project_SWP391.Data;

#nullable disable

namespace Project_SWP391.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20241011161324_EditDB")]
    partial class EditDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
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

                    b.HasData(
                        new
                        {
                            Id = "65c663ca-b543-4db8-9a3b-7c1be05a16a3",
                            Name = "Customer",
                            NormalizedName = "CUSTOMER"
                        },
                        new
                        {
                            Id = "7e190e9d-0715-4a5c-a840-375c7c771caf",
                            Name = "Manager",
                            NormalizedName = "MANAGER"
                        },
                        new
                        {
                            Id = "80058da3-eac9-49e7-b9e1-ca4b6e299170",
                            Name = "SalesStaff",
                            NormalizedName = "SALESSTAFF"
                        },
                        new
                        {
                            Id = "0cbfd504-ba58-4eb6-a600-5b338336a300",
                            Name = "ConsultingStaff",
                            NormalizedName = "CONSULTINGSTAFF"
                        },
                        new
                        {
                            Id = "9ebefaee-8495-429c-ae5d-de6ce873f6cf",
                            Name = "DeliveringStaff",
                            NormalizedName = "DELIVERINGSTAFF"
                        });
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
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

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
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Project_SWP391.Model.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateOfBirth")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
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
                        .IsRequired()
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

            modelBuilder.Entity("Project_SWP391.Model.Bill", b =>
                {
                    b.Property<int>("BillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BillId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int>("QuotationId")
                        .HasColumnType("int");

                    b.Property<string>("UserFullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("BillId");

                    b.HasIndex("QuotationId")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("Project_SWP391.Model.BillDetail", b =>
                {
                    b.Property<int>("BillDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BillDetailId"));

                    b.Property<string>("ArriveDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BillId")
                        .HasColumnType("int");

                    b.Property<string>("BookBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeliveryEstimateDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DepartDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("TotalPrice")
                        .HasColumnType("real");

                    b.Property<string>("TourName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BillDetailId");

                    b.HasIndex("BillId")
                        .IsUnique();

                    b.ToTable("BillDetails");
                });

            modelBuilder.Entity("Project_SWP391.Model.Delivery", b =>
                {
                    b.Property<int>("DeliveryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DeliveryId"));

                    b.Property<string>("DeliveryDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("DeliveryFee")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("DeliveryType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DeliveryId");

                    b.ToTable("Deliveries");
                });

            modelBuilder.Entity("Project_SWP391.Model.DeliveryStatus", b =>
                {
                    b.Property<int>("DeliveryStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DeliveryStatusId"));

                    b.Property<int>("BillId")
                        .HasColumnType("int");

                    b.Property<string>("DeliveryAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DeliveryId")
                        .HasColumnType("int");

                    b.Property<string>("DeliveryStatusText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EstimatedDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DeliveryStatusId");

                    b.HasIndex("BillId")
                        .IsUnique();

                    b.HasIndex("DeliveryId");

                    b.ToTable("DeliveryStatuses");
                });

            modelBuilder.Entity("Project_SWP391.Model.FarmImage", b =>
                {
                    b.Property<int>("FarmImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FarmImageId"));

                    b.Property<int>("FarmId")
                        .HasColumnType("int");

                    b.Property<string>("UrlImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FarmImageId");

                    b.HasIndex("FarmId");

                    b.ToTable("FarmImages");
                });

            modelBuilder.Entity("Project_SWP391.Model.Feedback", b =>
                {
                    b.Property<int>("FeedbackId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FeedbackId"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Rating")
                        .HasColumnType("real");

                    b.Property<string>("UrlImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("FeedbackId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Feedbacks");
                });

            modelBuilder.Entity("Project_SWP391.Model.Koi", b =>
                {
                    b.Property<int>("KoiId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KoiId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FarmId")
                        .HasColumnType("int");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KoiName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Length")
                        .HasColumnType("real");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("UpdateDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YOB")
                        .HasColumnType("int");

                    b.HasKey("KoiId");

                    b.HasIndex("FarmId");

                    b.ToTable("Kois");
                });

            modelBuilder.Entity("Project_SWP391.Model.KoiBill", b =>
                {
                    b.Property<int>("KoiBillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KoiBillId"));

                    b.Property<int>("BillId")
                        .HasColumnType("int");

                    b.Property<float?>("FinalPrice")
                        .HasColumnType("real");

                    b.Property<int>("KoiId")
                        .HasColumnType("int");

                    b.Property<float?>("OriginalPrice")
                        .HasColumnType("real");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("KoiBillId");

                    b.HasIndex("BillId");

                    b.HasIndex("KoiId");

                    b.ToTable("KoiBills");
                });

            modelBuilder.Entity("Project_SWP391.Model.KoiFarm", b =>
                {
                    b.Property<int>("FarmId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FarmId"));

                    b.Property<string>("CloseHour")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FarmName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hotline")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Introduction")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OpenHour")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FarmId");

                    b.ToTable("KoiFarms");
                });

            modelBuilder.Entity("Project_SWP391.Model.KoiImage", b =>
                {
                    b.Property<int>("KoiImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KoiImageId"));

                    b.Property<int>("KoiId")
                        .HasColumnType("int");

                    b.Property<string>("UrlImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KoiImageId");

                    b.HasIndex("KoiId");

                    b.ToTable("KoiImages");
                });

            modelBuilder.Entity("Project_SWP391.Model.KoiVariety", b =>
                {
                    b.Property<int>("VarietyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VarietyId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrlImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VarietyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VarietyId");

                    b.ToTable("KoiVarieties");
                });

            modelBuilder.Entity("Project_SWP391.Model.PayStatus", b =>
                {
                    b.Property<int>("PayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PayId"));

                    b.Property<int>("BillId")
                        .HasColumnType("int");

                    b.Property<float>("Deposit")
                        .HasColumnType("real");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Remain")
                        .HasColumnType("real");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PayId");

                    b.HasIndex("BillId")
                        .IsUnique();

                    b.ToTable("PayStatuses");
                });

            modelBuilder.Entity("Project_SWP391.Model.Quotation", b =>
                {
                    b.Property<int>("QuotationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QuotationId"));

                    b.Property<string>("ApprovedDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("PriceOffer")
                        .HasColumnType("real");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TourId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("QuotationId");

                    b.HasIndex("TourId");

                    b.HasIndex("UserId");

                    b.ToTable("Quotations");
                });

            modelBuilder.Entity("Project_SWP391.Model.Rating", b =>
                {
                    b.Property<int>("FarmId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rate")
                        .HasColumnType("int");

                    b.HasKey("FarmId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("Project_SWP391.Model.Tour", b =>
                {
                    b.Property<int>("TourId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TourId"));

                    b.Property<string>("FinishTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumberOfParticipate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<string>("StartTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TourName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TourId");

                    b.ToTable("Tours");
                });

            modelBuilder.Entity("Project_SWP391.Model.TourDestination", b =>
                {
                    b.Property<int>("FarmId")
                        .HasColumnType("int");

                    b.Property<int>("TourId")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FarmId", "TourId");

                    b.HasIndex("TourId");

                    b.ToTable("TourDestinations");
                });

            modelBuilder.Entity("Project_SWP391.Model.VarietyOfKoi", b =>
                {
                    b.Property<int>("KoiId")
                        .HasColumnType("int");

                    b.Property<int>("VarietyId")
                        .HasColumnType("int");

                    b.HasKey("KoiId", "VarietyId");

                    b.HasIndex("VarietyId");

                    b.ToTable("VarietyOfKois");
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
                    b.HasOne("Project_SWP391.Model.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Project_SWP391.Model.AppUser", null)
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

                    b.HasOne("Project_SWP391.Model.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Project_SWP391.Model.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Project_SWP391.Model.Bill", b =>
                {
                    b.HasOne("Project_SWP391.Model.Quotation", "Quotation")
                        .WithOne("Bill")
                        .HasForeignKey("Project_SWP391.Model.Bill", "QuotationId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Project_SWP391.Model.AppUser", "User")
                        .WithMany("Bills")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Quotation");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Project_SWP391.Model.BillDetail", b =>
                {
                    b.HasOne("Project_SWP391.Model.Bill", "Bill")
                        .WithOne("BillDetails")
                        .HasForeignKey("Project_SWP391.Model.BillDetail", "BillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bill");
                });

            modelBuilder.Entity("Project_SWP391.Model.DeliveryStatus", b =>
                {
                    b.HasOne("Project_SWP391.Model.Bill", "Bill")
                        .WithOne("DeliveryStatus")
                        .HasForeignKey("Project_SWP391.Model.DeliveryStatus", "BillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project_SWP391.Model.Delivery", "Delivery")
                        .WithMany()
                        .HasForeignKey("DeliveryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bill");

                    b.Navigation("Delivery");
                });

            modelBuilder.Entity("Project_SWP391.Model.FarmImage", b =>
                {
                    b.HasOne("Project_SWP391.Model.KoiFarm", "KoiFarm")
                        .WithMany("FarmImages")
                        .HasForeignKey("FarmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KoiFarm");
                });

            modelBuilder.Entity("Project_SWP391.Model.Feedback", b =>
                {
                    b.HasOne("Project_SWP391.Model.AppUser", "User")
                        .WithOne("Feedback")
                        .HasForeignKey("Project_SWP391.Model.Feedback", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Project_SWP391.Model.Koi", b =>
                {
                    b.HasOne("Project_SWP391.Model.KoiFarm", "KoiFarm")
                        .WithMany("Kois")
                        .HasForeignKey("FarmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KoiFarm");
                });

            modelBuilder.Entity("Project_SWP391.Model.KoiBill", b =>
                {
                    b.HasOne("Project_SWP391.Model.Bill", "Bill")
                        .WithMany("KoiBills")
                        .HasForeignKey("BillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project_SWP391.Model.Koi", "Koi")
                        .WithMany("KoiBills")
                        .HasForeignKey("KoiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bill");

                    b.Navigation("Koi");
                });

            modelBuilder.Entity("Project_SWP391.Model.KoiImage", b =>
                {
                    b.HasOne("Project_SWP391.Model.Koi", "Koi")
                        .WithMany("KoiImages")
                        .HasForeignKey("KoiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Koi");
                });

            modelBuilder.Entity("Project_SWP391.Model.PayStatus", b =>
                {
                    b.HasOne("Project_SWP391.Model.Bill", "Bill")
                        .WithOne("PayStatus")
                        .HasForeignKey("Project_SWP391.Model.PayStatus", "BillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bill");
                });

            modelBuilder.Entity("Project_SWP391.Model.Quotation", b =>
                {
                    b.HasOne("Project_SWP391.Model.Tour", "Tour")
                        .WithMany("Quotations")
                        .HasForeignKey("TourId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project_SWP391.Model.AppUser", "User")
                        .WithMany("Quotations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tour");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Project_SWP391.Model.Rating", b =>
                {
                    b.HasOne("Project_SWP391.Model.KoiFarm", "KoiFarm")
                        .WithMany("Ratings")
                        .HasForeignKey("FarmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project_SWP391.Model.AppUser", "User")
                        .WithMany("Ratings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KoiFarm");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Project_SWP391.Model.TourDestination", b =>
                {
                    b.HasOne("Project_SWP391.Model.KoiFarm", "KoiFarm")
                        .WithMany("TourDestinations")
                        .HasForeignKey("FarmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project_SWP391.Model.Tour", "Tour")
                        .WithMany("TourDestinations")
                        .HasForeignKey("TourId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KoiFarm");

                    b.Navigation("Tour");
                });

            modelBuilder.Entity("Project_SWP391.Model.VarietyOfKoi", b =>
                {
                    b.HasOne("Project_SWP391.Model.Koi", "Koi")
                        .WithMany("VarietyOfKois")
                        .HasForeignKey("KoiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project_SWP391.Model.KoiVariety", "KoiVariety")
                        .WithMany("VarietyOfKois")
                        .HasForeignKey("VarietyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Koi");

                    b.Navigation("KoiVariety");
                });

            modelBuilder.Entity("Project_SWP391.Model.AppUser", b =>
                {
                    b.Navigation("Bills");

                    b.Navigation("Feedback")
                        .IsRequired();

                    b.Navigation("Quotations");

                    b.Navigation("Ratings");
                });

            modelBuilder.Entity("Project_SWP391.Model.Bill", b =>
                {
                    b.Navigation("BillDetails")
                        .IsRequired();

                    b.Navigation("DeliveryStatus")
                        .IsRequired();

                    b.Navigation("KoiBills");

                    b.Navigation("PayStatus")
                        .IsRequired();
                });

            modelBuilder.Entity("Project_SWP391.Model.Koi", b =>
                {
                    b.Navigation("KoiBills");

                    b.Navigation("KoiImages");

                    b.Navigation("VarietyOfKois");
                });

            modelBuilder.Entity("Project_SWP391.Model.KoiFarm", b =>
                {
                    b.Navigation("FarmImages");

                    b.Navigation("Kois");

                    b.Navigation("Ratings");

                    b.Navigation("TourDestinations");
                });

            modelBuilder.Entity("Project_SWP391.Model.KoiVariety", b =>
                {
                    b.Navigation("VarietyOfKois");
                });

            modelBuilder.Entity("Project_SWP391.Model.Quotation", b =>
                {
                    b.Navigation("Bill")
                        .IsRequired();
                });

            modelBuilder.Entity("Project_SWP391.Model.Tour", b =>
                {
                    b.Navigation("Quotations");

                    b.Navigation("TourDestinations");
                });
#pragma warning restore 612, 618
        }
    }
}
