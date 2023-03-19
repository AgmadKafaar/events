using Microsoft.EntityFrameworkCore.Migrations;

namespace Events.Shared.Migrations
{
    public partial class SetAttendeeTypeDescriptionMaxLength : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AttendeesType",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Patient");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AttendeesType",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Customer");
        }
    }
}
