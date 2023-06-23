﻿// <auto-generated />
using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20230623152222_seedData")]
    partial class seedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Data.Entities.Announcement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("announcements");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateAdded = new DateTime(2001, 1, 19, 19, 54, 31, 503, DateTimeKind.Unspecified).AddTicks(6712),
                            Description = "Ipsum corrupti eveniet numquam possimus.",
                            Title = "veritatis"
                        },
                        new
                        {
                            Id = 2,
                            DateAdded = new DateTime(2005, 10, 3, 16, 29, 20, 785, DateTimeKind.Unspecified).AddTicks(4208),
                            Description = "Qui quasi suscipit ut.",
                            Title = "recusandae"
                        },
                        new
                        {
                            Id = 3,
                            DateAdded = new DateTime(2009, 11, 4, 0, 17, 18, 510, DateTimeKind.Unspecified).AddTicks(9699),
                            Description = "Officia saepe sapiente aperiam vero at fugiat ratione.",
                            Title = "quia"
                        },
                        new
                        {
                            Id = 4,
                            DateAdded = new DateTime(2014, 12, 22, 0, 18, 33, 149, DateTimeKind.Unspecified).AddTicks(1440),
                            Description = "Eius ut numquam rem nisi error quia qui veniam quia.",
                            Title = "qui"
                        },
                        new
                        {
                            Id = 5,
                            DateAdded = new DateTime(2004, 7, 21, 13, 29, 11, 62, DateTimeKind.Unspecified).AddTicks(1798),
                            Description = "In quisquam dolor consequatur commodi sit aut qui.",
                            Title = "earum"
                        },
                        new
                        {
                            Id = 6,
                            DateAdded = new DateTime(2011, 3, 17, 17, 50, 55, 185, DateTimeKind.Unspecified).AddTicks(5864),
                            Description = "Hic ipsum numquam sed dolores suscipit nisi.",
                            Title = "nisi"
                        },
                        new
                        {
                            Id = 7,
                            DateAdded = new DateTime(2009, 11, 2, 21, 49, 58, 584, DateTimeKind.Unspecified).AddTicks(939),
                            Description = "Dolorem optio hic tempore est assumenda quia autem ipsa.",
                            Title = "harum"
                        },
                        new
                        {
                            Id = 8,
                            DateAdded = new DateTime(2020, 12, 5, 17, 30, 0, 335, DateTimeKind.Unspecified).AddTicks(8666),
                            Description = "Tempora praesentium eos tempore dolorem dolor labore cumque autem accusantium.",
                            Title = "hic"
                        },
                        new
                        {
                            Id = 9,
                            DateAdded = new DateTime(2007, 3, 29, 22, 7, 25, 775, DateTimeKind.Unspecified).AddTicks(8160),
                            Description = "Ipsum aliquid ut tenetur rerum voluptatibus nesciunt.",
                            Title = "libero"
                        },
                        new
                        {
                            Id = 10,
                            DateAdded = new DateTime(2013, 12, 8, 6, 14, 0, 763, DateTimeKind.Unspecified).AddTicks(1492),
                            Description = "Voluptatem tempora suscipit rerum velit nihil autem voluptatem molestiae.",
                            Title = "recusandae"
                        },
                        new
                        {
                            Id = 11,
                            DateAdded = new DateTime(2006, 7, 27, 12, 25, 33, 977, DateTimeKind.Unspecified).AddTicks(7363),
                            Description = "Possimus et qui molestias natus labore non nihil et aut.",
                            Title = "asperiores"
                        },
                        new
                        {
                            Id = 12,
                            DateAdded = new DateTime(2006, 11, 4, 7, 38, 25, 929, DateTimeKind.Unspecified).AddTicks(6948),
                            Description = "Quam quia quo explicabo odio temporibus facilis.",
                            Title = "voluptatem"
                        },
                        new
                        {
                            Id = 13,
                            DateAdded = new DateTime(2019, 5, 19, 7, 47, 49, 224, DateTimeKind.Unspecified).AddTicks(835),
                            Description = "Ducimus corrupti qui.",
                            Title = "impedit"
                        },
                        new
                        {
                            Id = 14,
                            DateAdded = new DateTime(2003, 1, 31, 18, 38, 16, 631, DateTimeKind.Unspecified).AddTicks(5128),
                            Description = "Officiis delectus beatae cupiditate tempora deserunt et.",
                            Title = "repellat"
                        },
                        new
                        {
                            Id = 15,
                            DateAdded = new DateTime(2004, 5, 15, 0, 9, 23, 452, DateTimeKind.Unspecified).AddTicks(6883),
                            Description = "Et vel excepturi hic numquam hic.",
                            Title = "odio"
                        },
                        new
                        {
                            Id = 16,
                            DateAdded = new DateTime(2000, 6, 23, 16, 36, 58, 454, DateTimeKind.Unspecified).AddTicks(4267),
                            Description = "Et tenetur inventore corrupti aut aliquid et ab hic autem.",
                            Title = "vitae"
                        },
                        new
                        {
                            Id = 17,
                            DateAdded = new DateTime(2007, 9, 24, 9, 51, 9, 53, DateTimeKind.Unspecified).AddTicks(6160),
                            Description = "Recusandae voluptas non voluptas sed fuga.",
                            Title = "quam"
                        },
                        new
                        {
                            Id = 18,
                            DateAdded = new DateTime(2018, 4, 6, 1, 13, 50, 17, DateTimeKind.Unspecified).AddTicks(9180),
                            Description = "Impedit expedita sit accusamus ut.",
                            Title = "dolorem"
                        },
                        new
                        {
                            Id = 19,
                            DateAdded = new DateTime(2013, 6, 3, 5, 30, 41, 134, DateTimeKind.Unspecified).AddTicks(7744),
                            Description = "Dolores corporis inventore fugiat dolores et vel deleniti enim quia.",
                            Title = "possimus"
                        },
                        new
                        {
                            Id = 20,
                            DateAdded = new DateTime(2017, 9, 21, 1, 13, 16, 190, DateTimeKind.Unspecified).AddTicks(9402),
                            Description = "Facere esse repellat molestias dignissimos tempore voluptatem quis maxime natus.",
                            Title = "ut"
                        },
                        new
                        {
                            Id = 21,
                            DateAdded = new DateTime(2002, 1, 1, 8, 17, 47, 121, DateTimeKind.Unspecified).AddTicks(1255),
                            Description = "Dolore ea totam itaque.",
                            Title = "dolorem"
                        },
                        new
                        {
                            Id = 22,
                            DateAdded = new DateTime(2010, 4, 9, 12, 41, 9, 364, DateTimeKind.Unspecified).AddTicks(8442),
                            Description = "Quae debitis porro commodi culpa.",
                            Title = "debitis"
                        },
                        new
                        {
                            Id = 23,
                            DateAdded = new DateTime(2017, 10, 13, 22, 42, 49, 898, DateTimeKind.Unspecified).AddTicks(2665),
                            Description = "Commodi non ducimus.",
                            Title = "non"
                        },
                        new
                        {
                            Id = 24,
                            DateAdded = new DateTime(2002, 6, 9, 0, 41, 9, 722, DateTimeKind.Unspecified).AddTicks(4829),
                            Description = "Tenetur labore sit ea qui.",
                            Title = "veniam"
                        },
                        new
                        {
                            Id = 25,
                            DateAdded = new DateTime(2000, 3, 24, 15, 21, 9, 259, DateTimeKind.Unspecified).AddTicks(5565),
                            Description = "Facere quod corporis nam ullam eum velit.",
                            Title = "id"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
