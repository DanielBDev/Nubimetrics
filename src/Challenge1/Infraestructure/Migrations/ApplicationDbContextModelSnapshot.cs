// <auto-generated />
using Infraestructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infraestructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.User.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Apellido = "Apellido1",
                            Email = "user1@correo.com",
                            Nombre = "User1",
                            Password = "9EgzGra2QlVZYKZE8AF4"
                        },
                        new
                        {
                            Id = 2,
                            Apellido = "Apellido2",
                            Email = "user2@correo.com",
                            Nombre = "User2",
                            Password = "NomzTELJ9RqNjnBnDGmW"
                        },
                        new
                        {
                            Id = 3,
                            Apellido = "Apellido3",
                            Email = "user3@correo.com",
                            Nombre = "User3",
                            Password = "Nqme8R3YAEDw6qSUbqfB"
                        },
                        new
                        {
                            Id = 4,
                            Apellido = "Apellido4",
                            Email = "user4@correo.com",
                            Nombre = "User4",
                            Password = "fQ295I0vJvB1YtrhCI0C"
                        },
                        new
                        {
                            Id = 5,
                            Apellido = "Apellido5",
                            Email = "user5@correo.com",
                            Nombre = "User5",
                            Password = "LxI5O3Q2UqMWkk06xnj0"
                        },
                        new
                        {
                            Id = 6,
                            Apellido = "Apellido6",
                            Email = "user6@correo.com",
                            Nombre = "User6",
                            Password = "bIPOCLYM9uST0d0sI6uB"
                        },
                        new
                        {
                            Id = 7,
                            Apellido = "Apellido7",
                            Email = "user7@correo.com",
                            Nombre = "User7",
                            Password = "17acjoRx3vuYj9kCi32D"
                        },
                        new
                        {
                            Id = 8,
                            Apellido = "Apellido8",
                            Email = "user8@correo.com",
                            Nombre = "User8",
                            Password = "fE3kX2fGuIy02h9erwpY"
                        },
                        new
                        {
                            Id = 9,
                            Apellido = "Apellido9",
                            Email = "user9@correo.com",
                            Nombre = "User9",
                            Password = "3kSOA4u03xJODrgwD0Eq"
                        },
                        new
                        {
                            Id = 10,
                            Apellido = "Apellido10",
                            Email = "user10@correo.com",
                            Nombre = "User10",
                            Password = "IKDv73fBAGVvOeJ4vpjd"
                        },
                        new
                        {
                            Id = 11,
                            Apellido = "Apellido11",
                            Email = "user11@correo.com",
                            Nombre = "User11",
                            Password = "IpN78kwLANa1r9PshhRH"
                        },
                        new
                        {
                            Id = 12,
                            Apellido = "Apellido12",
                            Email = "user12@correo.com",
                            Nombre = "User12",
                            Password = "Ys0xcY9jilAYRlhd7FwW"
                        },
                        new
                        {
                            Id = 13,
                            Apellido = "Apellido13",
                            Email = "user13@correo.com",
                            Nombre = "User13",
                            Password = "GUBwpdDPPaXOYbFayZek"
                        },
                        new
                        {
                            Id = 14,
                            Apellido = "Apellido14",
                            Email = "user14@correo.com",
                            Nombre = "User14",
                            Password = "kNmYMCjGbvubu4ADrDI8"
                        },
                        new
                        {
                            Id = 15,
                            Apellido = "Apellido15",
                            Email = "user15@correo.com",
                            Nombre = "User15",
                            Password = "UuTIOwAzfHpilMw3smkn"
                        },
                        new
                        {
                            Id = 16,
                            Apellido = "Apellido16",
                            Email = "user16@correo.com",
                            Nombre = "User16",
                            Password = "47yep5debBtuRgQ04eKZ"
                        },
                        new
                        {
                            Id = 17,
                            Apellido = "Apellido17",
                            Email = "user17@correo.com",
                            Nombre = "User17",
                            Password = "BukTFM0iHGUEdeEX6ycT"
                        },
                        new
                        {
                            Id = 18,
                            Apellido = "Apellido18",
                            Email = "user18@correo.com",
                            Nombre = "User18",
                            Password = "SgYdY5QF669OcKlJWeZc"
                        },
                        new
                        {
                            Id = 19,
                            Apellido = "Apellido19",
                            Email = "user19@correo.com",
                            Nombre = "User19",
                            Password = "F5WUqoRwb24FB0GfWH4K"
                        },
                        new
                        {
                            Id = 20,
                            Apellido = "Apellido20",
                            Email = "user20@correo.com",
                            Nombre = "User20",
                            Password = "5umLHGlS34AbZANXJDwt"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
