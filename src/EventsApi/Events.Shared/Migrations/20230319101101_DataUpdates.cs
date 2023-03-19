using Microsoft.EntityFrameworkCore.Migrations;

namespace Events.Shared.Migrations
{
    public partial class DataUpdates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AttendeesType",
                columns: new[] { "Id", "Description" },
                values: new object[] { 1, "Customer" });

            migrationBuilder.InsertData(
                table: "AttendeesType",
                columns: new[] { "Id", "Description" },
                values: new object[] { 2, "Doctor" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AttendeesType",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AttendeesType",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}