using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TimeTable.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EMPLOYEES",
                columns: table => new
                {
                    EMPLOYEE_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EMPLOYEE_EGN = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    EMPLOYEE_NAME = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    EMPLOYEE_SURNAME = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    EMPLOYEE_LASTNAME = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    EMPLOYEE_POSITION = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EMPLOYEE_HIREDATE = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EMPLOYEES", x => x.EMPLOYEE_ID);
                });

            migrationBuilder.CreateTable(
                name: "PROJECT",
                columns: table => new
                {
                    PROJECT_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PROJECT_NAME = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    PROJECT_BEGIN = table.Column<DateTime>(type: "date", nullable: false),
                    PROJECT_END = table.Column<DateTime>(type: "date", nullable: false),
                    PROJECT_DESCRIPTION = table.Column<string>(type: "varchar(400)", unicode: false, maxLength: 400, nullable: true),
                    PROJECT_STATUS = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    PROJECT_MAXHOURS = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PROJECT", x => x.PROJECT_ID);
                });

            migrationBuilder.CreateTable(
                name: "PROJECT_HOURS",
                columns: table => new
                {
                    PROJECT_ID = table.Column<int>(type: "int", nullable: false),
                    EMPLOYEE_ID = table.Column<int>(type: "int", nullable: false),
                    PROJECT_TASKDATE = table.Column<DateTime>(type: "date", nullable: false),
                    PROJECT_MONTH_ID = table.Column<int>(type: "int", nullable: true),
                    PROJECT_TASK = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    PROJECT_HOURS = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PROJECT_HOURS", x => new { x.PROJECT_ID, x.EMPLOYEE_ID, x.PROJECT_TASKDATE });
                });

            migrationBuilder.CreateTable(
                name: "PROJECT_MONTHS",
                columns: table => new
                {
                    PROJECT_MONTH_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PROJECT_ID = table.Column<int>(type: "int", nullable: false),
                    PROJECT_YEAR = table.Column<int>(type: "int", nullable: false),
                    PROJECT_MONTH = table.Column<int>(type: "int", nullable: false),
                    PROJECT_MONTH_STATUS = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('O')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PROJECT_MONTHS", x => x.PROJECT_MONTH_ID);
                    table.ForeignKey(
                        name: "FK_PROJECT__REFERENCE_PROJECT",
                        column: x => x.PROJECT_ID,
                        principalTable: "PROJECT",
                        principalColumn: "PROJECT_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IDX_EMPLOYEE_UQ",
                table: "EMPLOYEES",
                column: "EMPLOYEE_EGN",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IDX_PROJECT_UQ",
                table: "PROJECT",
                column: "PROJECT_NAME",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IDX_PROJECT_MONTHS_UQ",
                table: "PROJECT_MONTHS",
                columns: new[] { "PROJECT_ID", "PROJECT_YEAR", "PROJECT_MONTH" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EMPLOYEES");

            migrationBuilder.DropTable(
                name: "PROJECT_HOURS");

            migrationBuilder.DropTable(
                name: "PROJECT_MONTHS");

            migrationBuilder.DropTable(
                name: "PROJECT");
        }
    }
}
