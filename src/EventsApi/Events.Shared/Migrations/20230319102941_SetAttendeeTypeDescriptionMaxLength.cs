using Microsoft.EntityFrameworkCore.Migrations;

namespace Events.Shared.Migrations
{
    /// <summary>
    /// The set attendee type description max length class
    /// </summary>
    /// <seealso cref="Migration"/>
    public partial class SetAttendeeTypeDescriptionMaxLength : Migration
    {
        /// <summary>
        /// Ups the migration builder
        /// </summary>
        /// <param name="migrationBuilder">The migration builder</param>
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AttendeesType",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Patient");
        }

        /// <summary>
        /// Downs the migration builder
        /// </summary>
        /// <param name="migrationBuilder">The migration builder</param>
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