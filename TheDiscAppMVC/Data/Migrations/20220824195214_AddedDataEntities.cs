using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheDiscAppMVC.Data.Migrations
{
    public partial class AddedDataEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Collections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlayerId = table.Column<int>(type: "int", nullable: false),
                    DiscId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Collections", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Discs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<int>(type: "int", nullable: false),
                    Stability = table.Column<int>(type: "int", nullable: false),
                    DiscType = table.Column<int>(type: "int", nullable: false),
                    Speed = table.Column<int>(type: "int", nullable: false),
                    Glide = table.Column<int>(type: "int", nullable: false),
                    Turn = table.Column<int>(type: "int", nullable: false),
                    Fade = table.Column<int>(type: "int", nullable: false),
                    Plastic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxWeight = table.Column<double>(type: "float", nullable: true),
                    OuterDiameter = table.Column<double>(type: "float", nullable: true),
                    InnerDiameter = table.Column<double>(type: "float", nullable: true),
                    RimWidth = table.Column<double>(type: "float", nullable: true),
                    RimDepth = table.Column<double>(type: "float", nullable: true),
                    RimConfiguration = table.Column<double>(type: "float", nullable: true),
                    Height = table.Column<double>(type: "float", nullable: true),
                    CollectionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Discs_Collections_CollectionId",
                        column: x => x.CollectionId,
                        principalTable: "Collections",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PdgaNumber = table.Column<int>(type: "int", nullable: true),
                    PdgaRating = table.Column<int>(type: "int", nullable: true),
                    TeamId = table.Column<int>(type: "int", nullable: false),
                    CollectionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Players_Collections_CollectionId",
                        column: x => x.CollectionId,
                        principalTable: "Collections",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Players_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Collections",
                columns: new[] { "Id", "DiscId", "Name", "PlayerId" },
                values: new object[,]
                {
                    { 1, 2, "Paul's Bag", 1 },
                    { 2, 1, "Calvin's Bag", 3 },
                    { 3, 3, "Eagle's Bag", 4 },
                    { 4, 4, "Ricky's Bag", 2 },
                    { 5, 5, "James' Bag", 5 }
                });

            migrationBuilder.InsertData(
                table: "Discs",
                columns: new[] { "Id", "Brand", "CollectionId", "DiscType", "Fade", "Glide", "Height", "InnerDiameter", "MaxWeight", "Name", "OuterDiameter", "Plastic", "RimConfiguration", "RimDepth", "RimWidth", "Speed", "Stability", "Turn" },
                values: new object[,]
                {
                    { 1, 47, null, 0, 6, 9, 1.3999999999999999, 16.699999999999999, 176.0, "Destroyer", 21.100000000000001, "Champion", 30.5, 5.6900000000000004, 2.2000000000000002, 23, 1, 4 },
                    { 2, 21, null, 2, 2, 7, 1.8999999999999999, 19.300000000000001, 180.0, "Buzzz", 21.699999999999999, "Big Z", 44.0, 5.9900000000000002, 1.2, 9, 2, 4 },
                    { 3, 20, null, 2, 4, 9, 1.8999999999999999, 19.0, 180.0, "MD3", 21.800000000000001, "C-Line", 44.5, 5.96, 1.3999999999999999, 9, 1, 2 },
                    { 4, 25, null, 2, 2, 9, 1.7, 18.699999999999999, 180.0, "Truth", 21.699999999999999, "Lucid", 41.5, 5.5300000000000002, 1.5, 9, 2, 4 },
                    { 5, 62, null, 0, 4, 9, 1.7, 16.800000000000001, 176.0, "Zenith", 21.199999999999999, "Neutron", 27.0, 5.1900000000000004, 2.2000000000000002, 21, 1, 3 }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Innova" },
                    { 2, "Discraft" },
                    { 3, "MVP Disc Sports" },
                    { 4, "Dynamic Discs" },
                    { 5, "Discmania" }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "CollectionId", "Name", "PdgaNumber", "PdgaRating", "TeamId" },
                values: new object[,]
                {
                    { 1, null, "Paul McBeth", 27523, 1055, 2 },
                    { 2, null, "Ricky Wysocki", 38008, 1049, 4 },
                    { 3, null, "Calvin Heimburg", 45971, 1039, 1 },
                    { 4, null, "Eagle McMahon", 37817, 1045, 5 },
                    { 5, null, "James Conrad", 17295, 1035, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Discs_CollectionId",
                table: "Discs",
                column: "CollectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_CollectionId",
                table: "Players",
                column: "CollectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_TeamId",
                table: "Players",
                column: "TeamId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Discs");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Collections");

            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
