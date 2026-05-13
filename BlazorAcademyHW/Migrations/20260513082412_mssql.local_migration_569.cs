using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorAcademyHW.Migrations
{
    /// <inheritdoc />
    public partial class mssqllocal_migration_569 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TeacherDisciplines",
                columns: table => new
                {
                    teacher_discipline_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    teacher_id = table.Column<short>(type: "smallint", nullable: false),
                    discipline_id = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherDisciplines", x => x.teacher_discipline_id);
                    table.ForeignKey(
                        name: "FK_TeacherDisciplines_Disciplines_discipline_id",
                        column: x => x.discipline_id,
                        principalTable: "Disciplines",
                        principalColumn: "discipline_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeacherDisciplines_Teachers_teacher_id",
                        column: x => x.teacher_id,
                        principalTable: "Teachers",
                        principalColumn: "teacher_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TeacherDisciplines_discipline_id",
                table: "TeacherDisciplines",
                column: "discipline_id");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherDisciplines_teacher_id",
                table: "TeacherDisciplines",
                column: "teacher_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeacherDisciplines");
        }
    }
}
