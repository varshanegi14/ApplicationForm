using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApplicationForm.Migrations
{
    /// <inheritdoc />
    public partial class AddTeamwwess : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BooleanTypeClass",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Awnser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Questionid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BooleanTypeClass", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BooleanTypeClass_questions_Questionid",
                        column: x => x.Questionid,
                        principalTable: "questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DropDownClass",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Awnser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Questionid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DropDownClass", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DropDownClass_questions_Questionid",
                        column: x => x.Questionid,
                        principalTable: "questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TextTypeClass",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Awnser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Questionid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TextTypeClass", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TextTypeClass_questions_Questionid",
                        column: x => x.Questionid,
                        principalTable: "questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BooleanTypeClass_Questionid",
                table: "BooleanTypeClass",
                column: "Questionid",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DropDownClass_Questionid",
                table: "DropDownClass",
                column: "Questionid",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TextTypeClass_Questionid",
                table: "TextTypeClass",
                column: "Questionid",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BooleanTypeClass");

            migrationBuilder.DropTable(
                name: "DropDownClass");

            migrationBuilder.DropTable(
                name: "TextTypeClass");
        }
    }
}
