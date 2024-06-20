using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApplicationForm.Migrations
{
    /// <inheritdoc />
    public partial class AddT : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Awnser",
                table: "TextTypeClass",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Awnser",
                table: "DropDownClass",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Awnser",
                table: "BooleanTypeClass",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "DateTypeClass",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Awnser = table.Column<DateOnly>(type: "date", nullable: true),
                    Questionid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DateTypeClass", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DateTypeClass_questions_Questionid",
                        column: x => x.Questionid,
                        principalTable: "questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MCQTypeClass",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Awnser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Questionid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MCQTypeClass", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MCQTypeClass_questions_Questionid",
                        column: x => x.Questionid,
                        principalTable: "questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NumberTypeClass",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Awnser = table.Column<int>(type: "int", nullable: true),
                    Questionid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NumberTypeClass", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NumberTypeClass_questions_Questionid",
                        column: x => x.Questionid,
                        principalTable: "questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DateTypeClass_Questionid",
                table: "DateTypeClass",
                column: "Questionid",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MCQTypeClass_Questionid",
                table: "MCQTypeClass",
                column: "Questionid",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_NumberTypeClass_Questionid",
                table: "NumberTypeClass",
                column: "Questionid",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DateTypeClass");

            migrationBuilder.DropTable(
                name: "MCQTypeClass");

            migrationBuilder.DropTable(
                name: "NumberTypeClass");

            migrationBuilder.AlterColumn<string>(
                name: "Awnser",
                table: "TextTypeClass",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Awnser",
                table: "DropDownClass",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Awnser",
                table: "BooleanTypeClass",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
