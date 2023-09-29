﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RepositoryLayer.Context;

#nullable disable

namespace RepositoryLayer.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EntityLayer.WebApplication.Entities.About", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Clients")
                        .HasMaxLength(5)
                        .HasColumnType("int");

                    b.Property<string>("CreatedDate")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HardWorkers")
                        .HasMaxLength(5)
                        .HasColumnType("int");

                    b.Property<string>("Header")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("HoursOfSupport")
                        .HasMaxLength(5)
                        .HasColumnType("int");

                    b.Property<int>("Projects")
                        .HasMaxLength(5)
                        .HasColumnType("int");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<int>("SocialMediaId")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedDate")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("SocialMediaId")
                        .IsUnique();

                    b.ToTable("Abouts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Clients = 5,
                            CreatedDate = "27/09/2023",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. In nibh mauris cursus mattis molestie a iaculis at erat. Odio ut enim blandit volutpat maecenas volutpat blandit aliquam etiam. Suspendisse sed nisi lacus sed viverra tellus in. Amet volutpat consequat mauris nunc congue. Diam maecenas sed enim ut sem. Et magnis dis parturient montes nascetur. Morbi tempus iaculis urna id volutpat lacus laoreet. Urna condimentum mattis pellentesque id nibh tortor id. Fames ac turpis egestas maecenas pharetra convallis posuere. Nunc mi ipsum faucibus vitae aliquet.",
                            FileName = "test",
                            FileType = "test",
                            HardWorkers = 3,
                            Header = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                            HoursOfSupport = 150,
                            Projects = 5,
                            SocialMediaId = 1
                        });
                });

            modelBuilder.Entity("EntityLayer.WebApplication.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedDate")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("UpdatedDate")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = "27/09/2023",
                            Name = "Projects"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = "27/09/2023",
                            Name = "SiteWorks"
                        });
                });

            modelBuilder.Entity("EntityLayer.WebApplication.Entities.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Call")
                        .IsRequired()
                        .HasMaxLength(17)
                        .HasColumnType("nvarchar(17)");

                    b.Property<string>("CreatedDate")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Map")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("UpdatedDate")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Call = "1246556956",
                            CreatedDate = "27/09/2023",
                            Email = "test@try.com",
                            Location = "Iron streen, Brave Avenue, KD1 2CF, London",
                            Map = "TestLink Here"
                        });
                });

            modelBuilder.Entity("EntityLayer.WebApplication.Entities.HomePage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedDate")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<string>("Header")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("UpdatedDate")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("VideoLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HomePages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = "27/09/2023",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. In nibh mauris cursus mattis molestie a iaculis at erat. Odio ut enim blandit volutpat maecenas volutpat blandit aliquam etiam.",
                            Header = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                            VideoLink = "Test Video Link"
                        });
                });

            modelBuilder.Entity("EntityLayer.WebApplication.Entities.Portfolio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedDate")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("UpdatedDate")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Portfolios");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreatedDate = "27/09/2023",
                            FileName = "Test",
                            FileType = "test",
                            Title = "Test Picture"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            CreatedDate = "27/09/2023",
                            FileName = "Test2",
                            FileType = "test2",
                            Title = "Test Picture2"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            CreatedDate = "27/09/2023",
                            FileName = "Test3",
                            FileType = "test3",
                            Title = "Test Picture3"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            CreatedDate = "27/09/2023",
                            FileName = "Test4",
                            FileType = "test4",
                            Title = "Test Picture4"
                        });
                });

            modelBuilder.Entity("EntityLayer.WebApplication.Entities.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedDate")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("UpdatedDate")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.ToTable("Services");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = "27/09/2023",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. In nibh mauris cursus mattis molestie a iaculis at erat. Odio ut enim blandit volutpat maecenas volutpat blandit aliquam etiam.",
                            Icon = "bi bi-service1",
                            Name = "Plumbing Service 1"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = "27/09/2023",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. In nibh mauris cursus mattis molestie a iaculis at erat. Odio ut enim blandit volutpat maecenas volutpat blandit aliquam etiam.",
                            Icon = "bi bi-service2",
                            Name = "Plumbing Service 2"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = "27/09/2023",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. In nibh mauris cursus mattis molestie a iaculis at erat. Odio ut enim blandit volutpat maecenas volutpat blandit aliquam etiam.",
                            Icon = "bi bi-service3",
                            Name = "Plumbing Service 3"
                        });
                });

            modelBuilder.Entity("EntityLayer.WebApplication.Entities.SocialMedia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedDate")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("FaceBook")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Instagram")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LinkedIn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("Twitter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedDate")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.ToTable("SocialMedias");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = "27/09/2023",
                            FaceBook = "testFacebook",
                            Instagram = "testInstagram"
                        });
                });

            modelBuilder.Entity("EntityLayer.WebApplication.Entities.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedDate")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("FaceBook")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Instagram")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LinkedIn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Twitter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedDate")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.ToTable("Teams");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = "27/09/2023",
                            FaceBook = "facebook",
                            FileName = "test",
                            FileType = "test",
                            FullName = "John Black",
                            Instagram = "instagram",
                            Title = "Professor"
                        });
                });

            modelBuilder.Entity("EntityLayer.WebApplication.Entities.Testimonal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<string>("CreatedDate")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("UpdatedDate")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.ToTable("Testimonals");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. In nibh mauris cursus mattis molestie a iaculis at erat. Odio ut enim blandit volutpat maecenas volutpat blandit aliquam etiam.",
                            CreatedDate = "27/09/2023",
                            FileName = "test",
                            FileType = "test",
                            FullName = "Merlyn Monroe",
                            Title = "interesting"
                        },
                        new
                        {
                            Id = 2,
                            Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. In nibh mauris cursus mattis molestie a iaculis at erat. Odio ut enim blandit volutpat maecenas volutpat blandit aliquam etiam.",
                            CreatedDate = "27/09/2023",
                            FileName = "test",
                            FileType = "test",
                            FullName = "Jackie Chan",
                            Title = "interesting"
                        },
                        new
                        {
                            Id = 3,
                            Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. In nibh mauris cursus mattis molestie a iaculis at erat. Odio ut enim blandit volutpat maecenas volutpat blandit aliquam etiam.",
                            CreatedDate = "27/09/2023",
                            FileName = "test",
                            FileType = "test",
                            FullName = "Bruce Wills",
                            Title = "interesting"
                        });
                });

            modelBuilder.Entity("EntityLayer.WebApplication.Entities.About", b =>
                {
                    b.HasOne("EntityLayer.WebApplication.Entities.SocialMedia", "SocialMedia")
                        .WithOne("About")
                        .HasForeignKey("EntityLayer.WebApplication.Entities.About", "SocialMediaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SocialMedia");
                });

            modelBuilder.Entity("EntityLayer.WebApplication.Entities.Portfolio", b =>
                {
                    b.HasOne("EntityLayer.WebApplication.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("EntityLayer.WebApplication.Entities.SocialMedia", b =>
                {
                    b.Navigation("About")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}