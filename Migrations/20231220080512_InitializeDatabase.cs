using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cottages_asp.Migrations;

public partial class InitializeDatabase : Migration
{
	protected override void Up(MigrationBuilder migrationBuilder)
	{
		migrationBuilder.CreateTable(
			name: "Buildings",
			columns: table => new
			{
				Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
				Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
				Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
				Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
				Review = table.Column<int>(type: "int", nullable: false)
			},
			constraints: table =>
			{
				table.PrimaryKey("PK_Buildings", x => x.Id);
			});

		migrationBuilder.CreateTable(
			name: "Extras",
			columns: table => new
			{
				Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
				Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
				Icon = table.Column<string>(type: "nvarchar(max)", nullable: false)
			},
			constraints: table =>
			{
				table.PrimaryKey("PK_Extras", x => x.Id);
			});

		migrationBuilder.CreateTable(
			name: "Users",
			columns: table => new
			{
				Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
				IsOffering = table.Column<bool>(type: "bit", nullable: false),
				Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
				Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
				Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
				Phone = table.Column<string>(type: "nvarchar(max)", nullable: false)
			},
			constraints: table =>
			{
				table.PrimaryKey("PK_Users", x => x.Id);
			});

		migrationBuilder.CreateTable(
			name: "Categories",
			columns: table => new
			{
				Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
				Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
				Icon = table.Column<string>(type: "nvarchar(max)", nullable: false),
				BuildingId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
				CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
			},
			constraints: table =>
			{
				table.PrimaryKey("PK_Categories", x => x.Id);
				table.ForeignKey(
					name: "FK_Categories_Buildings_BuildingId",
					column: x => x.BuildingId,
					principalTable: "Buildings",
					principalColumn: "Id");
				table.ForeignKey(
					name: "FK_Categories_Categories_CategoryId",
					column: x => x.CategoryId,
					principalTable: "Categories",
					principalColumn: "Id");
			});

		migrationBuilder.CreateTable(
			name: "Offers",
			columns: table => new
			{
				Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
				UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
				BuildingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
			},
			constraints: table =>
			{
				table.PrimaryKey("PK_Offers", x => x.Id);
				table.ForeignKey(
					name: "FK_Offers_Buildings_BuildingId",
					column: x => x.BuildingId,
					principalTable: "Buildings",
					principalColumn: "Id",
					onDelete: ReferentialAction.Cascade);
				table.ForeignKey(
					name: "FK_Offers_Users_UserId",
					column: x => x.UserId,
					principalTable: "Users",
					principalColumn: "Id",
					onDelete: ReferentialAction.Cascade);
			});

		migrationBuilder.CreateTable(
			name: "Rooms",
			columns: table => new
			{
				Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
				Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
				Price = table.Column<double>(type: "float", nullable: false),
				People = table.Column<int>(type: "int", nullable: false),
				OfferId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
			},
			constraints: table =>
			{
				table.PrimaryKey("PK_Rooms", x => x.Id);
				table.ForeignKey(
					name: "FK_Rooms_Offers_OfferId",
					column: x => x.OfferId,
					principalTable: "Offers",
					principalColumn: "Id",
					onDelete: ReferentialAction.Cascade);
			});

		migrationBuilder.CreateTable(
			name: "ExtraRoom",
			columns: table => new
			{
				ExtrasId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
				RoomsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
			},
			constraints: table =>
			{
				table.PrimaryKey("PK_ExtraRoom", x => new { x.ExtrasId, x.RoomsId });
				table.ForeignKey(
					name: "FK_ExtraRoom_Extras_ExtrasId",
					column: x => x.ExtrasId,
					principalTable: "Extras",
					principalColumn: "Id",
					onDelete: ReferentialAction.Cascade);
				table.ForeignKey(
					name: "FK_ExtraRoom_Rooms_RoomsId",
					column: x => x.RoomsId,
					principalTable: "Rooms",
					principalColumn: "Id",
					onDelete: ReferentialAction.Cascade);
			});

		migrationBuilder.CreateIndex(
			name: "IX_Categories_BuildingId",
			table: "Categories",
			column: "BuildingId");

		migrationBuilder.CreateIndex(
			name: "IX_Categories_CategoryId",
			table: "Categories",
			column: "CategoryId");

		migrationBuilder.CreateIndex(
			name: "IX_ExtraRoom_RoomsId",
			table: "ExtraRoom",
			column: "RoomsId");

		migrationBuilder.CreateIndex(
			name: "IX_Offers_BuildingId",
			table: "Offers",
			column: "BuildingId");

		migrationBuilder.CreateIndex(
			name: "IX_Offers_UserId",
			table: "Offers",
			column: "UserId");

		migrationBuilder.CreateIndex(
			name: "IX_Rooms_OfferId",
			table: "Rooms",
			column: "OfferId");
	}

	protected override void Down(MigrationBuilder migrationBuilder)
	{
		migrationBuilder.DropTable(
			name: "Categories");

		migrationBuilder.DropTable(
			name: "ExtraRoom");

		migrationBuilder.DropTable(
			name: "Extras");

		migrationBuilder.DropTable(
			name: "Rooms");

		migrationBuilder.DropTable(
			name: "Offers");

		migrationBuilder.DropTable(
			name: "Buildings");

		migrationBuilder.DropTable(
			name: "Users");
	}
}
