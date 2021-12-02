using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraestructure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Apellido", "Email", "Nombre", "Password" },
                values: new object[,]
                {
                    { 1, "Apellido1", "user1@correo.com", "User1", "9EgzGra2QlVZYKZE8AF4" },
                    { 18, "Apellido18", "user18@correo.com", "User18", "SgYdY5QF669OcKlJWeZc" },
                    { 17, "Apellido17", "user17@correo.com", "User17", "BukTFM0iHGUEdeEX6ycT" },
                    { 16, "Apellido16", "user16@correo.com", "User16", "47yep5debBtuRgQ04eKZ" },
                    { 15, "Apellido15", "user15@correo.com", "User15", "UuTIOwAzfHpilMw3smkn" },
                    { 14, "Apellido14", "user14@correo.com", "User14", "kNmYMCjGbvubu4ADrDI8" },
                    { 13, "Apellido13", "user13@correo.com", "User13", "GUBwpdDPPaXOYbFayZek" },
                    { 12, "Apellido12", "user12@correo.com", "User12", "Ys0xcY9jilAYRlhd7FwW" },
                    { 11, "Apellido11", "user11@correo.com", "User11", "IpN78kwLANa1r9PshhRH" },
                    { 10, "Apellido10", "user10@correo.com", "User10", "IKDv73fBAGVvOeJ4vpjd" },
                    { 9, "Apellido9", "user9@correo.com", "User9", "3kSOA4u03xJODrgwD0Eq" },
                    { 8, "Apellido8", "user8@correo.com", "User8", "fE3kX2fGuIy02h9erwpY" },
                    { 7, "Apellido7", "user7@correo.com", "User7", "17acjoRx3vuYj9kCi32D" },
                    { 6, "Apellido6", "user6@correo.com", "User6", "bIPOCLYM9uST0d0sI6uB" },
                    { 5, "Apellido5", "user5@correo.com", "User5", "LxI5O3Q2UqMWkk06xnj0" },
                    { 4, "Apellido4", "user4@correo.com", "User4", "fQ295I0vJvB1YtrhCI0C" },
                    { 3, "Apellido3", "user3@correo.com", "User3", "Nqme8R3YAEDw6qSUbqfB" },
                    { 2, "Apellido2", "user2@correo.com", "User2", "NomzTELJ9RqNjnBnDGmW" },
                    { 19, "Apellido19", "user19@correo.com", "User19", "F5WUqoRwb24FB0GfWH4K" },
                    { 20, "Apellido20", "user20@correo.com", "User20", "5umLHGlS34AbZANXJDwt" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
