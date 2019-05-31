﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pandas.Models;

namespace Pandas.Migrations
{
    [DbContext(typeof(PandaContext))]
    partial class PandaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Pandas.Models.Panda", b =>
                {
                    b.Property<int>("PandaId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created_At");

                    b.Property<int>("Cuteness");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Location")
                        .IsRequired();

                    b.Property<string>("Type")
                        .IsRequired();

                    b.Property<DateTime>("Updated_At");

                    b.Property<int>("Weight");

                    b.HasKey("PandaId");

                    b.ToTable("Pandas");
                });
#pragma warning restore 612, 618
        }
    }
}
