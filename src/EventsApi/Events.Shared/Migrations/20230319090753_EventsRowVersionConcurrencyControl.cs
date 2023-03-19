using Microsoft.EntityFrameworkCore.Migrations;

namespace Events.Shared.Migrations
{
    /// <summary>
    /// The events row version concurrency control class
    /// </summary>
    /// <seealso cref="Migration"/>
    public partial class EventsRowVersionConcurrencyControl : Migration
    {
        /// <summary>
        /// Ups the migration builder
        /// </summary>
        /// <param name="migrationBuilder">The migration builder</param>
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Events",
                type: "BLOB",
                rowVersion: true,
                nullable: true);
        }

        /// <summary>
        /// Downs the migration builder
        /// </summary>
        /// <param name="migrationBuilder">The migration builder</param>
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Events");
        }
    }
}