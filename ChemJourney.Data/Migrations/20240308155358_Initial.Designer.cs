﻿// <auto-generated />
using System;
using ChemJourney.Web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ChemJourney.Data.Migrations
{
    [DbContext(typeof(ChemJourneyDbContext))]
    [Migration("20240308155358_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ChemJourney.Data.Models.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTime>("MemberSince")
                        .HasColumnType("datetime2");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
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

            modelBuilder.Entity("ChemJourney.Data.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Id of the category");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasComment("Name of the category");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasComment("Categories that a post might have.");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Organic Chemistry"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Physical Chemistry"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Analytical Chemistry"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Inorganic Chemistry"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Biochemistry"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Undefined"
                        });
                });

            modelBuilder.Entity("ChemJourney.Data.Models.ChemicalGroupBlock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("The ID of the chemical group block.");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasComment("The Name of the chemical group block.");

                    b.HasKey("Id");

                    b.ToTable("ChemicalGroupBlocks");

                    b.HasComment("The types of chemical group blocks that exist in the periodic table.");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Nonmetal"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Alkali Metal"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Alkaline Earth Metal"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Lanthanide"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Actinide"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Transition Metal"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Post-Transition Metal"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Metalloid"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Halogen"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Noble Gas"
                        });
                });

            modelBuilder.Entity("ChemJourney.Data.Models.Element", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("The atomic number of the element");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("AtomicMass")
                        .HasColumnType("float")
                        .HasComment("The atomic mass of the element");

                    b.Property<double?>("BoilingPoint")
                        .HasColumnType("float")
                        .HasComment("The boiling point of the element");

                    b.Property<int>("ChemicalGroupBlockId")
                        .HasColumnType("int");

                    b.Property<double?>("MeltingPoint")
                        .HasColumnType("float")
                        .HasComment("The melting point of the element");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasComment("The number of the element");

                    b.Property<string>("OxidationStates")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasComment("The standart state of the element");

                    b.Property<string>("StandardState")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasComment("The standard state of the element");

                    b.Property<string>("Symbol")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)")
                        .HasComment("The symbol of the element");

                    b.HasKey("Id");

                    b.HasIndex("ChemicalGroupBlockId");

                    b.ToTable("Elements");

                    b.HasComment("The elements of the Periodic Table");
                });

            modelBuilder.Entity("ChemJourney.Data.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Id of the post.");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<Guid>("AuthorId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Id of the user who wrote the post.");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasComment("Category ID of the post.");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)")
                        .HasComment("Content of the post.");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2")
                        .HasComment("Time when the post has been posted.");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasComment("To check if post is deleted.");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Title of the post.");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Posts");

                    b.HasComment("A post that an user can submit to the forum.");
                });

            modelBuilder.Entity("ChemJourney.Data.Models.PostReply", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Id of the post reply.");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<Guid>("AuthorId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("User Id of the person who gave the reply.");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasComment("Content of the reply.");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2")
                        .HasComment("Time when the reply is given.");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasComment("To check if reply is deleted.");

                    b.Property<int>("PostId")
                        .HasColumnType("int")
                        .HasComment("Post ID to which the reply is associated.");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("PostId");

                    b.ToTable("PostReplies");

                    b.HasComment("Replies that are given to a post.");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

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
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ChemJourney.Data.Models.Element", b =>
                {
                    b.HasOne("ChemJourney.Data.Models.ChemicalGroupBlock", "ChemicalGroupBlock")
                        .WithMany("Elements")
                        .HasForeignKey("ChemicalGroupBlockId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("ChemicalGroupBlock");
                });

            modelBuilder.Entity("ChemJourney.Data.Models.Post", b =>
                {
                    b.HasOne("ChemJourney.Data.Models.ApplicationUser", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ChemJourney.Data.Models.Category", "Category")
                        .WithMany("Posts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ChemJourney.Data.Models.PostReply", b =>
                {
                    b.HasOne("ChemJourney.Data.Models.ApplicationUser", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ChemJourney.Data.Models.Post", "Post")
                        .WithMany("PostReplies")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Post");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("ChemJourney.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("ChemJourney.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ChemJourney.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("ChemJourney.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ChemJourney.Data.Models.Category", b =>
                {
                    b.Navigation("Posts");
                });

            modelBuilder.Entity("ChemJourney.Data.Models.ChemicalGroupBlock", b =>
                {
                    b.Navigation("Elements");
                });

            modelBuilder.Entity("ChemJourney.Data.Models.Post", b =>
                {
                    b.Navigation("PostReplies");
                });
#pragma warning restore 612, 618
        }
    }
}
