﻿// <auto-generated />
using Amaterasu.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Amaterasu.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Amaterasu.Data.DatabaseEntities.Kanji", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Translation")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Kanji");
                });

            modelBuilder.Entity("Amaterasu.Data.DatabaseEntities.Password", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Value")
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)");

                    b.HasKey("Id");

                    b.ToTable("Passwords");
                });

            modelBuilder.Entity("Amaterasu.Data.DatabaseEntities.Reading", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("KanjiId")
                        .HasColumnType("integer");

                    b.Property<string>("Kun")
                        .HasColumnType("text");

                    b.Property<string>("On")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("KanjiId")
                        .IsUnique();

                    b.ToTable("Readings");
                });

            modelBuilder.Entity("Amaterasu.Data.DatabaseEntities.Word", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Level")
                        .HasColumnType("text");

                    b.Property<string>("Translation")
                        .HasColumnType("text");

                    b.Property<string>("WordInJapanese")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Words");
                });

            modelBuilder.Entity("Amaterasu.Data.DatabaseEntities.Reading", b =>
                {
                    b.HasOne("Amaterasu.Data.DatabaseEntities.Kanji", "Kanji")
                        .WithOne("Reading")
                        .HasForeignKey("Amaterasu.Data.DatabaseEntities.Reading", "KanjiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kanji");
                });

            modelBuilder.Entity("Amaterasu.Data.DatabaseEntities.Kanji", b =>
                {
                    b.Navigation("Reading");
                });
#pragma warning restore 612, 618
        }
    }
}
