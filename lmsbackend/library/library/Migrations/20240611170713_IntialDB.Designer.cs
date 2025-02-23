﻿// <auto-generated />
using System;
using library.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace library.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240611170713_IntialDB")]
    partial class IntialDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("API.Entities.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BookCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("BookName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Ordered")
                        .HasColumnType("bit");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookCategoryId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Thomas Corman",
                            BookCategoryId = 1,
                            BookName = "Introduction to Algorithm",
                            Description = "Algorithm is a step by step process",
                            Ordered = false,
                            Price = 100f,
                            Rating = 5,
                            userId = 1
                        },
                        new
                        {
                            Id = 2,
                            Author = "Thomas Corman",
                            BookCategoryId = 1,
                            BookName = "Introduction to Algorithm",
                            Description = "Renowned for its clarity and depth, this book provides an extensive exploration of algorithms and their applications. From sorting and searching algorithms to graph algorithms and data structures, it offers a wealth of knowledge supported by insightful explanations and practical examples.",
                            Ordered = false,
                            Price = 100f,
                            Rating = 5,
                            userId = 1
                        },
                        new
                        {
                            Id = 3,
                            Author = "Robert Sedgewick & Kevin Wayne",
                            BookCategoryId = 1,
                            BookName = "Algorithms",
                            Description = "This practical guide to algorithm design presents a holistic approach to problem-solving and algorithm development. ",
                            Ordered = false,
                            Price = 200f,
                            Rating = 4,
                            userId = 1
                        },
                        new
                        {
                            Id = 4,
                            Author = "Steve Skiena",
                            BookCategoryId = 1,
                            BookName = "The Algorithm Design Manual",
                            Description = "Designed for beginners, this book offers a beginner-friendly introduction to Python programming.",
                            Ordered = false,
                            Price = 300f,
                            Rating = 5,
                            userId = 1
                        },
                        new
                        {
                            Id = 5,
                            Author = "Adnan Aziz",
                            BookCategoryId = 1,
                            BookName = "Algorithms For Interviews",
                            Description = "With its unique and engaging approach, this book makes learning Python fun and accessible. ",
                            Ordered = false,
                            Price = 400f,
                            Rating = 3,
                            userId = 1
                        },
                        new
                        {
                            Id = 6,
                            Author = "Eric Matthes",
                            BookCategoryId = 2,
                            BookName = "Python Crash Course: A Hands-On, Project-Based Introduction to Programming",
                            Description = "This indispensable resource offers expert guidance on writing clean, efficient, and maintainable Java code",
                            Ordered = false,
                            Price = 700f,
                            Rating = 3,
                            userId = 1
                        },
                        new
                        {
                            Id = 7,
                            Author = "Eric Matthes",
                            BookCategoryId = 2,
                            BookName = "Python Crash Course: A Hands-On, Project-Based Introduction to Programming",
                            Description = "deal for beginners, this book provides a lively and interactive introduction to Java programming.",
                            Ordered = false,
                            Price = 700f,
                            Rating = 3,
                            userId = 1
                        },
                        new
                        {
                            Id = 8,
                            Author = "Eric Matthes",
                            BookCategoryId = 2,
                            BookName = "Python Crash Course: A Hands-On, Project-Based Introduction to Programming",
                            Description = "Designed for beginners, this book offers a beginner-friendly introduction to Python programming",
                            Ordered = false,
                            Price = 700f,
                            Rating = 2,
                            userId = 1
                        },
                        new
                        {
                            Id = 9,
                            Author = "Paul Barry",
                            BookCategoryId = 2,
                            BookName = "Head First Python: A Brain-Friendly Guide",
                            Description = "Algorithm is a step by step process",
                            Ordered = false,
                            Price = 800f,
                            Rating = 2,
                            userId = 1
                        },
                        new
                        {
                            Id = 10,
                            Author = "Joshua Bloch",
                            BookCategoryId = 2,
                            BookName = "Effective Java",
                            Description = "Algorithm is a step by step process",
                            Ordered = false,
                            Price = 900f,
                            Rating = 3,
                            userId = 3
                        },
                        new
                        {
                            Id = 11,
                            Author = "Joshua Bloch",
                            BookCategoryId = 2,
                            BookName = "Effective Java",
                            Description = "Algorithm is a step by step process",
                            Ordered = false,
                            Price = 900f,
                            Rating = 4,
                            userId = 3
                        },
                        new
                        {
                            Id = 12,
                            Author = "James F Kurose and Keith W Ross",
                            BookCategoryId = 3,
                            BookName = "A Top-Down Approach: Computer Networking",
                            Description = "deal for beginners, this book provides a lively and interactive introduction to Java programming.",
                            Ordered = false,
                            Price = 1400f,
                            Rating = 4,
                            userId = 2
                        },
                        new
                        {
                            Id = 13,
                            Author = "Rich Seifert and James Edwards",
                            BookCategoryId = 3,
                            BookName = "The All-New Switch Book (2nd Edition)",
                            Description = "Designed for beginners, this book offers a beginner-friendly introduction to Python programming",
                            Ordered = false,
                            Price = 1500f,
                            Rating = 3,
                            userId = 4
                        },
                        new
                        {
                            Id = 14,
                            Author = "Rich Seifert and James Edwards",
                            BookCategoryId = 3,
                            BookName = "The All-New Switch Book (2nd Edition)",
                            Description = "This indispensable resource offers expert guidance on writing clean, efficient, and maintainable Java code",
                            Ordered = false,
                            Price = 1500f,
                            Rating = 5,
                            userId = 1
                        },
                        new
                        {
                            Id = 15,
                            Author = "Jerry FitzGerald, Alan Dennis, and Alexandra Durcikova",
                            BookCategoryId = 3,
                            BookName = "Business Data Communications and Networking (14th Edition)",
                            Description = "Algorithm is a step by step process",
                            Ordered = false,
                            Price = 1600f,
                            Rating = 3,
                            userId = 2
                        },
                        new
                        {
                            Id = 16,
                            Author = "Forouzan",
                            BookCategoryId = 4,
                            BookName = "Data Communications and Networking with TCP/IP Protocol Suite, 6th Edition",
                            Description = "Algorithm is a step by step process",
                            Ordered = false,
                            Price = 1700f,
                            Rating = 5,
                            userId = 3
                        },
                        new
                        {
                            Id = 17,
                            Author = "Gary Donahue",
                            BookCategoryId = 4,
                            BookName = "Network Warrior, 2nd Edition",
                            Description = "deal for beginners, this book provides a lively and interactive introduction to Java programming.",
                            Ordered = false,
                            Price = 1800f,
                            Rating = 5,
                            userId = 3
                        },
                        new
                        {
                            Id = 18,
                            Author = "Gary Donahue",
                            BookCategoryId = 5,
                            BookName = "Network Warrior, 2nd Edition",
                            Description = "This indispensable resource offers expert guidance on writing clean, efficient, and maintainable Java code",
                            Ordered = false,
                            Price = 1800f,
                            Rating = 2,
                            userId = 2
                        },
                        new
                        {
                            Id = 19,
                            Author = "Gary Donahue",
                            BookCategoryId = 5,
                            BookName = "Network Warrior, 2nd Edition",
                            Description = "Algorithm is a step by step process",
                            Ordered = false,
                            Price = 1800f,
                            Rating = 5,
                            userId = 2
                        });
                });

            modelBuilder.Entity("API.Entities.BookCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubCategory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BookCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "computer",
                            SubCategory = "algorithm"
                        },
                        new
                        {
                            Id = 2,
                            Category = "computer",
                            SubCategory = "programming languages"
                        },
                        new
                        {
                            Id = 3,
                            Category = "computer",
                            SubCategory = "networking"
                        },
                        new
                        {
                            Id = 4,
                            Category = "computer",
                            SubCategory = "hardware"
                        },
                        new
                        {
                            Id = 5,
                            Category = "mechanical",
                            SubCategory = "machine"
                        });
                });

            modelBuilder.Entity("API.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("FinePaid")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ReturnDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Returned")
                        .HasColumnType("bit");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("API.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AccountStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TokensAvailable")
                        .HasColumnType("int");

                    b.Property<string>("UserType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccountStatus = "ACTIVE",
                            CreatedOn = new DateTime(2024, 6, 11, 13, 28, 12, 0, DateTimeKind.Unspecified),
                            Email = "admin@gmail.com",
                            MobileNumber = "1234567890",
                            Name = "Admin",
                            Password = "admin1234",
                            TokensAvailable = 0,
                            UserType = "ADMIN"
                        },
                        new
                        {
                            Id = 2,
                            AccountStatus = "ACTIVE",
                            CreatedOn = new DateTime(2024, 3, 6, 13, 30, 12, 0, DateTimeKind.Unspecified),
                            Email = "sai@gmail.com",
                            MobileNumber = "1234567890",
                            Name = "sai",
                            Password = "sai1234",
                            TokensAvailable = 0,
                            UserType = "STUDENT"
                        },
                        new
                        {
                            Id = 3,
                            AccountStatus = "ACTIVE",
                            CreatedOn = new DateTime(2024, 1, 6, 14, 30, 12, 0, DateTimeKind.Unspecified),
                            Email = "manu@gmail.com",
                            MobileNumber = "1234567890",
                            Name = "manu",
                            Password = "manu4321",
                            TokensAvailable = 0,
                            UserType = "STUDENT"
                        });
                });

            modelBuilder.Entity("API.Entities.Book", b =>
                {
                    b.HasOne("API.Entities.BookCategory", "BookCategory")
                        .WithMany()
                        .HasForeignKey("BookCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BookCategory");
                });

            modelBuilder.Entity("API.Entities.Order", b =>
                {
                    b.HasOne("API.Entities.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
