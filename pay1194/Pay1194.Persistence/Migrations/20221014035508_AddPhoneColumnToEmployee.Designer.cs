﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pay1194.Persistence;

#nullable disable

namespace Pay1194.Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221014035508_AddPhoneColumnToEmployee")]
    partial class AddPhoneColumnToEmployee
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Pay1194.Entity.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateJoined")
                        .HasColumnType("datetime2");

                    b.Property<string>("Designation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NationalInsuranceNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PaymentMethod")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostCode")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("StudentLoan")
                        .HasColumnType("int");

                    b.Property<int>("UnionMember")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Pay1194.Entity.PaymentRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("ContractualEarnings")
                        .HasColumnType("money");

                    b.Property<decimal>("ContractualHours")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("DatePay")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<decimal>("HourlyRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("HourlyWorked")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("MonthPay")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("NetPayment")
                        .HasColumnType("money");

                    b.Property<decimal>("NiC")
                        .HasColumnType("money");

                    b.Property<string>("NiNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("OverTimeHours")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("OvertimeEarnings")
                        .HasColumnType("money");

                    b.Property<decimal?>("SLC")
                        .HasColumnType("money");

                    b.Property<decimal>("Tax")
                        .HasColumnType("money");

                    b.Property<string>("TaxCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TaxYearId")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalDeduction")
                        .HasColumnType("money");

                    b.Property<decimal>("TotalEarnings")
                        .HasColumnType("money");

                    b.Property<decimal>("UnionFee")
                        .HasColumnType("money");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("TaxYearId");

                    b.ToTable("PaymentRecords");
                });

            modelBuilder.Entity("Pay1194.Entity.TaxYear", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("YearOfTax")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TaxYears");
                });

            modelBuilder.Entity("Pay1194.Entity.PaymentRecord", b =>
                {
                    b.HasOne("Pay1194.Entity.Employee", "Employee")
                        .WithMany("PaymentRecords")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pay1194.Entity.TaxYear", "TaxYear")
                        .WithMany()
                        .HasForeignKey("TaxYearId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("TaxYear");
                });

            modelBuilder.Entity("Pay1194.Entity.Employee", b =>
                {
                    b.Navigation("PaymentRecords");
                });
#pragma warning restore 612, 618
        }
    }
}
