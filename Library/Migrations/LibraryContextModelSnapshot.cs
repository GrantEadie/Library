﻿// <auto-generated />
using System;
using Library.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Library.Migrations
{
    [DbContext(typeof(LibraryContext))]
    partial class LibraryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Library.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Library.Models.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AuthorName");

                    b.Property<string>("UserId");

                    b.HasKey("AuthorId");

                    b.HasIndex("UserId");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("Library.Models.AuthorBook", b =>
                {
                    b.Property<int>("AuthorBookId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AuthorId");

                    b.Property<int>("BookId");

                    b.HasKey("AuthorBookId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("BookId");

                    b.ToTable("AuthorBook");
                });

            modelBuilder.Entity("Library.Models.AuthorGenre", b =>
                {
                    b.Property<int>("AuthorGenreId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AuthorId");

                    b.Property<int>("GenreId");

                    b.HasKey("AuthorGenreId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("GenreId");

                    b.ToTable("AuthorGenre");
                });

            modelBuilder.Entity("Library.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BookDescription");

                    b.Property<string>("BookName");

                    b.Property<int>("NumberOfBooks");

                    b.Property<string>("UserId");

                    b.HasKey("BookId");

                    b.HasIndex("UserId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Library.Models.BookCopy", b =>
                {
                    b.Property<int>("BookCopyId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BookId");

                    b.Property<int>("CopyId");

                    b.HasKey("BookCopyId");

                    b.HasIndex("BookId");

                    b.HasIndex("CopyId");

                    b.ToTable("BookCopy");
                });

            modelBuilder.Entity("Library.Models.BookGenre", b =>
                {
                    b.Property<int>("BookGenreId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BookId");

                    b.Property<int>("GenreId");

                    b.HasKey("BookGenreId");

                    b.HasIndex("BookId");

                    b.HasIndex("GenreId");

                    b.ToTable("BookGenre");
                });

            modelBuilder.Entity("Library.Models.Copy", b =>
                {
                    b.Property<int>("CopyId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CopyCheckoutDate");

                    b.Property<string>("CopyName");

                    b.Property<string>("UserId");

                    b.HasKey("CopyId");

                    b.HasIndex("UserId");

                    b.ToTable("Copies");
                });

            modelBuilder.Entity("Library.Models.CopyPatron", b =>
                {
                    b.Property<int>("CopyPatronId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CopyId");

                    b.Property<int>("PatronId");

                    b.HasKey("CopyPatronId");

                    b.HasIndex("CopyId");

                    b.HasIndex("PatronId");

                    b.ToTable("CopyPatron");
                });

            modelBuilder.Entity("Library.Models.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("GenreDescription");

                    b.Property<string>("GenreName");

                    b.Property<string>("UserId");

                    b.HasKey("GenreId");

                    b.HasIndex("UserId");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("Library.Models.Patron", b =>
                {
                    b.Property<int>("PatronId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("PatronFirstName");

                    b.Property<string>("PatronLastName");

                    b.Property<string>("UserId");

                    b.HasKey("PatronId");

                    b.HasIndex("UserId");

                    b.ToTable("Patrons");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Library.Models.Author", b =>
                {
                    b.HasOne("Library.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Library.Models.AuthorBook", b =>
                {
                    b.HasOne("Library.Models.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Library.Models.Book", "Book")
                        .WithMany("Authors")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Library.Models.AuthorGenre", b =>
                {
                    b.HasOne("Library.Models.Author", "Author")
                        .WithMany("Genres")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Library.Models.Genre", "Genre")
                        .WithMany("Authors")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Library.Models.Book", b =>
                {
                    b.HasOne("Library.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Library.Models.BookCopy", b =>
                {
                    b.HasOne("Library.Models.Book", "Book")
                        .WithMany("Copies")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Library.Models.Copy", "Copy")
                        .WithMany("Books")
                        .HasForeignKey("CopyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Library.Models.BookGenre", b =>
                {
                    b.HasOne("Library.Models.Book", "Book")
                        .WithMany("Genres")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Library.Models.Genre", "Genre")
                        .WithMany("Books")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Library.Models.Copy", b =>
                {
                    b.HasOne("Library.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Library.Models.CopyPatron", b =>
                {
                    b.HasOne("Library.Models.Copy", "Copy")
                        .WithMany("Patrons")
                        .HasForeignKey("CopyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Library.Models.Patron", "Patron")
                        .WithMany("Copies")
                        .HasForeignKey("PatronId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Library.Models.Genre", b =>
                {
                    b.HasOne("Library.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Library.Models.Patron", b =>
                {
                    b.HasOne("Library.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Library.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Library.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Library.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Library.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
