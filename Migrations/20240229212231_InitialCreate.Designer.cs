﻿// <auto-generated />
using System;
using EventAppCase.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EventAppCase.Migrations
{
    [DbContext(typeof(EventContext))]
    [Migration("20240229212231_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("EventAppCase.Models.Event", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("EventDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("EventDetails")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EventLocation")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EventName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("EventId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("EventAppCase.Models.Guest", b =>
                {
                    b.Property<int>("GuestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("GuestMail")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("GuestName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("GuestSurname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("GuestId");

                    b.ToTable("Guests");
                });

            modelBuilder.Entity("EventAppCase.Models.SelectedGuests", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("EventId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GuestId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("SelectedDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("SGuests");
                });
#pragma warning restore 612, 618
        }
    }
}
