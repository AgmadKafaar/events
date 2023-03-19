﻿// <auto-generated />
using System;
using Events.Shared.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Events.Shared.Migrations
{
    [DbContext(typeof(EventsContext))]
    [Migration("20230319090753_EventsRowVersionConcurrencyControl")]
    partial class EventsRowVersionConcurrencyControl
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("AttendeeEvent", b =>
                {
                    b.Property<int>("AttendeesId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("EventsId")
                        .HasColumnType("INTEGER");

                    b.HasKey("AttendeesId", "EventsId");

                    b.HasIndex("EventsId");

                    b.ToTable("AttendeeEvent");
                });

            modelBuilder.Entity("Events.Shared.Models.Attendee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AttendeeTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsAttending")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AttendeeTypeId");

                    b.ToTable("Attendees");
                });

            modelBuilder.Entity("Events.Shared.Models.AttendeeType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("AttendeesType");
                });

            modelBuilder.Entity("Events.Shared.Models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("BLOB");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("AttendeeEvent", b =>
                {
                    b.HasOne("Events.Shared.Models.Attendee", null)
                        .WithMany()
                        .HasForeignKey("AttendeesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Events.Shared.Models.Event", null)
                        .WithMany()
                        .HasForeignKey("EventsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Events.Shared.Models.Attendee", b =>
                {
                    b.HasOne("Events.Shared.Models.AttendeeType", "AttendeeType")
                        .WithMany("Attendees")
                        .HasForeignKey("AttendeeTypeId");

                    b.Navigation("AttendeeType");
                });

            modelBuilder.Entity("Events.Shared.Models.AttendeeType", b =>
                {
                    b.Navigation("Attendees");
                });
#pragma warning restore 612, 618
        }
    }
}
