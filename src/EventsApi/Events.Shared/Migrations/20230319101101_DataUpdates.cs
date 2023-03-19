using Microsoft.EntityFrameworkCore.Migrations;

namespace Events.Shared.Migrations
{
    /// <summary>
    /// The data updates class
    /// </summary>
    /// <seealso cref="Migration"/>
    public partial class DataUpdates : Migration
    {
        /// <summary>
        /// Ups the migration builder
        /// </summary>
        /// <param name="migrationBuilder">The migration builder</param>
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

        /// <summary>
        /// Downs the migration builder
        /// </summary>
        /// <param name="migrationBuilder">The migration builder</param>
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