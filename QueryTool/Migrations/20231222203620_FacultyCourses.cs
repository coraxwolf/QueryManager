using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QueryTool.Migrations
{
    /// <inheritdoc />
    public partial class FacultyCourses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Faculty_Courses_CourseRecordSisId",
                table: "Faculty");

            migrationBuilder.DropIndex(
                name: "IX_Faculty_CourseRecordSisId",
                table: "Faculty");

            migrationBuilder.DropColumn(
                name: "CourseRecordSisId",
                table: "Faculty");

            migrationBuilder.CreateTable(
                name: "CourseRecordFacultyRecord",
                columns: table => new
                {
                    CoursesSisId = table.Column<string>(type: "TEXT", nullable: false),
                    FacultyNo = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseRecordFacultyRecord", x => new { x.CoursesSisId, x.FacultyNo });
                    table.ForeignKey(
                        name: "FK_CourseRecordFacultyRecord_Courses_CoursesSisId",
                        column: x => x.CoursesSisId,
                        principalTable: "Courses",
                        principalColumn: "SisId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseRecordFacultyRecord_Faculty_FacultyNo",
                        column: x => x.FacultyNo,
                        principalTable: "Faculty",
                        principalColumn: "FacultyNo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseRecordFacultyRecord_FacultyNo",
                table: "CourseRecordFacultyRecord",
                column: "FacultyNo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseRecordFacultyRecord");

            migrationBuilder.AddColumn<string>(
                name: "CourseRecordSisId",
                table: "Faculty",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Faculty_CourseRecordSisId",
                table: "Faculty",
                column: "CourseRecordSisId");

            migrationBuilder.AddForeignKey(
                name: "FK_Faculty_Courses_CourseRecordSisId",
                table: "Faculty",
                column: "CourseRecordSisId",
                principalTable: "Courses",
                principalColumn: "SisId");
        }
    }
}
